using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void AtoB_Return_0()
    {
      RepeatCounter testWordCounter = new RepeatCounter("A", "B");
      Assert.AreEqual(0, testWordCounter.PerformWordCount());
    }
    [TestMethod]
    public void AtoA_Return_1()
    {
      RepeatCounter testWordCounter = new RepeatCounter("A", "A");
      Assert.AreEqual(1, testWordCounter.PerformWordCount());
    }
  }
}
