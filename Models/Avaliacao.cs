namespace ScoutSport.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int ObservacaoId { get; set; }
        public decimal Tecnica { get; set; }
        public decimal Velocidade { get; set; }
        public decimal InteligenciaTatica { get; set; }
        public decimal Fisico { get; set; }
        public decimal Atitude { get; set; }
        public string? Potencial { get; set; }

        public decimal NotaFinal {  get; set; }
       
    }
}