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
        [TestMethod]
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
        [TestMethod]
        public void Test_019_SwapCol()
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
                b = a.SwapCol(from, to);
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка обмена столбцов: {e.Message}");
            }
        }
        [TestMethod]
        public void Test_020_SwapColWrongFrom()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 6;
            uint to = 3;
            Matrix a = new Matrix(bodyA);
            //act            
            try
            {
                Matrix b = a.SwapCol(from, to);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongColNumberForSwapFrom))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_021_SwapColWrongTo()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 5;
            Matrix a = new Matrix(bodyA);
            //act            
            try
            {
                Matrix b = a.SwapCol(from, to);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongColNumberForSwapTo))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_022_CheckSwapCol1()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            double[,] bodyB = { { 1, 4, 3, 2, 5 }, { 6, 9, 8, 7, 10 }, { 11, 14, 13, 12, 15 }, { 16, 19, 18, 17, 20 }, { 21, 24, 23, 22, 25 } };
            uint from = 1;
            uint to = 3;
            Matrix a = new Matrix(bodyA);
            Matrix b = new Matrix(bodyB);
            //act            
            b = b.SwapCol(from, to);
            //assert
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_023_CheckSwapCol2()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            double[,] bodyB = { { 1, 4, 3, 2, 5 }, { 6, 9, 8, 7, 10 }, { 11, 14, 13, 12, 15 }, { 16, 19, 18, 17, 20 }, { 21, 24, 23, 22, 25 } };
            uint from = 3;
            uint to = 1;
            Matrix a = new Matrix(bodyA);
            Matrix b = new Matrix(bodyB);
            //act            
            b = b.SwapCol(from, to);
            //assert
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_024_CheckSwapCol3()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 3;
            uint to = 3;
            Matrix a = new Matrix(bodyA);
            //assert
            Assert.IsTrue(a == a.SwapCol(from, to));
        }
        [TestMethod]
        public void Test_025_MergeRow()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 3;
            double mult = 2;
            Matrix a = new Matrix(bodyA);
            //act
            Matrix b = null;
            try
            {
                b = a.MergeRow(from, to, mult);
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка слияния строк: {e.Message}");
            }
        }
        [TestMethod]
        public void Test_026_MergeRowWrongFrom()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 6;
            uint to = 3;
            double mult = 2;
            Matrix a = new Matrix(bodyA);
            //act            
            try
            {
                Matrix b = a.MergeRow(from, to, mult);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongRowNumberForMergeFrom))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_027_SwapRowWrongTo()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 5;
            double mult = 2;
            Matrix a = new Matrix(bodyA);
            //act            
            try
            {
                Matrix b = a.MergeRow(from, to, mult);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongRowNumberForMergeTo))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_028_CheckMergeRow1()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            double[,] bodyB = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 28, 31, 34, 37, 40 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 3;
            double mult = 2;
            Matrix a = new Matrix(bodyA);
            Matrix b = new Matrix(bodyB);
            //act            
            a = a.MergeRow(from, to, mult);
            //assert
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_029_CheckMergeRow2()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            double[,] bodyB = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { -2, -4, -6, -8, -10 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 3;
            double mult = -3;
            Matrix a = new Matrix(bodyA);
            Matrix b = new Matrix(bodyB);
            //act            
            a = a.MergeRow(from, to, mult);
            //assert
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_030_MergeCol()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 3;
            double mult = 2;
            Matrix a = new Matrix(bodyA);
            //act
            Matrix b = null;
            try
            {
                b = a.MergeCol(from, to, mult);
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка слияния строк: {e.Message}");
            }
        }
        [TestMethod]
        public void Test_031_MergeColWrongFrom()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 6;
            uint to = 3;
            double mult = 2;
            Matrix a = new Matrix(bodyA);
            //act            
            try
            {
                Matrix b = a.MergeCol(from, to, mult);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongColNumberForMergeFrom))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_032_SwapColWrongTo()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint from = 1;
            uint to = 5;
            double mult = 2;
            Matrix a = new Matrix(bodyA);
            //act            
            try
            {
                Matrix b = a.MergeCol(from, to, mult);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongColNumberForMergeTo))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_033_CheckMergeCol1()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            double[,] bodyB = { { 1, 2, 3, 8, 5 }, { 6, 7, 8, 23, 10 }, { 11, 12, 13, 38, 15 }, { 16, 17, 18, 53, 20 }, { 21, 22, 23, 68, 25 } };
            uint from = 1;
            uint to = 3;
            double mult = 2;
            Matrix a = new Matrix(bodyA);
            Matrix b = new Matrix(bodyB);
            //act            
            a = a.MergeCol(from, to, mult);
            //assert
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_034_CheckMergeCol2()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            double[,] bodyB = { { 1, 2, 3, -2, 5 }, { 6, 7, 8, -12, 10 }, { 11, 12, 13, -22, 15 }, { 16, 17, 18, -32, 20 }, { 21, 22, 23, -42, 25 } };
            uint from = 1;
            uint to = 3;
            double mult = -3;
            Matrix a = new Matrix(bodyA);
            Matrix b = new Matrix(bodyB);
            //act            
            a = a.MergeCol(from, to, mult);
            //assert
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_035_Submatrix()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint rowFrom = 1;
            uint rowTo = 3;
            uint colFrom = 1;
            uint colTo = 3;
            Matrix a = new Matrix(bodyA);
            Matrix b = null;
            //act
            try
            {
                b = a.SubMatrix(rowFrom, rowTo, colFrom, colTo);
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка получения подматрицы: {e.Message}");
            }
            Assert.IsNotNull(b);
        }
        [TestMethod]
        public void Test_036_SubmatrixWrongRowFrom()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint rowFrom = 10;
            uint rowTo = 3;
            uint colFrom = 1;
            uint colTo = 3;
            Matrix a = new Matrix(bodyA);            
            //act
            try
            {
                a = a.SubMatrix(rowFrom, rowTo, colFrom, colTo);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongSubmatrixRowNumberFrom))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_037_SubmatrixWrongRowTo()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint rowFrom = 1;
            uint rowTo = 30;
            uint colFrom = 1;
            uint colTo = 3;
            Matrix a = new Matrix(bodyA);
            //act
            try
            {
                a = a.SubMatrix(rowFrom, rowTo, colFrom, colTo);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongSubmatrixRowNumberTo))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_038_SubmatrixWrongColFrom()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint rowFrom = 1;
            uint rowTo = 3;
            uint colFrom = 10;
            uint colTo = 3;
            Matrix a = new Matrix(bodyA);
            //act
            try
            {
                a = a.SubMatrix(rowFrom, rowTo, colFrom, colTo);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongSubmatrixColNumberFrom))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_039_SubmatrixWrongColTo()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint rowFrom = 1;
            uint rowTo = 3;
            uint colFrom = 1;
            uint colTo = 30;
            Matrix a = new Matrix(bodyA);
            //act
            try
            {
                a = a.SubMatrix(rowFrom, rowTo, colFrom, colTo);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongSubmatrixColNumberTo))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_040_CheckSubmatrix1()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint rowFrom = 1;
            uint rowTo = 3;
            uint colFrom = 1;
            uint colTo = 3;
            Matrix a = new Matrix(bodyA);
            double[,] bodyB = { { 7, 8, 9 }, { 12, 13, 14 }, { 17, 18, 19 } };
            Matrix b = new Matrix(bodyB);
            //act
            a = a.SubMatrix(rowFrom, rowTo, colFrom, colTo);
            //assert            
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_041_CheckSubmatrix2()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint rowFrom = 3;
            uint rowTo = 1;
            uint colFrom = 1;
            uint colTo = 3;
            Matrix a = new Matrix(bodyA);
            double[,] bodyB = { { 17, 18, 19 }, { 12, 13, 14 }, { 7, 8, 9 } };
            Matrix b = new Matrix(bodyB);
            //act
            a = a.SubMatrix(rowFrom, rowTo, colFrom, colTo);
            //assert            
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_042_CheckSubmatrix3()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            uint rowFrom = 1;
            uint rowTo = 3;
            uint colFrom = 3;
            uint colTo = 1;
            Matrix a = new Matrix(bodyA);
            double[,] bodyB = { { 9, 8, 7 }, { 14, 13, 12 }, { 19, 18, 17 } };
            
            Matrix b = new Matrix(bodyB);
            //act
            a = a.SubMatrix(rowFrom, rowTo, colFrom, colTo);
            //assert            
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_043_Abs() 
        {
            //arrange
            double[,] bodyA = { { 1, -2 }, { -3, 4 } };
            Matrix a = new Matrix(bodyA);
            Matrix b = null;
            //act
            try
            {
                b = a.Abs();
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка получения абсолютной величины: {e.Message}");
            }
            Assert.IsNotNull(b);
        }
        [TestMethod]
        public void Test_044_AbsCheck()
        {
            //arrange
            double[,] bodyA = { { 1, -2 }, { -3, 4 } };
            double[,] bodyB = { { 1, 2 }, { 3, 4 } };
            Matrix a = new Matrix(bodyA);
            Matrix b = new Matrix(bodyB);
            //assert            
            Assert.IsTrue(b == a.Abs());
        }
        [TestMethod]
        public void Test_045_RowSum()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3 }, { 4, 5, 6 } };            
            Matrix a = new Matrix(bodyA);
            uint rowNum = 0;
            //act
            try
            {
                double d = a.RowSum(rowNum);
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка получения суммы строки: {e.Message}");
            }            
        }
        [TestMethod]
        public void Test_046_RowSumWrongRowNum()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3 }, { 4, 5, 6 } };
            Matrix a = new Matrix(bodyA);
            uint rowNum = 3;
            //act
            try
            {
                double d = a.RowSum(rowNum);
            }            
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WronRowNumberForRowSum))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_047_RowSumCheck()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3 }, { 4, 5, 6 } };
            Matrix a = new Matrix(bodyA);
            uint rowNum = 0;
            double d = 6;           
            //assert            
            Assert.IsTrue(d == a.RowSum(rowNum));
        }
        [TestMethod]
        public void Test_048_ColSum()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3 }, { 4, 5, 6 } };
            Matrix a = new Matrix(bodyA);
            uint colNum = 0;
            //act
            try
            {
                double d = a.ColSum(colNum);
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка получения суммы столбца: {e.Message}");
            }
        }
        [TestMethod]
        public void Test_049_ColSumWrongRowNum()
        {
            //arrange
            double[,] bodyA = { { 1, 2, 3 }, { 4, 5, 6 } };
            Matrix a = new Matrix(bodyA);
            uint colNum = 3;
            //act
            try
            {
                double d = a.ColSum(colNum);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WronColNumberForColSum))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_050_ColSumCheck()
        {
            //arrange
            double[,] bodyA = { { 1, 2 }, { 3, 4 }, {5, 6 } };
            Matrix a = new Matrix(bodyA);
            uint colNum = 0;
            double d = 9;
            //assert            
            Assert.IsTrue(d == a.ColSum(colNum));
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

