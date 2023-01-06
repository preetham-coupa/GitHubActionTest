namespace NUnitTestProjectForGitHubActionTest;

public class Tests
{
    TestController testController;
    public Tests() 
    {
        testController = new TestController();
    }

    [SetUp]
    public void Setup()
    {
    }
    [Test]
    public void TestCase1()
    {
        var ans = testController.Add(1,2);
        int desired = 3;
        Assert.AreEqual(ans, desired);
    }

    [Test]
    public void TestCase2()
    {
        var ans = testController.Add("A", "B");
        string desired = "AB";
        Assert.Pass(ans, desired);
    }

    [Test]
    public void TestCase3()
    {
        var ans = testController.Add("A", "BC");
        string desired = "ABC";
        Assert.Pass(ans, desired);
    }

    [Test]
    public void TestCase4()
    {
        var ans = testController.Add(5, 5);
        int desired = 10;
        Assert.AreEqual(ans, desired);
    }
}