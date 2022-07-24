using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_App
{
    public class JobMaster
    {
        //Naming convention
        //camelCase and pascal

        //The input can come from various places : from file, or anywhere
        //How do you make this testable
        //Have manual cases on paper --> couple of examples
        //heres the output that it should be doing --> TEST it
        //later refactoring after finished.


        //Pay attenttion of the access modifier, protect/public/private
        //these should be private
        private List<Job> _initialJobs;
        private List<Job> _scheduledJobs;
        private List<Job> _rejectedJobs;
        public int TotalCompletionTime;


        public JobMaster()
        {
            _initialJobs = new List<Job>();
            _scheduledJobs = new List<Job>();
            _rejectedJobs = new List<Job>();
            TotalCompletionTime = 0;
        }
        public void AddJob(Job job)
        {
            _initialJobs.Add(job);
        }
        public void AssignJobs()
        {
            //Using LINQ - Sort the jobs according to early date & processing time
            _initialJobs = _initialJobs.OrderBy(x => x.DueDate).ThenBy(x => x.ProcessingTime).ToList();

            foreach (Job job in _initialJobs)
            {                
                //Add the job to the scheduledjobs
                _scheduledJobs.Add(job);
                //If after we added this job, totalCompletionTime <= DueDate, done
                if (TotalCompletionTime + job.ProcessingTime <= job.DueDate)
                {
                    TotalCompletionTime += job.ProcessingTime;
                }
                else //Else, we keep index track of which job was the latest job with longest processing time
                {
                    var threshold = -1;
                    var deleteIndex = -1;
                    for (int i = 0; i < _scheduledJobs.Count; i++)
                    {
                        if (_scheduledJobs[i].ProcessingTime > threshold) {
                            deleteIndex = i;
                        }
                    }

                    //Remove the job with the largest processing time and move it to rejectedJobs
                    _rejectedJobs.Add(_scheduledJobs[deleteIndex]);
                    _scheduledJobs.RemoveAt(deleteIndex);

                }
            }

        }

        public void printInitialJobs()
        {
            Console.WriteLine("Initial jobs : ");
            foreach (var job in _initialJobs)
            {
                Console.WriteLine(job.ToString());
            }
            Console.WriteLine();
        }
        public void printScheduledJobs()
        {
            Console.WriteLine("Scheduled jobs : ");
            foreach (var job in _scheduledJobs)
            {
                Console.WriteLine(job.ToString());
            }
            Console.WriteLine();
        }
        public void printRejectedJobs()
        {
            Console.WriteLine("Rejected jobs : ");
            foreach (var job in _rejectedJobs)
            {
                Console.WriteLine(job.ToString());
            }
            Console.WriteLine();
        }
    }

}
