#nullable disable

namespace Entities
{
    public partial class Country
    {
        public Country()
        {
            ChannelDtls = new HashSet<ChannelDtl>();
        }

        public byte CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<ChannelDtl> ChannelDtls { get; set; }
    }
}
