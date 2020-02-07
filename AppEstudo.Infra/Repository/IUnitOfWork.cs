using System;
using System.Collections.Generic;
using System.Text;
using AppEstudo.Domain.Models;

namespace AppEstudo.Infra.Repository
{
    public interface IUnitOfWork
    {
        IRepository<User> UserRepository { get; }
        IRepository<Ticket> TicketRepository { get; }
        void Commit();
    }
}
