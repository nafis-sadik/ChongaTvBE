using Entities.Models;

namespace Service_interface
{
    public interface ITvSerrvicecs
    {
        public string GetChannelDtls(int channelId);
        public List<TvChannel> GetChannelsByCountry(int countryId);
        public List<TvChannel> GetChannelsByLanguage(int languageId);
    }
}
