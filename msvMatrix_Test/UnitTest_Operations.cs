using msvMatrix;
namespace msvMatrix_Test
{
    [TestClass]
    public class UnitTest_Operations
    {
        [TestMethod]
        public void Test_001_EqualityOfEquals()
        {
            //arrange
            uint row = 3;
            uint col = 4;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //act
            Matrix a1 = new Matrix(row, col, body);
            Matrix a2 = new Matrix(row, col, body);

            //assert
            Assert.IsTrue(a1 == a2);
        }
        [TestMethod]
        public void Test_002_EqualityOfNonEquals_Row()
        {
            //arrange
            uint row1 = 2;
            uint row2 = 3;
            uint col = 4;
            double[] body1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double[] body2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //act
            Matrix a1 = new Matrix(row1, col, body1);
            Matrix a2 = new Matrix(row2, col, body2);

            //assert
            Assert.IsFalse(a1 == a2);
        }
        [TestMethod]
        public void Test_003_EqualityOfNonEquals_Col()
        {
            //arrange            
            uint row = 3;
            uint col1 = 3;
            uint col2 = 4;
            double[] body1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] body2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //act
            Matrix a1 = new Matrix(row, col1, body1);
            Matrix a2 = new Matrix(row, col2, body2);

            //assert
            Assert.IsFalse(a1 == a2);
        }
        [TestMethod]
        public void Test_004_EqualityOfNonEquals_Body()
        {
            //arrange            
            uint row = 3;
            uint col = 3;            
            double[] body1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] body2 = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //act
            Matrix a1 = new Matrix(row, col, body1);
            Matrix a2 = new Matrix(row, col, body2);

            //assert
            Assert.IsFalse(a1 == a2);
        }
        [TestMethod]
        public void Test_005_NonEqualityOfEquals()
        {
            //arrange
            uint row = 3;
            uint col = 4;
            double[] body = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //act
            Matrix a1 = new Matrix(row, col, body);
            Matrix a2 = new Matrix(row, col, body);

            //assert
            Assert.IsFalse(a1 != a2);
        }
        [TestMethod]
        public void Test_006_NonEqualityOfNonEquals_Row()
        {
            //arrange
            uint row1 = 2;
            uint row2 = 3;
            uint col = 4;
            double[] body1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double[] body2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //act
            Matrix a1 = new Matrix(row1, col, body1);
            Matrix a2 = new Matrix(row2, col, body2);

            //assert
            Assert.IsTrue(a1 != a2);
        }
        [TestMethod]
        public void Test_007_NonEqualityOfNonEquals_Col()
        {
            //arrange            
            uint row = 3;
            uint col1 = 3;
            uint col2 = 4;
            double[] body1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] body2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //act
            Matrix a1 = new Matrix(row, col1, body1);
            Matrix a2 = new Matrix(row, col2, body2);

            //assert
            Assert.IsTrue(a1 != a2);
        }
        [TestMethod]
        public void Test_008_NonEqualityOfNonEquals_Body()
        {
            //arrange            
            uint row = 3;
            uint col = 3;
            double[] body1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] body2 = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //act
            Matrix a1 = new Matrix(row, col, body1);
            Matrix a2 = new Matrix(row, col, body2);

            //assert
            Assert.IsTrue(a1 != a2);
        }
        /*
        [TestMethod]
        public void Test_Template()
        {
            //arrange

            //act

            //assert
            Assert.IsTrue(true);
        }
        
        [TestMethod]
        public void Test_Template()
        {
            //arrange

            //act

            //assert
            Assert.IsTrue(true);
        }
        */
    }
}

