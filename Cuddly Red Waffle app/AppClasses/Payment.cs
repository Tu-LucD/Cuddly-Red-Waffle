using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuddly_Red_Waffle_app.AppClasses
{
    class Payment
    {
        private int paymentID;
        private int amountDue;
        private int amountPaid;
        private DateTime dateDue;
        private DateTime datePaid;
        private string paymentMethod;

        public Payment(int paymentID, int amountDue, int amountPaid, 
            DateTime dateDue, DateTime datePaid, string paymentMethod)
        {
            PaymentID = paymentID;
            AmountDue = amountDue;
            AmountPaid = amountPaid;
            DateDue = dateDue;
            DatePaid = datePaid;
            PaymentMethod = paymentMethod;
        }

        public int PaymentID { get => paymentID; set => paymentID = value; }
        public int AmountDue { get => amountDue; set => amountDue = value; }
        public int AmountPaid { get => amountPaid; set => amountPaid = value; }
        public DateTime DateDue { get => dateDue; set => dateDue = value; }
        public DateTime DatePaid { get => datePaid; set => datePaid = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
    }
}
