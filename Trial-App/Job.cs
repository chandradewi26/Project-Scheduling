using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_App
{
    public class Job
    {
        private string Id { get; set; }
        private int DueDate { get; set; }
        private int ProcessingTime { get; set; }
        public Job()
        {

        }
        public Job(int _id, int _dueDate, int _processingTime)
        {
            Id = ("ADR-" + _id);
            DueDate = _dueDate;
            ProcessingTime = _processingTime;
        }

        public override string ToString()
        {
            return ("Job Id : " + Id + ", Process Time : " + ProcessingTime + ", Due Date : " + DueDate).ToString();
        }
    }
}
