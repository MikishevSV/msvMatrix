using msvMatrix;
namespace msvMatrix_Test
{
    [TestClass]
    public class UnitTest_Functions
    {        
        [TestMethod]
        public void Test_001_Transp1()
        {
            //arrange
            uint row = 2;
            uint col = 3;
            double[] body1 = { 1, 2, 3, 4, 5, 6};
            double[] body2 = { 1, 4, 2, 5, 3, 6 };
            Matrix a = new Matrix(row, col, body1);
            Matrix b = new Matrix(col, row, body2);
            //act
            Matrix c = a.Transp();
            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_002_Transp2()
        {
            //arrange
            uint row = 2;
            uint col = 3;
            double[] body = { 1, 2, 3, 4, 5, 6 };            
            Matrix a = new Matrix(row, col, body);            
            //act
            Matrix b = a.Transp();
            b = b.Transp();
            //assert
            Assert.IsTrue(a == b);
        }
        [TestMethod]
        public void Test_003_TrimRow()
        {
            //arrange
            uint row = 3;
            uint col = 3;
            uint trimRow = 1;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix a = new Matrix(row, col, body);
            Matrix b = null;
            //act
            try
            {
                b = a.TrimRow(trimRow);
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка обрезания строки матрицы: {e.Message}");
                return;
            }
            Assert.IsNotNull(b);
        }
        [TestMethod]
        public void Test_004_TrimRowWrongRowNum1()
        {
            //arrange
            uint row = 3;
            uint col = 3;
            uint trimRow = row;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix a = new Matrix(row, col, body);
            Matrix b = null;
            //act
            try
            {
                b = a.TrimRow(trimRow);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongTrimRowNumErrMsg))
                {
                    return;
                }                
            }
            Assert.Fail("Не было выброшено необходимое исключение"); 
        }
        [TestMethod]
        public void Test_005_TrimRowWrongRowNum2()
        {
            //arrange
            uint row = 3;
            uint col = 3;
            uint trimRow = row + 2;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix a = new Matrix(row, col, body);
            Matrix b = null;
            //act
            try
            {
                b = a.TrimRow(trimRow);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongTrimRowNumErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_006_TrimRowCheck1()
        {
            //arrange
            uint rowA = 3;
            uint colA = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix a = new Matrix(rowA, colA, bodyA);
            
            uint trimRow = 0;

            uint rowB = 2;
            uint colB = 3;
            double[] bodyB = { 4, 5, 6, 7, 8, 9 };
            Matrix b = new Matrix(rowB, colB, bodyB);
            
            //act
            Matrix c = a.TrimRow(trimRow);
            
            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_007_TrimRowCheck2()
        {
            //arrange
            uint rowA = 3;
            uint colA = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix a = new Matrix(rowA, colA, bodyA);

            uint trimRow = 1;

            uint rowB = 2;
            uint colB = 3;
            double[] bodyB = { 1, 2, 3, 7, 8, 9 };
            Matrix b = new Matrix(rowB, colB, bodyB);

            //act
            Matrix c = a.TrimRow(trimRow);

            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_008_TrimRowCheck3()
        {
            //arrange
            uint rowA = 3;
            uint colA = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix a = new Matrix(rowA, colA, bodyA);

            uint trimRow = 2;

            uint rowB = 2;
            uint colB = 3;
            double[] bodyB = { 1, 2, 3, 4, 5, 6 };
            Matrix b = new Matrix(rowB, colB, bodyB);

            //act
            Matrix c = a.TrimRow(trimRow);

            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_009_TrimCol()
        {
            //arrange
            uint row = 3;
            uint col = 3;
            uint trimCol = 1;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix a = new Matrix(row, col, body);
            Matrix b = null;
            //act
            try
            {
                b = a.TrimCol(trimCol);
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка обрезания столбца матрицы: {e.Message}");
                return;
            }
            Assert.IsNotNull(b);
        }
        [TestMethod]
        public void Test_010_TrimColWrongColNum1()
        {
            //arrange
            uint row = 3;
            uint col = 3;
            uint trimCol = col;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix a = new Matrix(row, col, body);
            Matrix b = null;
            //act
            try
            {
                b = a.TrimCol(trimCol);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongTrimColNumErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_011_TrimColWrongRowNum2()
        {
            //arrange
            uint row = 3;
            uint col = 3;
            uint trimCol = col + 2;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix a = new Matrix(row, col, body);
            Matrix b = null;
            //act
            try
            {
                b = a.TrimCol(trimCol);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongTrimColNumErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_012_TrimColCheck1()
        {
            //arrange
            uint rowA = 3;
            uint colA = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix a = new Matrix(rowA, colA, bodyA);

            uint trimCol = 0;

            uint rowB = 3;
            uint colB = 2;
            double[] bodyB = { 2, 3, 5, 6, 8, 9 };
            Matrix b = new Matrix(rowB, colB, bodyB);

            //act
            Matrix c = a.TrimCol(trimCol);

            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_013_TrimColCheck2()
        {
            //arrange
            uint rowA = 3;
            uint colA = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix a = new Matrix(rowA, colA, bodyA);

            uint trimCol = 1;

            uint rowB = 3;
            uint colB = 2;
            double[] bodyB = { 1, 3, 4, 6, 7, 9 };
            Matrix b = new Matrix(rowB, colB, bodyB);

            //act
            Matrix c = a.TrimCol(trimCol);

            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_014_TrimColCheck3()
        {
            //arrange
            uint rowA = 3;
            uint colA = 3;
            double[] bodyA = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix a = new Matrix(rowA, colA, bodyA);

            uint trimCol = 2;

            uint rowB = 3;
            uint colB = 2;
            double[] bodyB = { 1, 2, 4, 5, 7, 8 };
            Matrix b = new Matrix(rowB, colB, bodyB);

            //act
            Matrix c = a.TrimCol(trimCol);

            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_015_Determinant()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] body = { -1, 0, 3, 4, 2, -1, 1, 2, 0, 3, 2, 1, 2, 1, 4, 3 };
            Matrix a = new Matrix(row, col, body);

            //act
            try
            {
                double d = a.Determinant();
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка расчета определителя матрицы: {e.Message}");
            }
            //Assert.IsTrue(true);
        }
        [TestMethod]
        public void Test_016_DeterminantNonSquareMatrix()
        {
            //arrange
            uint row = 2;
            uint col = 3;
            double[] body = { 1, 2, 3, 4, 5, 6 };
            Matrix a = new Matrix(row, col, body);
            //act
            try
            {
                double d = a.Determinant();
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.NonSquareMatrixForDeterminantErrMsg))
                {
                    return;
                }
            }            
            Assert.Fail("Не было выброшено необходимое исключение");                        
        }
        [TestMethod]
        public void Test_017_DeterminantCheck()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] body = { -1, 0, 3, 4, 2, -1, 1, 2, 0, 3, 2, 1, 2, 1, 4, 3 };
            Matrix a = new Matrix(row, col, body);
            double res1 = -44;
            //act
            double res2 = a.Determinant();
            //assert
            Assert.AreEqual(res1, res2);
        }
        [TestMethod]
        public void Test_018_Cofactor()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] body = { -1, 0, 3, 4, 2, -1, 1, 2, 0, 3, 2, 1, 2, 1, 4, 3 };
            Matrix a = new Matrix(row, col, body);
            Matrix b = null;
            //act
            try
            {
                b = a.Cofactor();
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка расчета определителя матрицы: {e.Message}");
            }
            Assert.IsNotNull(b);
        }
        [TestMethod]
        public void Test_019_CofactorNonSquareMatrix()
        {
            //arrange
            uint row = 2;
            uint col = 3;
            double[] body = { 1, 2, 3, 4, 5, 6 };
            Matrix a = new Matrix(row, col, body);
            //act
            try
            {
                Matrix b = a.Cofactor();
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.NonSquareMatrixForCofactorErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_020_CofactorCheck()
        {
            //arrange
            uint row = 3;
            uint col = 3;
            double[] bodyA = { -3, 2, -5, -1, 0, -2, 3, -4, 1 };
            Matrix a = new Matrix(row, col, bodyA);

            double[] bodyB = { -8, -5, 4, 18, 12, -6, -4, -1, 2 };
            Matrix b = new Matrix(row, col, bodyB);
            //act
            Matrix c = a.Cofactor();
            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_021_Adjugate()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] body = { -1, 0, 3, 4, 2, -1, 1, 2, 0, 3, 2, 1, 2, 1, 4, 3 };
            Matrix a = new Matrix(row, col, body);
            Matrix b = null;
            //act
            try
            {
                b = a.Adjugate();
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка расчета определителя матрицы: {e.Message}");
            }
            Assert.IsNotNull(b);
        }
        [TestMethod]
        public void Test_022_AdjugateNonSquareMatrix()
        {
            //arrange
            uint row = 2;
            uint col = 3;
            double[] body = { 1, 2, 3, 4, 5, 6 };
            Matrix a = new Matrix(row, col, body);
            //act
            try
            {
                Matrix b = a.Adjugate();
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.NonSquareMatrixForAdjugateErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_023_AdjugateCheck()
        {
            //arrange
            uint row = 3;
            uint col = 3;
            double[] bodyA = { -3, 2, -5, -1, 0, -2, 3, -4, 1 };
            Matrix a = new Matrix(row, col, bodyA);
            double[] bodyB = { -8, 18, -4, -5, 12, -1, 4, -6, 2 };
            Matrix b = new Matrix(row, col, bodyB);
            //act
            Matrix c = a.Adjugate();
            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_024_Invert()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] body = { -1, 0, 3, 4, 2, -1, 1, 2, 0, 3, 2, 1, 2, 1, 4, 3 };
            Matrix a = new Matrix(row, col, body);
            Matrix b = null;
            //act
            try
            {
                b = a.Invert();
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка получения определителя матрицы: {e.Message}");
            }
            Assert.IsNotNull(b);
        }
        [TestMethod]
        public void Test_025_InvertNonSquareMatrix()
        {
            //arrange
            uint row = 2;
            uint col = 3;
            double[] body = { 1, 2, 3, 4, 5, 6 };
            Matrix a = new Matrix(row, col, body);
            //act
            try
            {
                Matrix b = a.Invert();
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.NonSquareMatrixForInvertErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_026_InvertCheck1()
        {
            //arrange
            uint row = 3;
            uint col = 3;
            double[] bodyA = { 2, 1, -1, 3, 0, 1, 2, -1, 1 };
            Matrix a = new Matrix(row, col, bodyA);
            double[] bodyB = { 0.25, 0, 0.25, -0.25, 1, -1.25, -0.75, 1, -0.75 };
            Matrix b = new Matrix(row, col, bodyB);
            //assert
            Assert.IsTrue(a.Invert() == b);
        }
        [TestMethod]
        public void Test_027_InvertCheck2()
        {
            //arrange
            uint row = 3;
            uint col = 3;
            double[] bodyA = { 2, 1, -1, 3, 0, 1, 2, -1, 1 }; 
            Matrix a = new Matrix(row, col, bodyA);            
            //assert
            Assert.IsTrue(a * a.Invert() == (new Matrix(row, 1.0)));
        }
        [TestMethod]
        public void Test_028_AddRow()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Matrix a = new Matrix(row, col, body);
            double[] newRow = { 17, 18, 19, 20 };
            uint newRowIndex = 2;
            Matrix b = null;
            //act
            try
            {
                b = a.AddRow(newRow, newRowIndex);
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка добавления строки: {e.Message}");
            }
            Assert.IsNotNull(b);
        }
        [TestMethod]
        public void Test_029_AddRowWrongLength()
        {            
            //arrange
            uint row = 4;
            uint col = 4;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Matrix a = new Matrix(row, col, body);
            double[] newRow = { 17, 18, 19 };
            uint newRowIndex = 2;
            //act
            try
            {
                Matrix b = a.AddRow(newRow, newRowIndex);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongAddRowLengthErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_030_AddRowCheck1()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] bodyA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Matrix a = new Matrix(row, col, bodyA);

            double[] bodyB = { 17, 18, 19, 20, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Matrix b = new Matrix(row+1, col, bodyB);

            double[] newRow = { 17, 18, 19, 20 };
            uint newRowIndex = 0;

            //act
            Matrix c = a.AddRow(newRow, newRowIndex);
            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_031_AddRowCheck2()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] bodyA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Matrix a = new Matrix(row, col, bodyA);

            double[] bodyB = { 1, 2, 3, 4, 5, 6, 7, 8, 17, 18, 19, 20, 9, 10, 11, 12, 13, 14, 15, 16 };
            Matrix b = new Matrix(row + 1, col, bodyB);

            double[] newRow = { 17, 18, 19, 20 };
            uint newRowIndex = 2;

            //act
            Matrix c = a.AddRow(newRow, newRowIndex);
            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_032_AddRowCheck3()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] bodyA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Matrix a = new Matrix(row, col, bodyA);

            double[] bodyB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Matrix b = new Matrix(row + 1, col, bodyB);

            double[] newRow = { 17, 18, 19, 20 };
            
            //act
            Matrix c = a.AddRow(newRow);
            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_033_AddCol()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Matrix a = new Matrix(row, col, body);
            double[] newCol = { 17, 18, 19, 20 };
            uint newColIndex = 2;
            Matrix b = null;
            //act
            try
            {
                b = a.AddCol(newCol, newColIndex);
            }
            //assert
            catch (Exception e)
            {
                Assert.Fail($"Ошибка добавления столбца: {e.Message}");
            }
            Assert.IsNotNull(b);
        }
        [TestMethod]
        public void Test_034_AddColWrongLength()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Matrix a = new Matrix(row, col, body);
            double[] newCol = { 17, 18, 19 };
            uint newColIndex = 2;
            //act
            try
            {
                Matrix b = a.AddCol(newCol, newColIndex);
            }
            //assert
            catch (Exception e)
            {
                if (StringAssert.Equals(e.Message, MatrixErrMsg.WrongAddColLengthErrMsg))
                {
                    return;
                }
            }
            Assert.Fail("Не было выброшено необходимое исключение");
        }
        [TestMethod]
        public void Test_035_AddColCheck1()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] bodyA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Matrix a = new Matrix(row, col, bodyA);

            double[] bodyB = { 17, 1, 2, 3, 4, 18, 5, 6, 7, 8, 19, 9, 10, 11, 12, 20, 13, 14, 15, 16 };
            Matrix b = new Matrix(row, col + 1, bodyB);

            double[] newCol = { 17, 18, 19, 20 };
            uint newColIndex = 0;

            //act
            Matrix c = a.AddCol(newCol, newColIndex);
            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_036_AddColCheck2()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] bodyA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Matrix a = new Matrix(row, col, bodyA);

            double[] bodyB = { 1, 2, 17, 3, 4, 5, 6, 18, 7, 8, 9, 10, 19, 11, 12, 13, 14, 20, 15, 16 };
            Matrix b = new Matrix(row, col + 1, bodyB);

            double[] newCol = { 17, 18, 19, 20 };
            uint newColIndex = 2;

            //act
            Matrix c = a.AddCol(newCol, newColIndex);
            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_037_AddColCheck3()
        {
            //arrange
            uint row = 4;
            uint col = 4;
            double[] bodyA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Matrix a = new Matrix(row, col, bodyA);

            double[] bodyB = { 1, 2, 3, 4, 17, 5, 6, 7, 8, 18, 9, 10, 11, 12, 19, 13, 14, 15, 16, 20 };
            Matrix b = new Matrix(row, col + 1, bodyB);

            double[] newCol = { 17, 18, 19, 20 };            

            //act
            Matrix c = a.AddCol(newCol);
            //assert
            Assert.IsTrue(b == c);
        }
        [TestMethod]
        public void Test_038_MoveRow()
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
        public void Test_039_MoveRowWrongFrom()
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
        public void Test_040_MoveRowWrongTo()
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

