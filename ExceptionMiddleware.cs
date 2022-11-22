using System;
using System.Net;
using Books.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Books.api
{
	public class ExceptionMiddleware
	{
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
		{
			this._next = next;

		}

		public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (OrderException ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status404NotFound;
            await context.Response.WriteAsync(new ErrorDetails()
            {
                StatusCode = context.Response.StatusCode,
                Message = exception.Message
            }.ToString()) ;
        }
	}
}

