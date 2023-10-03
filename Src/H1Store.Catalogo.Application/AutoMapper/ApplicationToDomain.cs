using AutoMapper;
using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{

			CreateMap<ProdutoViewModel, Produto>()
			   .ConstructUsing(q => new Produto(q.Codigo,q.Nome,q.Descricao,q.Ativo,q.Valor,q.DataCadastro,q.Imagem,q.QuantidadeEstoque));

			CreateMap<NovoProdutoViewModel, Produto>()
			   .ConstructUsing(q => new Produto(0, q.Nome, q.Descricao, q.Ativo, q.Valor, q.DataCadastro, q.Imagem, q.QuantidadeEstoque));

            CreateMap<CategoriaViewModel, Categoria>()
                .ConstructUsing(q => new Categoria(q.Codigo, q.Descricao));

            CreateMap<NovoCategoriaViewModel, Categoria>()
				.ConstructUsing (q => new Categoria(0, q.Descricao));

            CreateMap<FornecedorViewModel, Fornecedor>()
                .ConstructUsing(q => new Fornecedor(q.Codigo, q.RazaoSocial, q.CNPJ, q.Ativo, q.DataCadastro, q.Email, q.Contato));

            CreateMap<NovoFornecedorViewModel, Fornecedor>()
                .ConstructUsing(q => new Fornecedor(0 ,q.RazaoSocial, q.CNPJ, q.Ativo, q. DataCadastro, q.Email, q.Contato));


        }
	}
}
