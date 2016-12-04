using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGShoesFinal.Masters
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Login1.Focus();
        }
        protected void Username_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Login1.UserName == "Admin" && Login1.Password == "Admin")
            {
                e.Authenticated = true;
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
 