using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaCola.ClasesCola
{
    public class NodoCola
    {
        private int datocola;
        public int Datocola
        {
            get { return datocola; }
            set { datocola = value; }
        }

        private NodoCola siguientecola;

        public NodoCola Siguientecola
        {
            get { return siguientecola; }
            set { siguientecola = value; }
        }
    }
}
