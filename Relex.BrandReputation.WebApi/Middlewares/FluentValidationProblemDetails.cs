using System.Net;

namespace Relex.BrandReputation.WebApi.Middlewares
{
    public class FluentValidationProblemDetails : HttpValidationProblemDetails
    {
        public FluentValidationProblemDetails(FluentValidation.ValidationException ex, HttpContext httpContext)
            : base(ex.Errors.GroupBy(i => i.PropertyName).ToDictionary(i => i.Key, i => i.Select(v => v.ErrorMessage).ToArray()))
        {
            Type = "https://BrandReputation.com/modelvalidationproblem";
            Title = "Validation failed";
            Instance = httpContext.Request.Path;
            Detail = "Please check the property details.";
            Status = (int)HttpStatusCode.UnprocessableEntity;

            this.Extensions.Add("traceId", httpContext.TraceIdentifier);

        }
    }
}
