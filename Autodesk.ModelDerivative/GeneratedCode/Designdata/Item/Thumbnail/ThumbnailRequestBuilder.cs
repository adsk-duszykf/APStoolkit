// <auto-generated/>
using Autodesk.ModelDerivative.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ModelDerivative.Designdata.Item.Thumbnail {
    /// <summary>
    /// Builds and executes requests for operations under \designdata\{urn}\thumbnail
    /// </summary>
    public class ThumbnailRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="ThumbnailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThumbnailRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/designdata/{urn}/thumbnail{?height*,width*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ThumbnailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThumbnailRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/designdata/{urn}/thumbnail{?height*,width*}", rawUrl)
        {
        }
        /// <summary>
        /// Downloads the thumbnail for the source file.
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Thumbnail400Error">When receiving a 400 status code</exception>
        /// <exception cref="Thumbnail401Error">When receiving a 401 status code</exception>
        /// <exception cref="Thumbnail403Error">When receiving a 403 status code</exception>
        /// <exception cref="Thumbnail404Error">When receiving a 404 status code</exception>
        /// <exception cref="Thumbnail500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<string?> GetAsync(Action<RequestConfiguration<ThumbnailRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<string> GetAsync(Action<RequestConfiguration<ThumbnailRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", Thumbnail400Error.CreateFromDiscriminatorValue},
                {"401", Thumbnail401Error.CreateFromDiscriminatorValue},
                {"403", Thumbnail403Error.CreateFromDiscriminatorValue},
                {"404", Thumbnail404Error.CreateFromDiscriminatorValue},
                {"500", Thumbnail500Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<string>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Downloads the thumbnail for the source file.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ThumbnailRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ThumbnailRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ThumbnailRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ThumbnailRequestBuilder WithUrl(string rawUrl)
        {
            return new ThumbnailRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Downloads the thumbnail for the source file.
        /// </summary>
        public class ThumbnailRequestBuilderGetQueryParameters 
        {
            /// <summary>Height of thumbnail  Possible values: 100, 200, 400  If height is omitted, but width is specified, the implicit value for height will match width.  If both width and height are omitted, the server will return a thumbnail closest to a width of 200, if available.</summary>
            [QueryParameter("height")]
            public int? Height { get; set; }
            /// <summary>Width of thumbnail  Possible values: 100, 200, 400  If width is omitted, but height is specified, the implicit value for width will match height.  If both width and height are omitted, the server will return a thumbnail closest to a width of 200, if available.</summary>
            [QueryParameter("width")]
            public int? Width { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ThumbnailRequestBuilderGetRequestConfiguration : RequestConfiguration<ThumbnailRequestBuilderGetQueryParameters> 
        {
        }
    }
}
