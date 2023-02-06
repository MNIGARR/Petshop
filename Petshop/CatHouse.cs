using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    internal class CatHouse
    {
        public string Name { get; set; }
        public List<Cats> Catsl { get; set; } = new();
        public int CatCount { get; set; }

        public void AddCat(Cats cat)
        {
            foreach(var item in Catsl) {
                if (item.Nickname == cat.Nickname)
                {
                    throw new Exception("Bu ad ile pisik var.");
                }
                Catsl.Add(cat);
            }
        }
        public void RemoveNickname(string nickname)
        {
            foreach (var item in Catsl)
            {
                if (item.Nickname == nickname)
                {
                    Catsl.Remove(item);
                }
            }
        }
    }    
}
