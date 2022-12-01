using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Customers.Queries.GetCustomerList
{
    public class GetCustomersListQuery : IGetCustomersListQuery
    {
        private readonly IDatabaseService _database;

        public GetCustomersListQuery(IDatabaseService database)
        {
            _database = database;
        }


        public List<CustomerModel> Execute()
        {
            var customers = _database.Customers
                .Select(x => new CustomerModel
            {
                Name = x.Name,
                Id = x.Id,
            });
            return customers.ToList();
        }
    }
}
