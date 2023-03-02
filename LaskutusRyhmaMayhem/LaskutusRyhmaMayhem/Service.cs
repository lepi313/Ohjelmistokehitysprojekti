using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace LaskutusRyhmaMayhem
{
    class Service
    {
        public string ServLevel { get; set; }
        public double MPrice { get; set; }
        public Service(double mprice, string servlevel)
        {
            ServLevel = servlevel;
            MPrice = mprice;
        }

    }

}


