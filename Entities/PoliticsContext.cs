using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities.Models
{
    public partial class PoliticsContext : DbContext
    {
        public PoliticsContext()
        {
        }

        public PoliticsContext(DbContextOptions<PoliticsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Funkce> Funkce { get; set; }
        public virtual DbSet<Organy> Organy { get; set; }
        public virtual DbSet<Osoby> Osoby { get; set; }
        public virtual DbSet<Poslanec> Poslanec { get; set; }
        public virtual DbSet<TypFunkce> TypFunkce { get; set; }
        public virtual DbSet<TypOrganu> TypOrganu { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funkce>(entity =>
            {
                entity.HasKey(e => e.IdFunkce)
                    .HasName("PK__funkce__2764EA03EEF5F7AE");

                entity.ToTable("funkce");

                entity.Property(e => e.IdFunkce)
                    .HasColumnName("id_funkce")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdOrgan).HasColumnName("id_organ");

                entity.Property(e => e.IdTypFunkce).HasColumnName("id_typ_funkce");

                entity.Property(e => e.NazevFunkceCz)
                    .HasColumnName("nazev_funkce_cz")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Priorita).HasColumnName("priorita");

                entity.HasOne(d => d.IdTypFunkceNavigation)
                    .WithMany(p => p.Funkce)
                    .HasForeignKey(d => d.IdTypFunkce)
                    .HasConstraintName("FK_funkce_typ_funkce");
            });

            modelBuilder.Entity<Organy>(entity =>
            {
                entity.HasKey(e => e.IdOrgan)
                    .HasName("PK__organy__062B91726416CF69");

                entity.ToTable("organy");

                entity.Property(e => e.IdOrgan)
                    .HasColumnName("id_organ")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClOrganBase).HasColumnName("cl_organ_base");

                entity.Property(e => e.DoOrgan)
                    .HasColumnName("do_organ")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdTypOrganu).HasColumnName("id_typ_organu");

                entity.Property(e => e.NazevOrganuCz)
                    .HasColumnName("nazev_organu_cz")
                    .HasMaxLength(317)
                    .IsUnicode(false);

                entity.Property(e => e.NazevOrganuEn)
                    .HasColumnName("nazev_organu_en")
                    .HasMaxLength(392)
                    .IsUnicode(false);

                entity.Property(e => e.OdOrgan)
                    .HasColumnName("od_organ")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrganIdOrgan).HasColumnName("organ_id_organ");

                entity.Property(e => e.Priorita).HasColumnName("priorita");

                entity.Property(e => e.Zkratka)
                    .HasColumnName("zkratka")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTypOrganuNavigation)
                    .WithMany(p => p.Organy)
                    .HasForeignKey(d => d.IdTypOrganu)
                    .HasConstraintName("FK_organy_typ_organu");
            });

            modelBuilder.Entity<Osoby>(entity =>
            {
                entity.HasKey(e => e.IdOsoba);

                entity.ToTable("osoby");

                entity.Property(e => e.IdOsoba)
                    .HasColumnName("id_osoba")
                    .ValueGeneratedNever();

                entity.Property(e => e.Jmeno)
                    .HasColumnName("jmeno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Narozeni)
                    .HasColumnName("narozeni")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pohlavi)
                    .HasColumnName("pohlavi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pred)
                    .HasColumnName("pred")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prijmeni)
                    .HasColumnName("prijmeni")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Umrti)
                    .HasColumnName("umrti")
                    .HasColumnType("datetime");

                entity.Property(e => e.Za)
                    .HasColumnName("za")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zmena)
                    .HasColumnName("zmena")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Poslanec>(entity =>
            {
                entity.HasKey(e => e.IdPoslanec)
                    .HasName("PK__poslanec__35F3E5D6A583E1ED");

                entity.ToTable("poslanec");

                entity.Property(e => e.IdPoslanec)
                    .HasColumnName("id_poslanec")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Facebook)
                    .HasColumnName("facebook")
                    .HasMaxLength(57)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Foto).HasColumnName("foto");

                entity.Property(e => e.IdKandidatka).HasColumnName("id_kandidatka");

                entity.Property(e => e.IdKraj).HasColumnName("id_kraj");

                entity.Property(e => e.IdObdobi).HasColumnName("id_obdobi");

                entity.Property(e => e.IdOsoba).HasColumnName("id_osoba");

                entity.Property(e => e.Obec)
                    .HasColumnName("obec")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Psc)
                    .HasColumnName("psc")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PspTelefon)
                    .HasColumnName("psp_telefon")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .HasColumnName("telefon")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Ulice)
                    .HasColumnName("ulice")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Web)
                    .HasColumnName("web")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdKandidatkaNavigation)
                    .WithMany(p => p.PoslanecIdKandidatkaNavigation)
                    .HasForeignKey(d => d.IdKandidatka)
                    .HasConstraintName("FK_poslanec_kandidatka");

                entity.HasOne(d => d.IdKrajNavigation)
                    .WithMany(p => p.PoslanecIdKrajNavigation)
                    .HasForeignKey(d => d.IdKraj)
                    .HasConstraintName("FK_poslanec_kraj");

                entity.HasOne(d => d.IdObdobiNavigation)
                    .WithMany(p => p.PoslanecIdObdobiNavigation)
                    .HasForeignKey(d => d.IdObdobi)
                    .HasConstraintName("FK_poslanec_obdobi");

                entity.HasOne(d => d.OsobniData)
                    .WithMany(p => p.Poslanec)
                    .HasForeignKey(d => d.IdOsoba)
                    .HasConstraintName("FK_poslanec_osoby");
            });

            modelBuilder.Entity<TypFunkce>(entity =>
            {
                entity.HasKey(e => e.IdTypFunkce);

                entity.ToTable("typ_funkce");

                entity.Property(e => e.IdTypFunkce)
                    .HasColumnName("id_typ_funkce")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdTypOrg).HasColumnName("id_typ_org");

                entity.Property(e => e.Priorita).HasColumnName("priorita");

                entity.Property(e => e.TypFunkceCz)
                    .HasColumnName("typ_funkce_cz")
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.TypFunkceEn)
                    .HasColumnName("typ_funkce_en")
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.TypFunkceObecny).HasColumnName("typ_funkce_obecny");

                entity.HasOne(d => d.IdTypOrgNavigation)
                    .WithMany(p => p.TypFunkce)
                    .HasForeignKey(d => d.IdTypOrg)
                    .HasConstraintName("FK_typ_funkce_typ_organu");
            });

            modelBuilder.Entity<TypOrganu>(entity =>
            {
                entity.HasKey(e => e.IdTypOrg);

                entity.ToTable("typ_organu");

                entity.Property(e => e.IdTypOrg)
                    .HasColumnName("id_typ_org")
                    .ValueGeneratedNever();

                entity.Property(e => e.NazevTypOrgCz)
                    .HasColumnName("nazev_typ_org_cz")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.NazevTypOrgEn)
                    .HasColumnName("nazev_typ_org_en")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Priorita).HasColumnName("priorita");

                entity.Property(e => e.TypIdTypOrg).HasColumnName("typ_id_typ_org");

                entity.Property(e => e.TypOrgObecny).HasColumnName("typ_org_obecny");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
