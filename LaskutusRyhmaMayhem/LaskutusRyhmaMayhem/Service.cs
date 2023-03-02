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
        public double Hinta { get; set; }
        public string Text { get; set; }

        public Service(double hinta, string text)
        {
            Hinta = hinta;
            Text = text;
        }

    }

}


