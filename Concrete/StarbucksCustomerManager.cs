using System;
using AbstractAndInterface.Abstract;
using AbstractAndInterface.Entity;

namespace AbstractAndInterface.Conrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.save(customer);
            }
            else
            {
                throw new Exception("Not a valid Person");
            }
        }


       
    }
}