using PreferredItemFinder.DataModel;

namespace PreferredItemFinder.DataRepository
{
    internal interface IDataRepository
    {
        public List<Brick> ListOfBricksToMatch();

        public List<Item> AvailableItems();

        public List<MasterData> MasterData();
    }
}
