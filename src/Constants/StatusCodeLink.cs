#region License
// https://github.com/ofpinewood/http-exceptions/blob/main/LICENSE
//
// The latest version of this file can be found at https://github.com/ofpinewood/http-exceptions/blob/main/src/Opw.HttpExceptions/ResponseStatusCodeLink.cs
#endregion


using System;

namespace PowerUtils.Net.Constants
{
    // Reference: https://developer.mozilla.org/en-US/docs/Web/HTTP/Status#information_responses

    /// <summary>
    /// Status code information links to https://tools.ietf.org/html/rfc7231.
    /// </summary>
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    public static class StatusCodeLink
    {
        private const string BASE_URL = "https://tools.ietf.org/html/";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string STATUS_CODES = BASE_URL + "rfc7231#section-6";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string BAD_REQUEST = BASE_URL + "rfc7231#section-6.5.1";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string UNAUTHORIZED = BASE_URL + "rfc7235#section-3.1";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string PAYMENT_REQUIRED = BASE_URL + "rfc7231#section-6.5.2";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string FORBIDDEN = BASE_URL + "rfc7231#section-6.5.3";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string NOT_FOUND = BASE_URL + "rfc7231#section-6.5.4";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string METHOD_NOT_ALLOWED = BASE_URL + "rfc7231#section-6.5.5";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string NOT_ACCEPTABLE = BASE_URL + "rfc7231#section-6.5.6";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string PROXY_AUTHENTICATION_REQUIRED = BASE_URL + "rfc7235#section-3.2";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string REQUEST_TIMEOUT = BASE_URL + "rfc7231#section-6.5.7";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string CONFLICT = BASE_URL + "rfc7231#section-6.5.8";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string GONE = BASE_URL + "rfc7231#section-6.5.9";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string LENGTH_REQUIRED = BASE_URL + "rfc7231#section-6.5.10";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string PRECONDITION_FAILED = BASE_URL + "rfc7232#section-4.2";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string REQUEST_ENTITY_TOO_LARGE = BASE_URL + "rfc7231#section-6.5.11";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string REQUEST_URI_TOO_LONG = BASE_URL + "rfc7231#section-6.5.12";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string UNSUPPORTED_MEDIA_TYPE = BASE_URL + "rfc7231#section-6.5.13";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string REQUESTED_RANGE_NOT_SATISFIABLE = BASE_URL + "rfc7233#section-4.4";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string EXPECTATION_FAILED = BASE_URL + "rfc7231#section-6.5.14";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string I_AM_A_TEAPOT = BASE_URL + "rfc2324#section-2.3.2";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string UNPROCESSABLE_ENTITY = BASE_URL + "rfc4918#section-11.2";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string TOO_EARLY = "https://httpwg.org/specs/rfc8470.html#status";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string UPGRADE_REQUIRED = BASE_URL + "rfc7231#section-6.5.15";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string PRECONDITION_REQUIRED = BASE_URL + "rfc6585#section-3";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string TOO_MANY_REQUESTS = BASE_URL + "rfc6585#section-4";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string REQUEST_HEADER_FIELDS_TOO_LARGE = BASE_URL + "rfc6585#section-5";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string UNAVAILABLE_FOR_LEGAL_REASONS = "https://httpwg.org/specs/rfc7725.html#n-451-unavailable-for-legal-reasons";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string INTERNAL_SERVER_ERROR = BASE_URL + "rfc7231#section-6.6.1";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string NOT_IMPLEMENTED = BASE_URL + "rfc7231#section-6.6.2";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string BAD_GATEWAY = BASE_URL + "rfc7231#section-6.6.3";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string SERVICE_UNAVAILABLE = BASE_URL + "rfc7231#section-6.6.4";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string GATEWAY_TIMEOUT = BASE_URL + "rfc7231#section-6.6.5";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string HTTP_VERSION_NOT_SUPPORTED = BASE_URL + "rfc7231#section-6.6.6";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string VARIANT_ALSO_NEGOTIATES = BASE_URL + "rfc2295#section-8.1";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string INSUFFICIENT_STORAGE = BASE_URL + "rfc4918#section-11.5";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string LOOP_DETECTED = BASE_URL + "rfc5842#section-7.2";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string NOT_EXTENDED = BASE_URL + "rfc2774#section-7";
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string NETWORK_AUTHENTICATION_REQUIRED = BASE_URL + "rfc6585#section-6";


        /// <summary>
        /// Get documentation link by status code
        /// </summary>
        /// <param name="statuCode">Http status code</param>
        /// <returns>Documentation link. If the status code does not exists return NULL</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string? GetStatusCodeLinkOrDefault(this int statuCode)
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
                418 => I_AM_A_TEAPOT,
                422 => UNPROCESSABLE_ENTITY,
                425 => TOO_EARLY,
                426 => UPGRADE_REQUIRED,
                428 => PRECONDITION_REQUIRED,
                429 => TOO_MANY_REQUESTS,
                431 => REQUEST_HEADER_FIELDS_TOO_LARGE,
                451 => UNAVAILABLE_FOR_LEGAL_REASONS,

                // 5XX
                500 => INTERNAL_SERVER_ERROR,
                501 => NOT_IMPLEMENTED,
                502 => BAD_GATEWAY,
                503 => SERVICE_UNAVAILABLE,
                504 => GATEWAY_TIMEOUT,
                505 => HTTP_VERSION_NOT_SUPPORTED,
                506 => VARIANT_ALSO_NEGOTIATES,
                507 => INSUFFICIENT_STORAGE,
                508 => LOOP_DETECTED,
                510 => NOT_EXTENDED,
                511 => NETWORK_AUTHENTICATION_REQUIRED,

                _ => null,
            };

        /// <summary>
        /// Get documentation link by status code
        /// </summary>
        /// <param name="statuCode">Http status code</param>
        /// <exception cref="ArgumentException">The <paramref name="statuCode">info</paramref> parameter does not exist.</exception>
        /// <returns>Documentation link</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetStatusCodeLink(this int statuCode)
            => statuCode.GetStatusCodeLinkOrDefault() ?? throw new ArgumentException($"Unknown status code: '{statuCode}'");

        /// <summary>
        /// Get documentation link by status code
        /// </summary>
        /// <param name="statuCode">Http status code</param>
        /// <exception cref="ArgumentException">The <paramref name="statuCode">info</paramref> parameter does not exist.</exception>
        /// <returns>Documentation link</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetStatusCodeLink(this int? statuCode)
            => statuCode switch
            {
                null => STATUS_CODES,
                _ => statuCode.Value.GetStatusCodeLink(),
            };
    }
}
