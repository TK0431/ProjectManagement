using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using YiSha.Data.Repository;

namespace YiSha.Service.SystemManage
{
    public class BaseService : RepositoryFactory
    {
        public async Task<List<T>> GetList<T,M>(M param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        private Expression<Func<T, bool>> ListFilter<T,M>(M param)
        {
            var expression = LinqExtensions.True<AreaEntity>();
            if (param != null)
            {
                if (!param.AreaName.IsEmpty())
                {
                    expression = expression.And(t => t.AreaName.Contains(param.AreaName));
                }
            }
            return expression;
        }
    }
}
