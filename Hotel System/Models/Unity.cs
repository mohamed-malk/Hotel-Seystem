using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System.Models
{
     static class Unity
    {
        public static string ConnectionString => 
            ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
    }
}
