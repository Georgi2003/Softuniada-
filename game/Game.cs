using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Game : Information
    {
        private int Levels;

        public Game(int l, string inf, string pS) : base(inf, pS)
        {
            this.Levels = l;
            base.typeInformation = inf;
        }

        public string Ret()
        {
            string res = "Играта се играе от двама играчи!!!".ToString();
            return res;
        }

        public string Purpose()
        {
            string res = "Цел: Захранване на къщата!!!".ToString();
            return res;
        }

        public string Coins()
        {
            string res = "Събирането на монети увеличава точките!".ToString();
            return res;
        }

        public string Bombs()
        {
            string res = "Събирането на бомби намалява точките!".ToString();
            return res;
        }


        public int getLevels()
        {
            return this.Levels;
        }

        public void setLevels(int l)
        {
            do
            {
                this.Levels = l;
            }
            while(l > 0);
        }

        public override string ToString()
        {
            string res = base.typeInformation + "\r\n" + "Брои нива: " + this.Levels;
            return res;
        }
    }
}
