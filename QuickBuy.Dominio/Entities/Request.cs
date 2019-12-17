using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    class Request
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


        public ICollection<RequestItem> RequestsItems { get; set; }
    }
}
