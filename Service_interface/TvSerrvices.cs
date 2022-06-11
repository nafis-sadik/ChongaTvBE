using Entities.Models;
using Repoository_Interfface;

namespace Service_interface
{
    public class TvSerrvices : ITvSerrvicecs
    {
        private readonly IChannelDtlsRepo _channelDtlsRepo;

        public string GetChannelDtls(int channelId) => _channelDtlsRepo.Get(channelId).StrimmingUrl;

        public List<TvChannel> GetChannelsByCountry(int countryId)
        {
            return _channelDtlsRepo.AsQueryable().Where(x => x.TvChannelCountryId == countryId)
                .Select(x => new TvChannel
                {
                    TvId = x.TvId,
                    TvChannelName = x.TvChannelName,
                    TvChannelLogo =  x.TvChannelLogo
                }).ToList();
        }

        public List<TvChannel> GetChannelsByLanguage(int languageId)
        {
            throw new NotImplementedException();
        }
    }
}