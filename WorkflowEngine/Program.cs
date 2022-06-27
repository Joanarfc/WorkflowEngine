using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Workflow worflow = new Workflow();
            //Test the insertion of an empty activity:
            //worflow.AddActivity(null);

            EmailSender emailSender = new EmailSender();
            worflow.AddActivity(emailSender);
            worflow.AddActivity(new VideoRecorder());
            worflow.AddActivity(new WebServiceCaller());



            WorkflowEngine worflowEngine = new WorkflowEngine();

            Console.WriteLine("List of activities after the addition:");
            worflowEngine.Run(worflow);

            //Test the removal when there is no activity in the workflow:
            //worflow.RemoveActivity(null);
            worflow.RemoveActivity(emailSender);

            Console.WriteLine("\nList of activities after the removal of the EmailSender:");
            worflowEngine.Run(worflow);

            Console.ReadLine();
        }
    }
}
