using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    interface IProductAdress
    {
        String GetBase();
        bool IsContain(string www);
    }
    class ProductAdress : IProductAdress
    {
        private string _www;//todo change to www type

        public string Www { get => _www; set => _www = value; }

        public String GetBase() { return null; }//todo return base of addres
        public bool IsContain(String www)
        {
            if (Www.Contains(www)) return true;
            return false;
        }
    }
}
