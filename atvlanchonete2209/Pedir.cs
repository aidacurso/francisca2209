using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace atvlanchonete2209
{
    class Pedir
    {
        public int IDPedido { get; set; }
        public string NomePedido { get; set; }
        public double PrecoPedido { get; set; }

        public Pedir() { }
        public Pedir(int id, string nome, string preco)
        {
            IDPedido = id;
            NomePedido = nome;
            PrecoPedido = double.Parse(preco);
        }
        public bool SalvarDadosPedido(List<Pedir> cliente, string path)
        {
            var strJson = JsonConvert.SerializeObject(cliente);
            return SalvarArquivoPedido(strJson, path);
        }
        public static Pedir ListarPedido(string path)
        {
            var strJson = OpenFilePedido(path);
            if (strJson.Substring(0, 5) != "falha")
            {
                return JsonConvert.DeserializeObject<Pedir>(strJson);

            }
            else
            {
                var pedido = new Pedir();
                pedido.NomePedido = strJson;
                return pedido;

            }
        }
        public bool SalvarArquivoPedido(string strJson, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(strJson);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha{ex.Message}");
                return false;
            }
        }
        private static string OpenFilePedido(string path)
        {
            try
            {
                var strJson = "";
                using (StreamReader sr = new StreamReader(path))
                {
                    strJson = sr.ReadToEnd();
                }
                return strJson;
            }
            catch (Exception ex)
            {
                return "falha" + ex.Message;
            }
        }

        public static List<Pedir> carregarPedido(string path)
        {
            var strJson = OpenFilePedido(path);
            if (strJson.Substring(0, 5) != "falha")
            {
                return JsonConvert.DeserializeObject<List<Pedir>>(strJson);
            }
            else
            {
                var listPedido = new List<Pedir>();
                var pedido = new Pedir();
                pedido.NomePedido = strJson;
                listPedido.Add(pedido);
                pedido.NomePedido = strJson;
                return listPedido;
            }
        }
    }
}
