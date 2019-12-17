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

        public ICollection<RequestItem> RequestsItems { get; set; }
    }
}
