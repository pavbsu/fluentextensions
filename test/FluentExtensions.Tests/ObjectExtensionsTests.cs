using FluentAssertions;
using Xunit;

namespace FluentExtensions.Tests;

public class ObjectExtensionsTests
{
    [Theory]
    [InlineData(null)]
    [InlineData(0)]
    [InlineData("")]
    public void IsIn_ArrayHasNotBeenPassedAsArgument_ReturnsFalse<T>(T value)
    {
        var result = value.IsIn();

        result.Should().BeFalse();
    }

    [Theory]
    [InlineData(null)]
    [InlineData(0)]
    [InlineData("")]
    public void IsIn_ArrayIsEmpty_ReturnsFalse<T>(T value)
    {
        // ReSharper disable once RedundantExplicitParamsArrayCreation
        var result = value.IsIn(new T[] { });

        result.Should().BeFalse();
    }

    [Fact]
    public void IsIn_ValueIsNullAndArrayDoesNotContainNull_ReturnsFalse()
    {
        object? value = null;

        var result = value.IsIn(new object());

        result.Should().BeFalse();
    }

    [Fact]
    public void IsIn_ValueIsNullAndArrayContainsNull_ReturnsTrue()
    {
        object? value = null;

        var result = value.IsIn(new object(), null);

        result.Should().BeTrue();
    }

    [Fact]
    public void IsIn_ValueIsNotContainedInArray_ReturnsFalse()
    {
        var value = new object();

        var result = value.IsIn(new object(), new object());

        result.Should().BeFalse();
    }

    [Fact]
    public void IsIn_ValueIsContainedInArray_ReturnsTrue()
    {
        var value = new object();

        var result = value.IsIn(new object(), value);

        result.Should().BeTrue();
    }
}