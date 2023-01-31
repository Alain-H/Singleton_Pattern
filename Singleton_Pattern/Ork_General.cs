using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    internal class Ork_General
    {

        public string name;
        private static Ork_General My_General;   
        private Ork_General()
        {

        }
        public static Ork_General getInstance()
        {
            if (My_General == null)
            {
                My_General = new Ork_General();
            }
            return My_General;
        }

        public void setName(string General)
        {
            name = General;
        }
        public string AngrifsBefehl()
        {
            return name + " Befehl: Jetzt greifen wir an!";
        }
        public string Rueckzugsbefehl()
        {
            return name + " Befehl: Wir ziehen uns zurück!"!;
        }
    }
}
