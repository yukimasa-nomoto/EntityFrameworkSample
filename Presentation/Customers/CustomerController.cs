using Application.Customers.Commands.CreateCustomer;
using Application.Customers.Queries.GetCustomerList;
using Presentation.Customers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Customers
{
    public class CustomerController : ICustomerController
    {
        private readonly IGetCustomersListQuery _customerListQuery;
        private readonly ICreateCustomerCommand _createCommand;

        public CustomerController(IGetCustomersListQuery customerListQuery
            , ICreateCustomerCommand createCommand)
        {
            _customerListQuery = customerListQuery;
            _createCommand = createCommand;
        }
        public List<CustomerModel> Index()
        {
            var customers = _customerListQuery.Execute();

            return customers;

        }

        public void Create(CreateCustomerViewModel viewModel)
        {
            var m = viewModel.Customer;

            _createCommand.Execute(m);

        }

        
    }
}
