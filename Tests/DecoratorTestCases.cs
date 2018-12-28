using System;
using System.Diagnostics;
using DesignPatterns.Decorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class DecoratorTestCases
    {
        [TestMethod]
        public void CustomStringBuilderTest()
        {
            var cb = new CustomStringBuilder();

            cb.Append("The numbers are ")
                .Append("1, ")
                .Append("2, ")
                .Append("and 3");

            Assert.AreEqual("The numbers are 1, 2, and 3", cb.ToString());
        }

        [TestMethod]
        public void AdapterStringBuilderTest()
        {
            AdapterStringBuilder asb = "Hello ";
            asb += "World";

            Assert.AreEqual("Hello World", asb.ToString());
        }

        [TestMethod]
        public void MultipleInheritanceTest()
        {
            var dragon = new Dragon {Age = 123};
            var crawl = dragon.Crawl();
            var fly = dragon.Fly();
            
            Assert.AreEqual("Soaring in the sky with weight 123", fly);
            Assert.AreEqual("Crawling in the dirt with weight 123", crawl);
        }

        [TestMethod]
        public void DynamicDecoratorCompositionTest()
        {
            const float side = 1.23f;
            const double transparency = 0.5 * 100;
            
            var square = new Square(side);
            var squareText = $"A square with side {side}";
            var redSquare = new ColoredShape(square, "red");
            var redSquareText = $"{squareText} has the color red";
            var redHalfTransparentSquare = new TransparentShape(redSquare, 0.5f);
            var redHalfTransparentSquareText = $"{redSquareText} has {transparency}% transparency";

            Assert.AreEqual(squareText, square.AsString());
            Assert.AreEqual(redSquareText, redSquare.AsString());
            Assert.AreEqual(redHalfTransparentSquareText, redHalfTransparentSquare.AsString());
        }

        [TestMethod]
        public void ExercisesTest()
        {
            var dragon = new ExerciseDragon();
            Assert.AreEqual("flying", dragon.Fly());
            Assert.AreEqual("too young", dragon.Crawl());

            dragon.Age = 20;
            Assert.AreEqual("too old", dragon.Fly());
            Assert.AreEqual("crawling", dragon.Crawl());
        }
    }
}
