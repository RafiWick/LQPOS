namespace LQPOS.tests
{
    public class SpiritTests
    {
        [Fact]
        public void Spirit_Constructor_CreatesSpiritObject()
        {
            var testSpirit = new Spirit("number 7", "jack daniels", "0003", 30.00F, 44.99F, 1750);

            Assert.Equal("number 7", testSpirit.Name);
            Assert.Equal("jack daniels", testSpirit.Brand);
            Assert.Equal("0003", testSpirit.Code);
            Assert.Equal(30.00F, testSpirit.Cost);
            Assert.Equal(44.99F, testSpirit.Price);
            Assert.Equal(0, testSpirit.Stock);
            Assert.Equal(1750, testSpirit.Size);
        }
        [Fact]
        public void Spirit_AddStock_AddsToStock()
        {
            var testSpirit = new Spirit("number 7", "jack daniels", "0003", 30.00F, 44.99F, 1750);
            testSpirit.AddStock(6);
            Assert.Equal(6, testSpirit.Stock);
        }
    }
}