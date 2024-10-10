using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Data.Models
{
    /// <summary>
    /// Modelo de dados para consulta de tarefas por categoria
    /// </summary>
    public class TarefaCategoriaModel
    {
        public string? Categoria { get; set; }
        public int QtdTarefas { get; set; }
    }
}
