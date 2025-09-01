using DVDL_Business.After.DOTs;
using TheDataLayer_For_Project.Repositories.Country;
namespace DVDL_Business.After.Country
{
    public class CountryService : ICountryService
    {
        private CountryRepository _CountryRepository;
        public CountryService()
        {
            _CountryRepository = new CountryRepository();
        }

        public List<CountryDtos> GetAll()
        {
            List<CountryDtos> countryDtos = new List<CountryDtos>();
            foreach (var Country in _CountryRepository.GetAll())
            {
                countryDtos.Add(Map(Country));
            }
            return countryDtos;
        }

        private CountryDtos Map(TheDataLayer_For_Project.Models.Country.Country country)
        {
            return new CountryDtos
            {
                Id = country.Id,
                Name = country.Name
            };
        }

    }
}
