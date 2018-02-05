using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace hosting
{
    public class MyMiddleware 
    {
        private RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {   
            var start = DateTime.Now;

            await _next(context);

            var end = DateTime.Now;
            var diff = end.Subtract(start);
            await context.Response.WriteAsync($" The time was {diff.Milliseconds}");
        }
    }
}