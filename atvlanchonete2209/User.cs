using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace atvlanchonete2209
{
    class User
    {
        public int IDUser { get; set; }
        public string NomeUser { get; set; }
        public string SenhaUser { get; set; }

        public User() { }
        public User(int id, string nome, string telefone)
        {
            IDUser= id;
            NomeUser = nome;
            SenhaUser = telefone;
        }
        public bool SalvarDadosUser(List<User> cliente, string path)
        {
            var strJson = JsonConvert.SerializeObject(cliente);
            return SalvarArquivoUser(strJson, path);
        }
        public static User ListarUser(string path)
        {
            var strJson = OpenFileUser(path);
            if (strJson.Substring(0, 5) != "falha")
            {
                return JsonConvert.DeserializeObject<User>(strJson);

            }
            else
            {
                var user = new User();
                user.NomeUser = strJson;
                return user;

            }
        }
        public bool SalvarArquivoUser(string strJson, string path)
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
        private static string OpenFileUser(string path)
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

        public static List<User> carregarUser(string path)
        {
            var strJson = OpenFileUser(path);
            if (strJson.Substring(0, 5) != "falha")
            {
                return JsonConvert.DeserializeObject<List<User>>(strJson);
            }
            else
            {
                var listUser = new List<User>();
                var user = new User();
                user.NomeUser = strJson;
                listUser.Add(user);
                user.NomeUser = strJson;
                return listUser;
            }
        }
    }
}
