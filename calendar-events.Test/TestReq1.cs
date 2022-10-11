using Xunit;
using FluentAssertions;
using calendar_events;
using System;

namespace calendar_events.Test;

public class TestReq1
{
    [Theory(DisplayName = "Deve cadastrar um evento com o construtor completo")]
    [InlineData("Festa Fim de Ano", "20/11/2022", "Festa na chácara")]
    public void TestEventFullConstructor(string title, string date, string description)
    {
       Event evento =  new Event(title, date, description);
       DateTime dateFormatted = DateTimeUtils.validateDate(date);
        //PASS
        evento.Title.Should().Be(title);
        evento.EventDate.Should().Be(dateFormatted);
        evento.Description.Should().Be(description);   

        // Action action = () => DateTimeUtils.validateDate(date);
        // action.Should().Throw<FormatException>(); 
    }


    [Theory(DisplayName = "Deve cadastrar um evento com o construtor sem descrição")]
    [InlineData("Festa Fim de Ano", "20/11/2022")]
    [InlineData("Festa Carnaval", "2023-02-23")]
    [InlineData("Festa Vital", "20/11/2022")]
    [InlineData("Feira", "20/01/2022")]
    public void TestEventHalfConstructor(string title, string date)
    {
        Event evento = new Event(title, date);
        DateTime dateFormatted = DateTimeUtils.validateDate(date);

        evento.Title.Should().Be(title);
        evento.EventDate.Should().Be(dateFormatted);
        evento.Description.Should().BeNull();
        // evento.Title.Should().NotBe("Laland");
        // Action action = () => DateTimeUtils.validateDate(date);
        // action.Should().Throw<FormatException>();
    }


    [Theory(DisplayName = "Deve atrasar a data de um evento corretamente")]
    [InlineData("Festa Fim de Ano", "20/11/2022",2, "22/11/2022")]
    public void TestEventDelayDate(string title, string date, int days, string expected)
    {
        Event evento = new Event(title, date);
        DateTime delayed = DateTimeUtils.validateDate(expected);
        evento.DelayDate(days);
        evento.EventDate.Should().Be(delayed);
        // Action action = () => evento.DelayDate(days);
        // action.Should().NotThrow();

    }

    [Theory(DisplayName = "Deve imprimir um evento corretamente")]
    [InlineData("Festa Fim de Ano", "20/11/2022", "Festa na chácara", "normal", "Evento = Festa Fim de Ano\nDate = 20/11/2022\n")]    
    public void TestPrintEvent(string title, string date, string description, string format, string expected)
    {
        Event evento = new Event(title, date, description);
        string message = evento.PrintEvent(format);
        message.Should().Be(expected);
        message.Should().Contain(title);
    }
}