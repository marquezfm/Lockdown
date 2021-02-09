using Lockdown.Commands;
using System;
using Xunit;
using Lockdown.Test.Utils;
using Shouldly;

namespace Lockdown.Test
{
    public class BuildCommandTests
    {
        [Fact]
        public void TestWriteConsole()
        {
            // Set up
            var testConsole = new TestConsole();
            var buildCommand = new BuildCommand(testConsole);

            // Act
            buildCommand.OnExecute();

            // Asert
            string writtenText = testConsole.GetWrittenContent();

            writtenText.ShouldBe("You've executed the build command\r\n");
            // Assert.Equal("You've executed the build command\r\n", writtenText);
        }
    }
}
