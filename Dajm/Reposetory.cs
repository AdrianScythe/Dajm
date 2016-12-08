using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dajm
{
    public class Reposetory 
    {
        public List<ConsoleComands> KlasseListe;
        public Reposetory()
        {
            KlasseListe = new List<ConsoleComands>();
        }

        public int Tælle()
        {
            return KlasseListe.Count;
        }
        public void Tilføj(ConsoleComands Klasse)
        {
            KlasseListe.Add(Klasse);
        }
    }
}
