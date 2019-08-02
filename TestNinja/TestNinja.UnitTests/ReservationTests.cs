using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test] //[MethodName]_[Scenario]_[ExpectedBehaviour]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            //arrange
            var reservation = new Reservation();
            //act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
            //Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnTrue()
        {
            var user = new User();
            //arrange
            var reservation = new Reservation { MadeBy = user };
            //act
            var result = reservation.CanBeCancelledBy(user);
            //assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
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
