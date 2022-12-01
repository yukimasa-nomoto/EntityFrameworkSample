using Application.Customers.Commands.CreateCustomer;
using Application.Customers.Queries.GetCustomerList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Customers.Models
{
    public class CreateCustomerViewModel
    {
        public CreateCustomerModel Customer { get; set; }

        public List<CustomerModel> Customers { get; set; }
    }
}
