namespace LQPOS.tests
{
    public class InventoryTests
    {
        [Fact]
        public void Inventory_Constructor_CreatesEmptyLists()
        {
            var testInventory = new Inventory();
            Assert.Empty(testInventory.Beers);
            Assert.Empty(testInventory.Wines);
            Assert.Empty(testInventory.Spirits);
        }
    }
}