using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_GreenPlan_Repo
{
    public enum GreenType { Electric= 1, Hybrid, Gas }
    public class GreenPlan
    {
        public int CarNum { get; set; }
        public GreenType Type { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string CityMpg { get; set; }
        public string HwyMpg { get; set; }
        public int Msrp { get; set; }
        //Empty Constructor
        public GreenPlan() { }
        //Overloaded Constructor
        public GreenPlan(/*int carNum, */GreenType type, string make, string model, string city, string hwy, int msrp)
        {
            //CarNum = carNum;
            Type = type;
            Make = make;
            Model = model;
            CityMpg = city;
            HwyMpg = hwy;
            Msrp = msrp;
        }
    }

}

