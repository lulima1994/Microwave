namespace Microwave.Entities {
    public class ItemObj {

        public int Id { get; set; }
        public string Nome { get; set; }
        public TimeSpan Tempo { get; set; }
        public int Potencia { get; set; }
        public char Caractere { get; set; }
        public string Texto { get; set; }

        public ItemObj(int id, string nome, TimeSpan tempo, int potencia, char caractere, string texto) {
            Id = id;
            Nome = nome;
            Tempo = tempo;
            Potencia = potencia;
            Caractere = caractere;
            Texto = texto;
        }

        public ItemObj() {

        }

        public string DisplayText {
            get {
                return $"[nome: {Nome}]   " +
                    $"[tempo: ({Tempo:mm\\:ss})]   " +
                    $"[potência: {Potencia}]   " +
                    $"[caractere: {Caractere}]   " +
                    $"[texto: {Texto}]";
            }
        }
    }
}
