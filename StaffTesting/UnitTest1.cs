﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaffTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StaffContactShouldNotDuplicated()
        {
            AddStaffInfoTest LTO = new AddStaffInfoTest();

            string StaffContactNo = "0174511231";

            bool result = LTO.StaffContactIsDuplicated(StaffContactNo);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void StaffICNoShouldNotDuplicated()
        {
            try
            {
                AddStaffInfoTest LTO = new AddStaffInfoTest();

                string StaffICNo = "931101075665";

                bool result = LTO.ICIsDuplicated(StaffICNo);

                Assert.AreEqual(true, result);

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

        }
    }
}
