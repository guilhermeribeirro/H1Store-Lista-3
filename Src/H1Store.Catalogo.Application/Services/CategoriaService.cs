using AutoMapper;
using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Domain.Entities;
using H1Store.Catalogo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace H1Store.Catalogo.Application.Services
{
    public class CategoriaService : ICategoriaServices
    { 
        #region - Construtores
        private readonly ICategoriaRepository _categoriaRepository;
        private IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }
        #endregion

        #region - Funções
        public void Adicionar(NovoCategoriaViewModel novoCategoriaViewModel)
        {
            var novoCategoria = _mapper.Map<Categoria>(novoCategoriaViewModel);
            _categoriaRepository.Adicionar(novoCategoria);

        }

        public void Atualizar(CategoriaViewModel categoria)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoriaViewModel>> ObterPorCategoria(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaViewModel> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaViewModel> ObterTodos()
        {
            return _mapper.Map<IEnumerable<CategoriaViewModel>>(_categoriaRepository.ObterTodos());
        }

        
        #endregion


    }
}
