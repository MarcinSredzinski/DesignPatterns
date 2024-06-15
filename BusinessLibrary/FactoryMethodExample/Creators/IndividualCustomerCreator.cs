using BusinessLibrary.FactoryMethodExample.Abstractions;
using BusinessLibrary.FactoryMethodExample.Models;

namespace BusinessLibrary.FactoryMethodExample.Creators;

public class IndividualCustomerCreator : Creator
{
    public override ICustomer FactoryMethod()
    {
        return new IndividualCustomer();
    }
}