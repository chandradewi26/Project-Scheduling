﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_App
{
    interface IJobInterface
    {
        //Only public datas can use interface
        public int DueDate { get; set; }
        public int ProcessingTime { get; set; }
    }
    public class Job : IJobInterface
    {
        //Encapsulation
        //Private, Public, and Protected
        protected string _id { get; set; }
        public int DueDate { get; set; }
        public int ProcessingTime { get; set; }
        public Job() { }
        public Job(int id, int dueDate, int processingTime)
        {
            _id = ("ADR-" + id);
            DueDate = dueDate;
            ProcessingTime = processingTime;
        }

        public override string ToString()
        {
            return ($"{_id}, Process Time : {ProcessingTime}, Due Date : {DueDate}");
        }
    }
}
