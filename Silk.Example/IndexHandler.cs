﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Silk.Core;
using Silk.Core.Attributes;

namespace Silk.Example
{
    [Route("/")]
    public class IndexHandler : IHttpRequestHandler
    {
        public Task<IHttpResponse> ExecuteAsync(HttpContext context)
        {
            IHttpResponse response = new StringResponse(context, "Hello world!");

            return Task.FromResult(response);
        }
    }
}
