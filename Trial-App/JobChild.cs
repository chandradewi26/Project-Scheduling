using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_App
{
    //Inheritance
    public class JobChild : Job
    {
        public string Description { get; set; }

        public JobChild(int id, int dueDate, int processingTime)
        {
            _id = ("ADR-" + id);
            DueDate = dueDate;
            ProcessingTime = processingTime;
        }

        public void addDescription(string a)
        {
            Description = a;
        }
    }
}
