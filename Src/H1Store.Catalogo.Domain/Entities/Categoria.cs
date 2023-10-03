using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Domain.Entities
{
    public class Categoria
    {


        #region 1 - Contrutores
        public Categoria(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;

        }


        #endregion

        #region 2 - Propriedades
        public int Codigo { get; private set; }

        public string Descricao { get; private set; }

        #endregion

        #region 3 - Comportamentos



        public void AlterarDescricao(string descricao) => Descricao = descricao;



        public void SetaCodigoProduto(int novocodigo) => Codigo = novocodigo;

        #endregion




    }
}