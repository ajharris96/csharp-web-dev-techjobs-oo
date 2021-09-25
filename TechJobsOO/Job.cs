using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employer, Location location, PositionType position, CoreCompetency coreCompetency) : this()
        {
            Name = name;
            EmployerName = employer;
            EmployerLocation = location;
            JobType = position;
            JobCoreCompetency = coreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string NameText;
            string EmployerNameText;
            string EmployerLocationText;
            string JobTypeText;
            string JobCoreCompetencyText;
            string noData = "Data not available";

            if (Name == null && EmployerName == null && EmployerLocation == null && JobType == null && JobCoreCompetency == null)
            {
                return "OOPS! This job does not seem to exist.";
            }

            if (Name == null)
            {
                NameText = noData;
            } else { NameText = Name; }

            if (EmployerName == null)
            {
                EmployerNameText = noData;
            } else { EmployerNameText = EmployerName.Value; }

            if (EmployerLocation == null)
            {
                EmployerLocationText = noData;
            } else { EmployerLocationText = EmployerLocation.Value; }

            if (JobType == null)
            {
                JobTypeText = noData;
            } else { JobTypeText = JobType.Value; }

            if (JobCoreCompetency == null)
            {
                JobCoreCompetencyText = noData;
            } else { JobCoreCompetencyText = JobCoreCompetency.Value; }

            string str = Environment.NewLine +
                         "ID: " + Id +
                         Environment.NewLine +
                         "Name: " + NameText +
                         Environment.NewLine +
                         "Employer: " + EmployerNameText + 
                         Environment.NewLine +
                         "Location: " + EmployerLocationText +
                         Environment.NewLine +
                         "Position Type: " + JobTypeText +
                         Environment.NewLine +
                         "Core Competency: " + JobCoreCompetencyText +
                         Environment.NewLine;
            return str;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
