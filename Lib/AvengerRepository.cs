using Lib.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib
{
    public class AvengerRepository : IAvengerRepository
    {
        public AvengerRepository(ILogger logger)
        {
            _logger = logger;
        }
        ILogger _logger;

        public IEnumerable<Hero> FetchAll()
        {
            // simulate loading from datatabase
            List<Hero> heroes = new List<Hero>()
            {
                new Hero("Ironman", "Tony Stark", "Extreme Geek Suit"),
                new Hero("Thor", "Thor Johnson", "Craftsman Professional Hammer"),
                new Hero("Captain America", "Steve Rogers", "Steroid Tolerance & Big Frisbee"),
                new Hero("Hulk", "Bruce Banner", "Chlorofill Induced Epidermis"),
                new Hero("Black Widow", "Natasha Romanov", "Mixed-Martial Arts & Bad Temper"),
                new Hero("Spiderman", "Peter Parker", "Tarzan-like Swinging Abilities")
            };

            _logger.Log("AvengerRepository.FetchAll called - Database hit.");

            return heroes;
        }

        public Hero Fetch(string name)
        {
            // simulate loading from datatabase
            var heroes = FetchAll();

           _logger.Log("AvengerRepository.Fetch('{0}') called - Database hit.", name);

            return heroes.FirstOrDefault(item => item.SuperheroName.ToLower() == name.ToLower());
        }
    }
}
