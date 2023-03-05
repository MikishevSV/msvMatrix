using msvMatrix;

double[,] bodyA = { { 2, 1, -5, 1 }, { 1, -3, 0, -6 }, { 0, 2, -1, 2 }, { 1, 4, -7, 6 } };
double[] bodyB = { 8, 9, -5, 0};

Matrix a = new Matrix(bodyA);
Matrix b = new Matrix(4, 1, bodyB);
//act

a.SoLE(b).Print();
(a * a.SoLE(b)).Print();



