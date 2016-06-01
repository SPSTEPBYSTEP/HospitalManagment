using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void When_CalculateTotalCost_ResultShouldBeMore()
        {
            // prepare
            double expected = 267;
            String cost = "30";
            //var tax = 8.9;

            // action
            var actual = HospitalInformation.Appointment.costcal(cost);

            // assert
            Assert.That(expected, Is.EqualTo(267));
        }
    }
}
