using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entity
    {
        public List<string> _messages { get; set; }
        private List<string> ValidationMessages
        {
            get { return _messages ?? (_messages = new List<string>()); }
        }
        protected void ClearMessages()
        {
            ValidationMessages.Clear();
        }
        protected void AddCriti(string msg)
        {
            ValidationMessages.Add(msg);
        }
        public abstract void Validate();
        protected bool IsValid {
            get { return !ValidationMessages.Any(); }
        }
    }
}
