using System.Net.Http;
using System.Text.Json;

namespace Soenneker.Monday.GraphQlClient;

public sealed partial class MondayGraphQlClient
{
    /// <summary>
    /// Creates a Monday GraphQL client using the specified HTTP connection.
    /// </summary>
    /// <param name="httpClient">The configured HTTP client.</param>
    /// <param name="serializerOptions">Optional JSON serializer options.</param>
    public MondayGraphQlClient(HttpClient httpClient, JsonSerializerOptions? serializerOptions = null)
        : this(new GraphQlHttpClient(httpClient, serializerOptions))
    {
    }
}
