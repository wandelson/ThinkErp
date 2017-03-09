using Think.Erp.Api.Data.Contexts;

namespace Think.Erp.Api.Data.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Rollback()
        {
            // Do Nothing
        }
    }
}