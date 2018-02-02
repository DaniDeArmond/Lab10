using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab10.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void ValidateYesNoTest1()
        {
            string Word1 = "Y";
            Regex Pattern = new Regex("[YyNn]");

            StringAssert.Matches(Word1, Pattern);
        }
        [TestMethod()]
        public void ValidateYesNoTest2()
        {
            string Word2 = "N";
            Regex Pattern = new Regex("[YyNn]");

            StringAssert.Matches(Word2, Pattern);
        }
        [TestMethod()]
        public void ValidateYesNoTest3()
        {
            string Word3 = "U";
            Regex Pattern = new Regex("[YyNn]");

            StringAssert.Matches(Word3, Pattern);
        }
        [TestMethod()]
        public void ValidateYesNoTest4()
        {
            string Word4 = "1";
            Regex Pattern = new Regex("[YyNn]");

            StringAssert.Matches(Word4, Pattern);
        }
        [TestMethod()]
        public void ValidateInputTest1()
        {
            string Word5 = "1234";
            Regex Pattern = new Regex(@"^[A-z\ ]+$");
            StringAssert.Matches(Word5, Pattern);
        }
        [TestMethod()]
        public void ValidateInputTest2()
        {
            string Word6 = "Fancy letters";
            Regex Pattern = new Regex(@"^[A-z\ ]+$");
            StringAssert.Matches(Word6, Pattern);
        }
        [TestMethod()]
        public void ValidateInputTest3()
        {
            string Word7 = "Fancy letters 1234";
            Regex Pattern = new Regex(@"^[A-z\ ]+$");
            StringAssert.Matches(Word7, Pattern);
        }


    }
}