using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Todo.Core.Models;
using Todo.Core.Repositories;

namespace Todo.Data.Repositories
{
    public class TodoRepository : Repository<Todos>, ITodoRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public TodoRepository(AppDbContext context):base(context)
        {

        }
        public async Task<Todos> GetWithUserByIdAsync(int todoId)
        {
            return await _appDbContext.Todos.Include(x => x.User).SingleOrDefaultAsync(x => x.Id == todoId);
        }
    }
}
