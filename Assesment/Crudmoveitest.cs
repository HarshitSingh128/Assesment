using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Crudmoveitest
    {
        static void Main(string[] args)
        {
            Movei[] m1=new Movei[5];
            int id;
            double tcost;
            string mname, pname;
            int count = 0;
            do
            {
                Console.WriteLine("1.Add Movei");
                Console.WriteLine("2.Update Movei");
                Console.WriteLine("3.Delete Movei");
                Console.WriteLine("4.Show all movei");
                Console.WriteLine("5.Search movei by Id");
                Console.WriteLine("6.Search movei bY Name");


                Console.WriteLine("Enter Choice:");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Add Movei");
                        Console.WriteLine("Enter the number of Moveis You want to add");
                        int size = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < size; i++)
                        {
                            Console.WriteLine("Enter movei Id");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Movei Name");
                            mname = Console.ReadLine();
                            Console.WriteLine("Enter ticket cost");
                            tcost = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Producer name");
                            pname = Console.ReadLine();
                            m1[count] = new Movei(id, mname, tcost, pname);
                            count++;


                        }


                    break;
                    case 2:
                        Console.WriteLine("Update Movei");
                        Console.WriteLine("Enter movei id you want to update");
                        id = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i < count; i++)
                        {
                            if (m1[i]!=null && m1[i].Mid == id)
                            {
                                Console.WriteLine("Enter Ticket cost you want to update");
                                tcost = Convert.ToDouble(Console.ReadLine());
                                m1[i].Tcost = tcost;

                            }
                        }
                        Console.WriteLine("Update successfully");

                        break;
                    case 3:
                        Console.WriteLine("Delete Movie");
                        Console.WriteLine("Enter the Movei id you want to delete");
                        id = Convert.ToInt32(Console.ReadLine());

                       
                        int index = -1;
                        for (int i = 0; i < count; i++)
                        {
                            if (m1[i].Mid == id)
                            {
                                index = i;
                                break;
                            }
                        }

                        if (index == -1)
                        {
                            Console.WriteLine("Movie not found!");
                            return;
                        }

                        for (int i = index; i < count - 1; i++)
                        {
                            m1[i] = m1[i + 1];
                        }
                        count--;

                        Console.WriteLine("Movie deleted successfully!");
                
                break;
                    case 4:
                        Console.WriteLine("Show All Movei");
                        for (int i = 0; i < count; i++)
                        {
                             if (m1[i] != null)
                            {
 Console.WriteLine("Moveiid:"+m1[i].Mid+" " +"MoveiName:"+ m1[i].Mname+" "+"TicketCost:"+ m1[i].Tcost+" " +"ProducerName:"+ m1[i].Pname);
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Search Movei");
                        Console.WriteLine("Enter Movei id you want to search");
                        id = Convert.ToInt32(Console.ReadLine());
                        bool flag = false;
                        for(int i = 0; i < count; i++)
                        {
                            flag = false;
                            if (m1[i].Mid == id)
                            {
                                m1[i].Mid = id;
                                Console.WriteLine("Moveiid:" + m1[i].Mid + " " + "MoveiName:" + m1[i].Mname + " " + "TicketCost:" + m1[i].Tcost + " " + "ProducerName:" + m1[i].Pname);
                                flag = true;
                                break;
                            }
                            if (flag==false)
                            {
                                Console.WriteLine("id is not available");

                            }

                        }
                        break;
                    case 6:
                        Console.WriteLine("Search Movei");
                        Console.WriteLine("Enter Movei name you want to search");
                        mname= Console.ReadLine();
                         flag = false;
                        for (int i = 0; i < count; i++)
                        {
                            flag = false;
                            if (m1[i].Mname== mname)
                            {
                                m1[i].Mname = mname;
                                Console.WriteLine("Moveiid:" + m1[i].Mid + " " + "MoveiName:" + m1[i].Mname + " " + "TicketCost:" + m1[i].Tcost + " " + "ProducerName:" + m1[i].Pname);
                                flag = true;
                                break;
                            }
                            if (flag == false)
                            {
                                Console.WriteLine("id is not available");

                            }

                        }

                        break;
                    default:
                        Console.WriteLine("You have Enter invalid choice");
                        break;

                }
            } while (true);
            }
    }
}
