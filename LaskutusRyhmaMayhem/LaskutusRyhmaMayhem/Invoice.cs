using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaskutusRyhmaMayhem
{
    class Invoice
    {
        public string StringInvDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Double InvoiceSum { get; set; }
        public Customer CustomerName { get; set; }

        public Invoice(DateTime? invoicedate, int discount, Customer customer, Service service)
        {
            DateTime invdate = DateTime.Parse(invoicedate.ToString());
            StringInvDate= invdate.ToString();
            InvoiceDate = CalculateInvoiceDate(invdate, discount);
            InvoiceSum = CalculateDiscountPrice(discount, service);
            CustomerName = customer;
        }

        public DateTime CalculateInvoiceDate(DateTime invdate, int discount)
        {
            if (discount == 0)
            {
                return invdate.AddDays(180);
            }
            else if (discount == 1)
            {
                return invdate.AddDays(365);
            }
            else if (discount == 3)
            {
                return invdate.AddDays(30);
            }
            else
            {
                return invdate;
            }
        }

        public double CalculateDiscountPrice(int discount, Service service)
        {
            double dateamount = 0;
            if (discount == 0)
            {
                dateamount = 180;
            }
            else if (discount == 1)
            {
                dateamount = 365;
            }
            else if (discount == 2)
            {
                dateamount = 30;
            }
            else
            {
                dateamount = 30;
            }
            return service.MPrice * Math.Floor(dateamount / 30);
        }

        public Invoice()
        { }
    }
}
