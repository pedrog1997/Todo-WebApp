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
    [Route("todo")]
    public class TodoController : Controller
    {
        private IRepository repository;

        public TodoController(IRepository repository)
        {
            this.repository = repository;
        }

        [Route("")]
        [Route("list")]
        public IActionResult List(int userId)
        {
            return View(repository.Read(userId));
        }

        [Route("getUserId")]
        public IActionResult GetUserId(string email, string password)
        {
            int userId = repository.ReadWithoutId(email, password);
            return RedirectToAction("List", new {  userId });
        }

        [HttpGet("addTodo")]
        public IActionResult AddTodo()
        {
            return View();
        }
        [HttpPost("addTodo")]
        public IActionResult AddTodo(Todo todo)
        {
            repository.Create(todo);
            return RedirectToAction("List");
        }

        [Route("delete")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
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
            repository.Update(id, title, isUrgent, isDone);
            return RedirectToAction("List");
        }
    }
}