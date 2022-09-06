using PreferredItemFinder.DataModel;
using PreferredItemFinder.DataServices;

namespace PreferredItemFinder
{
    public class PreferredItem
    {
        private readonly IItemService _itemService;
        private readonly IMasterDataService _masterDataService;

        public PreferredItem(IItemService itemService, IMasterDataService masterDataService)
        {
            _itemService = itemService;
            _masterDataService = masterDataService;
        }

        public Item? GetFromBricks(List<Brick> bricks)
        {
            if (bricks == null) throw new ArgumentNullException(nameof(bricks));

            var matchingItems = _itemService.GetItemsFromBricks(bricks);
            if (!matchingItems.Any()) return null;

            var masterData = _masterDataService.GetMasterDataForItems(matchingItems.Select(i => i.Id).ToList());
            var sortedMasterData = masterData.OrderBy(m => m.Status).ThenBy(m => m.Price);

            return matchingItems.First(i => i.Id == sortedMasterData.First().Id);
        }
    }
}
