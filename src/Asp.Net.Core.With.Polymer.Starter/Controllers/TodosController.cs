using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp.Net.Core.With.Polymer.Starter.Models;
using Asp.Net.Core.With.Polymer.Starter.Repository;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Asp.Net.Core.With.Polymer.Starter.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        public TodoController(ITodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }
        public ITodoRepository TodoRepository { get; set; }

        public IEnumerable<Todo> GetAll()
        {
            return TodoRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(string id)
        {
            var item = TodoRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Todo item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            TodoRepository.Add(item);
            return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] Todo item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var todo = TodoRepository.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            TodoRepository.Update(item);
            return new NoContentResult();
        }

        [HttpPatch("{id}")]
        public IActionResult Update([FromBody] Todo item, string id)
        {
            if (item == null)
            {
                return BadRequest();
            }

            var todo = TodoRepository.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            item.Id = todo.Id;

            TodoRepository.Update(item);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var todo = TodoRepository.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            TodoRepository.Remove(todo);
            return new NoContentResult();
        }
    }
}
