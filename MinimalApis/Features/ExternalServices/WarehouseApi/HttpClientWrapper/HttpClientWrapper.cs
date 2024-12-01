namespace MinimalApis.Features.ExternalServices.WarehouseApi.HttpClient;

public class HttpClientWrapper(System.Net.Http.HttpClient httpClient) : IHttpClientWrapper
{
    public Task<HttpResponseMessage> GetAsync(string requestUri) =>
        httpClient.GetAsync(requestUri);

    public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content) =>
        httpClient.PostAsync(requestUri, content);
}