using Events.Domain.Interfaces;
using Events.Infra.Data.Context;

namespace Events.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EventContext _context;

        public UnitOfWork(EventContext context)
        {
            _context = context;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
