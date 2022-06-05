using System.Net;

namespace Relex.BrandReputation.WebApi.Middlewares
{
    public class FluentValidationExceptionHandler
    {
        public FluentValidationExceptionHandler(RequestDelegate next)
        {
            Next = next;
        }

        private RequestDelegate Next { get; }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {

                await Next(httpContext);
            }
            catch (FluentValidation.ValidationException ex)
            {
                // TODO : LogError($" ValidationException : {ex}");
                await HandleValidationExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleValidationExceptionAsync(HttpContext httpContext, FluentValidation.ValidationException ex)
        {
            httpContext.Response.ContentType = "application/problem+json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;

            var problem = new FluentValidationProblemDetails(ex, httpContext);

            await httpContext.Response.WriteAsync(System.Text.Json.JsonSerializer.Serialize(problem));
        }
    }

    public static class FluentValidationExceptionHandlerExtensions
    {
        public static void ConfigureFluentValidationExceptionHandler(this WebApplication app)
        {
            app.UseMiddleware<FluentValidationExceptionHandler>();
        }
    }
}
