using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceABP.Orders
{
    public enum TransactionType
    {
        ConfirmOrder,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}
