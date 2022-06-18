using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.CategoriesUseCases
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepossitory;

        public DeleteCategoryUseCase(ICategoryRepository categoryRepossitory)
        {
            this.categoryRepossitory = categoryRepossitory;
        }

        public void Delete(int categoryId)
        {
            categoryRepossitory.DeleteCategory(categoryId);
        }
    }
}
