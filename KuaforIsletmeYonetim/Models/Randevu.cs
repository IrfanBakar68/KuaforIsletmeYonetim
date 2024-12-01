using System;

namespace KuaforIsletmeYonetim.Models
{
    public class Randevu
    {
        public int Id { get; set; }
        public int CalisanId { get; set; } // Çalışan ID'si (Foreign Key)
        public Calisan? Calisan { get; set; } // Çalışan ile ilişki
        public DateTime BaslangicSaati { get; set; }
        public DateTime BitisSaati { get; set; }
        public string MusteriAdi { get; set; } = string.Empty;
        public string Islem { get; set; } = string.Empty;
        public decimal Ucret { get; set; }
    }
}
