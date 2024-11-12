using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC_TEST
{

    public class ELECTRONICS
    {
        private int Eid;
        private string Name;
        private string Brand;
        private string Type;
        private int Price;

        public ELECTRONICS(int Eid, string Name, string Brand, string Type,int price)
        {
            this.Eid = Eid;
            this.Name = Name;
            this.Brand = Brand;
            this.Type = Type;
            this.Price = price;
        }

        public int GetEid { get { return this.Eid; } }

        public string GetName { get { return this.Name; } }

        public string GetBrand { get { return this.Brand; } }

        public string GetCategory { get { return this.Type; } }

        public int GetPrice { get { return this.Price; } }

    }

    public class FURNITURE
    {
        private int Fid;
        private string Name;
        private string Category;
        private int Price;

        public FURNITURE(int Fid, string Name, string Category, int price)
        {
            this.Fid = Fid;
            this.Name = Name;
            this.Category = Category;
            this.Price = price;
        }

        public int GetFid { get { return this.Fid; } }

        public string GetName { get { return this.Name; } }
        public string GetCategory { get { return this.Category; } }
        public int GetPrice { get { return this.Price; } }

    }

    public class CLOTHING
    {
        private int Cid;
        private string Brand;
        private string Category;
        private int Price;

        public CLOTHING(int Cid, string Brand, string Category, int price)
        {
            this.Cid = Cid;
            this.Brand = Brand;
            this.Category = Category;
            this.Price = price;
        }

        public int GetCid { get { return this.Cid; } }
        public string GetBrand { get { return this.Brand; } }
        public string GetCategory { get { return this.Category; } }
        public int GetPrice { get { return this.Price; } }

    }


}
