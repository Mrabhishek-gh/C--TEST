using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC_TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Boolean ch = true;
            GenClass<ELECTRONICS> genClass1 = new GenClass<ELECTRONICS>();
            GenClass<FURNITURE> genClass2 = new GenClass<FURNITURE>();
            GenClass<CLOTHING> genClass3 = new GenClass<CLOTHING>();
            while (ch == true)
            {
                Console.WriteLine("1. Add Electronics  2. Add Furniture  3. Add Clothing  4. Remove  5.SHOW INVENTORY  6. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Electronics ID ->");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Electronics Name ->");
                        string n = Console.ReadLine();
                        Console.WriteLine("Enter Electronics Brand ->");
                        string b = Console.ReadLine();
                        Console.WriteLine("Enter Electronics Type ->");
                        string t = Console.ReadLine();
                        Console.WriteLine("Enter Electronics Price ->");
                        int p = Convert.ToInt32(Console.ReadLine());


                        ELECTRONICS elec = new ELECTRONICS(i,n,b,t,p);
                        genClass1.add(elec);
                        Console.WriteLine("ELECTRONIC Successfully Added");
                        break;


                    case 2:
                        Console.WriteLine("Enter FURNITURE ID ->");
                        i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter FURNITURE Name ->");
                        n = Console.ReadLine();
                        Console.WriteLine("Enter FURNITURE Category ->");
                        string c = Console.ReadLine();
                        Console.WriteLine("Enter FURNITURE Price ->");
                        p = Convert.ToInt32(Console.ReadLine());

                        FURNITURE fur = new FURNITURE(i,n,c,p);
                        genClass2.add(fur);
                        Console.WriteLine("FURNITURE Successfully Added");
                        break;

                    case 3:

                        Console.WriteLine("Enter CLOTHING ID ->");
                        i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter CLOTHING Brand ->");
                        b = Console.ReadLine();
                        Console.WriteLine("Enter CLOTHING Category ->");
                        c = Console.ReadLine();
                        Console.WriteLine("Enter CLOTHING Price ->");
                        p = Convert.ToInt32(Console.ReadLine());

                        FURNITURE clo = new FURNITURE(i, b, c, p);
                        genClass2.add(clo);
                        Console.WriteLine("CLOTHING Successfully Added");
                        break;

                    case 4:

                        Console.WriteLine("Which entity to remove");
                        string ent = Console.ReadLine();

                        switch (ent)
                        {
                            case "ELECTRONICS":

                                Console.WriteLine("Which index to remove");
                                int index = Convert.ToInt32(Console.ReadLine());

                                int check = genClass1.Getobject().Count();

                                if(check>=index)
                                {
                                    genClass1.remove(index - 1);
                                    Console.WriteLine("ELECTRONICS Successfully Deleted");
                                }
                                else
                                {
                                    Console.WriteLine("The index You are looking is invalid");
                                }
                                break;
                            case "FURNITURE":
                                Console.WriteLine("Which index to remove");
                                index = Convert.ToInt32(Console.ReadLine());
                                check = genClass1.Getobject().Count();

                                if (check >= index)
                                {
                                    genClass2.remove(index - 1);
                                    Console.WriteLine("FURNITURE Successfully Deleted");
                                }
                                else
                                {
                                    Console.WriteLine("The index You are looking is invalid");
                                }
                                break;
                            case "CLOTHING":
                                Console.WriteLine("Which index to remove");
                                index = Convert.ToInt32(Console.ReadLine());
                                check = genClass1.Getobject().Count();

                                if (check >= index)
                                {
                                    genClass3.remove(index - 1);
                                    Console.WriteLine("CLOTHING Successfully Deleted");
                                }
                                else
                                {
                                    Console.WriteLine("The index You are looking is invalid");
                                }
                                break;
                        }
                            break;
                     case 5:

                        Console.WriteLine("Which entity to show ?");
                        string ent1 = Console.ReadLine();

                        switch (ent1)
                        {
                            case "ELECTRONICS":
                                foreach (ELECTRONICS elect in genClass1.Getobject())
                                {
                                    Console.WriteLine($"{elect.GetEid},{elect.GetName},{elect.GetBrand},{elect.GetCategory},{elect.GetPrice}");
                                }
                                break;

                            case "FURNITURE":
                                foreach (FURNITURE furn in genClass2.Getobject())
                                {
                                    Console.WriteLine($"{furn.GetFid},{furn.GetName},{furn.GetCategory},{furn.GetPrice}");
                                }
                                break;
                            case "CLOTHING":
                                foreach (CLOTHING clot in genClass3.Getobject())
                                {
                                    Console.WriteLine($"{clot.GetCid},{clot.GetBrand},{clot.GetCategory},{clot.GetPrice}");
                                }
                                break;
                            default:
                                break;
                        }

                        break;

                    case 6:
                        ch = false;
                        break;

                }
            }
        }
    }
}
