using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{

    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void Test1SettingJobId()
        {
            var testJob1 = new Job();
            var testJob2 = new Job();

            Assert.AreEqual(1, testJob1.Id);
            Assert.AreEqual(2, testJob2.Id);
            Assert.IsFalse(testJob1.Id == testJob2.Id);
            //Compares IDs of both jobs, should return false indicating that they do not have duplicate IDs
        }

        [TestMethod]
        public void Test2JobConstructorSetsAllFields()
        {
            string name = "Product Tester";
            var employerName = new Employer("ACME");
            var jobLocation = new Location("Desert");
            var jobType = new PositionType("Quality Control");
            var jobCoreCompetency = new CoreCompetency("Persistence");

            var testJob = new Job(name, employerName, jobLocation, jobType, jobCoreCompetency);

            Assert.IsTrue(
                testJob.Id == 3 &&
                testJob.EmployerName == employerName &&
                testJob.Name == name &&
                testJob.JobType == jobType &&
                testJob.JobCoreCompetency == jobCoreCompetency
            );
        }


        [TestMethod]
        public void Test3JobsForEquality()
        {
            string name = "Product Tester";
            var employerName = new Employer("ACME");
            var jobLocation = new Location("Desert");
            var jobType = new PositionType("Quality Control");
            var jobCoreCompetency = new CoreCompetency("Persistence");

            var testJob1 = new Job(name, employerName, jobLocation, jobType, jobCoreCompetency);
            var testJob2 = new Job(name, employerName, jobLocation, jobType, jobCoreCompetency);
            Assert.IsFalse(testJob1.Equals(testJob2));
        }

        [TestMethod]
        public void Test4StringPrint()
        {
            string expectedResult = "\nID: 6\nName: Product Tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality Control\nCore Competency: Persistence\n";
            
            string name = "Product Tester";
            var employerName = new Employer("ACME");
            var jobLocation = new Location("Desert");
            var jobType = new PositionType("Quality Control");
            var jobCoreCompetency = new CoreCompetency("Persistence");

            var testJob1 = new Job(name, employerName, jobLocation, jobType, jobCoreCompetency);

            Assert.AreEqual(expectedResult, testJob1.ToString());
        }
    }
}
