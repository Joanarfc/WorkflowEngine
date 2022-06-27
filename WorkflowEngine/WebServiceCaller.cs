using System;

namespace WorkflowEngine
{
    public class WebServiceCaller : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling the WebService...");
        }
    }
}