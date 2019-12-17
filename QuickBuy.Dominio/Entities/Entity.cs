using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entity
    {
        public List<string> _messages { get; set; }
        public List<string> ValidationMessages
        {
            get { return _messages ?? (_messages = new List<string>()); }
        }

        public abstract void Validate();
        protected bool IsValid {
            get { return !ValidationMessages.Any(); }
        }


    }
}
