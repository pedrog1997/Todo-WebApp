using ListToDos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListToDos.Repositories
{
    public interface IRepository
    {
        void Create(Todo todo);
        List<Todo> Read();
        List<Todo> Read(bool isActive);
        void Update(int id, string title, bool isUrgent, bool isDone);
        void Delete(int id);
    }
}
