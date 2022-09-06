using PreferredItemFinder.DataModel;

namespace PreferredItemFinder.DataRepository
{
    public class DataRepository : IDataRepository
    {
        public List<Brick> ListOfBricksToMatch()
        {
            return new List<Brick>
            {
                new(3255421, new List<Color> { new(25), new(45), new(44) }),
                new(6522143, new List<Color> { new(15), new(21) }),
                new(541245,  new List<Color> { new(34) })
            };
        }

        private List<Brick> ListOfRandomBricks()
        {
            return new List<Brick>
            {
                new(2345152, new List<Color> { new(3), new(12) }),
                new(3254152, new List<Color> { new(35), new(16) }),
                new(3554212, new List<Color> { new(16), new(35) }),
                new(654215,  new List<Color> { new(12) })
            };
        }

        public List<Item> AvailableItems()
        {
            return new List<Item>
            {
                new(10321, ListOfBricksToMatch()),
                new(10365, ListOfBricksToMatch()),
                new(10451, ListOfBricksToMatch()),
                new(10150, ListOfBricksToMatch()),
                new(10256, ListOfBricksToMatch()),
                new(9456,  ListOfBricksToMatch()),
                new(7514,  ListOfRandomBricks()),
                new(10214, ListOfRandomBricks()),
                new(10311, ListOfRandomBricks())
            };
        }

        public List<MasterData> MasterData()
        {
            return new List<MasterData>
            {
                new(10321, ItemStatus.Normal, 899),
                new(10365, ItemStatus.Novelty, 899),
                new(10451, ItemStatus.Normal, 1599),
                new(10150, ItemStatus.Novelty, 699),
                new(10256, ItemStatus.Outgoing, 399),
                new(9456,  ItemStatus.Normal, 599),
                new(7514,  ItemStatus.Normal, 399),
                new(10214, ItemStatus.Novelty, 299),
                new(10311, ItemStatus.Normal, 1299)
            };
        }
    }
}
