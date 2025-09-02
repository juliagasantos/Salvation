using Microsoft.AspNetCore.Mvc.Rendering;
using Salvation.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Salvation.ViewModels
{
    public class ClassificacaoViewModel
    {
            public int IdClassificacao { get; set; }
            public string DescricaoClassificacao { get; set; }
            public IEnumerable<SelectListItem>? Filmes { get; set; }
    }
}
