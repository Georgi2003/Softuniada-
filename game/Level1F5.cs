using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Level1F5 : Information
    {
        private int heating;
        private string inform;

        public Level1F5(string inf, string pS, string info, int heat) : base(inf, pS)                       
        {
            base.typeInformation = inf;
            this.heating = heat;
            this.inform = info;
        }

        public int getHeating()
        {
            return this.heating;
        }

        public void setHeating(int h)
        {
            if (h > 0)
            {
                this.heating = h;
            }
            else
            {
                this.heating = 0;
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
            string res = "Брои отоплителни уреди за захранване: " + this.heating + "\r\n" + "Информация: " + "\r\n" + this.inform;
            return res;
        }
    }
}
