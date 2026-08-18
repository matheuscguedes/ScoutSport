namespace ScoutSport.Models
{
    public class Jogador
    {
        public int Id { get; set; }
        public int ClubeId { get; set; }
        public string Nome { get; set; } 
        public DateTime? DataNascimento { get; set; }
        public string? Nacionalidade { get; set; }
        public string Posicao { get; set; }
        public decimal? Altura { get; set; }
        public decimal? Peso { get; set; }
    }
}