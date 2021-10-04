using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace atvlanchonete2209
{
    class Produtos
    {
        public int IDProduto { get; set; }
        public string NomeProdutos { get; set; }
        public double PrecoProdutos { get; set; }

        public Produtos() { }
        public Produtos(int id, string nome, string preco)
        {
            IDProduto = id;
            NomeProdutos = nome;
            PrecoProdutos = double.Parse(preco);
        }
        public bool SalvarDadosProdutos(List<Produtos> cliente, string path)
        {
            var strJson = JsonConvert.SerializeObject(cliente);
            return SalvarArquivoProdutos(strJson, path);
        }
        public static Produtos ListarProdutos(string path)
        {
            var strJson = OpenFileProdutos(path);
            if (strJson.Substring(0, 5) != "falha")
            {
                return JsonConvert.DeserializeObject<Produtos>(strJson);

            }
            else
            {
                var produtos = new Produtos();
                produtos.NomeProdutos = strJson;
                return produtos;

            }
        }
        public bool SalvarArquivoProdutos(string strJson, string path)
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
        private static string OpenFileProdutos(string path)
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

        public static List<Produtos> carregarProdutos(string path)
        {
            var strJson = OpenFileProdutos(path);
            if (strJson.Substring(0, 5) != "falha")
            {
                return JsonConvert.DeserializeObject<List<Produtos>>(strJson);
            }
            else
            {
                var listProdutos = new List<Produtos>();
                var produtos = new Produtos();
                produtos.NomeProdutos = strJson;
                listProdutos.Add(produtos);
                produtos.NomeProdutos = strJson;
                return listProdutos;
            }
        }
    }
}
