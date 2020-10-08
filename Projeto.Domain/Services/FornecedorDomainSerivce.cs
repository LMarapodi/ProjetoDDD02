using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class FornecedorDomainSerivce : BaseDomainService<Fornecedor>, IFornecedorDomainService
    {
        private readonly IFornecedorRepository fornecedorRepository;

        public FornecedorDomainSerivce(IFornecedorRepository fornecedorRepository) : base(fornecedorRepository)
        {
            this.fornecedorRepository = fornecedorRepository;
        }

        public override void Insert(Fornecedor obj)
        { 
            if (fornecedorRepository.GetByCnpj(obj.Cnpj) != null)
            {
                throw new Exception("Erro ao cadastrar, Cnpj já está cadastrado.");      
            }
            else
            {
                fornecedorRepository.Insert(obj);
            }
        }
          

        public Fornecedor GetByCnpj(string cnpj)
        {

            return fornecedorRepository.GetByCnpj(cnpj);
        }
    }
}
