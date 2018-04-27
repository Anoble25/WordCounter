using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void AToB_Return_0()
    {
      RepeatCounter testWordCounter = new RepeatCounter("A", "B");
      Assert.AreEqual(0, testWordCounter.PerformWordCount());
    }
    [TestMethod]
    public void AToA_Return_1()
    {
      RepeatCounter testWordCounter = new RepeatCounter("A", "A");
      Assert.AreEqual(1, testWordCounter.PerformWordCount());
    }
    [TestMethod]
    public void ABToC_Return_0()
    {
      RepeatCounter testWordCounter = new RepeatCounter("AB", "C");
      Assert.AreEqual(0, testWordCounter.PerformWordCount());
    }
    [TestMethod]
    public void HappyToHappy_Return_1()
    {
      RepeatCounter testWordCounter = new RepeatCounter("Happy", "Happy");
      Assert.AreEqual(1, testWordCounter.PerformWordCount());
    }
    [TestMethod]
    public void HappyBirtdayToHappy_Return_1()
    {
      RepeatCounter testWordCounter = new RepeatCounter("Happy Birthday", "Happy");
      Assert.AreEqual(1, testWordCounter.PerformWordCount());
    }
  }
}
