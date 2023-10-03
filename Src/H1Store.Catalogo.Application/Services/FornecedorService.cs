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
    public class FornecedorService :IFornecedorService
    {
        #region - Construtores
        private readonly IFornecedorRepository _fornecedorRepository;
        private IMapper _mapper;

        public FornecedorService(IFornecedorRepository fornecedorRepository, IMapper mapper)
        {
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }
        #endregion

        #region - Funções
        public void Adicionar(NovoFornecedorViewModel novoFornecedorViewModel)
        {
            var novoFornecedor = _mapper.Map<Fornecedor>(novoFornecedorViewModel);
            _fornecedorRepository.Adicionar(novoFornecedor);

        }

        public void Atualizar(FornecedorViewModel fornecedor)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FornecedorViewModel>> ObterPorCategoria(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<FornecedorViewModel> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FornecedorViewModel> ObterTodos()
        {
            return _mapper.Map<IEnumerable<FornecedorViewModel>>(_fornecedorRepository.ObterTodos());
        }
        #endregion





    }
}
