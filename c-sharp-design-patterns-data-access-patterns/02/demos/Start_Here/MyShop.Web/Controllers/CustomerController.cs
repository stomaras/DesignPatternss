using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyShop.Domain.Models;
using MyShop.Infrastructure;
using MyShop.Infrastructure.Repositories;

namespace MyShop.Web.Controllers
{
    /*
     * No need for us to inject the IUnitOfWork into thic class here because we have only one repository
     * 
     */
    public class CustomerController : Controller
    {
        private readonly IRepository<Customer> customerRepository;
        // Inject an IRepository of custmomer
        public CustomerController(IRepository<Customer> customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public IActionResult Index(Guid? id)
        {
            if (id == null)
            {
                var customers = customerRepository.GetAll();

                return View(customers);
            }
            else
            {
                var customer = customerRepository.Get(id.Value);

                return View(new[] { customer });
            }
        }
    }
}
