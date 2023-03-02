using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LaskutusRyhmaMayhem
{
    class Service
    {
        public double Hinta { get; set; }
        public string Text { get; set; }
    }
    public Service(int hinta, string text)
    {
        Hinta = hinta;
        Text = text;
    }
    }
    

