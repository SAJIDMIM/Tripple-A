using System;
using Tripple_A_Supermart_Management_System.model;
using Tripple_A_Supermart_Management_System.view;
using System.Collections.Generic;
namespace Tripple_A_Supermart_Management_System.controller
{
    public class CJob
    {
        private model.MJob _postJob;

        public CJob()
        {
            _postJob = new model.MJob();
        }

        public void postJob(string postId, string jobTitle, List<string> jobTypes, string jobDescription)
        {
            _postJob.postJob(postId, jobTitle, jobTypes, jobDescription);
        }
    }
}