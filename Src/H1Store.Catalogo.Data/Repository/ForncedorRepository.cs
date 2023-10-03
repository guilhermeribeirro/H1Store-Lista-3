using H1Store.Catalogo.Domain.Entities;
using H1Store.Catalogo.Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Data.Repository
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly string _fornecedorCaminhoArquivo;

        #region - Construtores
        public FornecedorRepository()
        {
            _fornecedorCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "Fornecedor.json");
        }

        #endregion

        #region - Funções
        public void Adicionar(Fornecedor fornecedor)
        {
            var fornecedores = LerFornecedoresDoArquivo();
            int proximoCodigo = ObterProximoCodigoDisponivel();
            fornecedor.SetaCodigoProduto(proximoCodigo);
            fornecedores.Add(fornecedor);
            EscreverFornecedoresNoArquivo(fornecedores);
        }

        public void Atualizar(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Fornecedor>> ObterPorCategoria(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<Fornecedor> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Fornecedor> ObterTodos()
        {
            return LerFornecedoresDoArquivo();
        }
        #endregion

        #region - Métodos arquivo
        private List<Fornecedor> LerFornecedoresDoArquivo()
        {
            if (!System.IO.File.Exists(_fornecedorCaminhoArquivo))
                return new List<Fornecedor>();
            string json = System.IO.File.ReadAllText(_fornecedorCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Fornecedor>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            List<Fornecedor> fornecedores = LerFornecedoresDoArquivo();
            if (fornecedores.Any())
                return fornecedores.Max(p => p.Codigo) + 1;
            else
                return 1;
        }

        private void EscreverFornecedoresNoArquivo(List<Fornecedor> fornecedores)
        {
            string json = JsonConvert.SerializeObject(fornecedores);
            System.IO.File.WriteAllText(_fornecedorCaminhoArquivo, json);
        }
        #endregion

    }
}
