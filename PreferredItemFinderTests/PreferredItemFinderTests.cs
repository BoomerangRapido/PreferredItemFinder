using Moq;
using PreferredItemFinder;
using PreferredItemFinder.DataModel;
using PreferredItemFinder.DataRepository;
using PreferredItemFinder.DataServices;

namespace PreferredItemFinderTests
{
    public class PreferredItemFinderTests
    {

        [Fact]
        public void PreferredItemIsFound()
        {
            var itemServiceMock = new Mock<IItemService>();
            itemServiceMock.Setup(s => s.GetItemsFromBricks(It.IsAny<List<Brick>>())).Returns(TestData.MatchingItems());

            var masterDataServiceMock = new Mock<IMasterDataService>();
            masterDataServiceMock.Setup(s => s.GetMasterDataForItems(It.IsAny<List<int>>())).Returns(TestData.MasterData());

            var preferredItemFinder = new PreferredItem(itemServiceMock.Object, masterDataServiceMock.Object);

            var preferredItem = preferredItemFinder.GetFromBricks(TestData.ListOfBricksToMatch());

            Assert.NotNull(preferredItem);
            Assert.Equal(10497, preferredItem.Id);
        }

        [Fact]
        public void ThrowsIfListOfBricksIsNull()
        {
            var itemServiceMock = new Mock<IItemService>();
            itemServiceMock.Setup(s => s.GetItemsFromBricks(It.IsAny<List<Brick>>())).Returns(TestData.MatchingItems());

            var masterDataServiceMock = new Mock<IMasterDataService>();
            masterDataServiceMock.Setup(s => s.GetMasterDataForItems(It.IsAny<List<int>>())).Returns(TestData.MasterData());

            var preferredItemFinder = new PreferredItem(itemServiceMock.Object, masterDataServiceMock.Object);

            Assert.Throws<ArgumentNullException>(() => preferredItemFinder.GetFromBricks(null));
        }

        [Fact]
        public void ReturnsNullIfNoMatchingItemsAreFound()
        {
            var itemServiceMock = new Mock<IItemService>();
            itemServiceMock.Setup(s => s.GetItemsFromBricks(It.IsAny<List<Brick>>())).Returns(new List<Item>());

            var masterDataServiceMock = new Mock<IMasterDataService>();
            masterDataServiceMock.Setup(s => s.GetMasterDataForItems(It.IsAny<List<int>>())).Returns(new List<MasterData>());

            var preferredItemFinder = new PreferredItem(itemServiceMock.Object, masterDataServiceMock.Object);

            var preferredItem = preferredItemFinder.GetFromBricks(TestData.ListOfBricksToMatch());

            Assert.Null(preferredItem);
        }
    }
}