using System;
using AppEstudo.Domain.Models;
using AppEstudo.Infra.Context;

namespace AppEstudo.Infra.Repository
{
    public class UnitOfwork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext _context;
        private IRepository<User> _userRepository;

        private IRepository<Ticket> _ticketRepository;

        public UnitOfwork(AppDbContext context)
        {
            _context = context;
        }

        public IRepository<User> UserRepository { get { return _userRepository = new Repository<User>(_context); } }
        public IRepository<Ticket> TicketRepository { get { return _ticketRepository = new Repository<Ticket>(_context); } }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
