// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> The NatGateways service client. </summary>
    public partial class NatGatewaysOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal NatGatewaysRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of NatGatewaysOperations for mocking. </summary>
        protected NatGatewaysOperations()
        {
        }
        /// <summary> Initializes a new instance of NatGatewaysOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal NatGatewaysOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new NatGatewaysRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified nat gateway in a specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NatGateway>> GetAsync(string resourceGroupName, string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, natGatewayName, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified nat gateway in a specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NatGateway> Get(string resourceGroupName, string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, natGatewayName, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates nat gateway tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="parameters"> Parameters supplied to update nat gateway tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NatGateway>> UpdateTagsAsync(string resourceGroupName, string natGatewayName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, natGatewayName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates nat gateway tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="parameters"> Parameters supplied to update nat gateway tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NatGateway> UpdateTags(string resourceGroupName, string natGatewayName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, natGatewayName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the Nat Gateways in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<NatGateway> ListAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NatGateway>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NatGateway>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the Nat Gateways in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<NatGateway> ListAll(CancellationToken cancellationToken = default)
        {
            Page<NatGateway> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAll(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NatGateway> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAllNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all nat gateways in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual AsyncPageable<NatGateway> ListAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<NatGateway>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NatGateway>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all nat gateways in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Pageable<NatGateway> List(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<NatGateway> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NatGateway> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified nat gateway. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="natGatewayName"/> is null. </exception>
        public virtual async Task<NatGatewaysDeleteOperation> StartDeleteAsync(string resourceGroupName, string natGatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (natGatewayName == null)
            {
                throw new ArgumentNullException(nameof(natGatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, natGatewayName, cancellationToken).ConfigureAwait(false);
                return new NatGatewaysDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, natGatewayName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified nat gateway. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="natGatewayName"/> is null. </exception>
        public virtual NatGatewaysDeleteOperation StartDelete(string resourceGroupName, string natGatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (natGatewayName == null)
            {
                throw new ArgumentNullException(nameof(natGatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, natGatewayName, cancellationToken);
                return new NatGatewaysDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, natGatewayName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a nat gateway. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update nat gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="natGatewayName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<NatGatewaysCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string natGatewayName, NatGateway parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (natGatewayName == null)
            {
                throw new ArgumentNullException(nameof(natGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, natGatewayName, parameters, cancellationToken).ConfigureAwait(false);
                return new NatGatewaysCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, natGatewayName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a nat gateway. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update nat gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="natGatewayName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual NatGatewaysCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string natGatewayName, NatGateway parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (natGatewayName == null)
            {
                throw new ArgumentNullException(nameof(natGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NatGatewaysOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, natGatewayName, parameters, cancellationToken);
                return new NatGatewaysCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, natGatewayName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
