using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickBuy.Domain.Entities
{
    [Table("Product")]
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        
        public override void Validate()
        {
            ClearMessages();

            if (string.IsNullOrEmpty(Name))
                AddCriti("Importante - Produto: Nome do produto não pode ser vazio");
            if (string.IsNullOrEmpty(Description))
                AddCriti("Importante - Produto: Descrição do produto não pode ser vazio");
        }
    }
}
