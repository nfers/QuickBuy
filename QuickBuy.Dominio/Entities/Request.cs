using QuickBuy.Domain.ObjectValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class Request : Entity
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public int UserId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string ZipCode { get; set; } //criar entidade separada depois
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int NumberHouse { get; set; }
        public int PaymentId { get; set; }
        
        public Payment Payment { get; set; } //Objeto de Valor
        public ICollection<RequestItem> RequestsItems { get; set; }

        public override void Validate()
        {
            ClearMessages();

            if (!RequestsItems.Any())
                AddCriti("Importante - Pedido: Item do pedido nao pode ser vazio");

            if (string.IsNullOrEmpty(Address))
                AddCriti("Importante - Pedido: Endereço não pode ser vazio");

            if (string.IsNullOrEmpty(ZipCode))
                AddCriti("Importante - Pedido: CEP não pode estar vazio");

            if (PaymentId == 0)
                AddCriti("Importante - Pedido: Forma de Pagamento não pode ser nula");
        }
    }
}
