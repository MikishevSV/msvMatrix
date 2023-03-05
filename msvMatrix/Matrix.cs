namespace msvMatrix
{
    public class Matrix
    {           
        private uint _RowCount; // количество строк
        public uint RowCount 
        { 
            get 
            { 
                return _RowCount; 
            } 
            set 
            {
                if (value > 0)
                {
                    _RowCount = value;
                }
                else
                {
                    throw new Exception(MatrixErrMsg.WrongRowCountErrMsg);
                }
            }
        }
        private uint _ColCount; // количество столбцов
        public uint ColCount
        {
            get
            {
                return _ColCount;
            }
            set
            {
                if (value > 0)
                {
                    _ColCount = value;
                }
                else
                {
                    throw new Exception(MatrixErrMsg.WrongColCountErrMsg);
                }
            }
        }
        public double[,] Body; // тело матрицы
        public void Print()
        {
            Console.WriteLine($"{RowCount} x {ColCount} :");
            for (uint i = 0; i < RowCount; i++)
            {
                for (uint j = 0; j < ColCount; j++)
                {
                    Console.Write($"{Body[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public Matrix(uint aRowCount, uint aColCount, double aValue = 0) // создание заполненной одним значением матрицы
        {
            RowCount = aRowCount;
            ColCount = aColCount;
            Body = new double[aRowCount, aColCount];
            if (aValue != 0)
            {
                for (uint i = 0; i < aRowCount; i++)
                {
                    for (uint j = 0; j < aColCount; j++)
                    {
                        Body[i, j] = aValue;
                    }
                }
            }
        }
        public Matrix(uint aOrder, double aValue = 0, bool aIsScalar = true) : this(aOrder, aOrder) // создание диагональной или заполненной квадратной матрицы
        {
            if (aValue != 0)
            {
                if (aIsScalar)
                {
                    for (uint i = 0; i < aOrder; i++)
                    {
                        this.Body[i, i] = aValue;
                    }
                }
                else
                {
                    for (uint i = 0; i < aOrder; i++)
                    {
                        for (uint j = 0; j < aOrder; j++)
                        {
                            this.Body[i, j] = aValue;
                        }
                    }
                }
            }                      
        }
        public Matrix(uint aRowCount, uint aColCount, double[] aBody) : this(aRowCount, aColCount) // создание произвольной матрицы из одномерного массива
        {
            if (aRowCount * aColCount != aBody.Length)
            {
                throw new ArgumentException(MatrixErrMsg.WrongDimensionErrMsg);
            }
            for (uint i = 0; i < aRowCount; i++)
            {
                for (uint j = 0; j < aColCount; j++)
                {
                    this.Body[i, j] = aBody[i * aColCount + j];
                }
            }
        }
        public Matrix(double[,] aBody) : this((uint)aBody.GetUpperBound(0) + 1, (uint)(aBody.Length / (aBody.GetUpperBound(0) + 1))) // создание матрицы из двумерного массива
        {
            for (uint i = 0; i < RowCount; i++)
            {
                for (uint j = 0; j < ColCount; j++)
                {
                    Body[i, j] = aBody[i, j];
                }
            }
        }
        public Matrix(Matrix m) : this(m.Body)
        {

        }
        public Matrix(double[][] aBody) : this((uint)aBody.Length, (uint)aBody[0].Length) // создание матрицы по массиву одномерных массивов
        {
            for (uint i = 0; i < RowCount; i++)
            {
                if (aBody[i].Length != ColCount)
                {
                    throw new Exception(MatrixErrMsg.WrongRowLengthErrMsg);                    
                }
                for (uint j = 0; j < ColCount; j++)
                {
                    Body[i, j] = aBody[i][j];
                }
            }
        }
        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.RowCount != b.RowCount)
            {
                return false;
            }
            if (a.ColCount != b.ColCount)
            {
                return false;
            }
            for (uint i = 0; i < a.RowCount; i++)
            {
                for (uint j = 0; j < a.ColCount; j++)
                {
                    if (a.Body[i, j] != b.Body[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.RowCount != b.RowCount)
            {
                throw new ArgumentException(MatrixErrMsg.WrongRowsNumberWhenAddingErrMsg);
            }
            if (a.ColCount != b.ColCount)
            {
                throw new ArgumentException(MatrixErrMsg.WrongColumnsNumberWhenAddingErrMsg);
            }
            Matrix c = new Matrix(a.RowCount, a.ColCount);
            for (uint i = 0; i < c.RowCount; i++)
            {
                for (uint j = 0; j < c.ColCount; j++)
                {
                    c.Body[i, j] = a.Body[i, j] + b.Body[i, j];
                }
            }
            return c;
        }        
        public static Matrix operator *(double a, Matrix b)
        {
            Matrix c = new Matrix(b.RowCount, b.ColCount);
            for (uint i = 0; i < c.RowCount; i++)
            {
                for (uint j = 0; j < c.ColCount; j++)
                {
                    c.Body[i, j] = a * b.Body[i, j];
                }
            }
            return c;
        }
        public static Matrix operator *(Matrix a, double b)
        {
            return b * a;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            return -1 * b + a;
        }        
        public static Matrix operator /(Matrix a, double b)
        {
            return a * (1 / b);
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.ColCount != b.RowCount)
            {
                throw new ArgumentException(MatrixErrMsg.WrongDimensionWhenMultiplyErrMsg);
            }
            Matrix c = new Matrix(a.RowCount, b.ColCount);
            for (uint i = 0; i < a.RowCount; i++)
            {
                for (uint j = 0; j < b.ColCount; j++)
                {                   
                    for (uint k = 0; k < a.ColCount; k++)
                    {
                        c.Body[i, j] += a.Body[i, k] * b.Body[k, j];
                    }
                }
            }
            return c;
        }
        public Matrix Pow(uint aPow)
        {
            if (RowCount != ColCount)
            {
                throw new Exception(MatrixErrMsg.WrongDimensionWhenPowErrMsg);
            }
            Matrix res = new Matrix(RowCount, 1.0);
            if (aPow == 0)
            {
                return res;
            }
            for (uint i = 0; i < aPow; i++)
            {
                res *= this;
            }
            return res;            
        }
        public Matrix Transp()
        {
            Matrix a = new Matrix(ColCount, RowCount);
            for (uint i = 0; i < RowCount; i++)
            {
                for (uint j = 0; j < ColCount; j++)
                    a.Body[j, i] = Body[i, j];
            }
            return a;
        }
        public Matrix TrimRow(uint aRow)
        {
            if (aRow >= RowCount)
            {
                throw new ArgumentException(MatrixErrMsg.WrongTrimRowNumErrMsg);
            }
            Matrix a = new Matrix(RowCount - 1, ColCount);
            for (uint j = 0; j < ColCount; j++)
            {
                for (uint i = 0; i < aRow; i++)
                {
                    a.Body[i, j] = Body[i, j];
                }
                for (uint i = aRow + 1; i < RowCount; i++)
                {
                    a.Body[i - 1, j] = Body[i, j];
                }
            }                                        
            return a;
        }
        public Matrix TrimCol(uint aCol)
        {
            if (aCol >= ColCount)
            {
                throw new ArgumentException(MatrixErrMsg.WrongTrimColNumErrMsg);
            }
            Matrix a = new Matrix(RowCount, ColCount - 1);
            for (uint i = 0; i < RowCount; i++)
            {
                for (uint j = 0; j < aCol; j++)
                {
                    a.Body[i, j] = Body[i, j];
                }
                for (uint j = aCol + 1; j < ColCount; j++)
                {
                    a.Body[i, j - 1] = Body[i, j];
                }
            }
            return a;
        }        
        public double Determinant()
        {
            if (RowCount != ColCount)
            {
                throw new Exception(MatrixErrMsg.NonSquareMatrixForDeterminantErrMsg);
            }            
            if (RowCount == 1)
            {
                return Body[0, 0];
            }
            double res = 0;
            for (uint i = 0; i < ColCount; i++)
            {
                res += Math.Pow(-1, i) * Body[0, i] * TrimRow(0).TrimCol(i).Determinant();
            }
            return res;
        }
        public Matrix Cofactor()
        {
            if (RowCount != ColCount)
            {
                throw new Exception(MatrixErrMsg.NonSquareMatrixForCofactorErrMsg);
            }
            Matrix adj = new Matrix(RowCount, ColCount);
            for (uint i = 0; i < RowCount; i++)
            {
                for (uint j = 0; j < RowCount; j++)
                {
                    adj.Body[i, j] = TrimRow(i).TrimCol(j).Determinant() * Math.Pow(-1, i + j);
                }
            }
            return adj;
        }
        public Matrix Adjugate()
        {
            if (RowCount != ColCount)
            {
                throw new Exception(MatrixErrMsg.NonSquareMatrixForAdjugateErrMsg);
            }
            return Cofactor().Transp();
        }        
        public Matrix Invert()
        {
            if (RowCount != ColCount)
            {
                throw new Exception(MatrixErrMsg.NonSquareMatrixForInvertErrMsg);
            }
            return Adjugate() / Determinant();
        }
        public Matrix AddRow(double[] aNewRow, uint aIndex = uint.MaxValue)
        {
            if (aNewRow.Length != ColCount)
            {
                throw new ArgumentException(MatrixErrMsg.WrongAddRowLengthErrMsg);
            }
            if (aIndex > RowCount)
            {
                aIndex = RowCount;
            }
            Matrix m = new Matrix(RowCount + 1, ColCount);
            for (uint j = 0; j < ColCount; j++)
            {
                for (uint i = 0; i < aIndex; i++)
                {
                    m.Body[i, j] = Body[i, j];
                }
                m.Body[aIndex, j] = aNewRow[j];
                for (uint i = aIndex + 1; i <= RowCount; i++) 
                {
                    m.Body[i, j] = Body[i - 1, j];
                }
            }
            return m;
        }
        public Matrix AddCol(double[] aNewCol, uint aIndex = uint.MaxValue)
        {
            if (aNewCol.Length != RowCount)
            {
                throw new ArgumentException(MatrixErrMsg.WrongAddColLengthErrMsg);
            }
            if (aIndex > ColCount)
            {
                aIndex = ColCount;
            }
            Matrix m = new Matrix(RowCount, ColCount + 1);
            for (uint i = 0; i < RowCount; i++)
            {
                for (uint j = 0; j < aIndex; j++)
                {
                    m.Body[i, j] = Body[i, j];
                }
                m.Body[i, aIndex] = aNewCol[i];
                for (uint j = aIndex + 1; j <= ColCount; j++)
                {
                    m.Body[i, j] = Body[i, j - 1];
                }
            }
            return m;
        }        
        public Matrix CopyRow(uint aFrom, uint aTo)
        {
            if (aFrom >= RowCount)
            {
                throw new Exception(MatrixErrMsg.WrongRowNumberForCopyingFromErrMsg);
            }
            if (aTo >= RowCount)
            {
                throw new Exception(MatrixErrMsg.WrongRowNumberForCopyingToErrMsg);
            }
            Matrix m = new Matrix(Body);
            for (uint i = 0; i < ColCount; i++)
            {
                m.Body[aTo, i] = m.Body[aFrom, i];
            }
            return m;
        }
        public double[] Row(uint aFrom)
        {
            double[] d = new double[ColCount];
            for (uint i = 0; i < ColCount; i++)
            {
                d[i] = Body[aFrom, i];
            }
            return d;
        }
        public Matrix CopyCol(uint aFrom, uint aTo)
        {
            if (aFrom >= ColCount)
            {
                throw new Exception(MatrixErrMsg.WrongColNumberForCopyingFromErrMsg);
            }
            if (aTo >= ColCount)
            {
                throw new Exception(MatrixErrMsg.WrongColNumberForCopyingToErrMsg);
            }
            Matrix m = new Matrix(Body);
            for (uint i = 0; i < RowCount; i++)
            {
                m.Body[i, aTo] = m.Body[i, aFrom];
            }
            return m;
        }
        public double[] Col(uint aFrom)
        {
            double[] d = new double[RowCount];
            for (uint i = 0; i < RowCount; i++)
            {
                d[i] = Body[i, aFrom];
            }
            return d;
        }
        public Matrix MoveRow(uint aFrom, uint aTo)
        {
            if (aFrom >= RowCount)
            {
                throw new Exception(MatrixErrMsg.WrongRowNumberForMovingFromErrMsg);
            }
            if (aTo >= RowCount)
            {
                throw new Exception(MatrixErrMsg.WrongRowNumberForMovingToErrMsg);
            }
            if (aFrom < aTo)
            {
                return AddRow(Row(aFrom), aTo + 1).TrimRow(aFrom);
            }
            return AddRow(Row(aFrom), aTo).TrimRow(aFrom + 1);
        }
        public Matrix MoveCol(uint aFrom, uint aTo)
        {
            if (aFrom >= ColCount)
            {
                throw new Exception(MatrixErrMsg.WrongColNumberForMovingFromErrMsg);
            }
            if (aTo >= ColCount)
            {
                throw new Exception(MatrixErrMsg.WrongColNumberForMovingToErrMsg);
            }
            if (aFrom < aTo)
            {
                return AddCol(Col(aFrom), aTo + 1).TrimCol(aFrom);
            }
            return AddCol(Col(aFrom), aTo).TrimCol(aFrom + 1);
        }
        public Matrix SwapRow(uint aFrom, uint aTo)
        {
            if (aFrom >= RowCount)
            {
                throw new Exception(MatrixErrMsg.WrongRowNumberForSwapFromErrMsg);
            }
            if (aTo >= RowCount)
            {
                throw new Exception(MatrixErrMsg.WrongRowNumberForSwapToErrMsg);
            }
            uint max, min;
            if (aFrom > aTo)
            {
                max = aFrom;
                min = aTo;
            }
            else if (aFrom < aTo) 
            {
                max = aTo;
                min = aFrom;
            }
            else
            {
                return this;
            }
            return MoveRow(min, max).MoveRow(max - 1, min);
        }
        public Matrix SwapCol(uint aFrom, uint aTo)
        {
            if (aFrom >= ColCount)
            {
                throw new Exception(MatrixErrMsg.WrongColNumberForSwapFromErrMsg);
            }
            if (aTo >= ColCount)
            {
                throw new Exception(MatrixErrMsg.WrongColNumberForSwapToErrMsg);
            }
            uint max, min;
            if (aFrom > aTo)
            {
                max = aFrom;
                min = aTo;
            }
            else if (aFrom < aTo)
            {
                max = aTo;
                min = aFrom;
            }
            else
            {
                return this;
            }
            return MoveCol(min, max).MoveCol(max - 1, min);
        }
        public Matrix MergeRow(uint aFrom, uint aTo, double aMultiplier) 
        {
            if (aFrom >= RowCount)
            {
                throw new Exception(MatrixErrMsg.WrongRowNumberForMergeFromErrMsg);
            }
            if (aTo >= RowCount)
            {
                throw new Exception(MatrixErrMsg.WrongRowNumberForMergeToErrMsg);
            }
            Matrix m = new Matrix(Body);
            for (uint i = 0; i < ColCount; i++)
            {
                m.Body[aTo, i] += m.Body[aFrom, i] * aMultiplier;
            }
            return m;
        }
        public Matrix MergeCol(uint aFrom, uint aTo, double aMultiplier)
        {
            if (aFrom >= ColCount)
            {
                throw new Exception(MatrixErrMsg.WrongColNumberForMergeFromErrMsg);
            }
            if (aTo >= ColCount)
            {
                throw new Exception(MatrixErrMsg.WrongColNumberForMergeToErrMsg);
            }
            Matrix m = new Matrix(Body);
            for (uint i = 0; i < RowCount; i++)
            {
                m.Body[i, aTo] += m.Body[i, aFrom] * aMultiplier;
            }
            return m;
        }
        public Matrix SubMatrix(uint aRowFrom, uint aRowTo, uint aColFrom, uint aColTo)
        {
            if (aRowFrom > RowCount)
            {
                throw new Exception(MatrixErrMsg.WrongSubmatrixRowNumberFromErrMsg);
            }
            if (aRowTo > RowCount)
            {
                throw new Exception(MatrixErrMsg.WrongSubmatrixRowNumberToErrMsg);
            }
            if (aColFrom > ColCount)
            {
                throw new Exception(MatrixErrMsg.WrongSubmatrixColNumberFromErrMsg);
            }
            if (aColTo > ColCount)
            {
                throw new Exception(MatrixErrMsg.WrongSubmatrixColNumberToErrMsg);
            }
            Matrix m = new Matrix(Body);
            uint rowMin = Math.Min(aRowFrom, aRowTo);
            uint rowMax = Math.Max(aRowFrom, aRowTo);
            uint colMin = Math.Min(aColFrom, aColTo);
            uint colMax = Math.Max(aColFrom, aColTo);
            for (uint i = 0; i < rowMin; i++)
            {
                m = m.TrimRow(0);
            }
            rowMax -= rowMin; 
            for (uint i = m.RowCount - 1; i > rowMax; i--)
            {
                m = m.TrimRow(i);
            }
            for (uint i = 0; i < colMin; i++)
            {
                m = m.TrimCol(0);
            }
            colMax -= colMin;
            for (uint i = m.ColCount - 1; i > colMax; i--)
            {
                m = m.TrimCol(i);
            }            
            if (aRowFrom > aRowTo) // перевороты если From > To
            {
                for (uint i = 0; i < (aRowFrom - aRowTo) / 2; i++)
                {
                    m = m.SwapRow(i, m.RowCount - 1 - i);
                }
            }
            if (aColFrom > aColTo)
            {
                for (uint i = 0; i < (aColFrom - aColTo) / 2; i++)
                {
                    m = m.SwapCol(i, m.ColCount - 1 - i);
                }
            }
            return m;
        }        
        public bool IsSquare()
        {
            if (RowCount == ColCount) 
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
        public bool IsVectorRow()
        {
            if (RowCount == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsVectorCol()
        {
            if (ColCount == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsScalar()
        {
            if (IsVectorCol() & IsVectorRow())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsDiag()
        {
            if (!IsSquare())
            {
                return false;
            }
            for (uint i = 0; i < RowCount; i++)
            {
                for (uint j = 0; j < ColCount; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        if (Body[i, j] != 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public Matrix Abs()
        {
            Matrix m = new Matrix(RowCount, ColCount);
            for (uint i = 0; i < RowCount; i++)
            {
                for (uint j = 0; j < ColCount; j++)
                {
                    m.Body[i, j] = Math.Abs(Body[i, j]);
                }
            }
            return m;
        }
        public double RowSum(uint aRowNumber)
        {
            if (aRowNumber >= RowCount)
            {
                throw new Exception(MatrixErrMsg.WronRowNumberForRowSumErrMsg);
            }
            double d = 0;
            for (uint i = 0; i < ColCount; i++)
            {
                d += Body[aRowNumber, i];
            }
            return d;
        }
        public double ColSum(uint aColNumber)
        {
            if (aColNumber >= ColCount)
            {
                throw new Exception(MatrixErrMsg.WronColNumberForColSumErrMsg);
            }
            double d = 0;
            for (uint i = 0; i < RowCount; i++)
            {
                d += Body[i, aColNumber];
            }
            return d;
        }
        public double LNorm()
        {
            Matrix m = new Matrix(Body);
            m = m.Abs();            
            double res = 0;
            for (uint i = 0; i < ColCount; i++ )
            {
                double d = m.ColSum(i);
                if (d > res)
                {
                    res = d;
                }
            }
            return res;
        }
        public double MNorm()
        {
            Matrix m = new Matrix(Body);
            m = m.Abs();            
            double res = 0;
            for (uint i = 0; i < RowCount; i++)
            {
                double d = m.RowSum(i);
                if (d > res)
                {
                    res = d;
                }
            }
            return res;
        }
        public double KNorm()
        {
            double d = 0;
            for (uint i = 0; i < RowCount; i++)
            {
                for (uint j = 0; j < ColCount; j++)
                {
                    d += Body[i, j] * Body[i, j];
                }
            }
            return Math.Sqrt(d);
        }        
        public uint Rank()
        {
            Matrix m = new Matrix(Body);
            // делаем так, чтобы количество строк было не меньше количества столбцов
            if (RowCount < ColCount)
            {
                m = m.Transp();
            }
            uint c = 0;
            uint count = 0;
            while (c < m.RowCount)
            {                
                if (m.Body[c, c] != 0) // элемент подходит, чтобы начать элементарные преобразования
                {
                    for (uint i = c + 1; i < m.RowCount; i++)
                    {
                        if (m.Body[i, c] != 0)
                        {
                            m = m.MergeRow(c, i, -m.Body[i, c] / m.Body[c, c]);
                        }
                    }                    
                    for (uint j = c + 1; j < m.ColCount; j++)
                    {
                        if (m.Body[c, j] != 0)
                        {
                            m = m.MergeCol(c, j, -m.Body[c, j] / m.Body[c, c]);
                        }
                    }                    
                    // удаляем нулевые строки и столбцы
                    Matrix a = m.Abs();
                    for (uint i = m.RowCount - 1; i > c; i--)
                    {
                        if (a.RowSum(i) == 0)
                        {
                            m = m.TrimRow(i);
                        }                        
                    }
                    for (uint j = m.ColCount - 1; j > c; j--)
                    {
                        if (a.ColSum(j) == 0)
                        {
                            m = m.TrimCol(j);
                        }                        
                    }
                    c++;
                }                
                else // нужно переставить строки или столбцы
                {
                    bool flag = true;
                    for (uint j = c + 1; j < ColCount; j++)
                    {
                        if (m.Body[c, j] != 0 )
                        {
                            m = m.SwapCol(c, j);
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        m = m.TrimRow(c);
                    }
                }                
            }            
            return m.RowCount;
        }
        public uint Defect()
        {
            return Math.Min(RowCount, ColCount) - Rank();
        }
        public Matrix SoLE(Matrix aRes) // System of linear equations 
        {
            if (!IsSquare())
            {
                throw new Exception(MatrixErrMsg.NonSquareMatrixForSoLEErrMsg);
            }
            if (RowCount != aRes.RowCount)
            {
                throw new Exception(MatrixErrMsg.WrongSoLEConstantTermsVectorDimensionErrMsg);
            }
            if (Determinant() == 0)
            {
                throw new Exception(MatrixErrMsg.SingularSoLEMatrixErrMsg);
            }                   
            return Invert() * aRes;
        }
        // System of linear equations - one more method, where ColCOunt = RowCount + 1
        // and aRes is the last column of matrix.        
        // Tests 
    }
}