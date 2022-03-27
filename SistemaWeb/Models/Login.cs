using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace SistemaWeb.Models
{
    public class Login
    {
        public int Id { get; set; }
        public int CodigoPerfil { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
    }
}
