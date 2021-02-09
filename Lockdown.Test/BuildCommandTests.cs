using Lockdown.Commands;
using System;
using Xunit;
using Lockdown.Test.Utils;

namespace Lockdown.Test
{
    public class BuildCommandTests
    {
        [Fact]
        public void TestWriteConsole()
        {
            var testConsole = new TestConsole();
            var buildCommand = new BuildCommand(testConsole);

            buildCommand.OnExecute();

            string writtenText = testConsole.GetWrittenContent();

            Assert.Equal("You've executed the build command\r\n", writtenText);
        }
    }
}
