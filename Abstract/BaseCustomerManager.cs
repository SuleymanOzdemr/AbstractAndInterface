using System;
using AbstractAndInterface.Entity;

namespace AbstractAndInterface.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void save(Customer customer)
        {
            //virtual dediğimizde save yi ezebiliriz anlamina gelir.
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}