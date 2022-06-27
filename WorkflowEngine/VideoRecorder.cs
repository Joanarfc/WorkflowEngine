using System;

namespace WorkflowEngine
{
    public class VideoRecorder : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Recording a video... Processing...");
        }
    }
}