using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.App
{
    interface IAppleCompatible
    {
        string OSCompatible { get;}
        string downloading();
        bool check(string os);
    }
}
