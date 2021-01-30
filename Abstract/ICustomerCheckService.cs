using InterfaceAbstarctDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstarctDemo.Abstract
{
    public interface ICustomerCheckService
    {
        void CheckIfRealPerson(Customer customer);
    }
}
