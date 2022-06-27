using System;

namespace WorkflowEngine
{
    public class WorkflowEngine : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("The engine is being executed");
        }

        public void Run(IWorkflow workflow)
        {
            foreach (IActivity activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}
