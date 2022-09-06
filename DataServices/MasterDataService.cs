using PreferredItemFinder.DataModel;
using PreferredItemFinder.DataRepository;

namespace PreferredItemFinder.DataServices
{
    internal class MasterDataService : IMasterDataService
    {
        private readonly IDataRepository _dataRepository;

        public MasterDataService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public List<MasterData> GetMasterDataForItems(List<int> ItemIds)
        {
            return _dataRepository.MasterData().Where(x => ItemIds.Contains(x.Id)).ToList();
        }
    }
}
