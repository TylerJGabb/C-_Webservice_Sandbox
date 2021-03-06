﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WFC_Walkthrough
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {


        public string GetData(string value)
        {
            return value + " I got your data with the value";
        }

        public void MutateCompositeType(ref CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
        }

        public string Get(string request)
        {
            string[] args = request.Split('?')[1].Split('&');
            return args[0];
        }

        //public SomeOtherClass GetSome()
        //{
        //    return new SomeOtherClass();
        //}
    }
}
