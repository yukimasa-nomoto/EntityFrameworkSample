using Presentation.Customers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Customers.Services
{
    public interface ICreateCustomerViewModelFactory
    {
        CreateCustomerViewModel Create();
    }
}
