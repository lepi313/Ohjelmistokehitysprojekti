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
<<<<<<< HEAD
        public string ServLevel { get; set; }
        public string MPrice { get; set; }

        public Service(string servlevel, string mprice)
        {
            ServLevel = servlevel;
            MPrice = mprice;
        }

    }

}


=======
        public double Hinta { get; set; }
        public string Text { get; set; }

        public Service(int hinta, string text)
        {
            Hinta = hinta;
            Text = text;
        }
    }

    }
    
>>>>>>> 617d7c0d34221049d383d9d07abcea991a57ab44

