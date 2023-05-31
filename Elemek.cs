using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga
{
    class Elemek
    {
        private string ev;
        private string elem;
        private string vegyjel;
        private int rendszam;
        private string felfedezo;

        public Elemek(string csvLine)
        {
            var lines = csvLine.Split(';');

            ev = lines[0];
            elem = lines[1];
            vegyjel = lines[2];
            rendszam = Convert.ToInt32(lines[3]);
            felfedezo = lines[4];
        }

        public Elemek(string ev, string elem, string vegyjel, int rendszam, string felfedezo)
        {
            this.ev = ev;
            this.elem = elem;
            this.vegyjel = vegyjel;
            this.rendszam = rendszam;
            this.felfedezo = felfedezo;
        }


        public string Ev { get => ev; set => ev = value; }
        public string Elem { get => elem; set => elem = value; }
        public string Vegyjel { get => vegyjel; set => vegyjel = value; }
        public int Rendszam { get => rendszam; set => rendszam = value; }
        public string Felfedezo { get => felfedezo; set => felfedezo = value; }
    }
}
