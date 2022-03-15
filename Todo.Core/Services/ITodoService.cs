using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Todo.Core.Models;

namespace Todo.Core.Services
{
    public interface ITodoService:IService<Todos>
    {
        Task<Todos> GetWithUserByIdAsync(int todoId);
    }
}
