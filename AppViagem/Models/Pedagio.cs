using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppViagem.Models
{
    public class Pedagio
    {
        

        [AutoIncrement, PrimaryKey]
        public int id { get; set; }
        public string local { get; set; }
        public double valor { get; set;  }
    }
} 
