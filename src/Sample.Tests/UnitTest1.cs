using Proto;
using Xunit;

namespace Sample.Tests;

public record Pid(string Address, string Id);

public class PreludeSpec
{
    [Fact]
    public void AddSuccess()
    {
        var a = new PID("nonhost", "a");
        var b = new PID("nonhost", "a");

        Assert.True(PID.Equals(a, b));
    }

    [Fact]
    public void RecordCompare()
    {
        var a = new Pid("nonhost", "a");
        var b = new Pid("nonhost", "a");

        Pid.Equals(a, b);

        Assert.True(a == b);
    }
}
