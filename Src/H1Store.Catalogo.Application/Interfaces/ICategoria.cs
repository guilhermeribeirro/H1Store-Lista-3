using H1Store.Catalogo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.Interfaces
{
    public interface ICategoriaServices
    {
        IEnumerable<CategoriaViewModel> ObterTodos();
        Task<CategoriaViewModel> ObterPorId(Guid id);
        Task<IEnumerable<CategoriaViewModel>> ObterPorCategoria(int codigo);

        void Adicionar(NovoCategoriaViewModel categoria);
        void Atualizar(CategoriaViewModel categoria);


    }
}
