using msvMatrix;
namespace msvMatrix_Test
{
    [TestClass]
    public class UnitTest_Constructors
    {
        [TestMethod]
        public void Test_001_CreateMatrix()
        {
            //arrange
            uint row = 3;
            uint col = 4;
            Matrix a = null;
            //act
            try
            {
                a = new Matrix(row, col);
            //assert
            }
            catch (Exception e)
            {
                Assert.Fail($"Ошибка создания пустой матрицы {e.Message}");
            }
            Assert.IsNotNull(a);
        }
        [TestMethod]
        public void Test_002_CreateWithRowCountZero()
        {
            //arrange
            uint row = 0;
            uint col = 4;
            Matrix a = null;
            //act
            try
            {
                a = new Matrix(row, col);                
            }
            //assert
            catch (Exception e)
            {                
                if (StringAssert.Equals(e.Message, Matrix.WrongRowCountErrMsg))
                {
                    return;
                }                
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_003_CreateWithColCountZero()
        {
            //arrange
            uint row = 3;
            uint col = 0;
            Matrix a;
            //act
            try
            {
                a = new Matrix(row, col);
            }
            catch (Exception e)
            {
                //assert
                if (StringAssert.Equals(e.Message, Matrix.WrongColCountErrMsg))
                {
                    return;
                }                
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_004_CheckRowCount()
        {
            //arrange
            uint row = 4;
            uint col = 3;
            //act
            Matrix a = new Matrix(row, col);
            //assert
            Assert.AreEqual(row, a.RowCount);
        }
        [TestMethod]
        public void Test_005_CheckColCount()
        {
            //arrange
            uint row = 4;
            uint col = 3;
            //act
            Matrix a = new Matrix(row, col);
            //assert
            Assert.AreEqual(col, a.ColCount);
        }
        [TestMethod]
        public void Test_006_CheckZeroMatrix()
        {
            //arrange
            uint row = 4;
            uint col = 3;
           
            //act
            Matrix a = new Matrix(row, col);
            //assert
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < col; j++)
                {
                    if (a.Body[i, j] != 0)
                    {
                        Assert.Fail("Матрица должна быть нулевой");
                        return;
                    }
                }
            }            
        }
        [TestMethod]
        public void Test_007_CheckNonZeroMatrix()
        {
            //arrange
            uint row = 4;
            uint col = 3;
            double value = 5.1;
            //act
            Matrix a = new Matrix(row, col, value);
            //assert
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < col; j++)
                {
                    if (a.Body[i, j] != value)
                    {
                        Assert.Fail($"Матрица должна быть заполнена числом {value}"); ;
                        return;
                    }
                }
            }
        }
        [TestMethod]
        public void Test_008_CreateSquareMatrix()
        {
            //arrange
            uint order = 5;
            //act            
            try
            {                
                Matrix a = new Matrix(order);
            }
            //assert
            catch
            {                
                Assert.Fail("Ошибка создания квадратной матрицы!");
            }
        }

        [TestMethod]
        public void Test_009_CheckSquareMatrixIsSquare()
        {
            //arrange
            uint order = 5;
            //act            
            Matrix a = new Matrix(order, order);
            //assert
            Assert.IsTrue(((order == a.RowCount) & (a.RowCount == a.ColCount)));
        }
        [TestMethod]
        public void Test_010_CheckSquareMatrixZeroOrder()
        {
            //arrange
            uint order = 0;
            Matrix a;
            //act
            try
            {
                a = new Matrix(order);
            }
            catch (Exception e)
            {
                //assert
                if (StringAssert.Equals(e.Message, Matrix.WrongColCountErrMsg))
                {
                    return;
                }
                if (StringAssert.Equals(e.Message, Matrix.WrongRowCountErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_011_CheckZeroSquareMatrix()
        {
            //arrange
            uint order = 5;
            //act
            Matrix a = new Matrix(order);
            //assert
            for (uint i = 0; i < a.RowCount; i++)
            {
                for (uint j = 0; j < a.ColCount; j++)
                {
                    if (a.Body[i, j] != 0)
                    {
                        Assert.Fail($"Матрицы д.б. заполнена нулями! [{i}, {j}] = {a.Body[i, j]}");
                        return;
                    }
                }
            }            
        }
        [TestMethod]
        public void Test_012_CheckNonZeroSquareMatrix()
        {
            //arrange
            uint order = 5;
            double value = 3;
            //act
            Matrix a = new Matrix(order, value, false);
            //assert
            for (uint i = 0; i < a.RowCount; i++)
            {
                for (uint j = 0; j < a.ColCount; j++)
                {

                    if (a.Body[i, j] != value)
                    {
                        Assert.Fail($"Матрица д.б. заполнена значением {value}! [{i}, {j}] = {a.Body[i, j]}");
                        return;
                    }
                }
            }
        }
        [TestMethod]
        public void Test_013_CheckNonZeroDiagMatrix()
        {
            //arrange
            uint order = 5;
            double value = 1;
            //act
            Matrix a = new Matrix(order, value);
            //assert
            for (uint i = 0; i < a.RowCount; i++)
            {
                for (uint j = 0; j < a.ColCount; j++)
                {
                    if (i != j)
                    {
                        if (a.Body[i, j] != 0)
                        {
                            Assert.Fail($"Матрица вне главной диагонали д.б. заполнена нулями! [{i}, {j}] = {a.Body[i, j]}");
                            return;
                        }
                    }
                    else
                    {
                        if (a.Body[i, j] != value)
                        {
                            Assert.Fail($"Матрица по главной диагонали д.б. заполнена значением {value}! [{i}, {j}] = {a.Body[i, j]}");
                            return;
                        }
                    }                                        
                }
            }
        }
        [TestMethod]
        public void Test_014_CreateMatrixFromArray()
        {
            //arrange
            uint row = 2;
            uint col = 3;
            double[] body = { 1, 2, 3, 4, 5, 6 };
            //act
            try
            {
                Matrix a = new Matrix(row, col, body);
            }
            //assert
            catch
            {
                Assert.Fail("Ошибка создания матрицы из массива");
            }            
        }
        [TestMethod]
        public void Test_015_CheckMatrixFromArrayDimension()
        {
            //arrange
            uint row = 2;
            uint col = 2;
            double[] body = { 1, 2, 3, 4, 5, 6 };
            //act
            try
            {
                Matrix a = new Matrix(row, col, body);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, Matrix.WrongDimensionErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_016_CheckMatrixFromArrayBodyValues()
        {
            //arrange
            uint row = 2;
            uint col = 3;
            double[] body = { 1, 2, 3, 4, 5, 6 };
            //act
            Matrix a = new Matrix(row, col, body);
            //assert
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < col; j ++)
                {
                    if (a.Body[i, j] != body[i * col + j])
                    {
                        Assert.Fail($"Неверное значение в теле матрицы [{i}, {j}] = {a.Body[i, j]}, а д.б. {body[i * col + j]}");
                    }
                }
            }
        }
        [TestMethod]
        public void Test_017_CreateMatrixFrom2DimensionArray()
        {
            //arrange
            double[,] body = { { 1, 2 }, { 3, 4 } };
            //act
            try
            {
                Matrix a = new Matrix(body);
            }
            //assert
            catch
            {
                Assert.Fail("Ошибка создания матрицы из двумерного массива");
            }
        }
        [TestMethod]
        public void Test_018_CheckMatrixFrom2DimensionArray()
        {
            //arrange
            uint rowA = 2;
            uint colA = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6 };
            double[,] bodyB = { { 1, 2, 3 }, { 4, 5, 6 } };
            //act            
            Matrix a = new Matrix(rowA, colA, bodyA);
            Matrix b = new Matrix(bodyB);
            //assert
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_019_CreateMatrixFromArrayOfArray()
        {
            //arrange
            double[][] body = new double[2][];
            body[0] = new double[3] { 1, 2, 3 };
            body[1] = new double[3] { 4, 5, 6 };
            //act
            try
            {
                Matrix a = new Matrix(body);
            }
            //assert
            catch
            {
                Assert.Fail("Ошибка создания матрицы из двумерного массива");
            }
        }
        [TestMethod]
        public void Test_020_CheckMatrixFromArrayOfArrayWithDifferentLength()
        {
            //arrange
            double[][] body = new double[2][];
            body[0] = new double[3] { 1, 2, 3 };
            body[1] = new double[2] { 4, 5 };
            Matrix a = null;
            //act
            try
            {
                a = new Matrix(body);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, Matrix.WrongRowLengthErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");      
        }
        [TestMethod]
        public void Test_021_CheckMatrixFromArrayOfArray()
        {
            //arrange
            uint rowA = 2;
            uint colA = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6 };
            double[][] bodyB = new double[2][];
            bodyB[0] = new double[3] { 1, 2, 3 };
            bodyB[1] = new double[3] { 4, 5, 6 };
            //act            
            Matrix a = new Matrix(rowA, colA, bodyA);
            Matrix b = new Matrix(bodyB);
            //assert
            Assert.IsTrue(a == b);
        }


    }
}
