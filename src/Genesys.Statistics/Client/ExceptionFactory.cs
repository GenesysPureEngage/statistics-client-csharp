/* 
 * Statistics Service
 *
 * Statistics Service
 *
 * OpenAPI spec version: 9.0.000.00.dev
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using System;
using RestSharp;

namespace Genesys.Statistics.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}
