using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Workflow : IWorkflow
    {
        private readonly List<IActivity> _listOfActivities;

        public Workflow()
        {
            _listOfActivities = new List<IActivity>();
        }
        public void AddActivity(IActivity activity)
        {
            if (activity == null)
                throw new InvalidOperationException("There is no activity to be added to the workflow engine.");

            _listOfActivities.Add(activity);
        }

        public IActivity RemoveActivity(IActivity activity)
        {
            if (activity == null)
                throw new InvalidOperationException("There is no activity to be removed.");


            _listOfActivities.Remove(activity);
            return activity;
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _listOfActivities;
        }
    }
}