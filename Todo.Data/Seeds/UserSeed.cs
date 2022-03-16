using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Core.Models;

namespace Todo.Data.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        private readonly int[] _ids;
        public UserSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = _ids[0], FirstName = "Ahmet", LastName = "Yılmaz" },
                new User { Id = _ids[1], FirstName = "Ayşe", LastName = "Yılmaz" },
                new User { Id = _ids[2], FirstName = "Mehmet", LastName = "Yılmaz" }
                );
        }
    }
}
