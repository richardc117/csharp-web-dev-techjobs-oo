using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            var testJob1 = new Job();
            var testJob2 = new Job();

            Assert.IsFalse(testJob1.Id == testJob2.Id);
            //Compares IDs of both jobs, should return false indicating that they do not have duplicate IDs
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            string name = "Product Tester";
            var employerName = new Employer("ACME");
            var jobLocation = new Location("Desert");
            var jobType = new PositionType("Quality Control");
            var jobCoreCompetency = new CoreCompetency("Persistence");

            var testJob = new Job(name, employerName, jobLocation, jobType, jobCoreCompetency);
            Assert.IsTrue(
                testJob.Id==1 &&
                testJob.EmployerName==employerName &&
                testJob.Name == name &&
                testJob.JobType == jobType &&
                testJob.JobCoreCompetency == jobCoreCompetency
            );
        }
    }
}
