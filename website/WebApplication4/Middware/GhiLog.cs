using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace WebApplication4.Middleware
{
    public class GhiLog
    {
        private readonly RequestDelegate _next;

        public GhiLog(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"---> Request đến: {context.Request.Method} {context.Request.Path}");
            await _next(context);
            Console.WriteLine($"<--- Phản hồi: {context.Request.Method} {context.Request.Path} | Status: {context.Response.StatusCode}");
        }
    }
}

