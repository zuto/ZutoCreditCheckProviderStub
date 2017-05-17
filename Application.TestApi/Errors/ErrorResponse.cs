using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nancy;
using Nancy.ErrorHandling;
using Nancy.Responses;

namespace Application.TestApi.Errors
{
    public class ErrorResponse : TextResponse
    {
        public string Message { get; set; }

        public ErrorResponse(string message)
        {
            Message = message;
        }

        public static Response FromMessage(string message)
        {
            return new ErrorResponse(message);
        }

        public string ErrorMessage { get; set; }

        public string FullException { get; set; }

        public static Response FromException(Exception exception)
        {
            return new ErrorResponse(exception.Message)
            {
                StatusCode = HttpStatusCode.InternalServerError,
                FullException = exception.ToString()
            };
        }
    }
    public sealed class ErrorStatusCodeHandler : IStatusCodeHandler
    {
        public bool HandlesStatusCode(HttpStatusCode statusCode, NancyContext context)
        {
            return statusCode == HttpStatusCode.NotFound
                || statusCode == HttpStatusCode.InternalServerError
                || statusCode == HttpStatusCode.Forbidden
                || statusCode == HttpStatusCode.Unauthorized;
        }

        public void Handle(HttpStatusCode statusCode, NancyContext context)
        {
            var error = context.Response as ErrorResponse;
            switch (statusCode)
            {
                case HttpStatusCode.Unauthorized:
                    //context.Response = new RedirectResponse(WebRoutes.Web.Accounts.Login());
                    break;
                case HttpStatusCode.Forbidden:
                    context.Response = new ErrorHtmlPageResponse(statusCode)
                    {
                        Title = "Permission",
                        ErrorMessage = error == null ? "Sorry, you do not have permission to perform that action. Please contact your Octopus administrator." : error.ErrorMessage,
                        FullException = error == null ? "There is no full exception to show." : error.FullException
                    };
                    break;
                case HttpStatusCode.NotFound:
                    context.Response = new ErrorHtmlPageResponse(statusCode)
                    {
                        Title = "404 Not found",
                        ErrorMessage = "Sorry, the resource you requested was not found.",
                        FullException = error == null ? "There is no full exception to show." : error.FullException
                    };
                    break;
                case HttpStatusCode.InternalServerError:
                    context.Response = new ErrorHtmlPageResponse(statusCode)
                    {
                        Title = "Sorry, something went wrong",
                        ErrorMessage = error == null ? "An unexpected error occurred." : error.ErrorMessage,
                        FullException = error == null ? "There is no full exception to show." : error.FullException
                    };
                    break;
            }
        }
    }
    public class ErrorHtmlPageResponse : HtmlResponse
    {
        static readonly string ErrorTemplate;

        static ErrorHtmlPageResponse()
        {
            ErrorTemplate = "<html><head><title>{{ErrorSummary}}</title></head><body></body><h1>{{ErrorSummary}}</h1>{{ErrorDetails}}</html>";
        }

        public ErrorHtmlPageResponse(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
            ContentType = "text/html; charset=utf-8";
            Contents = Render;
        }

        public string Title { get; set; }
        public string ErrorMessage { get; set; }
        public string FullException { get; set; }

        void Render(Stream stream)
        {
            var formatArguments = GetErrorPageDetails();
            var page = formatArguments.Aggregate(ErrorTemplate, (current, argument) => current.Replace(argument.Key, argument.Value));

            using (var writer = new StreamWriter(stream))
            {
                writer.WriteLine(page);
                writer.Flush();
            }
        }

        Dictionary<string, string> GetErrorPageDetails()
        {
            var parameters = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            parameters["{{ErrorTitle}}"] = Title;
            parameters["{{ErrorSummary}}"] = ErrorMessage;
            if (!string.IsNullOrWhiteSpace(FullException))
            {
                parameters["{{ErrorDetails}}"] = "<h3>Details</h3><pre>" + FullException + "</pre>";
            }
            return parameters;
        }
    }
}