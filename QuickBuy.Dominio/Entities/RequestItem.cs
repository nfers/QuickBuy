using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class RequestItem : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public ICollection<Product> Products { get; set; }   
        
         public override void Validate()
        {
            ClearMessages();

            if (ProductId == 0)
                AddCriti("Importante - Item Pedido: Produto precisa ser informado");

            if (!Products.Any())
                AddCriti("Importante - Item Pedido: item cannot be empty");

        }

    }
}
