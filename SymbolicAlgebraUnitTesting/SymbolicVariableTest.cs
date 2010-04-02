﻿using SymbolicAlgebra;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SymbolicAlgebraUnitTesting
{
    
    
    /// <summary>
    ///This is a test class for SymbolicVariableTest and is intended
    ///to contain all SymbolicVariableTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SymbolicVariableTest
    {

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        #region Testing variables
        SymbolicVariable x = new SymbolicVariable("x");

        SymbolicVariable y = new SymbolicVariable("y");

        SymbolicVariable z = new SymbolicVariable("z");

        SymbolicVariable vv = new SymbolicVariable("vv");

        SymbolicVariable vs = new SymbolicVariable("vs");

        SymbolicVariable Zero = new SymbolicVariable("0");
        SymbolicVariable One = new SymbolicVariable("1");
        SymbolicVariable Two = new SymbolicVariable("2");
        SymbolicVariable Three = new SymbolicVariable("3");
        SymbolicVariable Four = new SymbolicVariable("4");
        SymbolicVariable Five = new SymbolicVariable("5");
        SymbolicVariable Six = new SymbolicVariable("6");
        SymbolicVariable Seven = new SymbolicVariable("7");
        SymbolicVariable Eight = new SymbolicVariable("8");
        SymbolicVariable Nine = new SymbolicVariable("9");
        SymbolicVariable Ten = new SymbolicVariable("10");

        SymbolicVariable Eleven = new SymbolicVariable("11");

        #endregion

        /// <summary>
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void OperationsTest()
        {


            var pr = (Four / Two) * y * y * y / x;   //2*y^3/x

            Assert.AreEqual(pr.ToString(), "2*y^3/x");

            pr = pr - (Three * y * y / x);          // 2*y^3/x - 3*y^2/x

            Assert.AreEqual(pr.ToString(), "2*y^3/x-3*y^2/x");


            var rr = pr / (2 * y);                 // y^2/x - 1.5*y/x

            Assert.AreEqual(rr.ToString(), "y^2/x-1.5*y/x");


            var tr = rr * (x * x);                //  y^2*x - 1.5*y*x
            Assert.AreEqual(tr.ToString(), "y^2*x-1.5*y*x");


            var mx = tr + (x * y);                    // y^2*x - 0.5*y*x
            Assert.AreEqual(mx.ToString(), "y^2*x-0.5*y*x");


            mx = mx + (y * y * x);                    // 2*y^2*x - 0.5*y*x
            Assert.AreEqual(mx.ToString(), "2*y^2*x-0.5*y*x");


            var nx = tr - (y * x);                    // y^2*x - 2.5*y*x
            Assert.AreEqual(nx.ToString(), "y^2*x-2.5*y*x");


            var r = Two * (y * x * y);                // 2*y^2*x
            Assert.AreEqual(r.ToString(), "2*y^2*x");


            nx = nx - r;                              // -1*y^2*x - 2.5*y*x
            Assert.AreEqual(nx.ToString(), "-y^2*x-2.5*y*x");


            var tx = mx + nx;                         // y^2*x-3*y*x
            Assert.AreEqual(tx.ToString(), "y^2*x-3*y*x");


            var ll = Three / y;

            Assert.AreEqual(ll.ToString(), "3/y");


            ll *= x;
            Assert.AreEqual(ll.ToString(), "3/y*x");


            var h = (3 * x + 2 * y) / (2 * x);
            Assert.AreEqual(h.ToString(), "1.5+y/x");


            var a = (x + y) * (x + y);

            Assert.AreEqual(a.ToString(), "x^2+2*y*x+y^2");

            a = (x + y) * (x - y);

            Assert.AreEqual(a.ToString(), "x^2-y^2");

        }

        [TestMethod]
        public void MultiplyOneByTerms()
        {
            var term = x - y + z;
            var rRight = term * One;

            Assert.AreEqual(rRight.ToString(), "x-y+z");

            var rleft = One * term;
            Assert.AreEqual(rleft.ToString(), "x-y+z");
        }

        [TestMethod]
        public void DivisionTest()
        {

            var a = x + y;
            var b = x - y;

            // dividing by two terms
            var r = a / b;

            Assert.AreEqual(r.ToString(), "x+y/(x-y)");

            // dividing by one term
            var rx = a / x;
            var ry = a / y;

            Assert.AreEqual(rx.ToString(), "1+y/x");

            Assert.AreEqual(ry.ToString(), "x/y+1");


            // dividing one term by three terms

            var r3 = x * y / (x - y + z);

            Assert.AreEqual(r3.ToString(), "x*y/(x-y+z)");

        }



        [TestMethod]
        public void PowerTest()
        {
            var r = x.Power(5);
            Assert.AreEqual(r.ToString(), "x^5");

            var co = x - y;
            var ee = co.Power(3);
            Assert.AreEqual(ee.ToString(), "x^3-3*y*x^2+3*y^2*x-y^3");

            var re = ee / x.Power(3);

            Assert.AreEqual(re.ToString(), "1-3*y/x+3*y^2/x^2-y^3/x^3");

        }
    }
}