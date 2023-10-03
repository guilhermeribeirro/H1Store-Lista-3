using H1Store.Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Domain.Interfaces
{
   public interface IFornecedorRepository
    {

        IEnumerable<Fornecedor> ObterTodos();
        Task<Fornecedor> ObterPorId(Guid id);
        Task<IEnumerable<Fornecedor>> ObterPorCategoria(int codigo);

        void Adicionar(Fornecedor fornecedor);
        void Atualizar(Fornecedor forncedor);
    }
}
