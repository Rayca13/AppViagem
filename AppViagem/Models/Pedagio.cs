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
        string _local;
        double _valor;

        [AutoIncrement, PrimaryKey]
        public int id { get; set; }
        public string local { get => local; set { local = value; } }
        public double valor { get => valor; set { valor = value; } }
    }
} //feito
