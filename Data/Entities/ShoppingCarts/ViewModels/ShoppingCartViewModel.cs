using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities.ShoppingCarts.ViewModels
{
    public class ShoppingCartViewModel
    {
        public string DeliveryAddress { get; set; }

        public IList<ShoppingCartItemViewModel> Items { get; set; }
    }
}
