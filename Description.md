# msvMatrix
Класс для работы с матрицами
Свойства:
  RowCount - количество строк в матрице
  ColCount - количество столбцов в матрице
  Body - тело матрицы, двумерный массив
Методы:
  Конструкторы:
    Matrix(uint aRowCount, uint aColCount, double aValue = 0) - матрица заданной размерности, все элементы которой равны заданному значению
    Matrix(uint aOrder, double aValue = 0, bool aIsScalar = true) - квадратная матрица, заполненная заданном числом или диогональная с заданным значением по главной диагонали
    Matrix(uint aRowCount, uint aColCount, double[] aBody) - матрица заданной размерности, элементы которой берутся из одномерного массива (элементы переностяся из массива в матрицу построчно слева направо, сверху вниз)
    Matrix(double[,] aBody) - создать матрицу из думерного массива
    Matrix(Matrix m) - создать матрицу - копию заданной
    Matrix(double[][] aBody) - матрица из одномерного массива одномерных массивов
  Операторы и логические проверки:
    ==(Matrix a, Matrix b) - сравнение на равенство
    !=(Matrix a, Matrix b) - сравнение на неравенство
    +(Matrix a, Matrix b) - сложение матриц    
    *(double a, Matrix b) - умножение скаляра на матрицу
    *(Matrix a, double b) - умножение матрицы на скаляр
    -(Matrix a, Matrix b) - вычитание матриц    
    /(Matrix a, double b) - деление матрицы на скаляр
    *(Matrix a, Matrix b) - произведение матриц
    Pow(uint aPow) - степень матрицы
    IsSquare() - проверка квадратности
    IsVectorRow() - проверка на вектор-строку
    IsVectorCol() - проверка на вектор столбец
    IsScalar() - проверка на скаляр
    IsDiag() - проверка на диоганальность

  Функции:
    Transp() - транспонирование
    TrimRow(uint aRow) - удалить строку
    TrimCol(uint aCol) - удалить столбец
    Determinant() - вычисление определителя матрицы
    Cofactor() - нахождение матрицы-кофактора
    Adjugate() - нахождение присоединенной матрицы
    Invert() - нахождение обратной матрицы
    AddRow(double[] aNewRow, uint aIndex = uint.MaxValue) - вставить строку
    AddCol(double[] aNewCol, uint aIndex = uint.MaxValue) - вставить столбец
    CopyRow(uint aFrom, uint aTo) - заменить одну строку другой
    Row(uint aFrom) - получить строку как одномерный массив
    CopyCol(uint aFrom, uint aTo) - заменить один столбец другим
    Col(uint aFrom) - получить столбцец как одномерный массив
    MoveRow(uint aFrom, uint aTo) - переместить строку
    MoveCol(uint aFrom, uint aTo) - переместить столбец
    SwapRow(uint aFrom, uint aTo) - поменять строки местами
    SwapCol(uint aFrom, uint aTo) - поменять столбцы местами
    MergeRow(uint aFrom, uint aTo, double aMultiplier) - элементарное преобразование строки aTo при помощи строки aFrom
    MergeCol(uint aFrom, uint aTo, double aMultiplier) - элементарное преобразование столбца aTo при помощи столбца aFrom
    SubMatrix(uint aRowFrom, uint aRowTo, uint aColFrom, uint aColTo) - получить подматрицу, элементы идут в порядке от From к To
    Abs() - абсолютное значение матрицы
    RowSum(uint aRowNumber) - сумма элементов строки
    ColSum(uint aColNumber) - сумма элементов столбца
    LNorm() - l-норма
    MNorm() - m-норма
    KNorm() - k-норма
    Rank() - ранг матрицы
    Defect() - дефект матрицы
    SoLE(Matrix aConstTerms) - решение СЛАУ (свободные члены в правой части системы)
    SoLE() - решение СЛАУ (свободные члены в левой части системы)










    
