using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Level1F7 : Information
    {
        private int boiler;
        private string inform;

        public Level1F7(string inf, string pS, string info, int boil) : base(inf, pS)                       
        {
            base.typeInformation = inf;
            this.boiler = boil;
            this.inform = info;
        }

        public int getBoiler()
        {
            return this.boiler;
        }

        public void setBoiler(int h)
        {
            if (h > 0)
            {
                this.boiler = h;
            }
            else
            {
                this.boiler = 0;
            }
        }

        public string getInform()
        {
            return this.inform;
        }

        public void setInform(string i)
        {
            this.inform = i;
        }

        public override string ToString()
        {
            string res = "Брои уреди за захранване: " + this.boiler + "\r\n" + "Информация: " + "\r\n" + this.inform;
            return res;
        }
    }
}
