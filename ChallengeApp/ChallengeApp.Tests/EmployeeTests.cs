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
            Assert.AreEqual(11.4F, result.Average);
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
            Assert.That(result.Average, Is.EqualTo(2.2F));
            Assert.That(result.Max, Is.EqualTo(14));
        }
    }
}