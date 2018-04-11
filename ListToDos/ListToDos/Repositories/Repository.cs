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
        private TodoContext _db;

        public Repository(TodoContext context)
        {
            _db = context;
        }

        public void Create(Todo todo)
        {
            _db.Todos.Add(todo);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            Todo todo = _db.Todos.FirstOrDefault(t => t.Id == id);
            _db.Todos.Remove(todo);
            _db.SaveChanges();
        }

        public List<Todo> Read()
        {
            return _db.Todos.ToList();
        }
        public List<Todo> Read(bool isActive)
        {
            return _db.Todos.Where(t => t.IsDone != isActive).ToList();
        }

        public void Update(int id, string title, bool isUrgent, bool isDone)
        {
            Todo todo = _db.Todos.FirstOrDefault(t => t.Id == id);
            todo.Title = title;
            todo.IsUrgent = isUrgent;
            todo.IsDone = isDone;
            _db.SaveChanges();
        }
    }
}
