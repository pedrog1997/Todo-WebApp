using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListToDos.ViewModel
{
    public class UpdateTodo
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public UpdateTodo(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
