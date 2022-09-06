using PreferredItemFinder.DataModel;

namespace PreferredItemFinderTests
{
    internal class TestData
    {
        public static List<Brick> ListOfBricksToMatch()
        {
            return new List<Brick>
            {
                new(4211614, new List<Color> { new(20), new(21) }),
                new(4211614, new List<Color> { new(5), new(11) }),
                new(4651063, new List<Color> { new(20), new(22) }),
                new(370021, new List<Color> { new(43) })
            };
        }

        public static List<Item> MatchingItems()
        {
            return new List<Item>
            {
                new(10497, ListOfBricksToMatch()),
                new(10500, ListOfBricksToMatch()),
                new(10234, ListOfBricksToMatch()),
                new(10364, ListOfBricksToMatch()),
                new(10147, ListOfBricksToMatch()),
                new(10112, ListOfBricksToMatch()),
            };
        }

        public static List<MasterData> MasterData()
        {
            return new List<MasterData>
            {
                new(10497, ItemStatus.Normal, 899),
                new(10500, ItemStatus.Novelty, 899),
                new(10234, ItemStatus.Normal, 1599),
                new(10364, ItemStatus.Discontinued, 699),
                new(10147, ItemStatus.Outgoing, 399),
                new(10112, ItemStatus.Novelty, 599),
            };
        }
    }
}
