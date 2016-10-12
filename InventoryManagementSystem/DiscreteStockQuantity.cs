using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class DiscreteStockQuantity : StockQuantity
    {
        private int _Quantity;
        public int Quantity { get; }

        public DiscreteStockQuantity(int quantity)
        {
            Quantity = quantity;
            _Quantity = Quantity;
            Console.WriteLine(_Quantity);

        }


    }
}
