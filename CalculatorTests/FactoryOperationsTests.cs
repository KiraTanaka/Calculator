﻿using System;
using NUnit.Framework;
using ConsoleCalculator;
using ConsoleCalculator.Factories;

namespace ConsoleCalculatorTests
{
    [TestFixture]
    public class FactoryOperationsTests
    {
        private TypeNumber firstNumber = new TypeNumber() { Number = 7f };
        private TypeNumber secondNumber = new TypeNumber() { Number = 3.5f };

        [Test]
        public void AdditionTest()
        {
            TypeNumber resultOfAddition = FactoryOperations.OperationSelection("+").Execute(firstNumber, secondNumber);

            Assert.AreEqual(10.5f,resultOfAddition.Number);
        }

        [Test]
        public void SubtractionTest()
        {
            TypeNumber resultOfSubtraction = FactoryOperations.OperationSelection("-").Execute(firstNumber, secondNumber);

            Assert.AreEqual(3.5f, resultOfSubtraction.Number);
        }

        [Test]
        public void MultiplicationTest()
        {
            TypeNumber resultOfMultiplication = FactoryOperations.OperationSelection("*").Execute(firstNumber, secondNumber);

            Assert.AreEqual(24.5f, resultOfMultiplication.Number);
        }

        [Test]
        public void DivisionTest()
        {
            TypeNumber resultOfDivision = FactoryOperations.OperationSelection("/").Execute(firstNumber, secondNumber);

            Assert.AreEqual(2, resultOfDivision.Number);
        }
    }
}
