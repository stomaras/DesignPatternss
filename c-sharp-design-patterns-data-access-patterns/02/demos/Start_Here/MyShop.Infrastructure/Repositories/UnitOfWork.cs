using MyShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ShoppingContext _shoppingContext;

        public UnitOfWork(ShoppingContext shoppingContext)
        {
            _shoppingContext = shoppingContext;
        }

        private IRepository<Customer> customerRepository;
        public IRepository<Customer> CustomerRepository
        {
            get
            {
                if (customerRepository == null)
                {
                    customerRepository = new CustomerRepository(_shoppingContext);
                }
                return customerRepository;
            }
        }

        private IRepository<Order> orderRepository;
        public IRepository<Order> OrderRepository
        {
            get
            {
                if (orderRepository == null)
                {
                    orderRepository = new OrderRepository(_shoppingContext);
                }
                return orderRepository;
            }
        }

        private IRepository<Product> productRepository;
        public IRepository<Product> ProductRepository
        {
            // lazy initializing a particular class we are going to fetch some data that could potentianlyyy
            // a little bit more of an expensive operation 
            get
            {
                if (productRepository == null)
                {
                    productRepository = new ProductRepository(_shoppingContext);
                }
                return productRepository;
            }
        }

        public void SaveChanges()
        {
            _shoppingContext.SaveChanges();
        }
    }
}
