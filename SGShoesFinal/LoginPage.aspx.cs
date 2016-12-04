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
            private TextBox txtUserName;
        private TextBox txtPassword;

        public string Username
        { get
            {
                EnsureChildControls();
                return txtUserName.Text;
            }
            set
            {
                EnsureChildControls();
                txtUserName.Text = value;
            }
        }
        public string Password
        {
            get
            {
                EnsureChildControls();
                return txtPassword.Text;
            }
            set
            {
                EnsureChildControls();
                txtPassword.Text = value;
            }
        }
        protected override void CreateChildControls()
        {
            txtUserName = new TextBox();
            txtUserName.ID = "txtUserName";
            this.Controls.Add(txtUserName);

            txtPassword = new TextBox();
            txtPassword.ID = "txtPassword";
            txtPassword.TextMode = TextBoxMode.Password;
            this.Controls.Add(txtPassword);
        }
        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);

            writer.RenderEndTag();
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            writer.RenderEndTag();
        }
        protected override HtmlTextWriterTag TagKey
        {
            get
            {
                return HtmlTextWriterTag.Table;
            }
        }
        }
    }