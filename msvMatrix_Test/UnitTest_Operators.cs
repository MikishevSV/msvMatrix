using msvMatrix;
namespace msvMatrix_Test
{
    [TestClass]
    public class UnitTest_Operators
    {
        [TestMethod]
        public void Test_001_EqualityOfEquals()
        {
            //arrange
            uint row = 3;
            uint col = 4;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //act
            Matrix a1 = new Matrix(row, col, body);
            Matrix a2 = new Matrix(row, col, body);

            //assert
            Assert.IsTrue(a1 == a2);
        }
        [TestMethod]
        public void Test_002_EqualityOfNonEquals_Row()
        {
            //arrange
            uint row1 = 2;
            uint row2 = 3;
            uint col = 4;
            double[] body1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double[] body2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //act
            Matrix a1 = new Matrix(row1, col, body1);
            Matrix a2 = new Matrix(row2, col, body2);

            //assert
            Assert.IsFalse(a1 == a2);
        }
        [TestMethod]
        public void Test_003_EqualityOfNonEquals_Col()
        {
            //arrange            
            uint row = 3;
            uint col1 = 3;
            uint col2 = 4;
            double[] body1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] body2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //act
            Matrix a1 = new Matrix(row, col1, body1);
            Matrix a2 = new Matrix(row, col2, body2);

            //assert
            Assert.IsFalse(a1 == a2);
        }
        [TestMethod]
        public void Test_004_EqualityOfNonEquals_Body()
        {
            //arrange            
            uint row = 3;
            uint col = 3;            
            double[] body1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] body2 = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //act
            Matrix a1 = new Matrix(row, col, body1);
            Matrix a2 = new Matrix(row, col, body2);

            //assert
            Assert.IsFalse(a1 == a2);
        }
        [TestMethod]
        public void Test_005_NonEqualityOfEquals()
        {
            //arrange
            uint row = 3;
            uint col = 4;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //act
            Matrix a1 = new Matrix(row, col, body);
            Matrix a2 = new Matrix(row, col, body);

            //assert
            Assert.IsFalse(a1 != a2);
        }
        [TestMethod]
        public void Test_006_NonEqualityOfNonEquals_Row()
        {
            //arrange
            uint row1 = 2;
            uint row2 = 3;
            uint col = 4;
            double[] body1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double[] body2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //act
            Matrix a1 = new Matrix(row1, col, body1);
            Matrix a2 = new Matrix(row2, col, body2);

            //assert
            Assert.IsTrue(a1 != a2);
        }
        [TestMethod]
        public void Test_007_NonEqualityOfNonEquals_Col()
        {
            //arrange            
            uint row = 3;
            uint col1 = 3;
            uint col2 = 4;
            double[] body1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] body2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //act
            Matrix a1 = new Matrix(row, col1, body1);
            Matrix a2 = new Matrix(row, col2, body2);

            //assert
            Assert.IsTrue(a1 != a2);
        }
        [TestMethod]
        public void Test_008_NonEqualityOfNonEquals_Body()
        {
            //arrange            
            uint row = 3;
            uint col = 3;
            double[] body1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] body2 = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //act
            Matrix a1 = new Matrix(row, col, body1);
            Matrix a2 = new Matrix(row, col, body2);

            //assert
            Assert.IsTrue(a1 != a2);
        }
        [TestMethod]
        public void Test_009_Sum()
        {
            //arrange
            uint row = 2;
            uint col = 3;
            double[] body = { 1, 2, 3, 4, 5, 6 };

            
            //act
            Matrix a = new Matrix(row, col, body);
            Matrix b = new Matrix(row, col, body);
            //assert
            Matrix c = null;
            try
            {
                c = a + b;
            }
            catch (Exception e)
            {
                Assert.Fail($"Ошибка сложения матриц {e.Message}");
            }
            Assert.IsNotNull(c);
        }
        [TestMethod]
        public void Test_010_SumCheckResult()
        {
            //arrange
            uint row = 2;
            uint col = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6 };
            double[] bodyB = { 7, 8, 9, 10, 11, 12 };
            double[] bodyC = { 8, 10, 12, 14, 16, 18 };            
            //act
            Matrix a = new Matrix(row, col, bodyA);
            Matrix b = new Matrix(row, col, bodyB);
            Matrix c1 = new Matrix(row, col, bodyC);
            Matrix c2 = a + b;
            //assert
            Assert.IsTrue(c1 == c2);
        }
        [TestMethod]
        public void Test_011_SumWhenRowsUnequal()
        {
            //arrange
            uint row1 = 2;
            uint row2 = 3;
            uint col = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6 };
            double[] bodyB = { 7, 8, 9, 10, 11, 12, 13, 14, 15 };            
            //act
            Matrix a = new Matrix(row1, col, bodyA);
            Matrix b = new Matrix(row2, col, bodyB);            
            try
            {
                Matrix c = a + b;
            }
            //assert
            catch (Exception e) 
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongRowsNumberWhenAddingErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_012_SumWhenColumnsUnequal()
        {
            //arrange
            uint row = 3;            
            uint col1 = 2;
            uint col2 = 3;
            double[] body1 = { 1, 2, 3, 4, 5, 6 };
            double[] body2 = { 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //act
            Matrix a = new Matrix(row, col1, body1);
            Matrix b = new Matrix(row, col2, body2);
            try
            {
                Matrix c = a + b;
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongColumnsNumberWhenAddingErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_013_MultiplyScalarByMatrix()
        {
            //arrange
            uint row = 3;
            uint col = 2;            
            double[] body = { 1, 2, 3, 4, 5, 6 };
            double a = 5;
            //act
            Matrix b = new Matrix(row, col, body);
            Matrix c = null;
            try
            {
                c = a * b;
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка умножения скаляра на матрицу {e.Message}");
            }
            Assert.IsNotNull(c);
        }
        [TestMethod]
        public void Test_014_MultiplyScalarByMatrixCheck()
        {
            //arrange
            uint row = 3;
            uint col = 2;
            double[] bodyB = { 1, 2, 3, 4, 5, 6 };
            double[] bodyC = { 5, 10, 15, 20, 25, 30 };
            double a = 5;
            //act
            Matrix b = new Matrix(row, col, bodyB);
            Matrix c1 = new Matrix(row, col, bodyC);
            Matrix c2 = a * b;
            //assert            
            Assert.IsTrue(c1 == c2);
        }
        [TestMethod]
        public void Test_015_MultiplyMatrixByScalar()
        {
            //arrange
            uint row = 3;
            uint col = 2;
            double[] body = { 1, 2, 3, 4, 5, 6 };
            double b = 5;
            //act
            Matrix a = new Matrix(row, col, body);
            Matrix c = null;
            try
            {
                c = a * b;
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка умножения скаляра на матрицу {e.Message}");
            }
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void Test_016_MultiplyMatrixByScalarCheck()
        {
            //arrange
            uint row = 3;
            uint col = 2;
            double[] bodyA = { 1, 2, 3, 4, 5, 6 };
            double[] bodyC = { 5, 10, 15, 20, 25, 30 };
            double b = 5;
            //act
            Matrix a = new Matrix(row, col, bodyA);
            Matrix c1 = new Matrix(row, col, bodyC);
            Matrix c2 = a * b;
            //assert            
            Assert.IsTrue(c1 == c2);
        }
        [TestMethod]
        public void Test_017_Subtraction()
        {
            //arrange
            uint row = 2;
            uint col = 3;
            double[] body = { 1, 2, 3, 4, 5, 6 };


            //act
            Matrix a = new Matrix(row, col, body);
            Matrix b = new Matrix(row, col, body);
            //assert
            Matrix c = null;
            try
            {
                c = a - b;
            }
            catch (Exception e)
            {
                Assert.Fail($"Ошибка вычитания матриц {e.Message}");
            }
            Assert.IsNotNull(c);
        }
        [TestMethod]
        public void Test_018_SubtractionCheckResult()
        {
            //arrange
            uint row = 2;
            uint col = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6 };
            double[] bodyB = { 12, 11, 10, 9, 8, 7 };
            double[] bodyC = { -11, -9, -7, -5, -3, -1 };
            //act
            Matrix a = new Matrix(row, col, bodyA);
            Matrix b = new Matrix(row, col, bodyB);
            Matrix c1 = new Matrix(row, col, bodyC);
            Matrix c2 = a - b;
            //assert
            Assert.IsTrue(c1 == c2);
        }
        [TestMethod]
        public void Test_019_SubtractionWhenRowsUnequal()
        {
            //arrange
            uint row1 = 2;
            uint row2 = 3;
            uint col = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6 };
            double[] bodyB = { 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //act
            Matrix a = new Matrix(row1, col, bodyA);
            Matrix b = new Matrix(row2, col, bodyB);
            try
            {
                Matrix c = a - b;
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongRowsNumberWhenAddingErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_020_SubtractionWhenColumnsUnequal()
        {
            //arrange
            uint row = 3;
            uint col1 = 2;
            uint col2 = 3;
            double[] body1 = { 1, 2, 3, 4, 5, 6 };
            double[] body2 = { 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //act
            Matrix a = new Matrix(row, col1, body1);
            Matrix b = new Matrix(row, col2, body2);
            try
            {
                Matrix c = a - b;
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongColumnsNumberWhenAddingErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_021_DivideMatrixByScalar()
        {
            //arrange
            uint row = 3;
            uint col = 2;
            double[] body = { 1, 2, 3, 4, 5, 6 };
            double b = 5;
            //act
            Matrix a = new Matrix(row, col, body);
            Matrix c = null;
            try
            {
                c = a / b;
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка умножения скаляра на матрицу {e.Message}");
            }
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void Test_022_DivideMatrixByScalarCheck()
        {
            //arrange
            uint row = 3;
            uint col = 2;
            double[] bodyA = { 5, 10, 15, 20, 25, 30 };
            double[] bodyC = { 1, 2, 3, 4, 5, 6 };            
            double b = 5;
            //act
            Matrix a = new Matrix(row, col, bodyA);
            Matrix c1 = new Matrix(row, col, bodyC);
            Matrix c2 = a / b;
            //assert            
            Assert.IsTrue(c1 == c2);
        }        
        [TestMethod]
        public void Test_023_Multiply()
        {
            //arrange
            uint rowA = 2;
            uint colA = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6 };
            Matrix a = new Matrix(rowA, colA, bodyA);
            uint rowB = 3;
            uint colB = 3;
            double[] bodyB = { 3, 2, 1, 2, 1, 3, 4, 3, 0 };
            Matrix b = new Matrix(rowB, colB, bodyB);
            //act
            Matrix c = null;
            try
            {
                c = a * b;
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка перемножения матриц: {e.Message}");
                return;
            }
            Assert.IsNotNull(c);
        }
        [TestMethod]
        public void Test_024_MultiplyCheck()
        {
            //arrange
            uint rowA = 2;
            uint colA = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6 };
            Matrix a = new Matrix(rowA, colA, bodyA);
            uint rowB = 3;
            uint colB = 3;
            double[] bodyB = { 3, 2, 1, 2, 1, 3, 4, 3, 0 };
            Matrix b = new Matrix(rowB, colB, bodyB);
            uint rowC = 2;
            uint colC = 3;
            double[] bodyC = { 19, 13, 7, 46, 31, 19 };
            Matrix c1 = new Matrix(rowC, colC, bodyC);
            //act
            Matrix c2 = a * b;
            //assert                        
            Assert.IsTrue(c1 == c2);
        }
        [TestMethod]
        public void Test_025_MultiplyWithWrongDimensions()
        {
            //arrange
            uint rowA = 2;
            uint colA = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6 };
            Matrix a = new Matrix(rowA, colA, bodyA);
            uint rowB = 3;
            uint colB = 3;
            double[] bodyB = { 3, 2, 1, 2, 1, 3, 4, 3, 0 };
            Matrix b = new Matrix(rowB, colB, bodyB);
            //act
            Matrix c = null;
            try
            {
                c = b * a;
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongDimensionWhenMultiplyErrMsg))
                {
                    return;
                }
                
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }                  
        [TestMethod]
        public void Test_026_Pow()
        {
            //arrange
            uint row = 3;
            uint col = 3;
            double[] bodyA = { -3, 2, -5, -1, 0, -2, 3, -4, 1 };
            Matrix a = new Matrix(row, col, bodyA);
            uint pow = 3;
            Matrix b = null;
            //act
            try
            {
                b = a.Pow(pow);
            }
            // assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка возведения матрицы в целую степень: {e.Message}");
                return;
            }            
            Assert.IsNotNull(b);
        }
        [TestMethod]
        public void Test_027_PowNonSquareMatrix()
        {
            //arrange
            uint row = 3;
            uint col = 4;
            double[] bodyA = { -3, 2, -5, -1, 0, -2, 3, -4, 1, 1, 2, 3 };
            Matrix a = new Matrix(row, col, bodyA);
            uint pow = 3;
            Matrix b = null;
            //act
            try
            {
                b = a.Pow(pow);
            }
            // assert
            catch (Exception e)
            {
                StringAssert.Equals(e.Message, MatrixErrMsg.WrongDimensionWhenPowErrMsg);
                return;
            }            
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_028_PowCheck1()
        {
            //arrange
            uint row = 3;
            uint col = row;
            double[] bodyA = { -3, 2, -5, -1, 0, -2, 3, -4, 1 };
            Matrix a = new Matrix(row, col, bodyA);
            uint pow = 0;
            Matrix b = new Matrix(row, 1.0);
            //act
            Matrix c = a.Pow(pow);
            // assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_029_PowCheck2()
        {
            //arrange
            uint row = 3;
            uint col = row;
            double[] bodyA = { -3, 2, -5, -1, 0, -2, 3, -4, 1 };
            Matrix a = new Matrix(row, col, bodyA);
            uint pow = 3;
            double[] bodyB = { 28, -40, 18, 12, -18, 6, -14, 20, 0 };
            Matrix b = new Matrix(row, col, bodyB);            
            //act
            Matrix c = a.Pow(pow);
            // assert
            Assert.IsTrue(b == c);
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

