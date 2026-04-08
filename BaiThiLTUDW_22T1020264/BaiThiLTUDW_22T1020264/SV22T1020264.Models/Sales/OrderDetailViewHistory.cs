using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV22T1020264.Models.Sales
{
    public class OrderDetailViewHistory : Order
    {
        public List<OrderDetailViewInfo> LstOrderDetails { get; set; }
    }
}
