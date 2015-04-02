namespace HiriKata.Migrations {
  using HiriKata.Models;
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;

  internal sealed class Configuration : DbMigrationsConfiguration<HiriKata.Models.WordDbContext> {
    public Configuration() {
      AutomaticMigrationsEnabled = false;
      ContextKey = "HiriKata.Models.WordDbContext";
    }

    protected override void Seed(HiriKata.Models.WordDbContext context) {
      context.Words.AddOrUpdate(x => x.ID,
          new Word {
            ID = 1,
            En = "A",
            Jp = "あ",
            Section = "Hirigana",
            Category = "A-K"
          },

          new Word {
            ID = 2,
            En = "I",
            Jp = "い",
            Section = "Hirigana",
            Category = "A-K"
          },

           new Word {
             ID = 3,
             En = "U",
             Jp = "う",
             Section = "Hirigana",
             Category = "A-K"
           },

           new Word {
             ID = 4,
             En = "E",
             Jp = "え",
             Section = "Hirigana",
             Category = "A-K"
           },

          new Word {
            ID = 5,
            En = "O",
            Jp = "お",
            Section = "Hirigana",
            Category = "A-K"
          },

          new Word {
            ID = 6,
            En = "KA",
            Jp = "か",
            Section = "Hirigana",
            Category = "A-K"
          },

          new Word {
            ID = 7,
            En = "KI",
            Jp = "き",
            Section = "Hirigana",
            Category = "A-K"
          },

          new Word {
            ID = 8,
            En = "KU",
            Jp = "く",
            Section = "Hirigana",
            Category = "A-K"
          },

          new Word {
            ID = 9,
            En = "KE",
            Jp = "け",
            Section = "Hirigana",
            Category = "A-K"
          },

          new Word {
            ID = 10,
            En = "KO",
            Jp = "こ",
            Section = "Hirigana",
            Category = "A-K"
          },

          new Word {
            ID = 11,
            En = "SA",
            Jp = "さ",
            Section = "Hirigana",
            Category = "S-T"
          },

          new Word {
            ID = 12,
            En = "SHI",
            Jp = "し",
            Section = "Hirigana",
            Category = "S-T"
          },

          new Word {
            ID = 13,
            En = "SU",
            Jp = "す",
            Section = "Hirigana",
            Category = "S-T"
          },

          new Word {
            ID = 14,
            En = "SE",
            Jp = "せ",
            Section = "Hirigana",
            Category = "S-T"
          },

          new Word {
            ID = 15,
            En = "SO",
            Jp = "そ",
            Section = "Hirigana",
            Category = "S-T"
          },

          new Word {
            ID = 16,
            En = "TA",
            Jp = "た",
            Section = "Hirigana",
            Category = "S-T"
          },

          new Word {
            ID = 17,
            En = "CHI",
            Jp = "ち",
            Section = "Hirigana",
            Category = "S-T"
          },

          new Word {
            ID = 18,
            En = "TSU",
            Jp = "つ",
            Section = "Hirigana",
            Category = "S-T"
          },

          new Word {
            ID = 19,
            En = "TE",
            Jp = "て",
            Section = "Hirigana",
            Category = "S-T"
          },

          new Word {
            ID = 20,
            En = "TO",
            Jp = "と",
            Section = "Hirigana",
            Category = "S-T"
          },

          new Word {
            ID = 21,
            En = "NA",
            Jp = "な",
            Section = "Hirigana",
            Category = "S-T"
          },

          new Word {
            ID = 22,
            En = "NI",
            Jp = "に",
            Section = "Hirigana",
            Category = "S-T"
          },

          new Word {
            ID = 23,
            En = "NU",
            Jp = "ぬ",
            Section = "Hirigana",
            Category = "N-H"
          },

          new Word {
            ID = 24,
            En = "NE",
            Jp = "ね",
            Section = "Hirigana",
            Category = "N-H"
          },

          new Word {
            ID = 25,
            En = "NO",
            Jp = "の",
            Section = "Hirigana",
            Category = "N-H"
          },

          new Word {
            ID = 26,
            En = "HA",
            Jp = "は",
            Section = "Hirigana",
            Category = "N-H"
          },

          new Word {
            ID = 27,
            En = "HI",
            Jp = "ひ",
            Section = "Hirigana",
            Category = "N-H"
          },

          new Word {
            ID = 28,
            En = "FU",
            Jp = "ふ",
            Section = "Hirigana",
            Category = "N-H"
          },

          new Word {
            ID = 29,
            En = "HE",
            Jp = "へ",
            Section = "Hirigana",
            Category = "N-H"
          },

          new Word {
            ID = 30,
            En = "HO",
            Jp = "ほ",
            Section = "Hirigana",
            Category = "N-H"
          },

          new Word {
            ID = 31,
            En = "Ma",
            Jp = "ま",
            Section = "Hirigana",
            Category = "M-R"
          },

          new Word {
            ID = 32,
            En = "MI",
            Jp = "み",
            Section = "Hirigana",
            Category = "M-R"
          },

          new Word {
            ID = 33,
            En = "MU",
            Jp = "む",
            Section = "Hirigana",
            Category = "M-R"
          },

          new Word {
            ID = 34,
            En = "ME",
            Jp = "め",
            Section = "Hirigana",
            Category = "M-R"
          },

          new Word {
            ID = 35,
            En = "MO",
            Jp = "も",
            Section = "Hirigana",
            Category = "M-R"
          },

          new Word {
            ID = 36,
            En = "YA",
            Jp = "や",
            Section = "Hirigana",
            Category = "Spec"
          },

          new Word {
            ID = 37,
            En = "YU",
            Jp = "ゆ",
            Section = "Hirigana",
            Category = "Spec"
          },

          new Word {
            ID = 38,
            En = "YO",
            Jp = "よ",
            Section = "Hirigana",
            Category = "Spec"
          },

          new Word {
            ID = 39,
            En = "RA",
            Jp = "ら",
            Section = "Hirigana",
            Category = "M-R"
          },

          new Word {
            ID = 40,
            En = "RI",
            Jp = "り",
            Section = "Hirigana",
            Category = "M-R"
          },

          new Word {
            ID = 41,
            En = "RU",
            Jp = "る",
            Section = "Hirigana",
            Category = "M-R"
          },

          new Word {
            ID = 42,
            En = "RE",
            Jp = "れ",
            Section = "Hirigana",
            Category = "M-R"
          },

          new Word {
            ID = 43,
            En = "RO",
            Jp = "ろ",
            Section = "Hirigana",
            Category = "M-R"
          },

          new Word {
            ID = 44,
            En = "WA",
            Jp = "わ",
            Section = "Hirigana",
            Category = "Spec"
          },

          new Word {
            ID = 45,
            En = "WO",
            Jp = "を",
            Section = "Hirigana",
            Category = "Spec"
          },

          new Word {
            ID = 46,
            En = "WI",
            Jp = "ゐ",
            Section = "Hirigana",
            Category = "Spec"
          },

          new Word {
            ID = 47,
            En = "WE",
            Jp = "ゑ",
            Section = "Hirigana",
            Category = "Spec"
          },

          new Word {
            ID = 48,
            En = "N",
            Jp = "ん",
            Section = "Hirigana",
            Category = "Spec"
          },

          new Word {
            ID = 49,
            En = "A",
            Jp = "ア",
            Section = "Katakana",
            Category = "A-K"
          },

          new Word {
            ID = 50,
            En = "I",
            Jp = "イ",
            Section = "Katakana",
            Category = "A-K"
          },

           new Word {
             ID = 51,
             En = "U",
             Jp = "ウ",
             Section = "Katakana",
             Category = "A-K"
           },

           new Word {
             ID = 52,
             En = "E",
             Jp = "エ",
             Section = "Katakana",
             Category = "A-K"
           },

          new Word {
            ID = 53,
            En = "O",
            Jp = "オ",
            Section = "Katakana",
            Category = "A-K"
          },

          new Word {
            ID = 54,
            En = "KA",
            Jp = "カ",
            Section = "Katakana",
            Category = "A-K"
          },

          new Word {
            ID = 55,
            En = "KI",
            Jp = "キ",
            Section = "Katakana",
            Category = "A-K"
          },

          new Word {
            ID = 56,
            En = "KU",
            Jp = "ク",
            Section = "Katakana",
            Category = "A-K"
          },

          new Word {
            ID = 57,
            En = "KE",
            Jp = "ケ",
            Section = "Katakana",
            Category = "A-K"
          },

          new Word {
            ID = 58,
            En = "KO",
            Jp = "コ",
            Section = "Katakana",
            Category = "A-K"
          },

          new Word {
            ID = 59,
            En = "SA",
            Jp = "サ",
            Section = "Katakana",
            Category = "S-T"
          },

          new Word {
            ID = 60,
            En = "SHI",
            Jp = "シ",
            Section = "Katakana",
            Category = "S-T"
          },

          new Word {
            ID = 61,
            En = "SU",
            Jp = "ス",
            Section = "Katakana",
            Category = "S-T"
          },

          new Word {
            ID = 62,
            En = "SE",
            Jp = "セ",
            Section = "Katakana",
            Category = "S-T"
          },

          new Word {
            ID = 63,
            En = "SO",
            Jp = "ソ",
            Section = "Katakana",
            Category = "S-T"
          },

          new Word {
            ID = 64,
            En = "TA",
            Jp = "タ",
            Section = "Katakana",
            Category = "S-T"
          },

          new Word {
            ID = 65,
            En = "CHI",
            Jp = "チ",
            Section = "Katakana",
            Category = "S-T"
          },

          new Word {
            ID = 66,
            En = "TSU",
            Jp = "ツ",
            Section = "Katakana",
            Category = "S-T"
          },

          new Word {
            ID = 67,
            En = "TE",
            Jp = "テ",
            Section = "Katakana",
            Category = "S-T"
          },

          new Word {
            ID = 68,
            En = "TO",
            Jp = "ト",
            Section = "Katakana",
            Category = "S-T"
          },

          new Word {
            ID = 69,
            En = "NA",
            Jp = "ナ",
            Section = "Katakana",
            Category = "S-T"
          },

          new Word {
            ID = 70,
            En = "NI",
            Jp = "ニ",
            Section = "Katakana",
            Category = "S-T"
          },

          new Word {
            ID = 71,
            En = "NU",
            Jp = "ヌ",
            Section = "Katakana",
            Category = "N-H"
          },

          new Word {
            ID = 72,
            En = "NE",
            Jp = "ネ",
            Section = "Katakana",
            Category = "N-H"
          },

          new Word {
            ID = 73,
            En = "NO",
            Jp = "ノ",
            Section = "Katakana",
            Category = "N-H"
          },

          new Word {
            ID = 74,
            En = "HA",
            Jp = "ハ",
            Section = "Katakana",
            Category = "N-H"
          },

          new Word {
            ID = 75,
            En = "HI",
            Jp = "ヒ",
            Section = "Katakana",
            Category = "N-H"
          },

          new Word {
            ID = 76,
            En = "FU",
            Jp = "フ",
            Section = "Katakana",
            Category = "N-H"
          },

          new Word {
            ID = 77,
            En = "HE",
            Jp = "へ",
            Section = "Katakana",
            Category = "N-H"
          },

          new Word {
            ID = 78,
            En = "HO",
            Jp = "ホ",
            Section = "Katakana",
            Category = "N-H"
          },

          new Word {
            ID = 79,
            En = "Ma",
            Jp = "マ",
            Section = "Katakana",
            Category = "M-R"
          },

          new Word {
            ID = 80,
            En = "MI",
            Jp = "ミ",
            Section = "Katakana",
            Category = "M-R"
          },

          new Word {
            ID = 81,
            En = "MU",
            Jp = "ム",
            Section = "Katakana",
            Category = "M-R"
          },

          new Word {
            ID = 82,
            En = "ME",
            Jp = "メ",
            Section = "Katakana",
            Category = "M-R"
          },

          new Word {
            ID = 83,
            En = "MO",
            Jp = "モ",
            Section = "Katakana",
            Category = "M-R"
          },

          new Word {
            ID = 84,
            En = "YA",
            Jp = "ヤ",
            Section = "Katakana",
            Category = "Spec"
          },

          new Word {
            ID = 85,
            En = "YU",
            Jp = "ユ",
            Section = "Katakana",
            Category = "Spec"
          },

          new Word {
            ID = 86,
            En = "YO",
            Jp = "ヨ",
            Section = "Katakana",
            Category = "Spec"
          },

          new Word {
            ID = 87,
            En = "RA",
            Jp = "ラ",
            Section = "Katakana",
            Category = "M-R"
          },

          new Word {
            ID = 88,
            En = "RI",
            Jp = "リ",
            Section = "Katakana",
            Category = "M-R"
          },

          new Word {
            ID = 89,
            En = "RU",
            Jp = "ル",
            Section = "Katakana",
            Category = "M-R"
          },

          new Word {
            ID = 90,
            En = "RE",
            Jp = "レ",
            Section = "Katakana",
            Category = "M-R"
          },

          new Word {
            ID = 91,
            En = "RO",
            Jp = "ロ",
            Section = "Katakana",
            Category = "M-R"
          },

          new Word {
            ID = 92,
            En = "WA",
            Jp = "ワ",
            Section = "Katakana",
            Category = "Spec"
          },

          new Word {
            ID = 93,
            En = "WO",
            Jp = "ヲ",
            Section = "Katakana",
            Category = "Spec"
          },

          new Word {
            ID = 94,
            En = "WI",
            Jp = "ヰ",
            Section = "Katakana",
            Category = "Spec"
          },

          new Word {
            ID = 95,
            En = "WE",
            Jp = "ヱ",
            Section = "Katakana",
            Category = "Spec"
          },

          new Word {
            ID = 96,
            En = "N",
            Jp = "ｎ",
            Section = "Katakana",
            Category = "Spec"
          }
      );
    }
  }
}
