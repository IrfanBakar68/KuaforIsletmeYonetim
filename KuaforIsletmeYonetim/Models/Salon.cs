namespace KuaforIsletmeYonetim.Models
{
    public class Salon
    {
        public int Id { get; set; } // Salon ID
        public string Ad { get; set; } = string.Empty; // Salon Adı
        public string Adres { get; set; } = string.Empty; // Salon Adresi
        public string Telefon { get; set; } = string.Empty; // Telefon Numarası
    }
}
