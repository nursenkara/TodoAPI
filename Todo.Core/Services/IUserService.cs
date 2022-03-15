using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Todo.Core.Models;

namespace Todo.Core.Services
{
    public interface IUserService:IService<User>
    {
        Task<User> GetWithTodosByIdAsync(int userId);
    }
}
