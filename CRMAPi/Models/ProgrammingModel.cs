using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KuyaTest.Models
{
    public class ProgrammingModel
    {
        [Required]
        public int SelectedProgrammingLanguage { get; set; }
        public List<ProgrammingLanguage> ProgrammingLanguages { get { return languages; } set { languages = value; } }

        private List<ProgrammingLanguage> languages = initializeLanguages();

        private static List<ProgrammingLanguage> initializeLanguages()
        {
            List<ProgrammingLanguage> l = new List<ProgrammingLanguage>();
            l.Add(new ProgrammingLanguage(1, "Python"));
            l.Add(new ProgrammingLanguage(2, "Ruby"));
            l.Add(new ProgrammingLanguage(3, "C#"));
            l.Add(new ProgrammingLanguage(4, "Java"));
            return l;
        }
    }

    public class ProgrammingLanguage
    {
        public ProgrammingLanguage(int id, string name)
        {
            this.ProgrammingLanguageID = id;
            this.ProgrammingLanguageName = name;
        }
        public int  ProgrammingLanguageID { get; set; }
        public string ProgrammingLanguageName { get; set; }
    }
}