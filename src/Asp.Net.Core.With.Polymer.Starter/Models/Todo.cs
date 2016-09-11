using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net.Core.With.Polymer.Starter.Models
{
    public class Todo
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public bool IsDone { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
