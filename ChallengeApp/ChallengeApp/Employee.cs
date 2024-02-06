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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value.");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))

            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float.");
            }

        }
        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(decimal grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
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
