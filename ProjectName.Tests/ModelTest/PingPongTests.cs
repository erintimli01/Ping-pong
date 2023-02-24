// ProjectName.Solution/ProjectName.Tests/ModelTests/ClassNameTests.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;

namespace ProjectName.Tests
{
  [TestClass]
  public class PingPongTests
  {
    [TestMethod]
    public void PingPong_ReturnsNumber_Int()
    {
      PingPong TestNumber = new PingPong();
      Assert.AreEqual(typeof(PingPong), TestNumber.GetType());
    }
  }
}