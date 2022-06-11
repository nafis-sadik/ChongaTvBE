using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Entities
{
    public partial class ChongaTvContext : DbContext
    {
        public ChongaTvContext()
        {
        }

        public ChongaTvContext(DbContextOptions<ChongaTvContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChannelDtl> ChannelDtls { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<UsersInfo> UsersInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("User Id=WORKSTATION;Database=ChongaTv;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChannelDtl>(entity =>
            {
                entity.HasKey(e => e.TvId);

                entity.ToTable("Channel_Dtls");

                entity.Property(e => e.TvId).HasColumnName("Tv_Id");

                entity.Property(e => e.StrimmingUrl)
                    .HasMaxLength(10)
                    .HasColumnName("Strimming_Url")
                    .IsFixedLength(true);

                entity.Property(e => e.TvChannelCountryId).HasColumnName("Tv_Channel_Country_Id");

                entity.Property(e => e.TvChannelLanguageId).HasColumnName("Tv_Channel_Language_Id");

                entity.Property(e => e.TvChannelLogo)
                    .HasMaxLength(10)
                    .HasColumnName("Tv_Channel_Logo")
                    .IsFixedLength(true);

                entity.Property(e => e.TvChannelName)
                    .HasMaxLength(10)
                    .HasColumnName("Tv_Channel_Name")
                    .IsFixedLength(true);

                entity.Property(e => e.TvChannelTitle)
                    .HasMaxLength(10)
                    .HasColumnName("Tv_Channel_Title")
                    .IsFixedLength(true);

                entity.HasOne(d => d.TvChannelCountry)
                    .WithMany(p => p.ChannelDtls)
                    .HasForeignKey(d => d.TvChannelCountryId)
                    .HasConstraintName("FK_Channel_Dtls_Countries1");

                entity.HasOne(d => d.TvChannelLanguage)
                    .WithMany(p => p.ChannelDtls)
                    .HasForeignKey(d => d.TvChannelLanguageId)
                    .HasConstraintName("FK_Channel_Dtls_Languages");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Country_Id");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(10)
                    .HasColumnName("Country_Name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.LanguageId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Language_Id");

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(10)
                    .HasColumnName("Language_Name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<UsersInfo>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Users_infos");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .HasColumnName("User_Id")
                    .IsFixedLength(true);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(10)
                    .HasColumnName("Email_Id")
                    .IsFixedLength(true);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(10)
                    .HasColumnName("First_Name")
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .HasColumnName("Last_Name")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(10)
                    .HasColumnName("Phone_No")
                    .IsFixedLength(true);

                entity.Property(e => e.UserName)
                    .HasMaxLength(10)
                    .HasColumnName("User_Name")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
