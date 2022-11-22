using System;
namespace Books.api
{
	public static class ExceptionHandlerExtentions
	{
        public static IApplicationBuilder UseExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }

        //public static void ConfigureCustomExceptionMiddleware(this WebApplication app)
        //{
        //    app.UseMiddleware<ExceptionMiddleware>();
        //}
    }
}

