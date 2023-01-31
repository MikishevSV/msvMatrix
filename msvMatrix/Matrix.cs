namespace msvMatrix
{
    public class Matrix
    {
        public const string WrongRowCountErrMsg = "msvMatrix - RowCount - Неверное значение количества строк!";
        public const string WrongColCountErrMsg  = "msvMatrix - ColCount - Неверное значение количества столбцов!";
        public const string WrongDimensionErrMsg = "msvMatrix - Constructor(uint, uint, double[]) - длина массива не соответствует размерности матрицы";
        public const string WrongRowsNumberWhenAddingErrMsg = "msvMatrix - Operator +(Matrix, Matrix) - Попытка сложить матрицы с разным количеством строк";
        public const string WrongColumnsNumberWhenAddingErrMsg = "msvMatrix - Operator +(Matrix, Matrix) - Попытка сложить матрицы с разным количеством столбцов";
        public const string WrongDimensionWhenMultiplyErrMsg = "msvMatrix - Operator *(Matrix, Matrix) - Попытка перемножить матрицы с неподходящей размерностью";
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
                    throw new Exception(WrongRowCountErrMsg);
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
                    throw new Exception(WrongColCountErrMsg);
                }
            }
        }
        public double[,] Body; // тело матрицы
        public Matrix(uint aRowCount, uint aColCount, double aValue = 0) // создание заполненной одним значением матрицы
        {
            RowCount = aRowCount;
            ColCount = aColCount;
            Body = new double[aRowCount, aColCount];
            for (uint i = 0; i < aRowCount; i++)
            {
                for (uint j = 0; j < aColCount; j++)
                {
                    Body[i, j] = aValue;
                }
            }
        }
        public Matrix(uint aOrder, double aValue = 0, bool aIsScalar = true) : this(aOrder, aOrder) // создание диоганальной или заполненной квадратной матрицы
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
        public Matrix(uint aRowCount, uint aColCount, double[] aArray) : this(aRowCount, aColCount) // создание произвольной матрицы из одномерного массива
        {
            if (aRowCount * aColCount != aArray.Length)
            {
                throw new ArgumentException(WrongDimensionErrMsg);
            }
            for (uint i = 0; i < aRowCount; i++)
            {
                for (uint j = 0; j < aColCount; j++)
                {
                    this.Body[i, j] = aArray[i * aColCount + j];
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
        public static Matrix operator *(double a, Matrix b)
        {
            Matrix c = new Matrix(b.RowCount, b.ColCount);
            for (uint i = 0; i < c.RowCount; i++)
            {
                for (uint j = 0; j < c.RowCount; j++)
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
        public static Matrix operator /(Matrix a, double b)
        {
            return a * (1 / b);
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.RowCount != b.RowCount)
            {
                throw new ArgumentException(WrongRowsNumberWhenAddingErrMsg);
            }
            if (a.ColCount != b.ColCount)
            {
                throw new ArgumentException(WrongColumnsNumberWhenAddingErrMsg);
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
        public static Matrix operator -(Matrix a, Matrix b) 
        {
            return -1 * b + a;
        }
        
    }
}