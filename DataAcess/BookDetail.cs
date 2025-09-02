using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class BookDetail
    {
        public int ID { get; set; }          // Primary key
        public string BookName { get; set; }
        public string Genre { get; set; }
        public bool Availability { get; set; }
    }
}



