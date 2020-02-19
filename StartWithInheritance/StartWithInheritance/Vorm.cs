using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StartWithInheritance
{
    class Vorm
    {
        private static Int32 _aantal = 0;
        public static Int32 Aantal
        {
            get
            {
                return _aantal;
            }
        }
        private int _nummer;
        public int Nummer
        {
            get
            {
                return _nummer;
            }
            private set
            {
                _nummer = value;
            }
        }
        public Vorm()
        {
            _aantal++;
            Nummer = _aantal;
        }

        public void Paint(Graphics g)
        {
            if (this is Cirkel)
            {
                Cirkel c = (Cirkel)this;
                c.Paint(g);
            }
            else if(this is Vierkant)
            {
                Vierkant v = (Vierkant)this;
                v.Paint(g);
            }
        }
    }
}
