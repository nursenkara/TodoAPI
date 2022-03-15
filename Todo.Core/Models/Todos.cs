﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Core.Models
{
    public class Todos
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public Boolean IsDone { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
