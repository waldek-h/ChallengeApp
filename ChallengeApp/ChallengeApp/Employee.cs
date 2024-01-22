//1. Stwórz klasę Employee, w której przechowaz imię, nazwisko, wiek
//    oraz punkty pracownika w postaci liczb całkowitych.

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
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; set; }

        private List<int> score = new List<int>();
        public void AddScore(int score)
        {
            this.score.Add(score);
        }
        public int Result
        {
            get { return score.Sum(); }
        }
    }
}
