using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    /// <summary>
    /// хранит колекцию категорий, выдает для одной категории потомков, похжие, синонимы
    /// </summary>
    interface ICategoryContainer
    {
        List<Category> getAll();
        List<Category> getSynonyms(Category categ);
        List<Category> getDescendants(Category categ);
        List<Category> getRelated(Category categ);

    }
}
