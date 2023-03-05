using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaskutusRyhmaMayhem
{
    internal class Invoice
    {
        public string StringInvDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Double InvoiceSum { get; set; }
        public Customer CustomerName { get; set; }

        public Invoice(DateTime? invoicedate, int Discount, Customer customer, Service service)
        {
            DateTime invdate = DateTime.Parse(invoicedate.ToString());
            StringInvDate= invdate.ToString();
            CustomerName = customer;
        }
    }
}
