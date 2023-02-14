using msvMatrix;
namespace msvMatrix_Test
{
    [TestClass]
    public class UnitTest_Functions_2
    {
        [TestMethod]
        public void Test_001_MoveRow()
        {
            //arrange
            double[,] body = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 3;
            Matrix a = new Matrix(body);
            Matrix b = null;
            //act
            try
            {
                b = a.MoveRow(from, to);
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка перемещения строки: {e.Message}");
            }
            Assert.IsNotNull(b);
        }
        [TestMethod]
        public void Test_002_MoveRowWrongFrom()
        {
            //arrange
            double[,] body = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 5;
            uint to = 3;
            Matrix a = new Matrix(body);
            //act
            try
            {
                Matrix b = a.MoveRow(from, to);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongRowNumberForMovingFrom))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_003_MoveRowWrongTo()
        {
            //arrange
            double[,] body = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 7;
            Matrix a = new Matrix(body);
            //act
            try
            {
                Matrix b = a.MoveRow(from, to);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongRowNumberForMovingTo))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_004_CheckMoveRow1()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            double[,] bodyB = { { 1, 2, 3, 4, 5 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 6, 7, 8, 9, 10 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 3;
            Matrix a = new Matrix(bodyA);
            Matrix b = new Matrix(bodyB);
            //act
            a = a.MoveRow(from, to);
            //assert            
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_005_CheckMoveRow2()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            double[,] bodyB = { { 1, 2, 3, 4, 5 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 6, 7, 8, 9, 10 }, { 21, 22, 23, 24, 25 } };
            uint from = 3;
            uint to = 1;
            Matrix a = new Matrix(bodyA);
            Matrix b = new Matrix(bodyB);
            //act
            b = b.MoveRow(from, to);
            //assert            
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_006_CheckMoveRow3()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 3;
            uint to = 3;
            Matrix a = new Matrix(bodyA);
            //assert            
            Assert.IsTrue(a == a.MoveRow(from, to));
        }






        public void Test_007_MoveCol()
        {
            //arrange
            double[,] body = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 3;
            Matrix a = new Matrix(body);
            Matrix b = null;
            //act
            try
            {
                b = a.MoveCol(from, to);
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка перемещения столбца: {e.Message}");
            }
            Assert.IsNotNull(b);
        }
        [TestMethod]
        public void Test_008_MoveColWrongFrom()
        {
            //arrange
            double[,] body = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 5;
            uint to = 3;
            Matrix a = new Matrix(body);
            //act
            try
            {
                Matrix b = a.MoveCol(from, to);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongColNumberForMovingFrom))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_009_MoveColWrongTo()
        {
            //arrange
            double[,] body = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 7;
            Matrix a = new Matrix(body);
            //act
            try
            {
                Matrix b = a.MoveCol(from, to);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongColNumberForMovingTo))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_010_CheckMoveCol1()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            double[,] bodyB = { { 1, 3, 4, 2, 5 }, { 6, 8, 9, 7, 10 }, { 11, 13, 14, 12, 15 }, { 16, 18, 19, 17, 20 }, { 21, 23, 24, 22, 25 } };
            uint from = 1;
            uint to = 3;
            Matrix a = new Matrix(bodyA);
            Matrix b = new Matrix(bodyB);
            //act
            a = a.MoveCol(from, to);
            //assert            
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_011_CheckMoveCol2()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            double[,] bodyB = { { 1, 3, 4, 2, 5 }, { 6, 8, 9, 7, 10 }, { 11, 13, 14, 12, 15 }, { 16, 18, 19, 17, 20 }, { 21, 23, 24, 22, 25 } };
            uint from = 3;
            uint to = 1;
            Matrix a = new Matrix(bodyA);
            Matrix b = new Matrix(bodyB);
            //act
            b = b.MoveCol(from, to);
            //assert            
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_012_CheckMoveCol3()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };            
            uint from = 3;
            uint to = 3;
            Matrix a = new Matrix(bodyA);                        
            //assert            
            Assert.IsTrue(a == a.MoveCol(from, to));
        }
        [TestMethod]
        public void Test_013_SwapRow()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 3;
            Matrix a = new Matrix(bodyA);
            //act
            Matrix b = null;
            try
            {
                b = a.SwapRow(from, to);
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка обмена строк: {e.Message}");
            }
        }
        [TestMethod]
        public void Test_014_SwapRowWrongFrom()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 6;
            uint to = 3;
            Matrix a = new Matrix(bodyA);
            //act            
            try
            {
                Matrix b = a.SwapRow(from, to);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongRowNumberForSwapFrom)) 
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_015_SwapRowWrongTo()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 5;
            Matrix a = new Matrix(bodyA);
            //act            
            try
            {
                Matrix b = a.SwapRow(from, to);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongRowNumberForSwapTo))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_016_CheckSwapRow1()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            double[,] bodyB = { { 1, 2, 3, 4, 5 }, { 16, 17, 18, 19, 20 }, { 11, 12, 13, 14, 15 }, { 6, 7, 8, 9, 10 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 3;
            Matrix a = new Matrix(bodyA);
            Matrix b = new Matrix(bodyB);
            //act            
            b = b.SwapRow(from, to);
            //assert
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_017_CheckSwapRow2()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            double[,] bodyB = { { 1, 2, 3, 4, 5 }, { 16, 17, 18, 19, 20 }, { 11, 12, 13, 14, 15 }, { 6, 7, 8, 9, 10 }, { 21, 22, 23, 24, 25 } };
            uint from = 3;
            uint to = 1;
            Matrix a = new Matrix(bodyA);
            Matrix b = new Matrix(bodyB);
            //act            
            b = b.SwapRow(from, to);
            //assert
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_018_CheckSwapRow3()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };            
            uint from = 3;
            uint to = 3;
            Matrix a = new Matrix(bodyA);            
            //assert
            Assert.IsTrue(a == a.SwapRow(from, to));
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

