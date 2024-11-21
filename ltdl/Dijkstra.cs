using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace ltdl
{
    internal class Dijkstra
    {
        private int _iNumVertices; // số lượng đỉnh của đồ thị.
        private List<(int, int)>[] _adijacencyList; // chúa danh sách các cạnh kề có trọng số.

        // hàm khởi vớ parameter là số đỉnh của đồ thị.
        public Dijkstra(int iNumVertices) 
        {
            _iNumVertices = iNumVertices;

            _adijacencyList = new List<(int, int)>[_iNumVertices];
            for(int i=0; i < _iNumVertices; ++i)
            {
                _adijacencyList[i] = new List<(int, int)>();
            }    
            
        }

        // thêm cạnh, và trọng số vào danh sách kề.
        public void addEdges(int u, int v, int weight)
        {
            _adijacencyList[u].Add((v, weight));
        }

        public int[] dijkstra(int s)
        {
            int[] result = new int[_iNumVertices]; // mảng lưu lại khoảng cách min từ đỉnh s đến 1 đỉnh khác trong đồ thị.
            int[] visited = new int[_iNumVertices]; // đánh dấu các đỉnh đã thăm.

            for (int i = 0; i < _iNumVertices; ++i)
            {
                result[i] = int.MinValue;
                visited[i] = 0;
            }
            result[s] = 0;

            var pq = new SortedSet<(int distance, int vertices)>();
            pq.Add((0, s));
            while(pq.Count > 0)
            {
                var current = pq.First();
                pq.Remove(current);

                int currentVertex = current.vertices;
                int currentDistance = current.distance;

                if (visited[currentVertex] == 1) continue;

                foreach(var (v, weight) in _adijacencyList[currentVertex])
                {
                    int newDistance = currentDistance + weight;
                    if(newDistance < result[v])
                    {
                        result[v] = newDistance;
                    } 

                    pq.Add((newDistance, v));
                        
                }

                visited[currentVertex] = 1;
            }    

            return result;

        }

        public void result(int s)
        {
            int[] distance = dijkstra(s);

            for (int i = 0; i < distance.Length; ++i)
            {
                Console.WriteLine($"dinh: {i}, khoang cach {distance[i]}\n");
            } 
                
        }
    }
}
