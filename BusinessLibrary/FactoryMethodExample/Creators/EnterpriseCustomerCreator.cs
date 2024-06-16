using BusinessLibrary.FactoryMethodExample.Abstractions;
using BusinessLibrary.FactoryMethodExample.Models;

namespace BusinessLibrary.FactoryMethodExample.Creators;

/// <summary>
/// Concrete implementation of Creator. Overrides a factory method to return a concrete product. 
/// </summary>
public class EnterpriseCustomerCreator : Creator
{    
    public override ICustomer FactoryMethod()
    {
        return new EnterpriseCustomer();
    }
}
