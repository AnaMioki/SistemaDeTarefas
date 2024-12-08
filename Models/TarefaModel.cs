namespace SistemaDeTarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string Tarefa { get; set; }
        public string Descricao { get; set; }
        public int Status { get; set; } //depois vamos criar o enum
    }
}
