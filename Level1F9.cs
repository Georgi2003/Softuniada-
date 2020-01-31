using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Level1F9 : Information
    {
        private int kooker;
        private string inform;

        public Level1F9(string inf, string pS, string info) : base(inf, pS)                       
        {
            base.typeInformation = inf;
            this.kooker = 1;
            this.inform = info;
        }

        public string Car()
        {
            string res = "Играчът може да си избере кола!!!";
            return res;
        }

        public int getHeating()
        {
            return this.kooker;
        }

        public void setHeating(int h)
        {
            if (h > 0)
            {
                this.kooker = h;
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
            string res = "Брои готварски печки за захранване: " + this.kooker + "\r\n" + "Информация: " + "\r\n" + this.inform;
            return res;
        }
    }
}
