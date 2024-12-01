namespace MinimalApis.Features.ExternalServices.WarehouseApi.HttpClient;

public interface IHttpClientWrapper
{
    Task<HttpResponseMessage> GetAsync(string requestUri);
    Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content);
}