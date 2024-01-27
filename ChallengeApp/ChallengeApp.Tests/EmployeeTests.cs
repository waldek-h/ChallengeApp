namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenWeAddPoints()
        {
            var user = new Employee("Micha³", "Nowak", 45);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(11);

            var result = user.Result;

            Assert.AreEqual(22, result);
        }

        [Test]
        public void WhenWeSubtractPoints()
        {
            var user = new Employee("Micha³", "Nowak", 45);
            user.AddScore(-3);
            user.AddScore(-2);
            user.AddScore(-14);

            var result = user.Result;

            Assert.AreEqual(-19, result);
        }

        [Test]
        public void WhenWeAddAndSubtractPoints()
        {
            var user = new Employee("Micha³", "Nowak", 45);
            user.AddScore(9);
            user.AddScore(2);
            user.AddScore(-1);
            user.AddScore(12);
            user.AddScore(-7);

            var result = user.Result;

            Assert.AreEqual(15, result);
        }
    }
}