using System;

namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            First ToString test suggestion:

            job1.ToString() should return a string that looks something like:

            string testOutput = "\n" +
            $"ID: {job1.Id}\n" +
            "Name: Product Tester\n" +
            "Employer: ACME\n" +
            "Location: Desert\n" +
            "Position Type: Quality Control\n" +
            "Core Competency: Persistence\n";

            Test this test output string against the actual output of the ToString() method, and if they match,
            you know your ToString method's output is good

            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

            job3.ToString() should return:
            ID: 3
            Name: Ice cream tester
            Employer: Data not available
            Location: Home
            Position Type: UX
            Core Competency: Tasting ability


            // what if we wanted to make 2 jobs with the same employer?
            Employer vmlyr = new Employer("VMLY&R");
            Job job4 = new Job("QA Analyst", vmlyr, etc...);
            Job job5 = new Job("Software Dev 3", vmlyr, etc...);

            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);

            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }
            */
        }
    }
}
