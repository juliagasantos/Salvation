using Microsoft.AspNetCore.Mvc.Rendering;
using Salvation.Models;
using System.ComponentModel.DataAnnotations;

namespace Salvation.ViewModels
{
    public class TipoUsuarioViewModel
    {
        public int IdTipoUsuario { get; set; }
        public string DescricaoTipoUsuario { get; set; }

        public IEnumerable<SelectListItem>? TipoUsuarios { get; set; }

    }
}
