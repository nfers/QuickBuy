using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    class RequestItem : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

    }
}
