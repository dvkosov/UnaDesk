using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnaDesk.GeometryLibrary.Geometry2D.Triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaDesk.GeometryLibrary.Geometry2D.Triangle.Tests
{
    [TestClass()]
    public class TriangleTests
    {

        [TestMethod()]
        public void Obtuse()
        {
            var tngl1 = new Triangle(new Element(1), new Element(2), new Element(3));
            Assert.IsTrue(tngl1.OneFastMethod() == AngledType.Obtuse);
        }

        [TestMethod()]
        public void NotObtuse()
        {
            var tngl1 = new Triangle(new Element(3), new Element(3), new Element(3));
            Assert.IsFalse(tngl1.OneFastMethod() == AngledType.Obtuse);
        }

        [TestMethod()]
        public void Rectangular()
        {
            var tngl1 = new Triangle(new Element(3), new Element(4), new Element(5));
            Assert.IsTrue(tngl1.OneFastMethod() == AngledType.Rectangular);
        }

        [TestMethod()]
        public void NotRectangular()
        {
            var tngl1 = new Triangle(new Element(2), new Element(3), new Element(4));
            Assert.IsFalse(tngl1.OneFastMethod() == AngledType.Rectangular);
        }

        [TestMethod()]
        public void AcuteAngled()
        {
            var tngl1 = new Triangle(new Element(3), new Element(3), new Element(4));
            Assert.IsTrue(tngl1.OneFastMethod() == AngledType.AcuteAngled);
        }

        [TestMethod()]
        public void NotAcuteAngled()
        {
            var tngl1 = new Triangle(new Element(2), new Element(2), new Element(9));
            Assert.IsFalse(tngl1.OneFastMethod() == AngledType.AcuteAngled);
        }
    }
}