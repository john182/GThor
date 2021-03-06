﻿using System.Collections.Generic;
using GThorFrameworkDominio.Dominios.Empresas;
using GThorFrameworkDominio.Dto;
using GThorFrameworkDominio.Dto.Empresas;
using GThorNegocio.Contratos;
using GThorRepositorio.Contratos;
using GThorRepositorioNHibernate.Helpers;
using GThorRepositorioNHibernate.Helpers.Ext;

namespace GThorNegocio.Negocios
{
    internal class NegocioEmpresa : INegocioEmpresa
    {
        private readonly IRepositorioEmpresa _repositorioEmpresa;

        public NegocioEmpresa(IRepositorioEmpresa repositorioEmpresa)
        {
            _repositorioEmpresa = repositorioEmpresa;
        }

        public Empresa CarregarPorId(int id)
        {
            using (var instancia = NHibernateHelper.Instancia())
            {
                _repositorioEmpresa.SetNHibernateHelper(instancia);
                return _repositorioEmpresa.CarregarPorId(id);
            }
        }

        public IEnumerable<Empresa> Lista()
        {
            using (var instancia = NHibernateHelper.Instancia())
            {
                _repositorioEmpresa.SetNHibernateHelper(instancia);
                return _repositorioEmpresa.Lista();
            }
        }

        public void SalvarOuAtualizar(Empresa entity)
        {
            using (var instancia = NHibernateHelper.InstanciaComTransacao())
            {
                _repositorioEmpresa.SetNHibernateHelper(instancia);
                _repositorioEmpresa.SalvarOuAtualizar(entity);
            }
        }

        public void Deletar(Empresa entity)
        {
            using (var instancia = NHibernateHelper.InstanciaComTransacao())
            {
                _repositorioEmpresa.SetNHibernateHelper(instancia);
                _repositorioEmpresa.Deletar(entity);
            }
        }

        public IEnumerable<EmpresaDto> BuscarParaGridModel()
        {
            using (var instancia = NHibernateHelper.Instancia())
            {
                _repositorioEmpresa.SetNHibernateHelper(instancia);
                return _repositorioEmpresa.BuscarParaGridModel();
            }
        }

        public IEnumerable<EmpresaComboBoxDto> BuscarParaComboBox()
        {
            using (var instancia = NHibernateHelper.Instancia())
            {
                _repositorioEmpresa.SetNHibernateHelper(instancia);
                return _repositorioEmpresa.BuscarParaComboBox();
            }
        }
    }
}