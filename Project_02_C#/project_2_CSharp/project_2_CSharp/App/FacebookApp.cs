using project_2_CSharp.product;
using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.App
{
    class FacebookApp:IAndroidCompatible
    {
        private string appName = "Facebook for android";
        private string version = "12.3";

        public string downloading()
        {
            return "Downloading " + ToString();
        }

        public string OSCompatible
        {
            get {
                return "Android";
            }
        }

        public override string ToString()
        {
            return "app name: " + appName  + ", Version: " + version;
        }

        public bool check(string os)
        {
            if (os == this.OSCompatible)
            {
                return true;
            }
            return false;      
        }
    }
}
