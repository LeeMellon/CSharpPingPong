using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongs.Models;
using System;

namespace PingPongs.Tests
{
  [TestClass]
  public class PingPongTest
  {

    // [TestMethod]
    // public void IsDivThree_DivisableBy_False()
    // {
    //   int Testint = 2;
    //   PingPong testPong = new PingPong();
    //   Assert.AreEqual(false, testPong.IsDiv(Testint));
    // }
    //
    // [TestMethod]
    // public void IsDivThree_DivisableBy3_True()
    // {
    //   int Testint = 9;
    //   PingPong testPong = new PingPong();
    //   Assert.AreEqual(true, testPong.IsDiv(Testint));
    // }
    //
    // [TestMethod]
    // public void IsDivThree_DivisableBy5_False()
    // {
    //   int Testint = 4;
    //   PingPong testPong = new PingPong();
    //   Assert.AreEqual(false, testPong.IsDiv(Testint));
    // }
    //
    // [TestMethod]
    // public void IsDivThree_DivisableBy5_True()
    // {
    //   int Testint = 10;
    //   PingPong testPong = new PingPong();
    //   Assert.AreEqual(true, testPong.IsDiv(Testint));
    // }
    [TestMethod]
    public void IsDivThree_DivisableBy3And5_Pong()
    {
      int Testint = 5;
      PingPong testPong = new PingPong();
      Assert.AreEqual("Pong", testPong.IsDiv(Testint));
    }

    [TestMethod]
    public void IsDivThree_DivisableBy3And5_PingPong()
    {
      int Testint = 15;
      PingPong testPong = new PingPong();
      Assert.AreEqual("PingPong", testPong.IsDiv(Testint));
    }
    [TestMethod]
    public void IsDivThree_DivisableBy3And5_TestInt()
    {
      int Testint = 14;
      PingPong testPong = new PingPong();
      string TestIntToString = Testint.ToString();
      Assert.AreEqual(TestIntToString, testPong.IsDiv(Testint));
    }
  }
}
