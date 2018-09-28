using CoreMVCDemo2.Data;
using System;

namespace CoreMVCDemo2.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private StudentDbContext _context;

        public UnitOfWork(StudentDbContext context)
        {
            _context = context;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if(_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}
