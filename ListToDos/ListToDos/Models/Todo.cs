using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListToDos.Models
{
    public class Todo
    {
        private long _id;
        private string _title;
        private bool _isUrgent = false;
        private bool _isDone = false;

        public long Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public bool IsUrgent
        {
            get
            {
                return _isUrgent;
            }
            set
            {
                _isUrgent = value;
            }
        }
        public bool IsDone
        {
            get
            {
                return _isDone;
            }
            set
            {
                _isDone = value;
            }
        }

        public Todo() { }
        public Todo(string title)
        {
            _title = title;
        }
        public Todo(string title, bool isUrgent)
        {
            _title = title;
            _isUrgent = isUrgent;
        }
    }
}
