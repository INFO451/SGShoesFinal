using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using SGShoesFinal.App_Code;
using ShoppingCart.DAL;


namespace SGShoesFinal.App_Code
{
    public class BusinessLogic
    {

        public List<CartItem> getCartContents()
        {
            return (List<CartItem>)HttpContext.Current.Session["UserCart"];
        }


        public List<CartItem> addCartItem(CartItem item)
        {
            List<CartItem> currentCart = (List<CartItem>)HttpContext.Current.Session["UserCart"];

            if (!currentCart.Exists(s => s.ProductId == item.ProductId))
                currentCart.Add(item);

            else
            {
                CartItem curItem = currentCart.Find(s => s.ProductId == item.ProductId);
                int newQty = curItem.Quantity + item.Quantity;

                curItem.Quantity = newQty;
            }

            return currentCart;
        }


        public void deleteCartItem(CartItem item)
        {
            List<CartItem> currentCart = (List<CartItem>)HttpContext.Current.Session["UserCart"];
            currentCart.RemoveAll(s => s.ProductId == item.ProductId);

        }

        public int sumCartItems(List<CartItem> cart)
        {

            int items = 0;

            foreach (CartItem item in cart)
            {
                items += item.Quantity;
            }

            return items;

        }

        public int getVisitorId()
        {
            DataAccess dataAccess = new DataAccess();
            return dataAccess.InsertVisitor();

        }

        public void updateLastVisit(int visitorId)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.UpdateVisit(visitorId);

        }

    }
}