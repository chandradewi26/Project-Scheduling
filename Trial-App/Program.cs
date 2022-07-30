using Trial_App;

//This is manual test
var rand = new Random();

var master = new JobMaster();

master.AddJob(new Job(2001, 5, 2));
master.AddJob(new Job(2002, 5, 4));
master.AddJob(new Job(2003, 7, 3));
master.AddJob(new Job(2004, 9, 1));
master.AddJob(new Job(2005, 8, 3));

master.AssignJobs();
master.printInitialJobs();
master.printScheduledJobs();
master.printRejectedJobs();

return 0;














/*


//This is manual test
Console.WriteLine("\n\nFor sprint of 14 days, and processing time of 1-5 days per job : ");
var rand = new Random();
int id = 2000;

int randomDate()
{
    return rand.Next(1, 14);
}

int generateId()
{
    return id++;
}

int randomProcessTime()
{
    return rand.Next(1, 5);
}

Job newJob;
var master = new JobMaster();

for (int i = 0; i < 10; i++)
{
    newJob = new Job(generateId(), randomDate(), randomProcessTime());
    master.AddJob(newJob);
}

master.AssignJobs();
master.printInitialJobs();
master.printScheduledJobs();
master.printRejectedJobs();

*/