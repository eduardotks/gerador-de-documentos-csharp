using System;
using System.Data.Common;

namespace SistemaWeb.CODE
{
    public class DbCommandGeneric
    {
        public DbCommand DbCommand { get; set; }
        public Object TableObject { get; set; }
    }
}
