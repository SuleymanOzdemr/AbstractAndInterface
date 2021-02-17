using AbstractAndInterface.Abstract;
using AbstractAndInterface.Entity;

namespace AbstractAndInterface.Conrete
{
    public class CustomerCheckManager:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}