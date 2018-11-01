using Dapper;
using FYC.DataAccess.Entities;
using FYC.DataAccess.Infrastructure;
using FYC.DataAccess.Literals;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace FYC.DataAccess.Repositories
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        private IConnectionFactory _connectionFactory;

        public BlogRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task<IEnumerable<Blog>> GetAllBlogByPageIndex(int pageIndex, int pageSize)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@PageIndex", pageIndex);
            param.Add("@PageSize", pageSize);
            IEnumerable<Blog> list = await SqlMapper.QueryAsync<Blog>(_connectionFactory.GetConnection, BlogLiterals.GetAllBlogPostByPageIndex, param, commandType: CommandType.StoredProcedure);
            return list;
        }
    }
}
