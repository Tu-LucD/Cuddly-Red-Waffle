using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuddly_Red_Waffle_app.AppClasses
{
    class Order
    {
        private int orderID;
        private int productInOrder;
        private int totalPoints;
        private bool isPlaced;
        private bool isShipped;
        private bool isDelivered;
        private DateTime arrivalDate;

        public USANA_DBDataSetTableAdapters.OrdersTableAdapter OrdersTable =
            new USANA_DBDataSetTableAdapters.OrdersTableAdapter();

        public Order(int orderID, int productInOrder, int totalPoints, 
            bool isPlaced, bool isShipped, bool isDelivered, DateTime arrivalDate)
        {
            OrderID = orderID;
            ProductInOrder = productInOrder;
            TotalPoints = totalPoints;
            IsPlaced = isPlaced;
            IsShipped = isShipped;
            IsDelivered = isDelivered;
            ArrivalDate = arrivalDate;
        }

        public void CreateOrderRow()
        {
            OrdersTable.Insert(ProductInOrder, TotalPoints, IsPlaced, IsShipped, IsDelivered, ArrivalDate);

            OrdersTable.Update(OrdersTable.GetData());
        }


        public int OrderID { get => orderID; set => orderID = value; }
        public int ProductInOrder { get => productInOrder; set => productInOrder = value; }
        public int TotalPoints { get => totalPoints; set => totalPoints = value; }
        public bool IsPlaced { get => isPlaced; set => isPlaced = value; }
        public bool IsShipped { get => isShipped; set => isShipped = value; }
        public bool IsDelivered { get => isDelivered; set => isDelivered = value; }
        public DateTime ArrivalDate { get => arrivalDate; set => arrivalDate = value; }
    }
}
