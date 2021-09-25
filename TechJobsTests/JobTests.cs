using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

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

        [TestMethod]
        public void TestingForBlankLines() { 
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string str = job3.ToString();
            String[] lines = str.Split(new String[] { Environment.NewLine }, StringSplitOptions.None);
            Assert.IsTrue(lines[0] == "");
            Assert.IsTrue(lines[lines.Length-1] == "");
            
        }

        [TestMethod]
        public void TestingForLabels()
        {
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string str = job3.ToString();
            String[] lines = str.Split(new String[] { Environment.NewLine }, StringSplitOptions.None);
            Assert.IsTrue(lines[1].Contains("ID:"));
            Assert.IsTrue(lines[2].Contains("Name:"));
            Assert.IsTrue(lines[3].Contains("Employer:"));
            Assert.IsTrue(lines[4].Contains("Location:"));
            Assert.IsTrue(lines[5].Contains("Position Type:"));
            Assert.IsTrue(lines[6].Contains("Core Competency:"));
        }

        [TestMethod]
        public void TestingForEmptyFields()
        {
            Job job5 = new Job();
            job5.Name = "Test Name";
            string str = job5.ToString();
            String[] lines = str.Split(new String[] { Environment.NewLine }, StringSplitOptions.None);
            Assert.IsTrue(lines[2] == "Name: Test Name");
            Assert.IsTrue(lines[3] == "Employer: Data not available");
            Assert.IsTrue(lines[4] == "Location: Data not available");
            Assert.IsTrue(lines[5] == "Position Type: Data not available");
            Assert.IsTrue(lines[6] == "Core Competency: Data not available");


        }

        [TestMethod]
        public void TestingForEmptyJob()
        {
            Job job5 = new Job();
            string str = job5.ToString();
            Assert.IsTrue(str == "OOPS! This job does not seem to exist.");
        }

    }
}
