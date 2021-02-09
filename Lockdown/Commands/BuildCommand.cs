namespace Lockdown.Commands
{
    using System;

    public class BuildCommand
    {
        public int OnExecute()
        {
            Console.WriteLine("You've executed the build command");
            return 0;
        }
    }
}
