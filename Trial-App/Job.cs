using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_App
{
    public class Job
    {
        public int Id { get; set; }
        public int DueDate { get; set; }
        public int ProcessingTime { get; set; }
        public Job()
        {

        }
        public Job(int a, int b, int c)
        {
            this.Id = a;
            this.DueDate = b;
            this.ProcessingTime = c;
        }

        public override string ToString()
        {
            return ("Job Id : " + Id + ", Process Time : " + ProcessingTime + ", Due Date : " + DueDate).ToString();
        }
    }
}
