using Application.Customers.Commands.CreateCustomer;
using Application.Customers.Commands.CreateCustomer.Factory;
using Application.Customers.Queries.GetCustomerList;
using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using Presentation.Customers;
using Presentation.Customers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public static class Startup
    {
        public static IServiceCollection ServiceCollection { get; } = new ServiceCollection();
        public static void Run()
        {
#if DEBUG
            setupDebug();
#else
            setupRelease();
#endif

        }

        private static void setupRelease()
        {

        }

        private static void setupDebug()
        {
            ServiceCollection.AddTransient<ICreateCustomerViewModelFactory, CreateCustomerViewModelFactory>();
            ServiceCollection.AddTransient<ICustomerFactory, CustomerFactory>();
            ServiceCollection.AddTransient<IDatabaseService, DatabaseService>();
            ServiceCollection.AddTransient<IGetCustomersListQuery, GetCustomersListQuery>();
            ServiceCollection.AddTransient<ICreateCustomerCommand, CreateCustomerCommand>();

            ServiceCollection.AddTransient<CustomerController>();
        }

    }
}
