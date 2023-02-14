using msvMatrix;

double[,] bodyA = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
double[,] bodyB = { { 1, 2, 3, 4, 5 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 6, 7, 8, 9, 10 }, { 21, 22, 23, 24, 25 } };
uint from = 2;
uint to = 2;
Matrix a = new Matrix(bodyA);
Matrix b = new Matrix(bodyB);
//act
a.Print();
a.SwapRow(from, to).Print();


