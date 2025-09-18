// <copyright file="IConfiguration.cs" company="APIMatic">
// APIMATICCalculator.Standard
//
// This file was automatically generated for dgfgfdg by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Net;
using APIMATICCalculator.Standard.Models;

namespace APIMATICCalculator.Standard
{
    /// <summary>
    /// IConfiguration.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets Current API environment.
        /// </summary>
        Environment Environment { get; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:CALCULATOR.</param>
        /// <returns>Returns the baseurl.</returns>
        string GetBaseUri(Server alias = Server.Calculator);
    }
}