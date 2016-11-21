using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisRacunara
{
    class Deo
    {
        private String model;
        private String kolicina;
        private String cena;

        public Deo()
        {

        }

        public Deo(String Model, String Kolicina, String Cena)
        {
            this.model = Model;
            this.kolicina = Kolicina;
            this.cena = Cena;

        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string Kolicina
        {
            get
            {
                return kolicina;
            }

            set
            {
                kolicina = value;
            }
        }

        public string Cena
        {
            get
            {
                return cena;
            }

            set
            {
                cena = value;
            }
        }
    }
}
