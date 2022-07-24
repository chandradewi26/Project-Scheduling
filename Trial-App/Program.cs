using Trial_App;

//Child Class learning
JobChild newJobChild = new JobChild(1, 25, 5);
//Public Get Set Usage
newJobChild.addDescription(newJobChild.Description);
newJobChild.Description = "Test";

Shape shape = new Shape();
shape.Draw();
Circle circle = new Circle();
circle.Draw();


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
