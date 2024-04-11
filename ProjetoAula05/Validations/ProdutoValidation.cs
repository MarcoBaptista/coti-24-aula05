using FluentValidation;
using ProjetoAula05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Validations
{
    //Classe para validação dos dados do produto
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(p => p.Id)
                .NotEmpty()
                .WithMessage("O Id do produto é obrigatório.");

            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("O Nome do produto é obrigatório.")
                .Length(8, 100).WithMessage("O nome do produto precisa ter de 8 a 100 caracteres");

            RuleFor(p => p.Preco)
                .NotEmpty().WithMessage("O Preço do produto é obrigatório.")
                .GreaterThanOrEqualTo(0).WithMessage("O preço do produto precisa ser maior que zero");

            RuleFor(p => p.Quantidade)
               .NotEmpty().WithMessage("A Quantidade do produto é obrigatório.")
               .GreaterThan(0).WithMessage("O preço do produto precisa ser maior ou igual a zero");

            RuleFor(p => p.Status)
             .NotEmpty().WithMessage("O Status do produto é obrigatório.");
             
        }
    }
}
