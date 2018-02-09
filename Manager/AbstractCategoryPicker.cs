using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    abstract class AbstractCategoryPicker
    {
        private CategDictionary categTree;
        private Product product;
        abstract public List<Category> OfferCategList();
    }
}
