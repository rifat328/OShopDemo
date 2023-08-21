namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int result = 2 + 1;
            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(2,2,2,6)]
        [InlineData(-2,2,2,2)]

        public void Test2(int n1,int n2, int n3,int expected)
        {
            //Arrenge 
            //---------------
            //Act
            int result = n1 + n2 + n3;
            // Assert

            Assert.Equal(expected,result);
        }

        [Theory]
        [InlineData(2, 2, 2, -2)]
        [InlineData(-2, 2, 2, -6)]

        public void Test21(int n1, int n2, int n3, int expected)
        {
            //Arrenge 
            //---------------
            //Act
            int result = n1 - n2 * n3;
            // Assert

            Assert.Equal(expected, result);
        }
    }
}