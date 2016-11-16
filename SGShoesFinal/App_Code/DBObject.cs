using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGShoesFinal.App_Code
{
    public class DBObject
    {
        private int _id = 0;
    }

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
}