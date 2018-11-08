using FYC.DataAccess.EFService;
using FYC.DataAccess.Entities;
using FYC.DataAccess.Literals;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace FYC.DataAccess.EFServices
{
    public class BlogService : BaseService
    {
        private BaseEntityService _DBService;
        public List<Category> GetAllCategories(int pageIndex, int pageSize)
        {
            using (_DBService = new BaseEntityService())
            {
                List<Category> list = _DBService.Database.SqlQuery<Category>(BlogLiterals.GetALLCategories, new SqlParameter("@PageIndex", pageIndex), new SqlParameter("@PageSize", pageSize)).ToList();
                return list;
            }
        }
        public IEnumerable<Category> GetAllBlogs(int pageIndex, int pageSize)
        {
            using (_DBService = new BaseEntityService())
            {
                IEnumerable<Category> list = _DBService.Database.SqlQuery<Category>(BlogLiterals.GetAllBlogPostByPageIndex + " @PageIndex,@PageSize",
                                                new SqlParameter("@PageIndex", pageIndex), new SqlParameter("@PageSize", pageSize));
                return list;
            }
        }
        public Category GetBlogById(int ID)
        {
            using (_DBService = new BaseEntityService())
            {
                var dbCategory = _DBService.FYC_DEF_Category.Where(x => x.CategoryID == ID).FirstOrDefault();
                if (dbCategory != null)
                {
                    return new Category
                    {
                        CategoryId = dbCategory.CategoryID,
                        CategoryName = dbCategory.CategoryName
                    };
                }
                return new Category();
            }
        }
    }
}
