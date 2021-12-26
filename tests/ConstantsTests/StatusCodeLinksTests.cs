using FluentAssertions;
using PowerUtils.Net.Constants;
using Xunit;

namespace PowerUtils.RestAPI.Tests.ProblemDetails
{
    [Trait("Category", "Contains")]
    public class StatusCodeLinksTests
    {
        [Theory(DisplayName = "Http status codes - Should return the links")]
        [InlineData(null, StatusCodeLink.STATUS_CODES)]
        [InlineData(400, StatusCodeLink.BAD_REQUEST)]
        [InlineData(401, StatusCodeLink.UNAUTHORIZED)]
        [InlineData(402, StatusCodeLink.PAYMENT_REQUIRED)]
        [InlineData(403, StatusCodeLink.FORBIDDEN)]
        [InlineData(404, StatusCodeLink.NOT_FOUND)]
        [InlineData(405, StatusCodeLink.METHOD_NOT_ALLOWED)]
        [InlineData(406, StatusCodeLink.NOT_ACCEPTABLE)]
        [InlineData(407, StatusCodeLink.PROXY_AUTHENTICATION_REQUIRED)]
        [InlineData(408, StatusCodeLink.REQUEST_TIMEOUT)]
        [InlineData(409, StatusCodeLink.CONFLICT)]
        [InlineData(410, StatusCodeLink.GONE)]
        [InlineData(411, StatusCodeLink.LENGTH_REQUIRED)]
        [InlineData(412, StatusCodeLink.PRECONDITION_FAILED)]
        [InlineData(413, StatusCodeLink.REQUEST_ENTITY_TOO_LARGE)]
        [InlineData(414, StatusCodeLink.REQUEST_URI_TOO_LONG)]
        [InlineData(415, StatusCodeLink.UNSUPPORTED_MEDIA_TYPE)]
        [InlineData(416, StatusCodeLink.REQUESTED_RANGE_NOT_SATISFIABLE)]
        [InlineData(417, StatusCodeLink.EXPECTATION_FAILED)]
        [InlineData(426, StatusCodeLink.UPGRADE_REQUIRED)]
        [InlineData(500, StatusCodeLink.INTERNAL_SERVER_ERROR)]
        [InlineData(501, StatusCodeLink.NOT_IMPLEMENTED)]
        [InlineData(502, StatusCodeLink.BAD_GATEWAY)]
        [InlineData(503, StatusCodeLink.SERVICE_UNAVAILABLE)]
        [InlineData(504, StatusCodeLink.GATEWAY_TIMEOUT)]
        [InlineData(505, StatusCodeLink.HTTP_VERSION_NOT_SUPPORTED)]
        public void GetStatusCodeLink_StatusCodes_ReturnLinks(int? statusCode, string statusCodeLink)
        {
            // Arrange & Act
            var act = statusCode.GetStatusCodeLink();

            // Assert
            act.Should().Be(statusCodeLink);
        }
    }
}