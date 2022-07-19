using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_App
{
    public class JobMaster
    {
        public List<Job> initialJobs;
        public List<Job> scheduledJobs;
        public List<Job> rejectedJobs;
        public int lastJobId; //I dont think its necessary
        public int totalCompletionTime;

        public JobMaster()
        {
            initialJobs = new List<Job>();
            scheduledJobs = new List<Job>();
            rejectedJobs = new List<Job>();
            totalCompletionTime = 0;
        }

        public void AssignJobs()
        {
            //Using List<T>.Sort method (System.Collections.Generic)
            //initialJobs.Sort(delegate (Job x, Job y) {
            //    return x.DueDate.CompareTo(y.DueDate);
            //});

            //Using LINQ
            //initialJobs = initialJobs.OrderBy(x=> x.DueDate).ThenBy(x=> x.DueDate).ToList();
            initialJobs = initialJobs.OrderBy(x => x.DueDate).ThenBy(x => x.ProcessingTime).ToList();


            //For every job
            foreach (Job job in initialJobs)
            {
                //Add the job to the scheduledjobs
                scheduledJobs.Add(job);
                //If after we added this job, totalCompletionTime <= DueDate, done
                if (totalCompletionTime + job.ProcessingTime <= job.DueDate)
                {
                    totalCompletionTime += job.ProcessingTime;
                }
                else //Else, we keep index track of which job was the latest job with longest processing time
                {
                    var threshold = -1;
                    var deleteIndex = -1;
                    for (int i = 0; i < scheduledJobs.Count; i++)
                    {
                        if (scheduledJobs[i].ProcessingTime > threshold) {
                            deleteIndex = i;
                        }
                    }

                    //Remove the job with the largest processing time and move it to rejectedJobs
                    rejectedJobs.Add(scheduledJobs[deleteIndex]);
                    scheduledJobs.RemoveAt(deleteIndex);

                }
            }

        }

        public void printInitialJobs()
        {
            Console.WriteLine("Initial jobs : ");
            foreach (var job in initialJobs)
            {
                Console.WriteLine(job.ToString());
            }
            Console.WriteLine();
        }
        public void printScheduledJobs()
        {
            Console.WriteLine("Scheduled jobs : ");
            foreach (var job in scheduledJobs)
            {
                Console.WriteLine(job.ToString());
            }
            Console.WriteLine();
        }
        public void printRejectedJobs()
        {
            Console.WriteLine("Rejected jobs : ");
            foreach (var job in rejectedJobs)
            {
                Console.WriteLine(job.ToString());
            }
            Console.WriteLine();
        }
    }

}
