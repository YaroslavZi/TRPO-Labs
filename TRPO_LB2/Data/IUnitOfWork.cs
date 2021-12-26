namespace TRPO_LB2.Data
{
    interface IUnitOfWork
    {
        IRepository Repository { get; }

        void SaveChanges();
    }
}