namespace OdevPortaliSon.ViewModel
{
    public class KayitModel
    {
        public string kayitId { get; set; }
        public string kayitOdevId { get; set; }
        public string kayitOgrId { get; set; }
        public string kayitDersId { get; set; }
        public OdevModel odevBilgi { get; set; }
        public OgrenciModel ogrBilgi { get; set; }
        public DersModel dersBilgi { get; set; }
    }
}