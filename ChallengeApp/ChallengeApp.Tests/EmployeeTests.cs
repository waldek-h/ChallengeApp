namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenWeAddPoints()
        {
            var employee = new Employee("Micha³", "Nowak", 45);
            employee.AddGrade(11);
            employee.AddGrade(18);
            employee.AddGrade(14);
            employee.AddGrade(5);
            employee.AddGrade(9);

            var result = employee.GetStatistics();

            Assert.AreEqual(5, result.Min);
            Assert.AreEqual(Math.Round(11.4, 2), Math.Round(result.Average, 2));
            Assert.AreEqual(18, result.Max);
        }
        [Test]
        public void WhenWeAddOrSubstractPoints()
        {
            var employee = new Employee("Micha³", "Nowak", 45);
            employee.AddGrade(11);
            employee.AddGrade(-18);
            employee.AddGrade(14);
            employee.AddGrade(-5);
            employee.AddGrade(9);

            var result = employee.GetStatistics();

            Assert.That(result.Min, Is.EqualTo(-18));
            Assert.That(Math.Round(result.Average, 2), Is.EqualTo(Math.Round(2.2, 2)));
            Assert.That(result.Max, Is.EqualTo(14));
        }
    }
}