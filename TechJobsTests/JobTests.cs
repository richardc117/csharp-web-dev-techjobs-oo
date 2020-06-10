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
            //Compares IDs of both jobs, should return false
        }
    }
}
