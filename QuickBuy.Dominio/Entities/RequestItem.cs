using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    class RequestItem : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public ICollection<Product> Products { get; set; }      
         public override void Validate()
        {
            ClearMessages();

            if (!Products.Any())
                AddCriti("Atention: item cannot be empty");
        }

    }
}
