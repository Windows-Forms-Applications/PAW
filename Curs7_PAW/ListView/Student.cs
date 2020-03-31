using System;
using System.Collections.Generic;
using System.Text;

namespace ListView
{
    class Student
    {
        private int cod;
        private string nume;
        private float nota;

        public Student(int c, string nm, float nt)
        {
            cod = c;
            nume = nm;
            nota = nt;
        }

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public float Nota
        {
            get { return nota; }
            set { nota = value; }
        }
    }
}
