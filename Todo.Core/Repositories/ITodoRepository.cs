using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Todo.Core.Models;

namespace Todo.Core.Repositories
{
    public interface ITodoRepository:IRepository<Todos>
    {
        Task<Todos> GetWithUserByIdAsync(int todoId);
    }
}
