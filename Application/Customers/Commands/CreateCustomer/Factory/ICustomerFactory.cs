using Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Customers.Commands.CreateCustomer.Factory
{
    public interface ICustomerFactory
    {
        Customer Create(CreateCustomerModel model);
    }
}
