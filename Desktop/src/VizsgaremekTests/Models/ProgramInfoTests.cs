﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vizsgaremek.Models;

namespace Vizsgaremek.Models.Tests
{
    [TestClass()]
    public class ProgramInfoTests
    {
        [TestMethod()]
        public void ProgramInfoTestVersion()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            Version expected = new Version(0, 0, 3, 0);

            // act
            Version actual = programInfo.Version;

            // assert
            Assert.AreEqual(expected, actual, "Version is not 0.0.3.0");
        }

        [TestMethod()]
        public void ProgramInfoTestCompany()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = "Vasvári";

            // act
            string actual = programInfo.Company;
            // assert
            Assert.AreEqual(expected, actual, "Company is not Vasvári");
        }

        [TestMethod()]
        public void ProgramInfoTestDescription()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = "Működő raktárkezelő program";

            // act
            string actual = programInfo.Description;
            // assert
            Assert.AreEqual(expected, actual, "Description is not Működő raktárkezelő program");
        }

        [TestMethod()]
        public void ProgramInfoTestTitle()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = "Vizsgaremek";

            // act
            string actual = programInfo.Title;
            // assert
            Assert.AreEqual(expected, actual, "Description is not Vizsgaremek");
        }

        [TestMethod()]
        public void ProgramInfoTestAuthor()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = "Dóczi Dominik (doczidominik)";

            // act
            string actual = programInfo.Authors;
            // assert
            Assert.AreEqual(expected, actual, "Description is not Dóczi Dominik");
        }

    }
}