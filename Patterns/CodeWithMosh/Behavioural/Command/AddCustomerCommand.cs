using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Command
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService customerService { get; }
        public AddCustomerCommand(CustomerService customerService)
        {
            this.customerService = customerService;
        }

     

        public void Execute()
        {
            customerService.CustomerAdd();
        }
    }
}
