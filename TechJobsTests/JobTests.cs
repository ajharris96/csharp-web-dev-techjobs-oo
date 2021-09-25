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
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job1.Id == job2.Id - 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job3.Name == "Product tester");
            Assert.IsTrue(job3.EmployerName.Value == "ACME");
            Assert.IsTrue(job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job3.JobType.Value == "Quality control");
            Assert.IsTrue(job3.JobCoreCompetency.value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job3.Equals(job4));
        }

    }
}
