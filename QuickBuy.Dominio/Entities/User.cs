﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
     class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<Request> Requests { get; set; }

        public override void Validate()
        {
            ClearMessages();
            if (string.IsNullOrEmpty(Name))
                AddCriti("Atention: zipcode cannot be empty");
        }
    }
}
