using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal interface IPlayable
    {
        public decimal Salary { get; set; }
        public decimal ShowPayment();
    }
}