using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HiriKata.Models {
  public class GameResult {
    public string Category { get; set; }
    public string Section { get; set; }
    public int Games { get; set; }
    public int PerfectGames { get; set; }
  }
}