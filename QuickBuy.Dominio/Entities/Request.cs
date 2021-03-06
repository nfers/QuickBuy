﻿using QuickBuy.Domain.ObjectValues;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    [Table("Request")]
    public class Request : Entity
    {
        public int Id { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime RequestDate { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }

        public string ZipCode { get; set; } //criar entidade de cidade, endereco e estado
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int NumberHouse { get; set; }
        public int PaymentId { get; set; }
                
        public virtual Payment Payment { get; set; } //Objeto de Valor
        public virtual ICollection<RequestItem> RequestItems { get; set; }

        public override void Validate()
        {
            ClearMessages();

            if (!RequestItems.Any())
                AddCriti("Importante - Pedido: Item do pedido nao pode ser vazio");

            if (string.IsNullOrEmpty(Address))
                AddCriti("Importante - Pedido: Endereço não pode ser vazio");

            if (string.IsNullOrEmpty(ZipCode))
                AddCriti("Importante - Pedido: CEP não pode estar vazio");

            if (PaymentId == 0)
                AddCriti("Importante - Pedido: Forma de Pagamento precisa ser informada");
        }
    }
}
