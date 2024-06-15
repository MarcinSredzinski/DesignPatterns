using BusinessLibrary.FactoryMethodExample.Abstractions;
using BusinessLibrary.FactoryMethodExample.Models;

namespace BusinessLibrary.FactoryMethodExample.Creators;

public class EnterpriseCustomerCreator : Creator
{
    public override ICustomer FactoryMethod()
    {
        return new EnterpriseCustomer();
    }
}
