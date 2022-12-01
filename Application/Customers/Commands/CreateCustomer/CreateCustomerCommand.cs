using Application.Customers.Commands.CreateCustomer.Factory;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand : ICreateCustomerCommand
    {
        private readonly IDatabaseService _database;
        private readonly ICustomerFactory _factory;
        public CreateCustomerCommand(IDatabaseService database
            ,ICustomerFactory factory)
        {
            _database= database;
            _factory= factory;
        }
        public void Execute(CreateCustomerModel model)
        {
            var c = _factory.Create(model);

            _database.Customers.Add(c);
            _database.Save();

        }
    }
}
