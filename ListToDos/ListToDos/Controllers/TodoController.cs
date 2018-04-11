using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ListToDos.Models;
using ListToDos.Repositories;
using ListToDos.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ListToDos.Controllers
{
    [Route("")]
    [Route("todo")]
    public class TodoController : Controller
    {
        private IRepository _repository;

        public TodoController(IRepository repository)
        {
            _repository = repository;
        }

        [Route("")]
        [Route("list")]
        public IActionResult List()
        {
            return View(_repository.Read());
        }
        [Route("list/{isActive}")]
        public IActionResult List(bool isActive)
        {
            return View(_repository.Read(isActive));
        }

        [HttpGet("addTodo")]
        public IActionResult AddTodo()
        {
            return View();
        }
        [HttpPost("addTodo")]
        public IActionResult AddTodo(Todo todo)
        {
            _repository.Create(todo);
            return RedirectToAction("List");
        }

        [Route("delete")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("List");
        }

        [HttpGet("update")]
        public IActionResult Update(int id, string title)
        {
            return View(new UpdateTodo(id, title));
        }
        [HttpPost("update/{id}")]
        public IActionResult Update(int id, string title, bool isUrgent, bool isDone)
        {
            _repository.Update(id, title, isUrgent, isDone);
            return RedirectToAction("List");
        }
    }
}