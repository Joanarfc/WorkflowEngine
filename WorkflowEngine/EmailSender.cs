using System;

namespace WorkflowEngine
{
    public class EmailSender : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending email...");
        }
    }
}