using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Todo.Core.Models
{
    public class User
    {
        public User()
        {
            Todos = new Collection<Todos>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Todos> Todos { get; set; }
    }
}
