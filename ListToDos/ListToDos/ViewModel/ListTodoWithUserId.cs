using ListToDos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListToDos.ViewModel
{
    public class ListTodoWithUserId
    {
        public List<Todo> Todos { get; set; }
        public int UserId { get; set; }

        public ListTodoWithUserId(List<Todo> listOfTodos, int userId)
        {
            Todos = listOfTodos;
            UserId = userId;
        }
    }
}
