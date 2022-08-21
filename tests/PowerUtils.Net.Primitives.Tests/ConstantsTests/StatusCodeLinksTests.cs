using System;
using FluentAssertions;
using PowerUtils.Net.Constants;
using Xunit;

namespace PowerUtils.Net.Primitives.Tests.ConstantsTests;

public class StatusCodeLinksTests
{
    [Theory]
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
    [InlineData(418, StatusCodeLink.I_AM_A_TEAPOT)]
    [InlineData(422, StatusCodeLink.UNPROCESSABLE_ENTITY)]
    [InlineData(425, StatusCodeLink.TOO_EARLY)]
    [InlineData(426, StatusCodeLink.UPGRADE_REQUIRED)]
    [InlineData(428, StatusCodeLink.PRECONDITION_REQUIRED)]
    [InlineData(429, StatusCodeLink.TOO_MANY_REQUESTS)]
    [InlineData(431, StatusCodeLink.REQUEST_HEADER_FIELDS_TOO_LARGE)]
    [InlineData(451, StatusCodeLink.UNAVAILABLE_FOR_LEGAL_REASONS)]
    [InlineData(500, StatusCodeLink.INTERNAL_SERVER_ERROR)]
    [InlineData(501, StatusCodeLink.NOT_IMPLEMENTED)]
    [InlineData(502, StatusCodeLink.BAD_GATEWAY)]
    [InlineData(503, StatusCodeLink.SERVICE_UNAVAILABLE)]
    [InlineData(504, StatusCodeLink.GATEWAY_TIMEOUT)]
    [InlineData(505, StatusCodeLink.HTTP_VERSION_NOT_SUPPORTED)]
    [InlineData(506, StatusCodeLink.VARIANT_ALSO_NEGOTIATES)]
    [InlineData(507, StatusCodeLink.INSUFFICIENT_STORAGE)]
    [InlineData(508, StatusCodeLink.LOOP_DETECTED)]
    [InlineData(510, StatusCodeLink.NOT_EXTENDED)]
    [InlineData(511, StatusCodeLink.NETWORK_AUTHENTICATION_REQUIRED)]
    public void StatusCodes_GetStatusCodeLink_Link(int? statusCode, string statusCodeLink)
    {
        // Arrange & Act
        var act = statusCode.GetStatusCodeLink();

        // Assert
        act.Should()
            .Be(statusCodeLink);
    }

    [Fact]
    public void InvalidStatusCode_GetStatusCodeLink_ArgumentException()
    {
        // Arrange & Act
        var act = () => 666.GetStatusCodeLink();

        // Assert
        act.Should()
            .Throw<ArgumentException>();
    }

    [Fact]
    public void NonExistentStatusCode_GetStatusCodeLinkOrDefault_Null()
    {
        // Arrange & Act
        var act = 666.GetStatusCodeLinkOrDefault();


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact]
    public void ExistentStatusCode_GetStatusCodeLinkOrDefault_Link()
    {
        // Arrange & Act
        var act = 510.GetStatusCodeLinkOrDefault();


        // Assert
        act.Should()
            .NotBeNull();
    }
}
