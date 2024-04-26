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
namespace Autodesk.ModelDerivative.Designdata.Item.References {
    /// <summary>
    /// Builds and executes requests for operations under \designdata\{urn}\references
    /// </summary>
    public class ReferencesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="ReferencesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReferencesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/designdata/{urn}/references", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ReferencesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReferencesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/designdata/{urn}/references", rawUrl)
        {
        }
        /// <summary>
        /// To create references for a composite design in Model Derivative. The description of references is stored in Model Derivative. To use it with the POST job endpoint, you need to set checkReferences to true.
        /// </summary>
        /// <returns>A <see cref="ReferencesPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="References400Error">When receiving a 400 status code</exception>
        /// <exception cref="References401Error">When receiving a 401 status code</exception>
        /// <exception cref="References403Error">When receiving a 403 status code</exception>
        /// <exception cref="References404Error">When receiving a 404 status code</exception>
        /// <exception cref="References500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ReferencesPostResponse?> PostAsReferencesPostResponseAsync(ReferencesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ReferencesPostResponse> PostAsReferencesPostResponseAsync(ReferencesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", References400Error.CreateFromDiscriminatorValue},
                {"401", References401Error.CreateFromDiscriminatorValue},
                {"403", References403Error.CreateFromDiscriminatorValue},
                {"404", References404Error.CreateFromDiscriminatorValue},
                {"500", References500Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ReferencesPostResponse>(requestInfo, ReferencesPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To create references for a composite design in Model Derivative. The description of references is stored in Model Derivative. To use it with the POST job endpoint, you need to set checkReferences to true.
        /// </summary>
        /// <returns>A <see cref="ReferencesResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="References400Error">When receiving a 400 status code</exception>
        /// <exception cref="References401Error">When receiving a 401 status code</exception>
        /// <exception cref="References403Error">When receiving a 403 status code</exception>
        /// <exception cref="References404Error">When receiving a 404 status code</exception>
        /// <exception cref="References500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsReferencesPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ReferencesResponse?> PostAsync(ReferencesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ReferencesResponse> PostAsync(ReferencesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", References400Error.CreateFromDiscriminatorValue},
                {"401", References401Error.CreateFromDiscriminatorValue},
                {"403", References403Error.CreateFromDiscriminatorValue},
                {"404", References404Error.CreateFromDiscriminatorValue},
                {"500", References500Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ReferencesResponse>(requestInfo, ReferencesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To create references for a composite design in Model Derivative. The description of references is stored in Model Derivative. To use it with the POST job endpoint, you need to set checkReferences to true.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ReferencesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ReferencesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ReferencesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ReferencesRequestBuilder WithUrl(string rawUrl)
        {
            return new ReferencesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ReferencesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
