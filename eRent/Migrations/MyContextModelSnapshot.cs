﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using travelAworld.EF;

namespace eRent.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("eRent.Data.Drzava", b =>
                {
                    b.Property<int>("DrzavaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("DrzavaId");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("eRent.Data.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaId");

                    b.Property<string>("Naziv");

                    b.HasKey("GradId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("eRent.Data.KategorijaNekretnina", b =>
                {
                    b.Property<int>("KategorijaNekretninaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.HasKey("KategorijaNekretninaId");

                    b.ToTable("KategorijaNekretnina");
                });

            modelBuilder.Entity("eRent.Data.Nekretnina", b =>
                {
                    b.Property<int>("NekretninaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<int>("BrojEtaza");

                    b.Property<decimal>("Cijena");

                    b.Property<int>("GodinaIzgradnje");

                    b.Property<int>("GradId");

                    b.Property<string>("Grijanje");

                    b.Property<int>("KategorijaNekretninaId");

                    b.Property<double>("Kvadratura");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.Property<bool>("PosjedujeKlimu");

                    b.Property<bool>("PosjedujeLift");

                    b.Property<int>("Sprat");

                    b.Property<bool>("UkljuceneRezije");

                    b.Property<int?>("UserId");

                    b.HasKey("NekretninaId");

                    b.HasIndex("GradId");

                    b.HasIndex("KategorijaNekretninaId");

                    b.HasIndex("UserId");

                    b.ToTable("Nekretnina");
                });

            modelBuilder.Entity("eRent.Data.NekretninaSlike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NekretninaId");

                    b.Property<string>("SlikaUrl");

                    b.HasKey("Id");

                    b.HasIndex("NekretninaId");

                    b.ToTable("NekretninaSlike");
                });

            modelBuilder.Entity("eRent.Data.Notifikacija", b =>
                {
                    b.Property<int>("NotifikacijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumSlanja");

                    b.Property<string>("Naziv");

                    b.Property<int?>("NovostId");

                    b.Property<bool>("Status");

                    b.Property<int>("UserId");

                    b.HasKey("NotifikacijaId");

                    b.HasIndex("NovostId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifikacija");
                });

            modelBuilder.Entity("eRent.Data.Novost", b =>
                {
                    b.Property<int>("NovostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.Property<byte[]>("Slika");

                    b.Property<int>("UserId");

                    b.HasKey("NovostId");

                    b.HasIndex("UserId");

                    b.ToTable("Novost");
                });

            modelBuilder.Entity("eRent.Data.Ocjena", b =>
                {
                    b.Property<int>("OcjenaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum");

                    b.Property<int>("NekretninaId");

                    b.Property<int>("UserId");

                    b.Property<int>("Vrijednost");

                    b.HasKey("OcjenaId");

                    b.HasIndex("UserId");

                    b.ToTable("Ocjena");
                });

            modelBuilder.Entity("eRent.Data.Pretplata", b =>
                {
                    b.Property<int>("PretplataId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum");

                    b.Property<int?>("KategorijaNekretninaId");

                    b.Property<int>("KategorijaNekretnineId");

                    b.Property<bool>("Status");

                    b.Property<int>("UserId");

                    b.HasKey("PretplataId");

                    b.HasIndex("KategorijaNekretninaId");

                    b.HasIndex("UserId");

                    b.ToTable("Pretplata");
                });

            modelBuilder.Entity("eRent.Data.Rezervacija", b =>
                {
                    b.Property<int>("RezervacijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumKreiranjaRezervacije");

                    b.Property<DateTime>("DatumObilaska");

                    b.Property<DateTime>("DatumPrijave");

                    b.Property<string>("Napomena");

                    b.Property<int>("NekretninaId");

                    b.Property<string>("Status");

                    b.Property<int>("UserId");

                    b.Property<string>("VrijemeOdjave");

                    b.Property<string>("VrijemePrijave");

                    b.Property<int?>("ZaposlenikId");

                    b.HasKey("RezervacijaId");

                    b.HasIndex("NekretninaId");

                    b.HasIndex("UserId");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("eRent.Data.Ugovor", b =>
                {
                    b.Property<int>("UgovorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cijena");

                    b.Property<int>("KlijentId");

                    b.Property<int>("KorisnikId");

                    b.Property<DateTime>("KrajKoristenja");

                    b.Property<int>("NekretninaId");

                    b.Property<DateTime>("PocetakKoristenja");

                    b.HasKey("UgovorId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("NekretninaId");

                    b.ToTable("Ugovor");
                });

            modelBuilder.Entity("travelAworld.Data.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("travelAworld.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Adresa");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Ime");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Prezime");

                    b.Property<string>("SecurityStamp");

                    b.Property<byte[]>("Slika");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("travelAworld.Data.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("travelAworld.Data.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("travelAworld.Data.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("travelAworld.Data.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("travelAworld.Data.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRent.Data.Grad", b =>
                {
                    b.HasOne("eRent.Data.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRent.Data.Nekretnina", b =>
                {
                    b.HasOne("eRent.Data.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eRent.Data.KategorijaNekretnina", "KategorijaNekretnina")
                        .WithMany()
                        .HasForeignKey("KategorijaNekretninaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travelAworld.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("eRent.Data.NekretninaSlike", b =>
                {
                    b.HasOne("eRent.Data.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRent.Data.Notifikacija", b =>
                {
                    b.HasOne("eRent.Data.Novost", "Novost")
                        .WithMany()
                        .HasForeignKey("NovostId");

                    b.HasOne("travelAworld.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRent.Data.Novost", b =>
                {
                    b.HasOne("travelAworld.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRent.Data.Ocjena", b =>
                {
                    b.HasOne("travelAworld.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRent.Data.Pretplata", b =>
                {
                    b.HasOne("eRent.Data.KategorijaNekretnina", "KategorijaNekretnina")
                        .WithMany()
                        .HasForeignKey("KategorijaNekretninaId");

                    b.HasOne("travelAworld.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRent.Data.Rezervacija", b =>
                {
                    b.HasOne("eRent.Data.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travelAworld.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travelAworld.Data.User", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikId");
                });

            modelBuilder.Entity("eRent.Data.Ugovor", b =>
                {
                    b.HasOne("travelAworld.Data.User", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travelAworld.Data.User", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eRent.Data.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("travelAworld.Data.UserRole", b =>
                {
                    b.HasOne("travelAworld.Data.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travelAworld.Data.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
