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
        public const string WrongRowNumberForCopyingFromErrMsg = "msvMatrix - CopyRow(uint, uint) - Неверный номер копируемой строки";
        public const string WrongRowNumberForCopyingToErrMsg = "msvMatrix - CopyRow(uint, uint) - Неверный номер строки в которую копируют";
        public const string WrongColNumberForCopyingFromErrMsg = "msvMatrix - CopyCol(uint, uint) - Неверный номер копируемого столбца";
        public const string WrongColNumberForCopyingToErrMsg = "msvMatrix - CopyCol(uint, uint) - Неверный номер столбца в который копируют";
        public const string WrongRowNumberForMovingFromErrMsg = "msvMatrix - MoveRow(uint, uint) - Неверный номер перемещаемой строки";
        public const string WrongRowNumberForMovingToErrMsg = "msvMatrix - MoveRow(uint, uint) - Неверный номер строки в который перемещают";
        public const string WrongColNumberForMovingFromErrMsg = "msvMatrix - MoveCol(uint, uint) - Неверный номер перемещаемого столбца";
        public const string WrongColNumberForMovingToErrMsg = "msvMatrix - MoveCol(uint, uint) - Неверный номер столбца в который перемещают";
        public const string WrongRowNumberForSwapFromErrMsg = "msvMatrix - SwapRow(uint, uint) - Неверный номер первой строки при обмене";
        public const string WrongRowNumberForSwapToErrMsg = "msvMatrix - SwapRow(uint, uint) - Неверный номер второй строки при обмене";
        public const string WrongColNumberForSwapFromErrMsg = "msvMatrix - SwapCol(uint, uint) - Неверный номер первого столбца при обмене";
        public const string WrongColNumberForSwapToErrMsg = "msvMatrix - SwapCol(uint, uint) - Неверный номер второго столбца при обмене";
        public const string WrongRowNumberForMergeFromErrMsg = "msvMatrix - MergeCol(uint, uint) - Неверный номер первой строки при слиянии";
        public const string WrongRowNumberForMergeToErrMsg = "msvMatrix - MergeCol(uint, uint) - Неверный номер второй строки при слиянии";
        public const string WrongColNumberForMergeFromErrMsg = "msvMatrix - MergeCol(uint, uint) - Неверный номер первого столбца при слиянии";
        public const string WrongColNumberForMergeToErrMsg = "msvMatrix - MergeCol(uint, uint) - Неверный номер второго столбца при слиянии";
        public const string WrongSubmatrixRowNumberFromErrMsg = "msvMatrix - Submatrix(uint, uint, uint, uint) - Неверный номер начальной строки для подматрицы";
        public const string WrongSubmatrixRowNumberToErrMsg = "msvMatrix - Submatrix(uint, uint, uint, uint) - Неверный номер конечной строки для подматрицы";
        public const string WrongSubmatrixColNumberFromErrMsg = "msvMatrix - Submatrix(uint, uint, uint, uint) - Неверный номер начального столбца для подматрицы";
        public const string WrongSubmatrixColNumberToErrMsg = "msvMatrix - Submatrix(uint, uint, uint, uint) - Неверный номер конечного столбца для подматрицы";
        public const string WronRowNumberForRowSumErrMsg = "msvMatrix - RowSum(uint) - неверный номер суммируемой строки";
        public const string WronColNumberForColSumErrMsg = "msvMatrix - ColSum(uint) - неверный номер суммируемого столбца";
        public const string NonSquareMatrixForSoLEErrMsg = "msvMatrix - SoLE(Matrix) - для решения СЛАУ матрица д.б. квадратной";
        public const string WrongSoLEConstantTermsVectorDimensionErrMsg = "msvMatrix - SoLE(Matrix) - неверная размерность вектора свободных членов СЛАУ";
        public const string SingularSoLEMatrixErrMsg = "msvMatrix - SoLE(Matrix) - для решения СЛАУ матрица не должна быть вырожденной";
        public const string WrongDimensionForSoLEErrMsg = "msvMatrix - SoLE() - неверный размер матрицы для СЛАУ";
    }
}
