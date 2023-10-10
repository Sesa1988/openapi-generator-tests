/*
 * DotAAS Part 2 | HTTP/REST | Asset Administration Shell Repository Service Specification
 *
 * The Full Profile of the Asset Administration Shell Repository Service Specification as part of the [Specification of the Asset Administration Shell: Part 2](http://industrialdigitaltwin.org/en/content-hub).   Publisher: Industrial Digital Twin Association (IDTA) April 2023
 *
 * OpenAPI spec version: V3.0.1_SSP-001
 * Contact: info@idtwin.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SerializationAPIApiController : ControllerBase
    { 
        /// <summary>
        /// Returns an appropriate serialization based on the specified format (see SerializationFormat)
        /// </summary>
        /// <param name="aasIds">The Asset Administration Shells&#x27; unique ids (UTF8-BASE64-URL-encoded)</param>
        /// <param name="submodelIds">The Submodels&#x27; unique ids (UTF8-BASE64-URL-encoded)</param>
        /// <param name="includeConceptDescriptions">Include Concept Descriptions?</param>
        /// <response code="200">Requested serialization based on SerializationFormat</response>
        /// <response code="400">Bad Request, e.g. the request parameters of the format of the request body is wrong.</response>
        /// <response code="401">Unauthorized, e.g. the server refused the authorization attempt.</response>
        /// <response code="403">Forbidden</response>
        /// <response code="500">Internal Server Error</response>
        /// <response code="0">Default error handling for unmentioned status codes</response>
        [HttpGet]
        [Route("/serialization")]
        [ValidateModelState]
        [SwaggerOperation("GenerateSerializationByIds")]
        [SwaggerResponse(statusCode: 200, type: typeof(byte[]), description: "Requested serialization based on SerializationFormat")]
        [SwaggerResponse(statusCode: 400, type: typeof(Result), description: "Bad Request, e.g. the request parameters of the format of the request body is wrong.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Result), description: "Unauthorized, e.g. the server refused the authorization attempt.")]
        [SwaggerResponse(statusCode: 403, type: typeof(Result), description: "Forbidden")]
        [SwaggerResponse(statusCode: 500, type: typeof(Result), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 0, type: typeof(Result), description: "Default error handling for unmentioned status codes")]
        public virtual IActionResult GenerateSerializationByIds([FromQuery]List<string> aasIds, [FromQuery]List<string> submodelIds, [FromQuery]bool? includeConceptDescriptions)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(byte[]));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Result));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Result));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Result));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Result));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Result));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<byte[]>(exampleJson)
                        : default(byte[]);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}