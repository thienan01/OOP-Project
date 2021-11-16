using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.App
{
    class YoutubeApp: IAppleCompatible
    {
        private string appName = "Youtube for IOS";
        private string version = "15.2";

        public string downloading()
        {
            return "Downloading " + ToString();
        }
        public string OSCompatible
        {
            get
            {
                return "IOS";
            }
        }

        public override string ToString()
        {
            return "app name: " + appName + ", Version: " + version;
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
