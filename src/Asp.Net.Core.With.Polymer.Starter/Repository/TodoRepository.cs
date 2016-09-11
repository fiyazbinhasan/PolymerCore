using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.Net.Core.With.Polymer.Starter.Data;
using Asp.Net.Core.With.Polymer.Starter.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.Net.Core.With.Polymer.Starter.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public IEnumerable<Todo> GetAll()
        {
            return _context.Todos;
        }

        public void Add(Todo item)
        {
            item.Id = Guid.NewGuid().ToString();
            item.DateAdded = DateTime.Now;
            item.IsDone = false;

            _context.Todos.Add(item);
            _context.SaveChanges();
        }

        public Todo Find(string id)
        {
            Todo todo = _context.Todos.AsNoTracking().FirstOrDefault(s => s.Id == id);
            return todo;
        }

        public void Remove(Todo item)
        {
            _context.Todos.Remove(item);
            _context.SaveChanges();
        }

        public void Update(Todo item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
