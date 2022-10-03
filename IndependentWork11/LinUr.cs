using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork11
{
    struct LinUr
    {
        double k;
        double b;

        public LinUr(double k, double b) 
        {
            this.k = k; 
            this.b = b;

        }
        public string Root() 
        {
            double x = -b / k;
            return $"X={x}";

        }
    }
}
