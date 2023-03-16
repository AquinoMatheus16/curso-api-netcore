using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    public class UserDtoCreate
    {
        [Required(ErrorMessage = "Nome é um campo obrigatório.")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-mail é um campo obrigatório.")]
        [StringLength(60, ErrorMessage = "E-mail deve ter no máximo {1} caracteres.")]
        [EmailAddress(ErrorMessage = "E-mail é um campo obrigatório.")]
        public string Email { get; set; }
    }
}
