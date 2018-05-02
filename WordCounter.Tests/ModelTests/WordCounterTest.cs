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
      Assert.AreEqual(0, RepeatCounter.PerformWordCount(testWordCounter));
    }
    [TestMethod]
    public void AToA_Return_1()
    {
      RepeatCounter testWordCounter = new RepeatCounter("A", "A");
      Assert.AreEqual(1, RepeatCounter.PerformWordCount(testWordCounter));
    }
    [TestMethod]
    public void ABToC_Return_0()
    {
      RepeatCounter testWordCounter = new RepeatCounter("AB", "C");
      Assert.AreEqual(0, RepeatCounter.PerformWordCount(testWordCounter));
    }
    [TestMethod]
    public void HappyToHappy_Return_1()
    {
      RepeatCounter testWordCounter = new RepeatCounter("Happy", "Happy");
      Assert.AreEqual(1, RepeatCounter.PerformWordCount(testWordCounter));
    }
    [TestMethod]
    public void HappyBirtdayToHappy_Return_1()
    {
      RepeatCounter testWordCounter = new RepeatCounter("Happy Birthday", "Happy");
      Assert.AreEqual(1, RepeatCounter.PerformWordCount(testWordCounter));
    }
    [TestMethod]
    public void HappyHappyBirthdayToHappy_Return_2()
    {
      RepeatCounter testWordCounter = new RepeatCounter("Happy Happy Birthday", "Happy");
      Assert.AreEqual(2, RepeatCounter.PerformWordCount(testWordCounter));
    }
    [TestMethod]
    public void HappyHappyBirthdayWithPunctuationToHappy_Return_2()
    {
      RepeatCounter testWordCounter = new RepeatCounter("Happy! Happy! Birthday", "Happy");
      Assert.AreEqual(2, RepeatCounter.PerformWordCount(testWordCounter));
    }
  }
}
