using QuickBuy.Domain.Entities;
using QuickBuy.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository
{
    public class Client
    {
        public Client()
        {
            var userRepository = new UserRepository();
            var user = new Product();

            userRepository.Add(user);
        }
    }
}
