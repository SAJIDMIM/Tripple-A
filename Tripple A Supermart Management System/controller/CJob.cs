using System;
using Tripple_A_Supermart_Management_System.model;
using Tripple_A_Supermart_Management_System.view;
using System.Collections.Generic;
using System.Data;

namespace Tripple_A_Supermart_Management_System.controller
{
    public class CJob
    {

        public void postJob(string post_Id, string Job_Title,string jobType, string Job_Description,DateTime Date)
        {
            model.Job newJob = new model.Job();
            newJob.postJob(post_Id, Job_Title, jobType, Job_Description, Date);

        }
        public DataTable viewPostJob(string post_Id)
        {
            model.Job viewJobs = new model.Job();
            return viewJobs.viewPostJob(post_Id);
        }

    }
}