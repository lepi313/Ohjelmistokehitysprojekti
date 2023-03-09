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

        public void SetInvoices(DateTime? invoicedate, int discount, Customer customer, Service service)
        {
            DateTime invdate = DateTime.Parse(invoicedate.ToString());
            int dateamount = 0;
            if (discount == 0)
            {
                dateamount = 180;
                InvoiceDate = invdate;
                StringInvDate = InvoiceDate.ToShortDateString();
                InvoiceSum = CalculateDiscountPrice(discount, service);
                CustomerName = customer;
            }
            else if (discount == 1)
            {
                dateamount = 365;
                InvoiceDate = invdate;
                StringInvDate = InvoiceDate.ToShortDateString();
                InvoiceSum = CalculateDiscountPrice(discount, service);
                CustomerName = customer;
            }
            else if (discount == 2)
            {
                dateamount = 30;
                InvoiceDate = invdate.AddDays(dateamount);
                StringInvDate = InvoiceDate.ToShortDateString();
                InvoiceSum = CalculateDiscountPrice(discount, service);
                CustomerName = customer;
            }
            else
            {
                dateamount = 0;
                InvoiceDate = invdate;
                StringInvDate = InvoiceDate.ToShortDateString();
                InvoiceSum = CalculateDiscountPrice(discount, service);
                CustomerName = customer;
            }
        }

        public double CalculateDiscountPrice(int discount, Service service)
        {
            double dateamount = 0;
            double percentage = 0;

            if (discount == 0)
            {
                dateamount = 180;
                percentage = 0.9;
            }
            else if (discount == 1)
            {
                dateamount = 365;
                percentage = 0.82;
            }
            else if (discount == 2)
            {
                dateamount = 30;
                percentage = 1;
            }
            else
            {
                dateamount = 30;
                percentage = 1;
            }

            return Math.Round(service.MPrice * Math.Floor(dateamount / 30) * percentage, 2);
        }

        public Invoice()
        { }
    }
}
