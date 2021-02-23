using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstrasShortestPath
{
    class Program
    {
        class DNode
        {
            public string name;
            public int distance;
            public bool visited;
            public DNode previousNode;

            public DNode(string name)
            {
                this.name = name;
                this.distance = 99999999;
                visited = false;
                previousNode = null;
            }
        }


        static void Main(string[] args)
        {
            //Define Graph
            int[,] gMatrix =
            {
                { 0,4,3,7,0,0,0},
                { 4,0,0,1,1,5,0},
                { 3,0,0,3,5,0,0},
                { 7,1,3,0,2,2,7},
                { 0,0,0,7,2,5,0},
                { 0,5,0,2,0,0,5},
                { 0,0,0,7,2,5,0}
            };

            //create Dijkstra List
            List<DNode> dList = new List<DNode>();
            dList.Add(new DNode("a"));
            dList.Add(new DNode("b"));
            dList.Add(new DNode("c"));
            dList.Add(new DNode("d"));
            dList.Add(new DNode("e"));
            dList.Add(new DNode("f"));
            dList.Add(new DNode("g"));

            DNode startNode;
            DNode endNode;
            DNode lowestUnvisited;

            string tempInput;

            Console.WriteLine("Dijkstra's Shortest Path Algorithm");
            Console.WriteLine("==================================\n");
            Console.WriteLine("Enter Start Node: ");
            tempInput = Console.ReadLine().ToLower();
            startNode = dList.ElementAt(((int)tempInput.First()) - 97);
            Console.WriteLine("Enter End Node: ");
            tempInput = Console.ReadLine().ToLower();
            endNode = dList.ElementAt(((int)tempInput.First()) - 97);

            //Set Start node values
            startNode.distance = 0;
            lowestUnvisited = startNode;

            do
            {
                lowestUnvisited.visited = true;
                evaluateNode(gMatrix, dList, lowestUnvisited);
                lowestUnvisited = FindLowestUnvisited(dList);
            } while (lowestUnvisited != null);

            //output final path

            Console.WriteLine("The final distance is: {0}", endNode.distance);
            Console.Write("The shortest path is {0}", shortestPath(endNode));

            Console.ReadKey();
        }


        static DNode FindLowestUnvisited(List<DNode> dNodes)
        {
            DNode tempNode = null;
            bool first = true;

            foreach (DNode item in dNodes)
            {
                if (first && !item.visited)
                {
                    tempNode = item;
                    first = false;
                }
                else if (!item.visited && item.distance < tempNode.distance)
                {
                    tempNode = item;
                }
            }

            return tempNode;
        }

        static void evaluateNode(int[,] graph, List<DNode> dList, DNode currentNode)
        {
            int currentNodeRow = (int) (currentNode.name.ToString().First()) - 97;

            for (int x = 0; x <= graph.GetUpperBound(1); x++)
            {
                if( graph[currentNodeRow,x] > 0 && !dList[x].visited)
                {
                    if (dList[x].distance > currentNode.distance + graph[currentNodeRow, x])
                    {
                        dList[x].distance = currentNode.distance + graph[currentNodeRow, x];
                        dList[x].previousNode = currentNode;
                    }
                }
            }
        }

        static string shortestPath(DNode endNode)
        {
            string path = "";
            DNode currentNode = endNode;

            do
            {
                path = currentNode.name + path;
                currentNode = currentNode.previousNode;
            } while (currentNode !=null);

            return path;
        }
    }
}
