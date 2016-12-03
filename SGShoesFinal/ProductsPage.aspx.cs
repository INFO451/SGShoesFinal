using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGShoesFinal
{
    public partial class ProductsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void QuantDD_DataBound(object sender, EventArgs e)
        {
            DropDownList myDD = (DropDownList)sender;
            string ssize = myDD.SelectedValue;
            int quant;
            if (int.TryParse(ssize,out quant))
            {
                myDD.Items.Clear();                
                for (int x=1;x<=quant;x++)
                {
                    ListItem newOption = new ListItem((x).ToString(), x.ToString());
                    myDD.Items.Add(newOption);
                }
            }            
        }
    }
}