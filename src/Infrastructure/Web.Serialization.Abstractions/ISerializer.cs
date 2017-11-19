﻿namespace Skeleton.Web.Serialization.Abstractions
{
    using System.IO;
    using System.Net.Http;
    using Microsoft.Net.Http.Headers;

    public interface ISerializer
    {
        HttpContent Serialize(object obj);

        T Deserialize<T>(Stream stream);

        MediaTypeHeaderValue MediaType { get; }
    }
}