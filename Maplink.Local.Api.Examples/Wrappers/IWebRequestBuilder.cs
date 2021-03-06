using System.Net;
using System.Text;

namespace Maplink.Local.Api.Examples.Wrappers
{
    public interface IWebRequestBuilder
    {
        IWebRequestBuilder For(string uri);
        IWebRequestBuilder WithHttpMethod(string method);
        IWebRequestBuilder InsertHeader(string name, string value);
        IWebRequestBuilder WithContentType(string contentType);
        HttpWebRequest Build();
        IWebRequestBuilder WithBody(string body, Encoding encoding);
    }
}