using System;

namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);

            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }
            */


            string name = "Product Tester";
            var employerName = new Employer("ACME");
            var jobLocation = new Location("Desert");
            var jobType = new PositionType("Quality Control");
            var jobCoreCompetency = new CoreCompetency("Persistence");

            var testJob1 = new Job();
            var testJob2 = new Job();


            var testJob = new Job(name, employerName, jobLocation, jobType, jobCoreCompetency);

            Console.WriteLine(testJob1.Id);
            Console.WriteLine(testJob2.Id);
            Console.WriteLine(testJob.Id);
        }
    }
}
