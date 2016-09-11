using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.Net.Core.With.Polymer.Starter.Models;

namespace Asp.Net.Core.With.Polymer.Starter.Repository
{
    public interface ITodoRepository
    {
        void Add(Todo item);
        IEnumerable<Todo> GetAll();
        Todo Find(string key);
        void Remove(Todo item);
        void Update(Todo item);
    }
}
