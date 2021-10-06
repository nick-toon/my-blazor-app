using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp.Client
{
    public class TodoItem // holds a class that represents a todo item
    {
        public string Title { get; set; } 
        public bool IsDone { get; set; }
    }
}