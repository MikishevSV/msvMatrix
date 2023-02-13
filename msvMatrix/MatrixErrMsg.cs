using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msvMatrix
{
    public static class MatrixErrMsg
    {
        public const string WrongRowCountErrMsg = "msvMatrix - RowCount - Неверное значение количества строк!";
        public const string WrongColCountErrMsg = "msvMatrix - ColCount - Неверное значение количества столбцов!";
        public const string WrongDimensionErrMsg = "msvMatrix - Constructor(uint, uint, double[]) - длина массива не соответствует размерности матрицы";
        public const string WrongRowLengthErrMsg = "msvMatrix - Constructor(double[][]) - разная длина элементов массива";
        public const string WrongRowsNumberWhenAddingErrMsg = "msvMatrix - Operator +(Matrix, Matrix) - Попытка сложить/вычесть матрицы с разным количеством строк";
        public const string WrongColumnsNumberWhenAddingErrMsg = "msvMatrix - Operator +(Matrix, Matrix) - Попытка сложить/вычесть матрицы с разным количеством столбцов";
        public const string WrongDimensionWhenMultiplyErrMsg = "msvMatrix - Operator *(Matrix, Matrix) - Попытка перемножить матрицы с неподходящей размерностью";
        public const string WrongDimensionWhenPowErrMsg = "msvMatrix - Pow (uint) - Попытка возвести в степень не квадратную матрицу";
        public const string NonSquareMatrixForDeterminantErrMsg = "msvMatrix - Determinant() - Для вычисления определителя матрица должна быть квадратной";
        public const string WrongTrimRowNumErrMsg = "msvMatrix - TrimRow - неверный индекс вырезаемой строки";
        public const string WrongTrimColNumErrMsg = "msvMatrix - TrimCOl - неверный индекс вырезаемого столбца";
        public const string NonSquareMatrixForCofactorErrMsg = "msvMatrix - Cofactor() - Для вычисления матрицы дополнений, матрица должна быть квадратной";
        public const string NonSquareMatrixForAdjugateErrMsg = "msvMatrix - Adjugate() - Для вычисления присоединенной, матрица должна быть квадратной";
        public const string NonSquareMatrixForInvertErrMsg = "msvMatrix - Invert() - Для вычисления обратной, матрица должна быть квадратной";
        public const string WrongAddRowLengthErrMsg = "msvMatrix - AddRow(double[], uint) - Длина добавляемой строки не совпадает с количеством столбцов матрицы";
        public const string WrongAddColLengthErrMsg = "msvMatrix - AddCol(double[], uint) - Длина добавляемого столбца не совпадает с количеством строк матрицы";
        public const string WrongRowNumberForMovingFrom = "msvMatrix - MoveRow(uint, uint) - Неверный номер перемещаемого столбца";
        public const string WrongRowNumberForMovingTo = "msvMatrix - MoveRow(uint, uint) - Неверный номер столбца на который перемещают";
    }
}
