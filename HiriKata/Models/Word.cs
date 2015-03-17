using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace HiriKata.Models
{
    public class Word
    {
        public int ID { get; set; }
        public string En { get; set; }
        public string Jp { get; set; }
        public string Section { get; set; }
        public string Category { get; set; }
    }

  
}