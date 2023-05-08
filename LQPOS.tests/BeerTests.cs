namespace LQPOS.tests
{
    public class BeerTests
    {
        [Fact]
        public void Beer_Constructor_CreatesBeerObject()
        {
            var testBeer = new Beer("banquet", "coors", "0001", 5.00F, 9.99F, 6, 12);

            Assert.Equal("banquet", testBeer.Name);
            Assert.Equal("coors", testBeer.Brand);
            Assert.Equal("0001", testBeer.Code);
            Assert.Equal(5.00F, testBeer.Cost);
            Assert.Equal(9.99F, testBeer.Price);
            Assert.Equal(0, testBeer.Stock);
            Assert.Equal(6, testBeer.Count);
            Assert.Equal(12, testBeer.Size);


        }
    }
}