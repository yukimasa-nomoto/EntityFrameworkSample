using Application.Customers.Commands.CreateCustomer;
using Microsoft.Extensions.DependencyInjection;
using Presentation;
using Presentation.Customers;
using Presentation.Customers.Models;

namespace Guis
{
    public partial class FormMain : Form
    {
        private ICustomerController? _controller;

        public FormMain()
        {
            InitializeComponent();

            var serviceCollection = Startup.ServiceCollection;
            var serviceProvider = serviceCollection.BuildServiceProvider();

            _controller = serviceProvider.GetService<CustomerController>();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshCustomer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(_controller != null)
            {
                //ç°Ç±ÇÃViewModeoÇÕïsóv
                var m = new CreateCustomerViewModel();
                m.Customers = _controller.Index();
                m.Customer = new CreateCustomerModel()
                {
                    Name = txtUserName.Text,
                };

                _controller.Create(m);
                //çƒï`âÊ
                RefreshCustomer();

            }
        }

        private void RefreshCustomer()
        {
            if (_controller != null)
            {
                var customers = _controller.Index();

                listUsers.Items.Clear();
                foreach (var c in customers)
                {
                    listUsers.Items.Add(c.Name);
                }

            }

        }
    }
}