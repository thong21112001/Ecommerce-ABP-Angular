using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceABP.Orders
{
    public enum OrderStatus
    {
        New,
        Confirmed,
        Processing,
        Shipping,
        Finished,
        Canceled
    }
}
