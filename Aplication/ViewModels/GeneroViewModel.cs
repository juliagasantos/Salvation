using Microsoft.AspNetCore.Mvc.Rendering;
using Salvation.Models;
using System.ComponentModel.DataAnnotations;

namespace Salvation.ViewModels
{
    public class GeneroViewModel
    {
        public int IdGenero { get; set; }
        public string DescricaoGenero { get; set; }

        public IEnumerable<SelectListItem>? Filmes { get; set; }

    }
}
