using System;

namespace CoreMVCDemo2.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}
