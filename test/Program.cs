using msvMatrix;
using System.Globalization;

public static class Test
{
    public static void Main()
    {
        bool res = true;
        res &= Test_001();
        res &= Test_002();
        res &= Test_003();
        res &= Test_004();
        res &= Test_005();
        res &= Test_006();
        res &= Test_007();
        if (res)
        {
            Console.WriteLine("Все тесты пройдены успешно");
        }
        else
        {
            Console.WriteLine("ОШИБКА ТЕСТИРОВАНИЯ!");
        }
    }
    public static bool Test_001()
    {
        Console.WriteLine("001 - Создание прямоугольной матрицы");
        bool res = true;
        res &= Test_001_001();
        res &= Test_001_002();
        if (res)
        {
            Console.WriteLine("Секция 001 выполнена успешно");
        }
        else
        {
            Console.WriteLine("Секция 001 выполнена c ошибками");
        }
        return res;
    }
    public static bool Test_001_001()
    {
        Console.Write("\t001 - заполненной нулями : ");
        try
        {
            uint row = 10;
            uint col = 2000;
            Matrix m = new Matrix(row, col);
            if (m.RowCount != row)
            {
                throw new Exception("001_001_001");
            }
            if (m.ColumnCount != col)
            {
                throw new Exception("001_001_002");
            }
            if (m.Body.Length != row * col)
            {
                throw new Exception("001_001_003");
            }
            if (m.Body.GetUpperBound(0) + 1 != row)
            {
                throw new Exception("001_001_004");
            }
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < col; j++)
                {
                    if (m.Body[i, j] != 0)
                    {
                        throw new Exception("001_001_005");
                    }
                }
            }
            Console.WriteLine("успешно");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА: {e.Message}");
            return false;
        }
    }
    public static bool Test_001_002()
    {
        Console.Write("\t002 - заполненной числом : ");
        try
        {
            uint row = 321;
            uint col = 4321;
            double value = 654321.789;
            Matrix m = new Matrix(row, col, value);
            if (m.RowCount != row)
            {
                throw new Exception("001_002_001");
            }
            if (m.ColumnCount != col)
            {
                throw new Exception("001_002_002");
            }
            if (m.Body.Length != row * col)
            {
                throw new Exception("001_002_003");
            }
            if (m.Body.GetUpperBound(0) + 1 != row)
            {
                throw new Exception("001_002_004");
            }
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < col; j++)
                {
                    if (m.Body[i, j] != value)
                    {
                        throw new Exception("001_002_005");
                    }
                }
            }

            Console.WriteLine("успешно");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
    }
    public static bool Test_002()
    {
        Console.WriteLine("002 - Создание квадратной матрицы");
        bool res = true;
        res &= Test_002_001();
        res &= Test_002_002();
        res &= Test_002_003();
        if (res)
        {
            Console.WriteLine("Секция 002 выполнена успешно");
        }
        else
        {
            Console.WriteLine("Секция 002 выполнена c ошибками");
        }
        return res;
    }
    public static bool Test_002_001()
    {
        try
        {
            Console.Write("\t001 - заполненной нулями : ");
            uint order = 123;
            Matrix m = new Matrix(order);
            if (m.RowCount != order)
            {
                throw new Exception("002_001_001");
            }
            if (m.ColumnCount != order)
            {
                throw new Exception("002_001_002");
            }
            if (m.Body.Length != order * order)
            {
                throw new Exception("002_001_003");
            }
            if (m.Body.GetUpperBound(0) + 1 != order)
            {
                throw new Exception("002_001_004");
            }
            for (uint i = 0; i < order; i++)
            {
                for (uint j = 0; j < order; j++)
                {
                    if (m.Body[i, j] != 0)
                    {
                        throw new Exception("002_001_005");
                    }
                }
            }
            Console.WriteLine("успешно");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }

    }
    public static bool Test_002_002()
    {
        try
        {
            Console.Write("\t002 - диогональной : ");
            uint order = 123;
            double value = -1;
            Matrix m = new Matrix(order, value);
            if (m.RowCount != order)
            {
                throw new Exception("002_002_001");
            }
            if (m.ColumnCount != order)
            {
                throw new Exception("002_002_002");
            }
            if (m.Body.Length != order * order)
            {
                throw new Exception("002_002_003");
            }
            if (m.Body.GetUpperBound(0) + 1 != order)
            {
                throw new Exception("002_002_004");
            }
            for (uint i = 0; i < order; i++)
            {
                for (uint j = 0; j < order; j++)
                {
                    if (i == j)
                    {
                        if (m.Body[i, j] != value)
                        {
                            throw new Exception("002_002_005");
                        }
                    }
                    else
                    {
                        if (m.Body[i, j] != 0)
                        {
                            throw new Exception("002_002_006");
                        }
                    }
                }
            }
            Console.WriteLine("успешно");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
    }
    public static bool Test_002_003()
    {
        try
        {
            Console.Write("\t003 - заполненной числом : ");
            uint order = 123;
            double value = 5.6;
            bool isScalar = false;
            Matrix m = new Matrix(order, value, isScalar);
            if (m.RowCount != order)
            {
                throw new Exception("002_003_001");
            }
            if (m.ColumnCount != order)
            {
                throw new Exception("002_003_002");
            }
            if (m.Body.Length != order * order)
            {
                throw new Exception("002_003_003");
            }
            if (m.Body.GetUpperBound(0) + 1 != order)
            {
                throw new Exception("002_003_004");
            }
            for (uint i = 0; i < order; i++)
            {
                for (uint j = 0; j < order; j++)
                {
                    if (m.Body[i, j] != value)
                    {
                        throw new Exception("002_003_005");
                    }
                }
            }
            Console.WriteLine("успешно");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
    }
    public static bool Test_003()
    {
        Console.WriteLine("003 - Создание матрицы из одномерного массива");
        bool res = true;
        res &= Test_003_001();
        if (res)
        {
            Console.WriteLine("Секция 003 выполнена успешно");
        }
        else
        {
            Console.WriteLine("Секция 003 выполнена c ошибками");
        }
        return res;
    }
    public static bool Test_003_001()
    {
        try
        {
            Console.Write("\t001 - заполненной числом : ");
            uint row = 2;
            uint col = 3;
            double[] arr = { 0, 1, 2, 3, 4, 5 };
            bool isScalar = false;
            Matrix m = new Matrix(row, col, arr);
            if (m.RowCount != row)
            {
                throw new Exception("003_001_001");
            }
            if (m.ColumnCount != col)
            {
                throw new Exception("003_001_002");
            }
            if (m.Body.Length != row * col)
            {
                throw new Exception("003_001_003");
            }
            if (m.Body.GetUpperBound(0) + 1 != row)
            {
                throw new Exception("003_001_004");
            }
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < col; j++)
                {
                    if (m.Body[i, j] != arr[i * col + j])
                    {
                        throw new Exception("003_001_005");
                    }
                }
            }
            if ((m.Body[0, 0] != 0) | (m.Body[0, 1] != 1) | (m.Body[0, 2] != 2) | (m.Body[1, 0] != 3) | (m.Body[1, 1] != 4) | (m.Body[1, 2] != 5))
            {
                throw new Exception("003_001_006");
            }
            Console.WriteLine("успешно");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
    }
    public static bool Test_004()
    {
        Console.WriteLine("004 - Умножение и деление матрицы и скаляра");
        bool res = true;
        res &= Test_004_001();
        res &= Test_004_002();
        res &= Test_004_003();

        if (res)
        {
            Console.WriteLine("Секция 004 выполнена успешно");
        }
        else
        {
            Console.WriteLine("Секция 004 выполнена c ошибками");
        }
        return res;
    }
    public static bool Test_004_001()
    {
        Console.Write("\t001 - умножение матрицы на скаляр : ");
        try
        {
            uint row = 2;
            uint col = 2;
            double[] arr = { 0, 1, 2, 3 };
            double b = 4;
            Matrix a = new Matrix(row, col, arr);

            Matrix c;
            try
            {
                c = a * b;
            }
            catch (Exception e)
            {
                throw new Exception($"004_001_001 {e.Message}"); // умножение матрицы на скаляр прошло неуспешно
            }
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < col; j++)
                {
                    if (c.Body[i, j] != a.Body[i, j] * b)
                    {
                        throw new Exception("004_001_002"); // результат умножения не верный
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_004_002()
    {
        Console.Write("\t002 - умножение скаляра на матрицу : ");
        try
        {
            uint row = 2;
            uint col = 2;
            double[] arr = { 0, 1, 2, 3 };
            double b = 4;
            Matrix a = new Matrix(row, col, arr);

            Matrix c;
            try
            {
                c = b * a;
            }
            catch (Exception e)
            {
                throw new Exception($"004_002_001 {e.Message}"); // умножение матрицы на скаляр прошло неуспешно
            }
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < col; j++)
                {
                    if (c.Body[i, j] != a.Body[i, j] * b)
                    {
                        throw new Exception("004_002_002"); // результат умножения не верный
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_004_003()
    {
        Console.Write("\t001 - деление матрицы на скаляр : ");
        try
        {
            uint row = 2;
            uint col = 2;
            double[] arr = { 0, 1, 2, 3 };
            double b = 0.25;
            Matrix a = new Matrix(row, col, arr);

            Matrix c;
            try
            {
                c = a / b;
            }
            catch (Exception e)
            {
                throw new Exception($"004_002_001 {e.Message}"); // деление матрицы на скаляр прошло неуспешно
            }
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < col; j++)
                {
                    if (c.Body[i, j] != a.Body[i, j] / b)
                    {
                        throw new Exception("004_002_002"); // результат деления не верный
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_005()
    {
        Console.WriteLine("005 - Сложение и вычитание матриц");
        bool res = true;
        res &= Test_005_001();
        res &= Test_005_002();
        res &= Test_005_003();
        res &= Test_005_004();
        if (res)
        {
            Console.WriteLine("Секция 005 выполнена успешно");
        }
        else
        {
            Console.WriteLine("Секция 005 выполнена c ошибками");
        }
        return res;
    }
    public static bool Test_005_001()
    {
        Console.Write("\t001 - разное количество строк : ");
        try
        {
            uint row1 = 2;
            uint row2 = 3;
            uint col = 2;

            double[] arr1 = { 0, 1, 2, 3 };
            double[] arr2 = { 0, 1, 2, 3, 4, 5 };
            Matrix a = new Matrix(row1, col, arr1);
            Matrix b = new Matrix(row2, col, arr2);
            Matrix c;
            try
            {
                c = a + b;
                throw new Exception("005_001_001"); // при сложении матриц с разным количеством строк не получили ошибки, а должны были
            }
            catch (Exception e)
            {

                if (e.Message != "msvMatrix - Operator +(Matrix, Matrix) - Попытка сложить матрицы с разным количеством строк")
                {
                    throw new Exception("005_001_002"); // при сложении матриц с разным количеством строк произошла ошибка, но не та которую ждали
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_005_002()
    {
        Console.Write("\t002 - разное количество столбцов : ");
        try
        {
            uint row = 2;
            uint col1 = 2;
            uint col2 = 3;
            double[] arr1 = { 0, 1, 2, 3 };
            double[] arr2 = { 0, 1, 2, 3, 4, 5 };
            Matrix a = new Matrix(row, col1, arr1);
            Matrix b = new Matrix(row, col2, arr2);
            Matrix c;
            try
            {
                c = a + b;
                throw new Exception("005_002_001"); // при сложении матриц с разным количеством столбцов не получили ошибки, а должны были
            }
            catch (Exception e)
            {
                if (e.Message != "msvMatrix - Operator +(Matrix, Matrix) - Попытка сложить матрицы с разным количеством столбцов")
                {
                    throw new Exception("005_002_001"); // при сложении матриц с разным количеством столбцов произошла ошибка, но не та которую ждали
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_005_003()
    {
        Console.Write("\t003 - сложение : ");
        try
        {
            uint row = 2;
            uint col = 2;
            double[] arr1 = { 0, 1, 2, 3 };
            double[] arr2 = { 1, 2, 3, 4 };
            Matrix a = new Matrix(row, col, arr1);
            Matrix b = new Matrix(row, col, arr2);
            Matrix c;
            try
            {
                c = a + b;
            }
            catch (Exception e)
            {
                throw new Exception($"005_003_001 {e.Message}"); // сложение матриц прошло неуспешно
            }
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < col; j++)
                {
                    if (c.Body[i, j] != a.Body[i, j] + b.Body[i, j])
                    {
                        throw new Exception("005_001_006"); // результат сложения матриц не верный
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_005_004()
    {
        Console.Write("\t004 - вычитание : ");
        try
        {
            uint row = 2;
            uint col = 2;
            double[] arr1 = { 1, 2, 3, 4 };
            double[] arr2 = { 0, 1, 2, 3 };

            Matrix a = new Matrix(row, col, arr1);
            Matrix b = new Matrix(row, col, arr2);
            Matrix c;
            try
            {
                c = a - b;
            }
            catch (Exception e)
            {
                throw new Exception($"005_004_001 {e.Message}"); // вычитание матриц прошло неуспешно
            }
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < col; j++)
                {
                    if (c.Body[i, j] != a.Body[i, j] - b.Body[i, j])
                    {
                        throw new Exception("005_001_006"); // результат сложения матриц не верный
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_006()
    {
        Console.WriteLine("006 - Равенство и неравенство матриц");
        bool res = true;
        res &= Test_006_001();
        res &= Test_006_002();
        res &= Test_006_003();
        res &= Test_006_004();
        res &= Test_006_005();
        res &= Test_006_006();
        res &= Test_006_007();
        res &= Test_006_008();
        if (res)
        {
            Console.WriteLine("Секция 006 выполнена успешно");
        }
        else
        {
            Console.WriteLine("Секция 006 выполнена c ошибками");
        }
        return res;
    }
    public static bool Test_006_001()
    {
        Console.Write("\t001 - равенство равных : ");
        try
        {
            uint row = 2;
            uint col = 2;
            double[] arr = { 1, 2, 3, 4 };
            bool res;
            Matrix a = new Matrix(col, row, arr);
            Matrix b = new Matrix(col, row, arr);
            try
            {
                res = (a == b);
            }
            catch (Exception e)
            {
                throw new Exception($"006_001_001 - {e.Message}");
            }

            if (!res)
            {
                throw new Exception("006_001_002");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_006_002()
    {
        Console.Write("\t002 - равенство неравных (количество строк): ");
        try
        {
            uint row1 = 2;
            uint row2 = 3;
            uint col = 2;
            double[] arr1 = { 1, 2, 3, 4 };
            double[] arr2 = { 2, 3, 4, 5, 6, 7 };
            bool res;
            Matrix a = new Matrix(row1, col, arr1);
            Matrix b = new Matrix(row2, col, arr2);
            try
            {
                res = (a == b);
            }
            catch (Exception e)
            {
                throw new Exception($"006_002_001 - {e.Message}");
            }

            if (res)
            {
                throw new Exception("006_002_002");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_006_003()
    {
        Console.Write("\t003 - равенство неравных (количество столбцов): ");
        try
        {
            uint row = 2;
            uint col1 = 2;
            uint col2 = 3;
            double[] arr1 = { 1, 2, 3, 4 };
            double[] arr2 = { 2, 3, 4, 5, 6, 7 };
            bool res;
            Matrix a = new Matrix(row, col1, arr1);
            Matrix b = new Matrix(row, col2, arr2);
            try
            {
                res = (a == b);
            }
            catch (Exception e)
            {
                throw new Exception($"006_003_001 - {e.Message}");
            }

            if (res)
            {
                throw new Exception("006_003_002");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_006_004()
    {
        Console.Write("\t004 - равенство неравных (значения элементов): ");
        try
        {
            uint row = 2;
            uint col = 2;            
            double[] arr1 = { 1, 2, 3, 4 };
            double[] arr2 = { 2, 3, 4, 5 };
            bool res;
            Matrix a = new Matrix(row, col, arr1);
            Matrix b = new Matrix(row, col, arr2);
            try
            {
                res = (a == b);
            }
            catch (Exception e)
            {
                throw new Exception($"006_004_001 - {e.Message}");
            }

            if (res)
            {
                throw new Exception("006_004_002");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_006_005()
    {
        Console.Write("\t005 - неравенство равных : ");
        try
        {
            uint row = 2;
            uint col = 2;
            double[] arr = { 1, 2, 3, 4 };
            bool res;
            Matrix a = new Matrix(col, row, arr);
            Matrix b = new Matrix(col, row, arr);
            try
            {
                res = (a != b);
            }
            catch (Exception e)
            {
                throw new Exception($"006_005_001 - {e.Message}");
            }

            if (res)
            {
                throw new Exception("006_005_002");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_006_006()
    {
        Console.Write("\t006 - неравенство неравных (количество строк): ");
        try
        {
            uint row1 = 2;
            uint row2 = 3;
            uint col = 2;
            double[] arr1 = { 1, 2, 3, 4 };
            double[] arr2 = { 2, 3, 4, 5, 6, 7 };
            bool res;
            Matrix a = new Matrix(row1, col, arr1);
            Matrix b = new Matrix(row2, col, arr2);
            try
            {
                res = (a != b);
            }
            catch (Exception e)
            {
                throw new Exception($"006_006_001 - {e.Message}");
            }

            if (!res)
            {
                throw new Exception("006_006_002");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_006_007()
    {
        Console.Write("\t007 - неравенство неравных (количество столбцов): ");
        try
        {
            uint row = 2;
            uint col1 = 2;
            uint col2 = 3;
            double[] arr1 = { 1, 2, 3, 4 };
            double[] arr2 = { 2, 3, 4, 5, 6, 7 };
            bool res;
            Matrix a = new Matrix(row, col1, arr1);
            Matrix b = new Matrix(row, col2, arr2);
            try
            {
                res = (a != b);
            }
            catch (Exception e)
            {
                throw new Exception($"006_007_001 - {e.Message}");
            }

            if (!res)
            {
                throw new Exception("006_007_002");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_006_008()
    {
        Console.Write("\t008 - неравенство неравных (значения элементов): ");
        try
        {
            uint row = 2;
            uint col = 2;
            double[] arr1 = { 1, 2, 3, 4 };
            double[] arr2 = { 2, 3, 4, 5 };
            bool res;
            Matrix a = new Matrix(row, col, arr1);
            Matrix b = new Matrix(row, col, arr2);
            try
            {
                res = (a != b);
            }
            catch (Exception e)
            {
                throw new Exception($"006_008_001 - {e.Message}");
            }

            if (!res)
            {
                throw new Exception("006_008_002");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_007()
    {
        Console.WriteLine("007 - Произведение матриц");
        bool res = true;
        res &= Test_007_001();
        res &= Test_007_002();

        if (res)
        {
            Console.WriteLine("Секция 007 выполнена успешно");
        }
        else
        {
            Console.WriteLine("Секция 007 выполнена c ошибками");
        }
        return res;
    }
    public static bool Test_007_001()
    {
        Console.Write("\t001 - непоходящие размерности множителей : ");
        try
        {
            uint row1 = 2;
            uint row2 = 3;
            uint col = 2;

            double[] arr1 = { 0, 1, 2, 3 };
            double[] arr2 = { 0, 1, 2, 3, 4, 5 };
            Matrix a = new Matrix(row1, col, arr1);
            Matrix b = new Matrix(row2, col, arr2);
            Matrix c;
            try
            {
                c = a * b;
                throw new Exception("007_001_001"); // при перемножении матриц с непоходящими размерностями не получили ошибки, а должны были
            }
            catch (Exception e)
            {
                if (e.Message == "007_001_001")
                {
                    throw new Exception("007_001_001"); // пробрасываем дальше
                }
                if (e.Message != "msvMatrix - Operator *(Matrix, Matrix) - Попытка перемножить матрицы с неподходящей размерностью")
                {
                    throw new Exception("007_001_002"); // при сложении матриц с разным количеством строк произошла ошибка, но не та которую ждали
                }
            }
            
        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }
    public static bool Test_007_002()
    {
        Console.Write("\t002 - проверка результата перемножения : ");
        try
        {
            uint row1 = 2;
            uint col1 = 4;
            double[] arr1 = { 3, 2, 8, 1, 1, -4, 0, 3 };
            Matrix a = new Matrix(row1, col1, arr1);

            uint row2 = 4;
            uint col2 = 2;
            double[] arr2 = { 2, -1, 1, -3, 0, 1, 3, 1 };
            Matrix b = new Matrix(row2, col2, arr2);
            
            double[] arr3 = { 11, 0, 7, 14 };
            Matrix c1 = new Matrix(row1, col2, arr3);
            Matrix c2;
            try
            {
                c2 = a * b;                
            }
            catch (Exception e)
            {
                throw new Exception("007_002_001 + {e.Message}"); 
            }
            if (c1 != c2)
            {
                throw new Exception("007_002_002");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine($"ОШИБКА {e.Message}");
            return false;
        }
        Console.WriteLine("успешно");
        return true;
    }


}