using BusinessLibrary.Repositories;
using DesignPatternsWeb.Repositories;

namespace DesignPatternsWeb.DB;

public class CustomersUnitOfWork(InMemeoryDBContext inMemeoryDBContext) : IDisposable
{
    private ICustomersRepository? _customersRepository;

    public ICustomersRepository CustomersRepository
    {
        get
        {
            if (_customersRepository == null)
            {
                _customersRepository = new CustomersRepository(inMemeoryDBContext);
            }
            return _customersRepository;
        }
    }

    private IOrdersRepository? _ordersRepository;

    public IOrdersRepository OrdersRepository
    {
        get
        {
            if (_ordersRepository == null)
            {
                _ordersRepository = new OrdersRepository(inMemeoryDBContext);
            }
            return _ordersRepository;
        }
    }

    public void Save()
    {
        inMemeoryDBContext.SaveChanges();
    }

    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                inMemeoryDBContext.Dispose();
            }
        }
        this.disposed = true;
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
