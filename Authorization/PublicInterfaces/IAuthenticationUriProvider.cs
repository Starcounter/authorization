﻿using System.Web;
using Starcounter.Startup.Routing.Middleware;

namespace Starcounter.Authorization
{
    /// <summary>
    /// Provides various URIs and URI templates for handlers related to authentication and its blending.
    /// </summary>
    public interface IAuthenticationUriProvider
    {
        /// <summary>
        /// URI template for the handler that will blend with sign-in page
        /// </summary>
        string UnauthenticatedUriTemplate { get; }

        /// <summary>
        /// URI for the sign-out handler
        /// </summary>
        string SignOutUriTemplate { get; }

        /// <summary>
        /// The URI under which the HTML file with view for <see cref="UnauthenticatedUriTemplate"/> will be registered
        /// </summary>
        string UnauthenticatedViewUri { get; }

        /// <summary>
        /// The URI under which the HTML file with 404 error message will be registered
        /// </summary>
        string UnauthorizedViewUri { get; }

        /// <summary>
        /// The URI under which the HTML file with redirection will be registered
        /// </summary>
        string RedirectionViewUri { get; }

        /// <summary>
        /// URI template for the handler of <see cref="CreateSetTokenUri"/>
        /// </summary>
        string SetTokenUriTemplate { get; }

        /// <summary>
        /// Returns a URI to which the application should redirect the user after successful sign-in, or whenever there is a need
        /// to regenerate the authentication cookie
        /// </summary>
        /// <param name="destinationUri">The original URI that the user wished to access, relative to the application root.
        ///  The user will be redirected there after the cookie is set</param>
        /// <returns>A URI, relative to the application root</returns>
        string CreateSetTokenUri(string destinationUri);

        /// <summary>
        /// Returns a URI to which the application should redirect to sign out the user
        /// </summary>
        /// <param name="destinationUri">The user will be redirected there after sign-out</param>
        /// <returns>A URI, relative to the application root</returns>
        string CreateSignOutUri(string destinationUri);
    }
}