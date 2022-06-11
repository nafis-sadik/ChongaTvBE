#nullable disable

namespace Entities
{
    public partial class ChannelDtl
    {
        public int TvId { get; set; }
        public string TvChannelName { get; set; }
        public byte? TvChannelCountryId { get; set; }
        public byte? TvChannelLanguageId { get; set; }
        public string TvChannelLogo { get; set; }
        public string StrimmingUrl { get; set; }
        public string TvChannelTitle { get; set; }

        public virtual Country TvChannelCountry { get; set; }
        public virtual Language TvChannelLanguage { get; set; }
    }
}
