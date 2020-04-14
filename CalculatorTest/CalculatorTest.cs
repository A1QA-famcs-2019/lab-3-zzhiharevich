using System;
using NUnit.Framework;
using Calculator.Pages;

namespace CalculatorTest
{
    using Calculator;
    using Calculator.Resources;
    using System.Diagnostics;
    using System.IO;

    [TestFixture]
    class CalculatorTest
    {
        public static void KillAllCalculators()
        {
            string calculatorExeFileName = Path.GetFileNameWithoutExtension(Resource.PathToCalculatorApp);
            Process[] processList = Process.GetProcessesByName(calculatorExeFileName);
            
            foreach (Process process in processList)
            {
                foreach (ProcessModule module in process.Modules)
                {
                    if (module.FileName.Equals(Resource.PathToCalculatorApp))
                    {
                        process.Kill();
                        break;
                    }
                }
            }
        }

        [SetUp]
        public static void SetUp()
        {
            KillAllCalculators();
        }

        [TearDown]
        public static void TearDown()
        {
            CalculatorApp.GetInstance.Close();
            KillAllCalculators();
        }

        [Test]
        public static void Test()
        {
            int expectedResult = 1030;
            Assert.DoesNotThrow(CalculatorApp.GetInstance.Launch);
            ButtonsPage mainWindow = new ButtonsPage(CalculatorApp.GetInstance.GetWindow());
            mainWindow.EnterNumber("12");
            mainWindow.ButtonAdd.Click();
            mainWindow.EnterNumber("999");
            mainWindow.ButtonGetResult.Click();
            mainWindow.MemoryButtonAdd.Click();

            mainWindow.EnterNumber("19");
            mainWindow.ButtonAdd.Click();
            mainWindow.MemoryButtonRecall.Click();
            mainWindow.ButtonGetResult.Click();

            string resultValue = mainWindow.LabelResult.Text;
            int actualResult = Convert.ToInt32(resultValue);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
