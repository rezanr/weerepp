using Core.Entities;
using Core.Entities.Apple;
using Core.Entities.Computer;
using Core.Entities.Huawei;
using Core.Entities.Motorola;
using Core.Entities.Nokia;
using Core.Entities.Oneplus;
using Core.Entities.Samsung;
using Core.Entities.Sony;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //---Account-Database--
        //---Images-Database--
        public DbSet<Images_Tabel> Images { get; set; }
        //---Aplle-Database--
        public DbSet<AppleWatchReprationPreis> AppleWatchReprationPreis { get; set; }
        public DbSet<IphoneReprationPreis> IphoneReprationPreis { get; set; }
        public DbSet<IpadReprationPreis> IpadReprationPreis { get; set; }
        public DbSet<MacbookReparation> MacbookReparation { get; set; }
        public DbSet<ImacReparation> ImacReparation { get; set; }

        //--Samsung_Databasse
        public DbSet<Galaxy_A_Serien> Galaxy_A_Serien { get; set; }
        public DbSet<Galaxy_J_Serien> Galaxy_J_Serien { get; set; }
        public DbSet<Galaxy_S_Serien> Galaxy_S_Serien { get; set; }
        public DbSet<Galaxy_Xcover_Serien> Galaxy_Xcover_Serien { get; set; }
        public DbSet<GalaxyNoteSerien> GalaxyNoteSerien { get; set; }

        //--Huawei_Databasse
        public DbSet<Huawei_Mate_Serien> Huawei_Mate_Serien { get; set; }
        public DbSet<Huawei_P_Serien> Huawei_P_Serien { get; set; }

        //--OneplusReparation_Databasse
        public DbSet<OneplusReparation> OneplusReparation { get; set; }

        //--Sony_Databasse
        public DbSet<Xperia_X_Serien> Xperia_X_Serien { get; set; }
        public DbSet<Xperia_Z_Serien> Xperia_Z_Serien { get; set; }
        public DbSet<XperiaTopModeller> XperiaTopModeller { get; set; }

        //--Motorola_Databasse
        public DbSet<Motorola_E_Serien> Motorola_E_Serien { get; set; }
        public DbSet<Motorola_G_Serien> Motorola_G_Serien { get; set; }
        public DbSet<MotorolaEdge_Serien> MotorolaEdge_Serien { get; set; }
        public DbSet<MotorolaOne_Serien> MotorolaOne_Serien { get; set; }

        //--NokiaRepartionPrice_Databasse
        public DbSet<NokiaRepartionPrice> NokiaRepartionPrice { get; set; }

        //--CpmputerReparationPrice_Databasse
        public DbSet<CpmputerReparationPrice> CpmputerReparationPrice { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 1,
                 ImageName = "hero-b.jpg",

             }); 
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 2,
                 ImageName = "Smadret-skaerm.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 3,
                 ImageName = "Smartphone-rep.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 4,
                 ImageName = "ikon1-04.svg",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 5,
                 ImageName = "mobile-app-2-03.svg",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 6,
                 ImageName = "mobile-app-6-06.svg",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 7,
                 ImageName = "iphone.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 8,
                 ImageName = "AppleWatch.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 9,
                 ImageName = "iPad.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 10,
                 ImageName = "macbook.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 11,
                 ImageName = "IMac.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 12,
                 ImageName = "GalaxyNote.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 13,
                 ImageName = "GalaxyA.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 14,
                 ImageName = "GalaxyJ.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 15,
                 ImageName = "xcover.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 16,
                 ImageName = "GalaxyNote.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 17,
                 ImageName = "P-Serien.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 18,
                 ImageName = "Mate-Serien.webp",             
             });
            
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 19,
                 ImageName = "Mate-Serien.webp",             
             });
            
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 20,
                 ImageName = "Xperia-Z.webp",             
             });
            
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 21,
                 ImageName = "Xperia-X.webp",             
             });
            
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 22,
                 ImageName = "Xperia-Top.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 23,
                 ImageName = "Motorola-G.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 24,
                 ImageName = "Motorola-E.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 25,
                 ImageName = "Motorola-One.webp",             
             });
            modelBuilder.Entity<Images_Tabel>().HasData(
             new Images_Tabel()
             {
                 ID = 26,
                 ImageName = "Motorola-Edge.webp",             
             });

        }
    }
}
