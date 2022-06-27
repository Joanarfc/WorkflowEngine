using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IWorkflow
    {
        void AddActivity(IActivity activity);
        IActivity RemoveActivity(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}