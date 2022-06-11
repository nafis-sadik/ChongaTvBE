#nullable disable

namespace Entities
{
    public partial class Language
    {
        public Language()
        {
            ChannelDtls = new HashSet<ChannelDtl>();
        }

        public byte LanguageId { get; set; }
        public string LanguageName { get; set; }

        public virtual ICollection<ChannelDtl> ChannelDtls { get; set; }
    }
}
