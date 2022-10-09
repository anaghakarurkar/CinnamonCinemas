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
        var expectedResult = _layout.CreateSeatingArea(3, 5);
        Assert.That(expectedResult, Is.True);
    }

    [Test]
    public void Layout_AfterLayoutCreation_ShoudHaveThreeRows()
    {
        var expectedRows = 3;
        _layout.CreateSeatingArea(3, 5);
        Assert.That(_layout.SeatingArea, Has.Count.EqualTo(expectedRows));
    }

    [Test]
    public void Layout_AfterLayoutCreation_ShouldHaveFiveSeatsPerRow()
    {
        var expectedRows = 5;
        _layout.CreateSeatingArea(3, 5);
        var numberOfSeats = _layout.SeatingArea['A'];
        Assert.That(numberOfSeats?.Count, Is.EqualTo(expectedRows));

    }

    [Test]
    public void Layout_RowName_ShouldStartFromA()
    {
        char[] expectedRowNames = { 'A', 'B', 'C' };
        _layout.CreateSeatingArea(3, 5);
        char[] actualRowNames = _layout.SeatingArea.Keys.ToArray();
        Assert.That(actualRowNames[0], Is.EqualTo(expectedRowNames[0]));
        Assert.That(actualRowNames[1], Is.EqualTo(expectedRowNames[1]));
        Assert.That(actualRowNames[2], Is.EqualTo(expectedRowNames[2]));
    }
}