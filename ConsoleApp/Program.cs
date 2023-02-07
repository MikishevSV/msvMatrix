using msvMatrix;

//arrange
uint row = 2;
uint col = 2;
double[] bodyA = { 1, 2, 3, 4};
Matrix a = new Matrix(row, col, bodyA);

a.Pow(10).Invert().Print();
a.Invert().Pow(10).Print();