using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.ViewModels
{
    public class NovoFornecedorViewModel
    {

        
        public string RazaoSocial { get; set; }

        public string CNPJ { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }
        public string Email { get; set; }

        public string Contato { get; set; }




    }
}
