﻿namespace Skeleton.Web.Authorisation.JwtBearer.Configuration
{
    using System;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.IdentityModel.Tokens;

    public static class JwtBearerOptionsExtensions
    {
        public static JwtBearerOptions WithTokenValidationParameters(this JwtBearerOptions options,
            Func<TokenValidationParameters, TokenValidationParameters> parametersBuilder)
        {
            if(options == null)
                throw new ArgumentNullException(nameof(options));
            if (parametersBuilder == null)
                throw new ArgumentNullException(nameof(parametersBuilder));

            options.TokenValidationParameters = parametersBuilder(new TokenValidationParameters());
            return options;
        }

        public static JwtBearerOptions WithEventsProcessor(this JwtBearerOptions options, IJwtBearerEvents eventsProcessor)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));
            if (eventsProcessor == null)
                throw new ArgumentNullException(nameof(eventsProcessor));

            options.Events = eventsProcessor;
            return options;
        }

        public static JwtBearerOptions WithErrorDetails(this JwtBearerOptions options, bool includeErrorDetails)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            options.IncludeErrorDetails = includeErrorDetails;
            return options;
        }

        public static JwtBearerOptions WithoutErrorDetails(this JwtBearerOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            options.IncludeErrorDetails = false;
            return options;
        }
    }
}