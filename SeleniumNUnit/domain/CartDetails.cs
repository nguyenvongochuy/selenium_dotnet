using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumNUnit
{
    class CartDetails
    {
        private String productName;
        private String unitPrice;
        private String quantity;
        private String price;
        private String grandTotal;

        public CartDetails(string productName, string unitPrice, string quantity, string price, string grandTotal)
        {
            this.productName = productName;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            this.price = price;
            this.grandTotal = grandTotal;
        }

        public string ProductName { get => productName; set => productName = value; }
        public string UnitPrice { get => unitPrice; set => unitPrice = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string Price { get => price; set => price = value; }
        public string GrandTotal { get => grandTotal; set => grandTotal = value; }
    }
}
