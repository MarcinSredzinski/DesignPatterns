namespace BusinessLibrary.FactoryMethodExample.Abstractions;

public abstract class Creator
{
    /// <summary>
    /// The factory method. The concrete creator will override this method to instantiane a concrete product. 
    /// This method can also have a default implementation returning a default concrete product.
    /// </summary>
    /// <returns></returns>
    public abstract ICustomer FactoryMethod(); 
}