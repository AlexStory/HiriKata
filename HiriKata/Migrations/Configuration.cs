namespace HiriKata.Migrations
{
    using HiriKata.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HiriKata.Models.WordDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HiriKata.Models.WordDbContext";
        }

        protected override void Seed(HiriKata.Models.WordDbContext context)
        {
           context.Words.AddOrUpdate(x => x.Jp,
               new Word
               {
                   En = "A",
                   Jp = "あ",
                   Section = "Hirigana",
                   Category = "A-K"
               },

               new Word 
                {
                    En = "I",
                    Jp = "い",
                    Section = "Hirigana",
                    Category = "A-K"
                },
                
                new Word
                {
                    En = "U",
                    Jp = "う",
                    Section = "Hirigana",
                    Category = "A-K"
                },

                new Word
               {
                   En = "E",
                   Jp = "え",
                   Section = "Hirigana",
                   Category = "A-K"
               },

               new Word
               {
                   En = "O",
                   Jp = "お",
                   Section = "Hirigana",
                   Category = "A-K"
               },

               new Word
               {
                   En = "KA",
                   Jp = "か",
                   Section = "Hirigana",
                   Category = "A-K"
               },

               new Word
               {
                   En = "KI",
                   Jp = "き",
                   Section = "Hirigana",
                   Category = "A-K"
               },

               new Word
               {
                   En = "KU",
                   Jp = "く",
                   Section = "Hirigana",
                   Category = "A-K"
               },

               new Word
               {
                   En = "KE",
                   Jp = "け",
                   Section = "Hirigana",
                   Category = "A-K"
               },

               new Word
               {
                   En = "KO",
                   Jp = "こ",
                   Section = "Hirigana",
                   Category = "A-K"
               },

               new Word
               {
                   En = "SA",
                   Jp = "さ",
                   Section = "Hirigana",
                   Category = "S-T"
               },

               new Word
               {
                   En = "SHI",
                   Jp = "し",
                   Section = "Hirigana",
                   Category = "S-T"
               },

               new Word
               {
                   En = "SU",
                   Jp = "す",
                   Section = "Hirigana",
                   Category = "S-T"
               },

               new Word
               {
                   En = "SE",
                   Jp = "せ",
                   Section = "Hirigana",
                   Category = "S-T"
               },

               new Word
               {
                   En = "SO",
                   Jp = "そ",
                   Section = "Hirigana",
                   Category = "S-T"
               },

               new Word
               {
                   En = "TA",
                   Jp = "た",
                   Section = "Hirigana",
                   Category = "S-T"
               },

               new Word
               {
                   En = "CHI",
                   Jp = "ち",
                   Section = "Hirigana",
                   Category = "S-T"
               },

               new Word
               {
                   En = "TSU",
                   Jp = "つ",
                   Section = "Hirigana",
                   Category = "S-T"
               },

               new Word
               {
                   En = "TE",
                   Jp = "て",
                   Section = "Hirigana",
                   Category = "S-T"
               },

               new Word
               {
                   En = "TO",
                   Jp = "と",
                   Section = "Hirigana",
                   Category = "S-T"
               },

               new Word
               {
                   En = "NA",
                   Jp = "な",
                   Section = "Hirigana",
                   Category = "S-T"
               },

               new Word
               {
                   En = "NI",
                   Jp = "に",
                   Section = "Hirigana",
                   Category = "S-T"
               },

               new Word
               {
                   En = "NU",
                   Jp = "ぬ",
                   Section = "Hirigana",
                   Category = "N-H"
               },

               new Word
               {
                   En = "NE",
                   Jp = "ね",
                   Section = "Hirigana",
                   Category = "N-H"
               },

               new Word
               {
                   En = "NO",
                   Jp = "の",
                   Section = "Hirigana",
                   Category = "N-H"
               },

               new Word
               {
                   En = "HA",
                   Jp = "は",
                   Section = "Hirigana",
                   Category = "N-H"
               },

               new Word
               {
                   En = "HI",
                   Jp = "ひ",
                   Section = "Hirigana",
                   Category = "N-H"
               },

               new Word
               {
                   En = "FU",
                   Jp = "ふ",
                   Section = "Hirigana",
                   Category = "N-H"
               },

               new Word
               {
                   En = "HE",
                   Jp = "へ",
                   Section = "Hirigana",
                   Category = "N-H"
               },

               new Word
               {
                   En = "HO",
                   Jp = "ほ",
                   Section = "Hirigana",
                   Category = "N-H"
               },

               new Word
               {
                   En = "Ma",
                   Jp = "ま",
                   Section = "Hirigana",
                   Category = "M-R"
               },

               new Word
               {
                   En = "MI",
                   Jp = "み",
                   Section = "Hirigana",
                   Category = "M-R"
               },

               new Word
               {
                   En = "MU",
                   Jp = "む",
                   Section = "Hirigana",
                   Category = "M-R"
               },

               new Word
               {
                   En = "ME",
                   Jp = "め",
                   Section = "Hirigana",
                   Category = "M-R"
               },

               new Word
               {
                   En = "MO",
                   Jp = "も",
                   Section = "Hirigana",
                   Category = "M-R"
               },

               new Word
               {
                   En = "YA",
                   Jp = "や",
                   Section = "Hirigana",
                   Category = "Special"
               },

               new Word
               {
                   En = "YU",
                   Jp = "ゆ",
                   Section = "Hirigana",
                   Category = "Special"
               },

               new Word
               {
                   En = "YO",
                   Jp = "よ",
                   Section = "Hirigana",
                   Category = "Special"
               },

               new Word
               {
                   En = "RA",
                   Jp = "ら",
                   Section = "Hirigana",
                   Category = "M-R"
               },

               new Word
               {
                   En = "RI",
                   Jp = "り",
                   Section = "Hirigana",
                   Category = "M-R"
               },

               new Word
               {
                   En = "RU",
                   Jp = "る",
                   Section = "Hirigana",
                   Category = "M-R"
               },

               new Word
               {
                   En = "RE",
                   Jp = "れ",
                   Section = "Hirigana",
                   Category = "M-R"
               },

               new Word
               {
                   En = "RO",
                   Jp = "ろ",
                   Section = "Hirigana",
                   Category = "M-R"
               },

               new Word
               {
                   En = "WA",
                   Jp = "わ",
                   Section = "Hirigana",
                   Category = "Special"
               },

               new Word
               {
                   En = "WO",
                   Jp = "を",
                   Section = "Hirigana",
                   Category = "Special"
               },

               new Word
               {
                   En = "WI",
                   Jp = "ゐ",
                   Section = "Hirigana",
                   Category = "Special"
               },

               new Word
               {
                   En = "WE",
                   Jp = "ゑ",
                   Section = "Hirigana",
                   Category = "Special"
               },

               new Word
               {
                   En = "N",
                   Jp = "ん",
                   Section = "Hirigana",
                   Category = "Special"
               }
           );
        }
    }
}
