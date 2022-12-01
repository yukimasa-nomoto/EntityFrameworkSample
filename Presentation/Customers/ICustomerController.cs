using Application.Customers.Queries.GetCustomerList;
using Presentation.Customers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Customers
{
    public interface ICustomerController
    {
        List<CustomerModel> Index();
        void Create(CreateCustomerViewModel viewModel);
    }
}
