using KuaforYonetim.Models;
using Microsoft.EntityFrameworkCore;

namespace KuaforIsletmeYonetim.Models
{
    public class KuaforContext : DbContext
    {
        public KuaforContext(DbContextOptions<KuaforContext> options) : base(options) { }

        public DbSet<Salon>? Salonlar { get; set; }
        public DbSet<Islem>? Islemler { get; set; }
        public DbSet<Calisan>? Calisanlar { get; set; }
        public DbSet<Randevu>? Randevular { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Randevu>()
                .HasOne(r => r.Calisan)
                .WithMany()
                .HasForeignKey(r => r.CalisanId);
        }
    }
}
