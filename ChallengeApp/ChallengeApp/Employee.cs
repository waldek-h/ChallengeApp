namespace ChallengeApp
{
    public class Employee
    {
        public Employee(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Employee(string firstName)
        {
            this.FirstName = firstName;

        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; set; }

        private List<float> grades = new List<float>();
        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }
        public float Result
        {
            get { return grades.Sum(); }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;


            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }

    }
}
