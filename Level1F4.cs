using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Level1F4 : Information
    {
        private int lamp;
        private int computer;

        public Level1F4(string inf, string pS, int lamps, int comp) : base(inf, pS)                       
        {
            base.typeInformation = inf;
            this.lamp = lamps;
            this.computer = comp;
        }

        public int getLamp()
        {
            return this.lamp;
        }

        public void setLamp(int l)
        {
            if(l > 0)
            {
                this.lamp = l;
            }            
        }

        public int getComp()
        {
            return this.computer;
        }

        public void setComp(int c)
        {
            if (c > 0)
            {
                this.computer = c;
            }
        }

        public override string ToString()
        {
            string res = "Брои лампи за захранване: " + this.lamp + "\r\n" + "и " + this.computer + " компютър";
            return res;
        }
    }
}
