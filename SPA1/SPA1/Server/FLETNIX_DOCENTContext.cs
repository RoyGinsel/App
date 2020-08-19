using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SPA1.Shared.Models;

namespace SPA1.Server
{
    public partial class FLETNIX_DOCENTContext : DbContext
    {
        public FLETNIX_DOCENTContext()
        {
        }

        public FLETNIX_DOCENTContext(DbContextOptions<FLETNIX_DOCENTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<MovieCast> MovieCast { get; set; }
        public virtual DbSet<MovieDirector> MovieDirector { get; set; }
        public virtual DbSet<MovieGenre> MovieGenre { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Watchhistory> Watchhistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost;Trusted_Connection=True;Database=FLETNIX_DOCENT");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contract>(entity =>
            {
                entity.HasKey(e => e.ContractType);

                entity.Property(e => e.ContractType)
                    .HasColumnName("contract_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage)
                    .HasColumnName("discount_percentage")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PricePerMonth)
                    .HasColumnName("price_per_month")
                    .HasColumnType("numeric(5, 2)");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryName);

                entity.Property(e => e.CountryName)
                    .HasColumnName("country_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerMailAddress);

                entity.Property(e => e.CustomerMailAddress)
                    .HasColumnName("customer_mail_address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("date");

                entity.Property(e => e.ContractType)
                    .IsRequired()
                    .HasColumnName("contract_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentCardNumber)
                    .IsRequired()
                    .HasColumnName("payment_card_number")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasColumnName("payment_method")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriptionEnd)
                    .HasColumnName("subscription_end")
                    .HasColumnType("date");

                entity.Property(e => e.SubscriptionStart)
                    .HasColumnName("subscription_start")
                    .HasColumnType("date");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContractTypeNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.ContractType)
                    .HasConstraintName("FK_contract_type");

                entity.HasOne(d => d.CountryNameNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.CountryName)
                    .HasConstraintName("FK_country");

                entity.HasOne(d => d.PaymentMethodNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.PaymentMethod)
                    .HasConstraintName("FK_payment_method");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.GenreName);

                entity.Property(e => e.GenreName)
                    .HasColumnName("genre_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.MovieId)
                    .HasColumnName("movie_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoverImage)
                    .HasColumnName("cover_image")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.PreviousPart).HasColumnName("previous_part");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PublicationYear).HasColumnName("publication_year");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Watched)
                    .HasColumnName("Watched");

                entity.HasOne(d => d.PreviousPartNavigation)
                    .WithMany(p => p.InversePreviousPartNavigation)
                    .HasForeignKey(d => d.PreviousPart)
                    .HasConstraintName("FK_previous_part");
            });

            modelBuilder.Entity<MovieCast>(entity =>
            {
                entity.HasKey(e => new { e.MovieId, e.PersonId, e.Role });

                entity.ToTable("Movie_Cast");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.MovieCast)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK2_movie_id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.MovieCast)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK2_person_id");
            });

            modelBuilder.Entity<MovieDirector>(entity =>
            {
                entity.HasKey(e => new { e.MovieId, e.PersonId })
                    .HasName("PK_Movie_Directors");

                entity.ToTable("Movie_Director");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.MovieDirector)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_movie_id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.MovieDirector)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_person_id");
            });

            modelBuilder.Entity<MovieGenre>(entity =>
            {
                entity.HasKey(e => new { e.MovieId, e.GenreName });

                entity.ToTable("Movie_Genre");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.GenreName)
                    .HasColumnName("genre_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.GenreNameNavigation)
                    .WithMany(p => p.MovieGenre)
                    .HasForeignKey(d => d.GenreName)
                    .HasConstraintName("FK_genre");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.MovieGenre)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK3_movie_id");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PaymentMethod);

                entity.Property(e => e.PaymentMethod)
                    .HasColumnName("payment_method")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.PersonId)
                    .HasColumnName("person_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Watchhistory>(entity =>
            {
                entity.HasKey(e => new { e.MovieId, e.CustomerMailAddress, e.WatchDate })
                    .HasName("PK_Movie_Watchhistory_1");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.CustomerMailAddress)
                    .HasColumnName("customer_mail_address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WatchDate)
                    .HasColumnName("watch_date")
                    .HasColumnType("date");

                entity.Property(e => e.Invoiced).HasColumnName("invoiced");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(5, 2)");

                entity.HasOne(d => d.CustomerMailAddressNavigation)
                    .WithMany(p => p.Watchhistory)
                    .HasForeignKey(d => d.CustomerMailAddress)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_customer");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Watchhistory)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK4_movie_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
