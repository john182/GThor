﻿namespace GThorFrameworkDominio.Dominios.MdfeFiscal
{
    public class MdfeCiot
    {
        public virtual int Id { get; set; }
        public virtual int MdfeId { get; set; }
        public virtual Mdfe Mdfe { get; set; }
        public virtual long Ciot { get; set; } // 12 
        public virtual string DocumentoUnico { get; set; } // 14
    }
}