namespace LQPOS.tests
{
    public class WineTests
    {
        [Fact]
        public void Wine_Constructor_CreatesWineObject()
        {
            var testWine = new Wine("chardonay", "kim crawford", "0002", 5.00F, 9.99F, 750);

            Assert.Equal("chardonay", testWine.Name);
            Assert.Equal("kim crawford", testWine.Brand);
            Assert.Equal("0002", testWine.Code);
            Assert.Equal(5.00F, testWine.Cost);
            Assert.Equal(9.99F, testWine.Price);
            Assert.Equal(0, testWine.Stock);
            Assert.Equal(750, testWine.Size);

        }
    }
}