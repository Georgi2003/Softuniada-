using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Information
    {
        protected string typeInformation;      
        protected string powerSupply;
        protected string energyConsumption;

        public string levels(int lev) 
        {
            string res = "Ниво: " + lev;
            return res;
        }

        public Information(string inf, string pS) 
        {
            this.typeInformation = inf;
            this.powerSupply = pS;
            this.energyConsumption = "Уредите консумират ел. енергия [Е]";
        }

        public string CountPoints(int points)
        {
            string res = "Брои точки: " + points;
            return res;
        }

        public string getTypeInformation()
        {
            return this.typeInformation;
        }

        public void setTypeInformation(string tF)
        {
            this.typeInformation = tF;            
        }

        public string getPowerSupply()
        {
            return this.powerSupply;
        }

        public void setPowerSupply(string pS)
        {
            this.powerSupply = pS;
        }

        public string getEnergyConsumption()
        {
            return this.energyConsumption;
        }

        public void setEnergyConsumption(string eC)
        {
            this.energyConsumption = eC;
        }

        public override string ToString()
        {
            string res = this.typeInformation + "\r\n" + "Захранване на: " + this.powerSupply + "\r\n" + this.energyConsumption;
            return res;
        }
    }
}
