using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using test_dijkstra_c_;

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
            for (int i = 0; i < _iNumVertices; ++i)
            {
                _adijacencyList[i] = new List<(int, int)>();
            }

        }

        // thêm cạnh, và trọng số vào danh sách kề.
        public void addEdges(int u, int v, int weight)
        {
            _adijacencyList[u].Add((v, weight));
        }

        public pair[] dijkstra(int s)
        {
            pair[] result = new pair[_iNumVertices]; // lưu distance min và đỉnh pre.
            int[] visited = new int[_iNumVertices]; // đánh dấu các đỉnh đã thăm.

            for (int i = 0; i < _iNumVertices; ++i)
            {
                result[i] = new pair(int.MaxValue, i);
                visited[i] = 0;
            }
            result[s] = new pair(0, s);

            var pq = new SortedSet<(int distance, int vertices)>();
            pq.Add((0, s));
            while (pq.Count > 0)
            {
                var current = pq.First();
                pq.Remove(current);

                int currentVertex = current.vertices;
                int currentDistance = current.distance;


                if (visited[currentVertex] == 1) continue;

                foreach (var (v, weight) in _adijacencyList[currentVertex])
                {
                    int newDistance = currentDistance + weight;
                    if (newDistance < result[v].Value1)
                    {
                        result[v].Value1 = newDistance;
                        result[v].Value2 = currentVertex;
                    }

                    pq.Add((newDistance, v));
                }

                visited[currentVertex] = 1;
            }

            return result;

        }

        public void result(int s, int e)
        {
            pair[] pathAnDistance = dijkstra(s);

            List<int> p = new List<int>();

            if (pathAnDistance[e].Value2 != e)
            {
                p.Add(e);
                int pre = pathAnDistance[e].Value2;
                while (pre != s)
                {
                    p.Add(pre);
                    pre = pathAnDistance[pre].Value2;
                }
                p.Add(pre);

                string path = "";
                p.Reverse();
                for (int i = 0; i < p.Count; ++i)
                {
                    path = (i == p.Count - 1) ? path + $"{p[i]}" : path + $"{p[i]}->";
                }

                Console.WriteLine(pathAnDistance[e].Value1);
                Console.WriteLine(path);
            }
            else Console.WriteLine("khong co duong di");

        }
    }
}
