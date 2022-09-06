using PreferredItemFinder.DataModel;

namespace PreferredItemFinder.DataServices
{
    public interface IItemService
    {
        List<Item> GetItemsFromBricks(List<Brick> Bricks);
    }
}
