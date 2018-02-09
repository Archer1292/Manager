using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    /// <summary>
    /// основная задача - быстрая организация графа категорий
    /// </summary>
    class CategDictionary:ICategoryContainer
    {
        private Dictionary<int, Category> _categories;//todo должны ли эти поля быть здесь?

        internal Dictionary<int, Category> Categories { get => _categories; set => _categories = value; }

        public List<Category> getAll()
        {
            return null; //tod возврат list
            //return (List<Category>)Categories.Values;
        }

        public List<Category> getDescendants(Category categ)
        {
            List<Category> temp = new List<Category>();
            foreach (CategRatio r in categ.Ratios)
            {
                if (r.Ratio.Equals(Ratio.contains))
                    temp.Add(r.SecondCateg);
            }
            return temp;
        }

        public List<Category> getRelated(Category categ)
        {
            List<Category> temp = new List<Category>();
            foreach (CategRatio r in categ.Ratios)
            {
                if (r.Ratio.Equals(Ratio.symilar))
                    temp.Add(r.SecondCateg);
            }
            return temp;
        }

        public List<Category> getSynonyms(Category categ)
        {
            List<Category> temp = new List<Category>();
            foreach(CategRatio r in categ.Ratios)
            {
                if (r.Ratio.Equals(Ratio.partOf) || r.Ratio.Equals(Ratio.equals))
                    temp.Add(r.SecondCateg);
            }
            return temp;
        }
    }
}
