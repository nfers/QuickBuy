using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    [Table("User")]
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        //Um usuario pode ter muitos pedidos, relacionamento 1 => N
        public virtual ICollection<Request> Requests { get; set; }
        public override void Validate()
        {
            ClearMessages();

            if (string.IsNullOrEmpty(Name))
                AddCriti("Atention: o Cep precisa ser informado");

            if (string.IsNullOrEmpty(Email))
                AddCriti("Usuario - Atenção: e-mail não foi informado");
        }
    }
}
