using ATKINO;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindPrimes_LimitIsZero_ReturnsEmptyList()
        {
            Sieve atkinSieve = new Sieve();
            List<int> primes = atkinSieve.FindPrimes(0);
            CollectionAssert.AreEqual(new List<int>(), primes);
        }

        [TestMethod]
        public void FindPrimes_LimitIsTwo_ReturnsOnlyTwo()
        {
            Sieve atkinSieve = new Sieve();
            List<int> primes = atkinSieve.FindPrimes(2);
            CollectionAssert.AreEqual(new List<int> { 2 }, primes);
        }

        [TestMethod]
        public void FindPrimes_LimitIsTen_ReturnsPrimesUpToTen()
        {
            Sieve atkinSieve = new Sieve();
            List<int> primes = atkinSieve.FindPrimes(10);
            CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 7 }, primes);
        }

        [TestMethod]
        public void AuthorizeRegistrated()
        {
            bool Authorizated = true;
            string Login = "tomath";
            string Password = "zxc";
            DBManager dBManager = new DBManager("C:\\Users\\Tomath\\Desktop\\Ó÷¸áà\\ÎÏ\\Users.db");
            Assert.AreEqual(Authorizated, dBManager.CheckUser(Login, Password));
        }
        
        [TestMethod]
        public void AuthorizeUnregistrated()
        {
            bool Authorizated = false;
            string Login = "tomath";
            string Password = "123";
            DBManager dBManager = new DBManager("C:\\Users\\Tomath\\Desktop\\Ó÷¸áà\\ÎÏ\\Users.db");
            Assert.AreEqual(Authorizated, dBManager.CheckUser(Login, Password));
        }
    }
}