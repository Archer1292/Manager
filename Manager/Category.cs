using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    class Category
    {
        private int _id;
        private string _name;
        private string _note;
        private Category _parent;
        private List<String> _keyWords;
        private List<CategRatio> _ratios;
        private int itemNumber;
        private int _index;//level of tree 
        /* для магазина в общем 0
         * потом 1
         * */
        private bool _canHaveProduct;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Note { get => _note; set => _note = value; }
        public List<string> KeyWords { get => _keyWords; set => _keyWords = value; }
        public int Index { get => _index; set => _index = value; }
        public int ItemNumber { get => itemNumber; set => itemNumber = value; }
        internal Category Parent { get => _parent; set => _parent = value; }
        internal List<CategRatio> Ratios { get => _ratios; set => _ratios = value; }
        /// <summary>
        /// проверяет является ли this потомком categ
        /// </summary>
        /// <param name="categ">предполагаемый предок</param>
        /// <returns></returns>
        public bool isInheritor(Category categ)
        {
            if (Parent.Equals(categ)) return true;
            if (Index > 2) return Parent.isInheritor(categ);
            return false;
            
        }
    }
  
}
