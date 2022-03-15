using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Todo.Core.Models;

namespace Todo.Core.Repositories
{
    public interface IUserRepository:IRepository<User>
    {
        Task<User> GetWithTodoByIdAsync(int userId);
    }
}
