using LibraryMVP.Logic.Services;
using LibraryMVP.Models;
using LibraryMVP.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVP.Logic.Prisenter
{
     class CategoryPrisenter
    {
        ICategory icategory;
        CategoryModel catModel = new CategoryModel();

        public CategoryPrisenter(ICategory view)
        {
            this.icategory = view;
        }

        //connect bewteen model cat and interface cat
        private void connectBetweenModelInterface()
        {
            catModel.ID = icategory.ID;
            catModel.CatName = icategory.CatName;
        }

        public bool catInsert()
        {
            connectBetweenModelInterface();
            return CategoryService.categoryInsert(catModel.ID, catModel.CatName);
        }

    }
}
