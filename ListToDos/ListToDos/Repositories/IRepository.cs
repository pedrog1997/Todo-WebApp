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
        void Create(Todo todo, int userId);

        List<Todo> Read(int id);
        int ReadWithoutId(string email, string password);

        void Update(int id, string title, bool isUrgent, bool isDone);

        void Delete(int id);
    }
}
