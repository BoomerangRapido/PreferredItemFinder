using PreferredItemFinder.DataModel;
using PreferredItemFinder.DataRepository;

namespace PreferredItemFinder.DataServices
{
    internal class ItemService : IItemService
    {
        private readonly IDataRepository _repository;

        public ItemService(IDataRepository repository)
        {
            _repository = repository;
        }

        public List<Item> GetItemsFromBricks(List<Brick> Bricks)
        {
            var availableItems = _repository.AvailableItems();
            var matchingItems = new List<Item>();

            foreach (var brick in Bricks)
            {
                matchingItems = availableItems.Where(x => AreListsEqual(x.Bricks, Bricks)).ToList();
            }

            return matchingItems;
        }

        private bool AreListsEqual(List<Brick> list1, List<Brick> list2)
        {
            if (list1.Count != list2.Count) return false;

            foreach (var brick in list1)
            {
                var matchingIds = list2.Where(x => x.DesignId == brick.DesignId).ToList();
                if (!matchingIds.Any(x => x.Colors.SequenceEqual(brick.Colors))) return false;
            }
            return true;
        }
    }
}
