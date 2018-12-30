﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SinglePayment
    {
        private string name;
        private double price;
        private double quantity;
        private bool isPaid;

        // Konstruktory 

        public SinglePayment(string name, double price, double quantity, bool isPaid)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.IsPaid = isPaid;
        }

        // Getery i Setery 

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public bool IsPaid { get => isPaid; set => isPaid = value; }

        // To string

        public override string ToString()
        {
            return this.Name + "  Quantity: " + this.Quantity + "  Price: " + this.Price + "  Cost: " + Cost().ToString() + "  Is Paid: " + this.IsPaid;
        }

        // Metody dodatkowe

        public virtual double Cost()
        {
            return quantity * price;
        }

    }
}