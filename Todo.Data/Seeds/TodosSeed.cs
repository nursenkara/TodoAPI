using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Core.Models;

namespace Todo.Data.Seeds
{
    public class TodosSeed : IEntityTypeConfiguration<Todos>
    {
        private readonly int[] _ids;
        public TodosSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Todos> builder)
        {
            builder.HasData(
                new Todos { Id = _ids[0], Title="Un al", Date = DateTime.Now, UserId = _ids[0]},
                new Todos { Id= _ids[1], Title="Yoğurt al", Date = DateTime.Now,UserId=_ids[1]},
                new Todos { Id = _ids[2],Title="Süt al", Date = DateTime.Now,UserId= _ids[2]}
                );
        }
    }
}
