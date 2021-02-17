using System;
using AbstractAndInterface.Abstract;
using AbstractAndInterface.Conrete;
using AbstractAndInterface.Entity;

namespace AbstractAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager();
            baseCustomerManager.save(new Customer
            {
                DateofBirth = new DateTime(1998,1,6),
                FirstName = "suleyman",
                LastName = "Oz",
                NationalityId = "4564"
            });
        }
    }
}