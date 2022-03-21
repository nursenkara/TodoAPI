using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Todo.Core.Models;
using Todo.Core.Repositories;

namespace Todo.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public UserRepository(AppDbContext context): base(context)
        {

        }
        public async Task<User> GetWithTodoByIdAsync(int userId)
        {
            return await _appDbContext.Users.Include(x => x.Todos).SingleOrDefaultAsync(x => x.Id == userId);
        }
    }
}
