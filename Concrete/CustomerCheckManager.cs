using InterfaceAbstarctDemo.Abstract;
using InterfaceAbstarctDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstarctDemo.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public void CheckIfRealPerson(Customer customer)
        {
            Console.WriteLine("True");
        }
    }
}
