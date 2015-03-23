using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HiriKata.Models {
  public class Game {
    public int ID { get; set; }
    public int UserID { get; set; }
    public int Correct { get; set; }
    public int Possible { get; set; }
    public string Section { get; set; }
    public string Category { get; set; }
  }
}