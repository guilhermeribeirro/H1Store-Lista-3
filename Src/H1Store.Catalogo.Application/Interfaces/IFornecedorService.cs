using H1Store.Catalogo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.Interfaces
{
    public interface IFornecedorService
    {
        IEnumerable<FornecedorViewModel> ObterTodos();
        Task<FornecedorViewModel> ObterPorId(Guid id);
        Task<IEnumerable<FornecedorViewModel>> ObterPorCategoria(int codigo);

        void Adicionar(NovoFornecedorViewModel fornecedor);
        void Atualizar(FornecedorViewModel fornecedor);


    }
}
