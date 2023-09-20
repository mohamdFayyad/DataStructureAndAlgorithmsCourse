using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Task
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Task(int id, string text)
        {
            Id = id;
            Text = text;
        }
    }
    
    internal class Node
    {
        public Task Task { get; set; }
        public Node? NextNode { get; set; }
        public Node(Task task)
        {
            Task = task;
            NextNode = null;
        }
    }
}
