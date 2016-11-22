using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGShoesFinal.App_Code
{
    abstract class DBObject
    {
        private int _id = 0;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        abstract public void select();
        abstract public void update();
        abstract public void delete();
        abstract public void insert();

    }
}