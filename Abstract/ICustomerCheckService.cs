using AbstractAndInterface.Entity;

namespace AbstractAndInterface.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}