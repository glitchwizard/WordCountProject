using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class CountBLTest
  {
    [TestMethod]
        public void DoesClassInstantiate_InstantitionSuccessful_NewObj()
        {
          CountBL testCountBL = new CountBL();

          Assert.AreEqual(typeof(CountBL), testCountBL.GetType());
        }
    // [TestMethod]
    //     public void IsInputWord_CapturedAsData_String()
    //     {
    //       CountBL testCountBL = new CountBL("Cathedral");
    //       string testArgument = "Cathedral" 

    //       Assert.AreEqual(false, testCountBL.word);
    //     }
  }
}
