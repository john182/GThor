﻿using System.Collections.Generic;

namespace GThorFrameworkRepositorio.Contratos
{
    public interface IDaoBase<out TEntity, in TId>
    {
        TEntity CarregarPorId(TId id);

        IEnumerable<TEntity> Lista();
    }
}