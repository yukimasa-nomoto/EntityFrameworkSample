using Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Customers.Commands.CreateCustomer.Factory
{
    public class CustomerFactory : ICustomerFactory
    {
        public Customer Create(CreateCustomerModel model)
        {
            var customer = new Customer()
            {
                //Id = model.Id,
                Name = model.Name,
            };

            return customer;
        }
    }
}
