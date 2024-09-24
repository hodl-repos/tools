﻿using System;
using System.Linq.Expressions;

namespace tools_dotnet.Dao.KeyWrapper
{
    public interface IKeyWrapper<TEntity>
    {
        string[] GetKeyAsString();

        /// <summary>
        /// updates the keywrapper by only entity-id's, but not parent-id's as navigation-properties may not be loaded
        /// </summary>
        void UpdateKeyWrapperByEntity(IKeyWrapper<TEntity> keyWrapper, TEntity entity);

        Expression<Func<TEntity, bool>> GetKeyFilter();

        /// <summary>
        /// Gets a partial key filter used to filter inside of GetAll
        /// </summary>
        Expression<Func<TEntity, bool>> GetContainingResourceFilter();
    }
}