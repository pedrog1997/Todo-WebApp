using ListToDos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ListToDos
{
    public class TodoContext : DbContext
    {
        public List<Todo> initialTodos = new List<Todo>
        {
            new Todo("Start the day"),
            new Todo("Finish H2 workshop 1"),
            new Todo("Finish JPA workshop 2"),
            new Todo("Cread a CRUD project")
        };

        public DbSet<Todo> Todos { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {       
        }
    }
}
