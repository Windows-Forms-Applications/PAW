using System;
using System.Collections.Generic;
using System.Text;

namespace MDI
{
    class Abonat
    {
        private int cnp;
        private string nume;

        public Abonat(int c, string n)
        {
            cnp = c;
            nume = n;
        }

        public int Cnp
        {
            get { return cnp; }
            set { cnp = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
    }
}
