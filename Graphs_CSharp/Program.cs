using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to graph program using Adjecency list\n");
            int[] command;
            Graph graph = new Graph();

            do
            {
                Console.WriteLine("Please use following commands for graph\n 1.Add(1 i j)\n 2.Search for edge(2 i j)\n 3.DFS(3)\n 4.BFS(4)\n");
                Console.WriteLine("Please enter the command as per given possible commands\n");
                command = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                switch (command[0])
                {
                    case 1:
                        graph.AddEdge(command[1], command[2]);
                        Console.WriteLine("edge added successfully");
                        break;
                    case 2:
                        bool exist = graph.IsEdge(command[1], command[2]);
                        if (exist)
                            Console.WriteLine("Edge is Present"); 
                        else
                            Console.WriteLine("Edge Not Found");
                        break;
                    case 3:
                        Console.WriteLine("Please find below DFS of Graph");
                        graph.DFS();
                        break;
                    case 4:
                        Console.WriteLine("Please find below BFS of Graph");
                        graph.BFS();
                        break;
                    default:
                        break;
                }
            } while (command[0] != 0);
        }
    }
}
