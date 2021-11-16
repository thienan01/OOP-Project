using project_2_CSharp.product;
using System;
using System.Collections.Generic;
using System.Text;

namespace project_2_CSharp.App
{
    interface IAndroidCompatible
    {
        string OSCompatible { get; }
        string downloading();

        bool check(string os);
    }
}
