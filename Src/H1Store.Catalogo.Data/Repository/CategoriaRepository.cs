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
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly string _categoriaCaminhoArquivo;

        #region - Construtores
        public CategoriaRepository()
        {
            _categoriaCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "Categoria.json");
        }

        #endregion

        #region - Funções
        public void Adicionar(Categoria categoria)
        {
            var categorias = LerCategoriasDoArquivo();
            int proximoCodigo = ObterProximoCodigoDisponivel();
            categoria.SetaCodigoProduto(proximoCodigo);
            categorias.Add(categoria);
            EscreverCategoriasNoArquivo(categorias);
        }

        public void Atualizar(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categoria>> ObterPorCategoria(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> ObterTodos()
        {
            return LerCategoriasDoArquivo();
        }
        #endregion

        #region - Métodos arquivo
        private List<Categoria> LerCategoriasDoArquivo()
        {
            if (!System.IO.File.Exists(_categoriaCaminhoArquivo))
                return new List<Categoria>();
            string json = System.IO.File.ReadAllText(_categoriaCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Categoria>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            List<Categoria> categorias = LerCategoriasDoArquivo();
            if (categorias.Any())
                return categorias.Max(p => p.Codigo) + 1;
            else
                return 1;
        }

        private void EscreverCategoriasNoArquivo(List<Categoria> categorias)
        {
            string json = JsonConvert.SerializeObject(categorias);
            System.IO.File.WriteAllText(_categoriaCaminhoArquivo, json);
        }
        #endregion



    }
}
