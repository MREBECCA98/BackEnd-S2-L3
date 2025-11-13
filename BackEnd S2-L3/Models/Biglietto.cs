namespace BackEnd_S2_L3.Models
{
    public class Biglietto
    {
        public Guid Id { get; set; }
        public DateTime EmessoIl { get; set; }
        public Sala Sala { get; set; }
        public Spettatore Spettatore { get; set; }
        public decimal PrezzoPagato { get; set; }
        public bool IsRidotto { get; set; }
    }


}
