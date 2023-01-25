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
                    throw new Exception("msvMatrix - RowCount - Неверное значение количества строк!");
                }
            }
        }
        private uint _ColumnCount; // количество столбцов
        public uint ColumnCount
        {
            get
            {
                return _ColumnCount;
            }
            set
            {
                if (value > 0)
                {
                    _ColumnCount = value;
                }
                else
                {
                    throw new Exception("msvMatrix - ColumnCount - Неверное значение количества столбцов!");
                }
            }
        }
        public double[,] Body; // тело матрицы
        public Matrix(uint aRowCount, uint aColumnCount, double aValue = 0) // создание заполненной одним значением матрицы
        {
            RowCount = aRowCount;
            ColumnCount = aColumnCount;
            Body = new double[aRowCount, aColumnCount];
            for (uint i = 0; i < aRowCount; i++)
            {
                for (uint j = 0; j < aColumnCount; j++)
                {
                    Body[i, j] = aValue;
                }
            }
        }
        public Matrix(uint aOrder, double aValue = 0, bool aIsScalar = true) : this(aOrder, aOrder)// создание диоганальной или заполненной квадратной матрицы
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
        public Matrix(uint aRowCount, uint aColumnCount, double[] aArray) : this(aRowCount, aColumnCount) // создание произвольной матрицы из одномерного массива
        {
            for (uint i = 0; i < aRowCount; i++)
            {
                for (uint j = 0; j < aColumnCount; j++)
                {
                    this.Body[i, j] = aArray[i * aColumnCount + j];
                }
            }
        }
        public static Matrix operator *(double a, Matrix b)
        {
            Matrix c = new Matrix(b.RowCount, b.ColumnCount);
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
                throw new ArgumentException("msvMatrix - Operator +(Matrix, Matrix) - Попытка сложить матрицы с разным количеством строк");
            }
            if (a.ColumnCount != b.ColumnCount)
            {
                throw new ArgumentException("msvMatrix - Operator +(Matrix, Matrix) - Попытка сложить матрицы с разным количеством столбцов");
            }
            Matrix c = new Matrix(a.RowCount, a.ColumnCount);
            for (uint i = 0; i < c.RowCount; i++)
            {
                for (uint j = 0; j < c.ColumnCount; j++)
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
        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.RowCount != b.RowCount)
            {
                return false;
            }
            if (a.ColumnCount != b.ColumnCount)
            {
                return false;
            }
            for (uint i = 0; i < a.RowCount; i++)
            {
                for (uint j = 0; j < a.ColumnCount; j++)
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
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.ColumnCount != b.RowCount)
            {
                throw new Exception("msvMatrix - Operator *(Matrix, Matrix) - Попытка перемножить матрицы с неподходящей размерностью");
            }
            Matrix c = new Matrix(a.RowCount, b.ColumnCount);
            for (uint i = 0; i < c.RowCount; i++)
            {
                for (uint j = 0; j < c.ColumnCount; j++)
                {                    
                    for (uint k = 0; k < a.ColumnCount; k++)
                    {
                        c.Body[i, j] += a.Body[i, k] * b.Body[k, j];
                    }
                }
            }
            return c;
        }
    }
}