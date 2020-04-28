using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuddly_Red_Waffle_app.AppClasses
{
    class Request
    {

        public USANA_DBDataSetTableAdapters.RequestTableAdapter RequestsTable =
            new USANA_DBDataSetTableAdapters.RequestTableAdapter();
        
        private int clientID;
        private int productsID;
        private DateTime datePlaced;
        private int priority;
        private bool isCompleted;
        private bool isPayed;
        private int paymentID;

        public Request(int clientID, int productsID, DateTime datePlaced,
            int priority, bool isCompleted, bool isPayed)
        {        
            ClientID = clientID;
            ProductsID = productsID;
            DatePlaced = datePlaced;
            Priority = priority;
            IsCompleted = isCompleted;
            IsPayed = isPayed;
        }

        public void CreateRequestRow()
        {
            RequestsTable.Insert(datePlaced,priority,isCompleted,isPayed,clientID,productsID,1);

            RequestsTable.Update(RequestsTable.GetData());
        }

        public int ClientID { get => clientID; set => clientID = value; }
        public int ProductsID { get => productsID; set => productsID = value; }
        public DateTime DatePlaced { get => datePlaced; set => datePlaced = value; }
        public int Priority { get => priority; set => priority = value; }
        public bool IsCompleted { get => isCompleted; set => isCompleted = value; }
        public bool IsPayed { get => isPayed; set => isPayed = value; }
        public int PaymentID { get => paymentID; set => paymentID = value; }
    }
}
