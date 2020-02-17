using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GIT
{
    class Program
    {
        static List<Auto> autoLista = new List<Auto>();

        static void Main(string[] args)
        {
            
            StreamReader sr = new StreamReader("auto.csv");

            string sor;
            do
            {
                sor = sr.ReadLine();
                string[] ertek = sor.Split(';');
                Auto a = new Auto(ertek[0], ertek[1], ertek[2], Convert.ToInt32(ertek[3]), Convert.ToInt32(ertek[4]), Convert.ToInt32(ertek[5]));
                autoLista.Add(a);
            } while (!sr.EndOfStream);


            sr.Close();

        }

        
    }
    class Auto
    {
        private string _markaNev;
        private string _modellNev;
        private string _uzemanyagTipus;
        private int _kilometer;
        private int _evarat;
        private int _ar;

        public Auto(string markaNev, string modellNev, string uzemanyagTipus, int kilometer, int evarat, int ar)
        {
            _markaNev = markaNev;
            _modellNev = modellNev;
            _uzemanyagTipus = uzemanyagTipus;
            _kilometer = kilometer;
            _evarat = evarat;
            _ar = ar;
        }

        public string MarkaNev { get => _markaNev; set => _markaNev = value; }
        public string ModellNev { get => _modellNev; set => _modellNev = value; }
        public string UzemanyagTipus { get => _uzemanyagTipus; set => _uzemanyagTipus = value; }
        public int Kilometer { get => _kilometer; set => _kilometer = value; }
        public int Evarat { get => _evarat; set => _evarat = value; }
        public int Ar { get => _ar; set => _ar = value; }
    }
}
