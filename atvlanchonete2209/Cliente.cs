using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

using System.Windows.Forms;

namespace atvlanchonete2209
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public string NomeUser { get; set; }
        public string TelefoneCliente { get; set; }

        public Cliente() { }
        public Cliente(int id, string nome, string telefone)
        {
            IDCliente = id;
            NomeUser = nome;
            TelefoneCliente = telefone;
        }
        public bool SalvarDadosCliente(List<Cliente> cliente, string path)
        {
            var strJson = JsonConvert.SerializeObject(cliente);
            return SalvarArquivoCliente(strJson, path);
        }
        public static Cliente ListarCliente(string path)
        {
            var strJson = OpenFileCliente(path);
            if (strJson.Substring(0, 5) != "falha")
            {
                return JsonConvert.DeserializeObject<Cliente>(strJson);

            }
            else
            {
                var cliente = new Cliente();
                cliente.NomeUser = strJson;
                return cliente;

            }
        }
        public bool SalvarArquivoCliente(string strJson, string path)
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
        private static string OpenFileCliente(string path)
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

        public static List<Cliente> carregarCliente(string path)
        {
            var strJson = OpenFileCliente(path);
            if (strJson.Substring(0, 5) != "falha")
            {
                return JsonConvert.DeserializeObject<List<Cliente>>(strJson);
            }
            else
            {
                var listClientes = new List<Cliente>();
                var cliente = new Cliente();
                cliente.NomeUser = strJson;
                listClientes.Add(cliente);
                cliente.NomeUser = strJson;
                return listClientes;
            }
        }
    }
}
