using InterfaceAbstarctDemo.Abstract;
using InterfaceAbstarctDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstarctDemo.Concrete
{
    public class StarbacksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbacksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            CheckIfRealPerson(customer);
        }
        
    }
}
