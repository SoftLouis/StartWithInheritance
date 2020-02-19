using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StartWithInheritance
{
    class Cirkel : Vorm
    {
        const UInt32 MAX_SIZE = 200;

        UInt32 _straal;
        public UInt32 Straal
        {
            get
            {
                return _straal;
            }
            set
            {
                if (value > MAX_SIZE)
                {
                    //mag niet!
                    throw new Exception("Straal is groter dan " + MAX_SIZE);
                }
                else
                {
                    _straal = value;
                }
            }
        }
        public Cirkel(UInt32 straal)
        {
            Straal = straal;
        }

        public void Paint(Graphics g)
        {
            Pen pen = new Pen(new SolidBrush(Color.Black));
            g.FillEllipse(new SolidBrush(Color.Yellow),
                Straal, Straal, Straal, Straal);
            g.DrawEllipse(pen, Straal, Straal, Straal, Straal);

        }

        public override String ToString()
        {
            return $"cirkel {Nummer} met straal {Straal}";
        }
    }

}
