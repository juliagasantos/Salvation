using Microsoft.AspNetCore.Mvc.Rendering;

namespace Salvation.ViewModels
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public int TipoUsuarioId { get; set; }

        //coleção para popular o dropdown
        public IEnumerable<SelectListItem>? TiposUsuarios { get; set; }

    }
}
