// See https://aka.ms/new-console-template for more information
using Trial_App;

Console.WriteLine("For sprint of 14 days, and processing time of 1-5 days per job : ");
var rand = new Random();
int id = 0;

int randomDate()
{
    return rand.Next(1, 14);
    //Lets say we have 2 weeks of sprint
}

int generateId()
{
    return id++;
}

int randomProcessTime()
{
    return rand.Next(1, 5);
    //1 to 5 days
}

Job newJob;
var master = new JobMaster();

for (int i = 0; i < 10; i++)
{
    newJob = new Job(generateId(), randomDate(), randomProcessTime());
    master.initialJobs.Add(newJob);
}

master.AssignJobs();
master.printInitialJobs();
master.printScheduledJobs();
master.printRejectedJobs();