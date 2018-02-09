using System;
using System.Collections.Generic;

namespace Manager
{
    public class Product
    {
        private int _id;
        private int _articul;
        private IDescription _description;
        private IProductAdress _productAdress;
        private decimal _price;
        private Producent producent;
        private int _mainCateg;     
        private List<Category> _categlist;

        public int Id { get => _id; set => _id = value; }
        public int Articul { get => _articul; set => _articul = value; }
        public int MainCateg { get => _mainCateg; set => _mainCateg = value; }
        public decimal Price { get => _price; set => _price = value; }
        internal IDescription Description { get => _description; set => _description = value; }
        internal IProductAdress ProductAdress { get => _productAdress; set => _productAdress = value; }
        internal Producent Producent { get => producent; set => producent = value; }
    }
}
