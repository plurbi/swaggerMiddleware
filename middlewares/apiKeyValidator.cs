using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

public class ApiKeyMiddleware {
    private readonly RequestDelegate _next;

    public ApiKeyMiddleware(RequestDelegate next){
        _next = next;
    }

    public Task Invoke (HttpContext httpContext){
        return _next(httpContext);   
    }
}