using System;
using System.ComponentModel.DataAnnotations;

namespace ReceitasMvc.Models
{
    public class Receita
    {
        public int Id { get; set; }

        [Required, StringLength(150), Display(Name = "Nome da receita")]
        public string Titulo { get; set; }
        [Required, StringLength(5000), Display(Name = "Modo de preparo")]
        public string Preparo { get; set; }
    }
}
