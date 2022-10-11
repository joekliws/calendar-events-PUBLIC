using Xunit;
using FluentAssertions;
using calendar_events;
using System;

namespace calendar_events.Test;

public class TestReq2
{
    [Theory(DisplayName = "Deve procurar um evento por titulo")]
    [InlineData("title 1", "12-10-1991", "some text", 0)]
    public void TestListSearchByTitle(string title, string date, string description,int expected)
    {
        EventList eventList = new();
        eventList.Add(new(title, date, description));
        eventList.SearchByTitle(title).Should().Be(expected);

    }

    [Theory(DisplayName = "Deve procurar um evento por data")]
    [InlineData("title 2", "12-10-2022", "some text", 0)]
    public void TestListSearchByDate(string title, string date, string description, int expected)
    {
        EventList eventList = new();
        eventList.Add(new(title, date, description));
        eventList.SearchByDate(date).Should().Be(expected);

    }

    
}