using FYC.DataAccess.Entities;
using FYC.DataAccess.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FYC.DataAccess.Services
{
    public class BlogService : IBlogService
    {
        private IUnitOfWork _unitOfWork;
        public BlogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Blog>> GetAllBlogByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.BlogRepository.GetAllBlogByPageIndex(pageIndex, pageSize);
        }
    }
}
