﻿namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EaseCircularTest
    {
        #region In
        [TestMethod]
        public void In_InputInRange_ReturnsExpectedPoint()
        {
            Ease ease = new Circular();
            float x = 0.6f;

            Point expected = new Point(x, 0.2f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_InputInRange_ReturnsExpectedPoint()
        {
            Ease ease = new Circular();
            float y = 0.6f;

            Point expected = new Point(0.9165f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void In_OffsetOriginAndDestinationInputInRange_ReturnsExpectedPoint()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float x = 3.6f;

            Point expected = new Point(x, 3.2f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_OffsetOriginAndDestinationInputInRange_ReturnsExpectedPoint()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float y = 3.6f;

            Point expected = new Point(3.9165f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void In_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Circular();
            float x = -0.5f;

            Point expected = ease.Origin;
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Circular();
            float y = -0.6f;

            Point expected = ease.Origin;
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void In_OffsetOriginAndDestinationInputBelowRange_ReturnsOrigin()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float x = 1.1f;

            Point expected = ease.Origin;
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_OffsetOriginAndDestinationInputBelowRange_ReturnsOrigin()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float y = 1.1f;

            Point expected = ease.Origin;
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void In_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Circular();
            float x = 1.5f;

            Point expected = ease.Destination;
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Circular();
            float y = 1.6f;

            Point expected = ease.Destination;
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void In_OffsetOriginAndDestinationInputAboveRange_ReturnsDestination()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float x = 11.1f;

            Point expected = ease.Destination;
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_OffsetOriginAndDestinationInputAboveRange_ReturnsDestination()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float y = 6.1f;

            Point expected = ease.Destination;
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_InputInRange_ReturnsExpectedPoint()
        {
            Ease ease = new Circular();
            float x = 0.6f;

            Point expected = new Point(x, 0.9165f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_InputInRange_ReturnsExpectedPoint()
        {
            Ease ease = new Circular();
            float y = 0.6f;

            Point expected = new Point(0.2f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void Out_OffsetOriginAndDestinationInputInRange_ReturnsExpectedPoint()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float x = 3.6f;

            Point expected = new Point(x, 3.9165f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_OffsetOriginAndDestinationInputInRange_ReturnsExpectedPoint()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float y = 3.6f;

            Point expected = new Point(3.2f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void Out_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Circular();
            float x = -0.5f;

            Point expected = ease.Origin;
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Circular();
            float y = -0.6f;

            Point expected = ease.Origin;
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void Out_OffsetOriginAndDestinationInputBelowRange_ReturnsOrigin()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float x = 1.1f;

            Point expected = ease.Origin;
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_OffsetOriginAndDestinationInputBelowRange_ReturnsOrigin()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float y = 1.1f;

            Point expected = ease.Origin;
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void Out_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Circular();
            float x = 1.5f;

            Point expected = ease.Destination;
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Circular();
            float y = 1.6f;

            Point expected = ease.Destination;
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void Out_OffsetOriginAndDestinationInputAboveRange_ReturnsDestination()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float x = 11.1f;

            Point expected = ease.Destination;
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_OffsetOriginAndDestinationInputAboveRange_ReturnsDestination()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float y = 6.1f;

            Point expected = ease.Destination;
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_InputInRange_ReturnsExpectedPoint()
        {
            Ease ease = new Circular();
            float x = 0.6f;

            Point expected = new Point(x, 0.8f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_InputInRange_ReturnsExpectedPoint()
        {
            Ease ease = new Circular();
            float y = 0.6f;

            Point expected = new Point(0.5101f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOut_OffsetOriginAndDestinationInputInRange_ReturnsExpectedPoint()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float x = 3.6f;

            Point expected = new Point(x, 3.8f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_OffsetOriginAndDestinationInputInRange_ReturnsExpectedPoint()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float y = 3.6f;

            Point expected = new Point(3.5101f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOut_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Circular();
            float x = -0.5f;

            Point expected = ease.Origin;
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Circular();
            float y = -0.6f;

            Point expected = ease.Origin;
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOut_OffsetOriginAndDestinationInputBelowRange_ReturnsOrigin()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float x = 1.1f;

            Point expected = ease.Origin;
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_OffsetOriginAndDestinationInputBelowRange_ReturnsOrigin()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float y = 1.1f;

            Point expected = ease.Origin;
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOut_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Circular();
            float x = 1.5f;

            Point expected = ease.Destination;
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Circular();
            float y = 1.6f;

            Point expected = ease.Destination;
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOut_OffsetOriginAndDestinationInputAboveRange_ReturnsDestination()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float x = 11.1f;

            Point expected = ease.Destination;
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_OffsetOriginAndDestinationInputAboveRange_ReturnsDestination()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Circular(origin, destination);
            float y = 6.1f;

            Point expected = ease.Destination;
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion
    }
}
