namespace ScoutSport.Models
{
    public class Observacao
    {
        public int Id { get; set; }
        public int JogadorId { get; set; }
        public DateTime DataObservacao { get; set; }
        public string? Adversario { get; set; }
        public string? Competicao { get; set; }
        public string? PosicaoObservada { get; set; }
        public string? Comentario { get; set; }
    }
}