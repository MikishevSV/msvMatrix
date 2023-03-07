using msvMatrix;

double[,] bodyA = { { 2, 1, -5, 1 }, { 1, -3, 0, -6 }, { 0, 2, -1, 2 }, { 1, 4, -7, 6 } };
double[] bodyB = { 8, 9, -5, 0};
double[,] bodyC = { { 2, 1, -5, 1, -8 }, { 1, -3, 0, -6, -9 }, { 0, 2, -1, 2, 5 }, { 1, 4, -7, 6, 0 } };
Matrix a = new Matrix(bodyA);
Matrix b = new Matrix(4, 1, bodyB);
Matrix c = new Matrix(bodyC);
//act

a.SoLE(b).Print();
c.SoLE().Print();



