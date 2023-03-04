using msvMatrix;
using System.Security.Cryptography;

namespace msvMatrix_Test
{
    [TestClass]
    public class UnitTest_Functions_3
    {
        [TestMethod]
        public void Test_01_LNorm()
        {
            //arrange
            double[,] body = {{1, 2, 3}, {4, 5, 6}, { 7, 8, 9 } };
            Matrix a = new Matrix(body);
            //act
            try
            {
                double d = a.LNorm();
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка вычисления l-нормы: {e.Message}");
            }            
        }
        [TestMethod]
        public void Test_02_LNormCheck()
        {
            //arrange
            double[,] body = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Matrix a = new Matrix(body);
            double d = 18;                                    
            //assert
            Assert.AreEqual(d, a.LNorm());            
        }
        [TestMethod]
        public void Test_03_MNorm()
        {
            //arrange
            double[,] body = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Matrix a = new Matrix(body);
            //act
            try
            {
                double d = a.MNorm();
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка вычисления m-нормы: {e.Message}");
            }
        }
        [TestMethod]
        public void Test_04_MNormCheck()
        {
            //arrange
            double[,] body = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Matrix a = new Matrix(body);
            double d = 24;
            //assert
            Assert.AreEqual(d, a.MNorm());
        }
        [TestMethod]
        public void Test_05_KNorm()
        {
            //arrange
            double[,] body = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Matrix a = new Matrix(body);
            //act
            try
            {
                double d = a.KNorm();
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка вычисления k-нормы: {e.Message}");
            }
        }
        [TestMethod]
        public void Test_06_KNormCheck()
        {
            //arrange
            double[,] body = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Matrix a = new Matrix(body);
            double d = Math.Sqrt(285);
            //assert
            Assert.AreEqual(d, a.KNorm());
        }
        [TestMethod]
        public void Test_07_Rank()
        {
            //arrange
            double[,] body = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Matrix a = new Matrix(body);
            //act
            try
            {
                uint r = a.Rank();
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка вычисления ранга: {e.Message}");
            }
        }
        [TestMethod]
        public void Test_08_RankCheck()
        {
            //arrange
            double[,] body = { { 2, -4, 3, 1, 0 }, { 1, -2, 1, -4, 2 }, { 0, 1, -1, 3, 1 }, { 4, -7, 4, -4, 5 } };
            Matrix a = new Matrix(body);
            uint r = 3;
            //assert
            Assert.AreEqual(r, a.Rank());
        }
        [TestMethod]
        public void Test_09_Defect()
        {
            //arrange
            double[,] body = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Matrix a = new Matrix(body);
            //act
            try
            {
                uint r = a.Defect();
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка вычисления дефекта: {e.Message}");
            }
        }
        [TestMethod]
        public void Test_10_DefectCheck()
        {
            //arrange
            double[,] body = { { 2, -4, 3, 1, 0 }, { 1, -2, 1, -4, 2 }, { 0, 1, -1, 3, 1 }, { 4, -7, 4, -4, 5 } };
            Matrix a = new Matrix(body);
            uint r = 1;
            //assert
            Assert.AreEqual(r, a.Defect());
        }
        /*               
         [TestMethod]
         public void Test_()
         {
             //arrange

             //act

             //assert
             Assert.IsTrue(true);
         }
         */
    }
}

