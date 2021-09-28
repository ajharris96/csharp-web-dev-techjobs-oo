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
            EmployerName = new Employer();
            EmployerLocation = new Location();
            JobType = new PositionType();
            JobCoreCompetency = new CoreCompetency();
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
            

            if (Name == null && EmployerName.Value == null && EmployerLocation.Value == null && JobType.Value == null && JobCoreCompetency.Value == null)
            {
                return "OOPS! This job does not seem to exist.";
            }

            string str = string.Format("\nID: {0}\nName: {1}\nEmployer: {2}\nLocation: {3}\nPosition Type: {4}\nCore Competency: {5}\n", Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);

          
            return str;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
