namespace Entities.Models
{
    public class TvChannel
    {
        public int TvId { get; set; }
        public string TvChannelName { get; set; }
        public byte? TvChannelCountryId { get; set; }
        public byte? TvChannelLanguageId { get; set; }
        public string TvChannelLogo { get; set; }
        public string StrimmingUrl { get; set; }
        public string TvChannelTitle { get; set; }
    }
}
