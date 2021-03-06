﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuddly_Red_Waffle_app.AppClasses
{
    class Client
    {
        private int clientID;
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string address;
        private string phone;
        private int healthCategory;

        public USANA_DBDataSetTableAdapters.ClientTableAdapter clientsTable =
               new USANA_DBDataSetTableAdapters.ClientTableAdapter();


        public Client(string firstName, string lastName, string emailAddress,
            string address, string phone, int healthCategory)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Address = address;
            Phone = phone;
            HealthCategory = healthCategory;
        }

        public void CreateClientRow()
        {
            clientsTable.InsertIntoClient(FirstName, LastName,
               EmailAddress, Address, Phone, HealthCategory);


            clientsTable.Update(clientsTable.GetData());

        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public int HealthCategory { get => healthCategory; set => healthCategory = value; }
        public int ClientID { get => clientID; set => clientID = value; }
    }
}
