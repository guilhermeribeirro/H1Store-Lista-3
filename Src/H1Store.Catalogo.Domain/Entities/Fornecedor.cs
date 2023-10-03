using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Domain.Entities
{
    public class Fornecedor
    {

        #region 1 - Contrutores
        public Fornecedor(int codigo, string razaosocial, string cnpj, bool ativo,  DateTime dataCadastro, string email, string contato)
        {
            Codigo = codigo;
            RazaoSocial = razaosocial;
            CNPJ = cnpj;
            Ativo = ativo;
            DataCadastro = dataCadastro;
            Email = email;
            Contato = contato;
            
       


           
        }


        #endregion

        #region 2 - Propriedades
        public int Codigo { get; private set; }
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Descricao { get; private set; }
     
        public string Email { get; private set; }
        public string Contato { get; private set; }
        #endregion

        #region 3 - Comportamentos

        public void Ativar() => Ativo = true;

        public void Desativar() => Ativo = false;

        public void AlterarDescricao(string descricao) => Descricao = descricao;
        public void AlterarRazaoSocial(string razaosocial) => RazaoSocial = razaosocial;
        public void AlterarCNPJ(string cnpj) => CNPJ = cnpj;
        public void AlterarEmail(string email) => Email = email;
        public void AlterarContato(string contato) => Contato = contato;


        public void SetaCodigoProduto(int novocodigo) => Codigo = novocodigo;

        #endregion
    }
}
