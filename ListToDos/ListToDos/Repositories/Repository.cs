using ListToDos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListToDos.Repositories
{
    public class Repository : IRepository
    {
        private TodoContext db;

        public Repository(TodoContext context)
        {
            db = context;
        }

        public void Create(Todo todo)
        {
            db.Todos.Add(todo);
            db.SaveChanges();
        }

        public List<Todo> Read(int id)
        {
            return db.Todos.Where(t => t.User.Id == id).ToList();
        }
        public int ReadWithoutId(string email, string password)
        {
            int userId = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password).Id;
            return userId;
        }

        public void Update(int id, string title, bool isUrgent, bool isDone)
        {
            Todo todo = db.Todos.FirstOrDefault(t => t.Id == id);
            todo.Title = title;
            todo.IsUrgent = isUrgent;
            todo.IsDone = isDone;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Todo todo = db.Todos.FirstOrDefault(t => t.Id == id);
            db.Todos.Remove(todo);
            db.SaveChanges();
        }
    }
}
