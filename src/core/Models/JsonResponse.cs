using System.Text.Json;

namespace TinyOS.Core.Models;

public static class JsonResponse
{    
    public static string Ok()
    {
        return "{}";
    }

    public static string Ok<TResponse>(object value)
        where TResponse : IResponse
    {
        try
        {
            return JsonSerializer.Serialize(value, typeof(TResponse),  JsonContext.Default);
        }
        catch
        {
            return """{err":"critical error}""";
        }
    }

    public static string Error(string text)
    {
        var response = new ErrorResponse() 
        {
            Err = text
        };
        
        return Ok<ErrorResponse>(response);
    }
}