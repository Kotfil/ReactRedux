using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    interface Cliente
    {
        string FullName { get; set; }
        int Date { get; set; }
        double Interestrate { get; set; }
        double Score { get; set; }

        string Result();
    }
}
