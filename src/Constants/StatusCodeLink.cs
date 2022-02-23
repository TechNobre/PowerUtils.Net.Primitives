using System;

namespace PowerUtils.Net.Constants
{
    // Reference: https://github.com/ofpinewood/http-exceptions/blob/main/src/Opw.HttpExceptions/ResponseStatusCodeLink.cs

    /// <summary>
    /// Status code information links to https://tools.ietf.org/html/rfc7231.
    /// </summary>
    public static class StatusCodeLink
    {
        public const string STATUS_CODES = "https://tools.ietf.org/html/rfc7231#section-6";

        public const string BAD_REQUEST = "https://tools.ietf.org/html/rfc7231#section-6.5.1";
        public const string UNAUTHORIZED = "https://tools.ietf.org/html/rfc7235#section-3.1";
        public const string PAYMENT_REQUIRED = "https://tools.ietf.org/html/rfc7231#section-6.5.2";
        public const string FORBIDDEN = "https://tools.ietf.org/html/rfc7231#section-6.5.3";
        public const string NOT_FOUND = "https://tools.ietf.org/html/rfc7231#section-6.5.4";
        public const string METHOD_NOT_ALLOWED = "https://tools.ietf.org/html/rfc7231#section-6.5.5";
        public const string NOT_ACCEPTABLE = "https://tools.ietf.org/html/rfc7231#section-6.5.6";
        public const string PROXY_AUTHENTICATION_REQUIRED = "https://tools.ietf.org/html/rfc7235#section-3.2";
        public const string REQUEST_TIMEOUT = "https://tools.ietf.org/html/rfc7231#section-6.5.7";
        public const string CONFLICT = "https://tools.ietf.org/html/rfc7231#section-6.5.8";
        public const string GONE = "https://tools.ietf.org/html/rfc7231#section-6.5.9";
        public const string LENGTH_REQUIRED = "https://tools.ietf.org/html/rfc7231#section-6.5.10";
        public const string PRECONDITION_FAILED = "https://tools.ietf.org/html/rfc7232#section-4.2";
        public const string REQUEST_ENTITY_TOO_LARGE = "https://tools.ietf.org/html/rfc7231#section-6.5.11";
        public const string REQUEST_URI_TOO_LONG = "https://tools.ietf.org/html/rfc7231#section-6.5.12";
        public const string UNSUPPORTED_MEDIA_TYPE = "https://tools.ietf.org/html/rfc7231#section-6.5.13";
        public const string REQUESTED_RANGE_NOT_SATISFIABLE = "https://tools.ietf.org/html/rfc7233#section-4.4";
        public const string EXPECTATION_FAILED = "https://tools.ietf.org/html/rfc7231#section-6.5.14";
        public const string UNPROCESSABLE_ENTITY = "https://tools.ietf.org/doc/html/rfc7231#section-6.5";
        public const string UPGRADE_REQUIRED = "https://tools.ietf.org/html/rfc7231#section-6.5.15";
        public const string INTERNAL_SERVER_ERROR = "https://tools.ietf.org/html/rfc7231#section-6.6.1";
        public const string NOT_IMPLEMENTED = "https://tools.ietf.org/html/rfc7231#section-6.6.2";
        public const string BAD_GATEWAY = "https://tools.ietf.org/html/rfc7231#section-6.6.3";
        public const string SERVICE_UNAVAILABLE = "https://tools.ietf.org/html/rfc7231#section-6.6.4";
        public const string GATEWAY_TIMEOUT = "https://tools.ietf.org/html/rfc7231#section-6.6.5";
        public const string HTTP_VERSION_NOT_SUPPORTED = "https://tools.ietf.org/html/rfc7231#section-6.6.6";

        /// <summary>
        /// Get documentation link by status code
        /// </summary>
        /// <param name="statuCode">Http statu code</param>
        /// <exception cref="ArgumentException">The <paramref name="statuCode">info</paramref> parameter does not exist.</exception>
        /// <returns>Documentation link</returns>
        public static string GetStatusCodeLink(this int statuCode)
            => statuCode switch
            {
                // 4XX
                400 => BAD_REQUEST,
                401 => UNAUTHORIZED,
                402 => PAYMENT_REQUIRED,
                403 => FORBIDDEN,
                404 => NOT_FOUND,
                405 => METHOD_NOT_ALLOWED,
                406 => NOT_ACCEPTABLE,
                407 => PROXY_AUTHENTICATION_REQUIRED,
                408 => REQUEST_TIMEOUT,
                409 => CONFLICT,
                410 => GONE,
                411 => LENGTH_REQUIRED,
                412 => PRECONDITION_FAILED,
                413 => REQUEST_ENTITY_TOO_LARGE,
                414 => REQUEST_URI_TOO_LONG,
                415 => UNSUPPORTED_MEDIA_TYPE,
                416 => REQUESTED_RANGE_NOT_SATISFIABLE,
                417 => EXPECTATION_FAILED,
                422 => UNPROCESSABLE_ENTITY,
                426 => UPGRADE_REQUIRED,

                // 5XX
                500 => INTERNAL_SERVER_ERROR,
                501 => NOT_IMPLEMENTED,
                502 => BAD_GATEWAY,
                503 => SERVICE_UNAVAILABLE,
                504 => GATEWAY_TIMEOUT,
                505 => HTTP_VERSION_NOT_SUPPORTED,

                _ => throw new ArgumentException($"Unknown status code: '{statuCode}'"),
            };

        /// <summary>
        /// Get documentation link by status code
        /// </summary>
        /// <param name="statuCode">Http statu code</param>
        /// <exception cref="ArgumentException">The <paramref name="statuCode">info</paramref> parameter does not exist.</exception>
        /// <returns>Documentation link</returns>
        public static string GetStatusCodeLink(this int? statuCode)
            => statuCode switch
            {
                null => STATUS_CODES,
                _ => statuCode.Value.GetStatusCodeLink(),
            };
    }
}
