using System;

namespace BuildVersionGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateVersion version = new CreateVersion();
            var currVersion = version.TodayVersion();
            Environment.SetEnvironmentVariable("NaroBuildVersion", currVersion, EnvironmentVariableTarget.User);
            
            //this is how to get that variable
            //var variable = Environment.GetEnvironmentVariable("MyVariable", EnvironmentVariableTarget.User);
        }
    }
}
