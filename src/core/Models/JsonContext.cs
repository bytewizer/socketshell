using System.Text.Json.Serialization;

namespace TinyOS.Core.Models
{
    [JsonSerializable(typeof(DefaultRequest))]
    [JsonSerializable(typeof(EnvironmentGetRequest))]
    [JsonSerializable(typeof(EnvironmentSetRequest))]
    [JsonSerializable(typeof(EnvironmentGetResponse))]
    [JsonSerializable(typeof(ErrorResponse))]
    [JsonSerializable(typeof(Dictionary<string, string>))]
    public partial class JsonContext : JsonSerializerContext
    {
    }
}

// private static readonly Dictionary<string, Tuple<IRequest, IResponse>> CommandTypeList =
// new Dictionary<string, Tuple<IRequest, IResponse>>(StringComparer.CurrentCultureIgnoreCase)
// {
//     {"app.add", new Tuple<IRequest, IResponse> {new Request, new AppAddRequest}}
// }

// app.add
// app.delete
// app.upload

// dev.status
// dev.time.get
// dev.time.set
// dev.wifi
// dev.ethernet

// env
// env.get
// env.set

// srv.status