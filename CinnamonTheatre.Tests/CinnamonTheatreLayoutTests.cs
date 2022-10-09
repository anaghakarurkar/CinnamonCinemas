using CinnamonTheatre.Models.Layout;
using FluentAssertions;
namespace CinnamonTheatre.Tests;

public class CinnamonTheatreLayoutTests
{
    private CinnamonTheatreLayout _layout;
    [SetUp]
    public void Setup()
    {
        _layout = new CinnamonTheatreLayout();

    }

    [Test]
    public void Layout_CreateLayout_ShouldReturnTrueAfterCreation()
    {
        bool expectedResult = _layout.CreateSeatingArea(3, 5);
        Assert.That(expectedResult, Is.True);
    }
}