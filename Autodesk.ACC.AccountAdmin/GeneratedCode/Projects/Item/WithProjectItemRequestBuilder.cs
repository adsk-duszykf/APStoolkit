// <auto-generated/>
using Autodesk.ACC.AccountAdmin.Projects.Item.Companies;
using Autodesk.ACC.AccountAdmin.Projects.Item.Users;
using Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.AccountAdmin.Projects.Item {
    /// <summary>
    /// Builds and executes requests for operations under \projects\{projectId}
    /// </summary>
    public class WithProjectItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The companies property</summary>
        public CompaniesRequestBuilder Companies { get =>
            new CompaniesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The users property</summary>
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The usersImport property</summary>
        public UsersImportRequestBuilder UsersImport { get =>
            new UsersImportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithProjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithProjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{projectId}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithProjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithProjectItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{projectId}", rawUrl) {
        }
    }
}
