using PreferredItemFinder.DataRepository;
using PreferredItemFinder.DataServices;

namespace PreferredItemFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding preferred item from list of bricks...");

            var repository = new DataRepository.DataRepository();
            var bricks = repository.ListOfBricksToMatch();

            var itemService = new ItemService(repository);
            var masterDataService = new MasterDataService(repository);
            var preferredItemFinder = new PreferredItem(itemService, masterDataService);

            var preferredItem = preferredItemFinder.GetFromBricks(bricks);

            Console.WriteLine($"The preferred item is item {preferredItem.Id}");

            Console.ReadLine();
        }
    }
}
