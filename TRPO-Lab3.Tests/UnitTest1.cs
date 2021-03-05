using NUnit.Framework;

namespace TRPO_Lab3.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            TRPO_Lab3.Lib.Math_1 math_1 = new Lib.Math_1();
            double s = math_1.Formula(3, 5, 8);
            Assert.AreEqual(197.92,s, 0.01);
            
        }
        [Test]
        public void Test2()
        {
            TRPO_Lab3.Lib.Math_1 math_1 = new Lib.Math_1();
            double s = math_1.Formula(3, 5, 8);
            Assert.Throws<System.ArgumentException>(()=> {
                TRPO_Lab3.Lib.Math_1 math_1 = new Lib.Math_1();
                double s = math_1.Formula(-3, 5, 8);
            });
        }
    }
}