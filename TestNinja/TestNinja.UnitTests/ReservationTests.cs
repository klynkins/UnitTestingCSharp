using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //arrange
            var reservation = new Reservation();
            //act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_MadeByUser_ReturnsTrue()
        {
            var user = new User();
            //arrange
            var reservation = new Reservation { MadeBy = user };
            //act
            var result = reservation.CanBeCancelledBy(user);
            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUser_ReturnFalse()
        {
            //var user = new User();
            //arrange
            var reservation = new Reservation { MadeBy = new User() };
            //act
            var result = reservation.CanBeCancelledBy(new User());
            //assert
            Assert.IsFalse(result);
        }
    }
}
