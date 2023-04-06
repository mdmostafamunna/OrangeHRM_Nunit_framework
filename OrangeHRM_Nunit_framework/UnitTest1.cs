namespace OrangeHRM_Nunit_framework
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Output for Set up method of  Nunit");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("Output for Test1 method of  Nunit");
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("Output for Test2 method of  Nunit");
            Assert.AreEqual(2, 2);
        }

        [TearDown]
        public void TearDown()
        {
            TestContext.Progress.WriteLine("Output for TearDown method of  Nunit");
        }
    }
}