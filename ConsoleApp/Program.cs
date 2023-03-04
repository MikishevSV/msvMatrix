using msvMatrix;

double[,] bodyA = { { 3, -1, 0 }, { -2, 1, 1 }, { 2, -1, 4 } };
double[] bodyB = { 5, 0, 15 };

Matrix a = new Matrix(bodyA);
Matrix b = new Matrix(3, 1, bodyB);
//act

a.SoLE(b).Print();



