using PreferredItemFinder.DataModel;

namespace PreferredItemFinder.DataServices
{
    public interface IMasterDataService
    {
        List<MasterData> GetMasterDataForItems(List<int> ItemIds);
    }
}
