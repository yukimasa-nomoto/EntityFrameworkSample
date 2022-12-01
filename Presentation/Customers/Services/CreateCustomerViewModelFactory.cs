using Application.Customers.Commands.CreateCustomer;
using Application.Customers.Queries.GetCustomerList;
using Presentation.Customers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Customers.Services
{
    public class CreateCustomerViewModelFactory : ICreateCustomerViewModelFactory
    {
        private readonly IGetCustomersListQuery _query;

        public CreateCustomerViewModelFactory(IGetCustomersListQuery query) 
        { 
            _query = query;
        }
        public CreateCustomerViewModel Create()
        {
            var customers = _query.Execute();

            var m = new CreateCustomerViewModel();

            //今のところはそのまま移行
            m.Customers = customers;
            //ここで入れておく
            m.Customer = new CreateCustomerModel();


            return m;
        }
    }
}
