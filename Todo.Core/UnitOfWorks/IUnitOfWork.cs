using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Todo.Core.Repositories;

namespace Todo.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        ITodoRepository Todos { get; set; }
        IUserRepository Users { get; set; }
        Task CommitAsync();
        void Commit();

    }
}
