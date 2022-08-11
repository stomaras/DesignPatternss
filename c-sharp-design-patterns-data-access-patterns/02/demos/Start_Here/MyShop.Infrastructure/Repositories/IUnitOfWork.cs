using MyShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Infrastructure.Repositories
{
    public interface IUnitOfWork
    {
        // All the different Repositories that exist in our app available in our unit of work 
        IRepository<Customer> CustomerRepository { get; }
        IRepository<Order> OrderRepository { get; }
        IRepository<Product> ProductRepository { get; }

        void SaveChanges();
    }
}
