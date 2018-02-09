using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    class CategRatio
    {
        private int _id;
        private Category _firstCateg;
        private Category _secondCateg;
        private Ratio _ratio;

        private static HashSet<CategRatio> _ratios;
        static CategRatio() { _ratios = new HashSet<CategRatio>(); }

        public CategRatio(int id, Category firstCateg, Category secondCateg, Ratio ratio)// todo autoid
        {
            _id = id;
            _firstCateg = firstCateg;
            _secondCateg = secondCateg;
            _ratio = ratio;
            if (Ratios.Contains(this)) throw new Exception("Попытка второй раз добавить отношение");//todo отношения между 2 категориями должны добавляться только 1 раз
        }

        public int Id { get => _id;}
        internal Category FirstCateg { get => _firstCateg;  }
        internal Category SecondCateg { get => _secondCateg;  }
        internal Ratio Ratio { get => _ratio; set => _ratio = value; }
        internal static HashSet<CategRatio> Ratios { get => _ratios; set => _ratios = value; }

        //public override int GetHashCode()//todo оптимизировать хешкод категории и этого класса
        //{
        //    return FirstCateg.Id * 100000 + SecondCateg.Id;            
        //}
        //public override bool Equals(object obj)
        //{
        //    if (!(obj is CategRatio)) return false;
        //    if(FirstCateg.Equals((obj as CategRatio).FirstCateg) &&
        //            SecondCateg.Equals((obj as CategRatio).SecondCateg )&& Ratio == (obj as CategRatio).Ratio) 
        //    return true;
        //    return false;
        //}
    }

    internal enum Ratio {partOf,
        equals,
        contains,
        symilar,
        exepts,
        undefined }
}
