namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenWeCompareStrings()
        {
            string user1 = "Marcin";
            string user2 = "Marcin";
            //pomijamy act
            Assert.AreEqual(user1, user2);
        }

        [Test]
        public void WhenWeCompareIntegers()
        {
            int number1 = 1;
            int number2 = 2;
            //pomijamy act
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void WhenWeCompareFloats()
        {
            float number3 = 1.58F;
            float number4 = 2.95F;
            //pomijamy act
            Assert.AreNotEqual(number3, number4);
        }

        [Test]
        public void WhenWeCompareReferences()
        {
            var employee1 = GetEmployee("Marcin");
            var employee2 = GetEmployee("Marcin");
            //pomijamy act
            Assert.AreEqual(employee1.FirstName, employee2.FirstName);
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
