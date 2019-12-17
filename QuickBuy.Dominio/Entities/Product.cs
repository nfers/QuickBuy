using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public override void Validate()
        {
            ClearMessages();
            if (string.IsNullOrEmpty(Name))
                AddCriti("Atention: name cannot be empty");
        }
    }
}
