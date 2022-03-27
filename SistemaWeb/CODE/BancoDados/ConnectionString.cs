using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWeb.CODE
{
    public class ConnectionString
    {
        public string ConnString { get; set; }
        public string ProviderName { get; set; }

        public ConnectionString(string connStringName)
        {
            this.ConnString = "Server=localhost;Database=bd_sistema_web;Uid=root;Pwd=masterkey;SslMode=none;Pooling=false;";
            this.ProviderName = "MySql.Data.MySqlClient";
        }
    }
}
