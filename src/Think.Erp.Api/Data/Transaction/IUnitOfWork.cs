namespace Think.Erp.Api.Data.Transaction
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}