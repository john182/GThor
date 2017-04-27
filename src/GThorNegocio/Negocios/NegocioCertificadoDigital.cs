﻿using System.Collections.Generic;
using GThorFrameworkDominio.Dominios.Certificados;
using GThorNegocio.Contratos;
using GThorRepositorio.Contratos;
using GThorRepositorioNHibernate.Helpers;
using GThorRepositorioNHibernate.Helpers.Ext;

namespace GThorNegocio.Negocios
{
    internal class NegocioCertificadoDigital : INegocioCertificadoDigital
    {
        private readonly IRepositorioCertificadoDigital _repositorioCertificadoDigital;

        public NegocioCertificadoDigital(IRepositorioCertificadoDigital repositorioCertificadoDigital)
        {
            _repositorioCertificadoDigital = repositorioCertificadoDigital;
        }

        public void SalvarOuAtualizar(CertificadoDigital certificadoDigital)
        {
            using (var instancia = NHibernateHelper.InstanciaComTransacao())
            {
                _repositorioCertificadoDigital.SetSession(instancia);
                _repositorioCertificadoDigital.SalvarOuAtualizar(certificadoDigital);
            }
        }

        public CertificadoDigital CarregarPorId(int id)
        {
            using (var instancia = NHibernateHelper.Instancia())
            {
                _repositorioCertificadoDigital.SetSession(instancia);
                return _repositorioCertificadoDigital.CarregarPorId(id);
            }
        }

        public IEnumerable<CertificadoDigital> Lista()
        {
            using (var instancia = NHibernateHelper.Instancia())
            {
                _repositorioCertificadoDigital.SetSession(instancia);
                return _repositorioCertificadoDigital.Lista();
            }
        }

        public void Deletar(CertificadoDigital certificadoDigital)
        {
            using (var instancia = NHibernateHelper.InstanciaComTransacao())
            {
                _repositorioCertificadoDigital.SetSession(instancia);
                _repositorioCertificadoDigital.Deletar(certificadoDigital);
            }
        }
    }
}