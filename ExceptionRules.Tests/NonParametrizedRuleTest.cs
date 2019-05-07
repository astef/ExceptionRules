using System;
using System.Reflection;
using ExceptionRules.Tests.TestExceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace ExceptionRules.Tests
{
    [TestClass]
    public class NonParametrizedRuleTest
    {
        [DataRow(typeof(AllCtorsException))]
        [DataRow(typeof(DerivedAllCtorsException))]
        [DataRow(typeof(OnlyFullCtorException))]
        [DataTestMethod]
        public void CreateAfterEmptySetup(Type exceptionType)
        {
            // arrange
            var npRule = RuleFor(exceptionType);

            // act
            var exception = npRule.Create();

            // assert
            var ctorMock = (IExceptionCtorMock)exception;
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType(exceptionType);
            ctorMock.CtorStatus.ShouldBe(ExceptionCtorStatus.EmptySetup);
        }

        [DataRow(typeof(AllCtorsException), "")]
        [DataRow(typeof(OnlyFullCtorException), " text\n\r\nwith \u23F0    spaces. ")]
        [DataTestMethod]
        public void CreateAfterMessageSetup(Type exceptionType, string message)
        {
            // arrange
            var npRule = RuleFor(exceptionType).SetMessage(message);

            // act
            var exception = npRule.Create();

            // assert
            var ctorMock = (IExceptionCtorMock)exception;
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType(exceptionType);
            exception.Message.ShouldBe(message);
            ctorMock.CtorStatus.ShouldBe(ExceptionCtorStatus.MessageSetup);
        }

        [DataRow(typeof(AllCtorsException), "")]
        [DataRow(typeof(AllCtorsException), null)]
        [DataRow(typeof(OnlyFullCtorException), "1")]
        [DataRow(typeof(OnlyFullCtorException), null)]
        [DataTestMethod]
        public void CreateAfterFullSetup(Type exceptionType, string message)
        {
            // arrange
            var npRule = RuleFor(exceptionType);
            if (message != null)
                npRule = npRule.SetMessage(message);
            var inner = new InvalidCastException();

            // act
            var exception = npRule.Create(inner);

            // assert
            var ctorMock = (IExceptionCtorMock)exception;
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType(exceptionType);
            exception.InnerException.ShouldBe(inner);
            if (message != null)
                exception.Message.ShouldBe(message);
            ctorMock.CtorStatus.ShouldBe(ExceptionCtorStatus.FullSetup);
        }

        [DataRow(typeof(AllCtorsException))]
        [DataRow(typeof(DerivedAllCtorsException))]
        [DataRow(typeof(OnlyFullCtorException))]
        [DataTestMethod]
        public void ThrowAfterEmptySetup(Type exceptionType)
        {
            // arrange
            var npRule = RuleFor(exceptionType);

            // act
            Action exceptionThrow = () => npRule.Throw();

            // assert
            var exception = (IExceptionCtorMock)exceptionThrow.ShouldThrow(exceptionType);
            exception.CtorStatus.ShouldBe(ExceptionCtorStatus.EmptySetup);
            exception.ShouldBeOfType(exceptionType);
        }

        private static Rule RuleFor(Type exceptionType)
        {
            return (Rule)typeof(RuleApi)
                .GetMethod(nameof(RuleApi.For), BindingFlags.Static | BindingFlags.Public)
                .MakeGenericMethod(exceptionType)
                .Invoke(null, null);
        }
    }
}
