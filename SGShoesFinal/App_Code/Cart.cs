using System;
using System.Collections.Generic;
using System.Web;

namespace ShoppingCart
{
    public class CartItem
    {
        private int _productId;
        private string _name;
        private string _description;
        private decimal _price;
        private int _quantity;

        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }


        public decimal Total
        {
            get { return Price * Quantity; }
        }


        public CartItem() { }

        public CartItem(int productId, string name, string description, decimal price, int quantity)
        {
            _productId = productId;
            _name = name;
            _description = description;
            _price = price;
            _quantity = quantity;

        }
    }
}