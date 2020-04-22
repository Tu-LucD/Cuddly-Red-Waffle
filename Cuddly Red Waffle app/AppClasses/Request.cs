using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuddly_Red_Waffle_app.AppClasses
{
    class Request
    {
        private int requestID;
        private int clientID;
        private int productsID;
        private DateTime datePlaced;
        private int priority;
        private bool isCompleted;
        private bool isPayed;
        private int paymentID;

        public Request(int requestID, int clientID, int productsID, DateTime datePlaced,
            int priority, bool isCompleted, bool isPayed, int paymentID)
        {
            RequestID = requestID;
            ClientID = clientID;
            ProductsID = productsID;
            DatePlaced = datePlaced;
            Priority = priority;
            IsCompleted = isCompleted;
            IsPayed = isPayed;
            PaymentID = paymentID;
        }

        public int RequestID { get => requestID; set => requestID = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public int ProductsID { get => productsID; set => productsID = value; }
        public DateTime DatePlaced { get => datePlaced; set => datePlaced = value; }
        public int Priority { get => priority; set => priority = value; }
        public bool IsCompleted { get => isCompleted; set => isCompleted = value; }
        public bool IsPayed { get => isPayed; set => isPayed = value; }
        public int PaymentID { get => paymentID; set => paymentID = value; }
    }
}
