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
        public string _strPath;
        public string _strMoneyMin;

        // hàm khởi vớ parameter là số đỉnh của đồ thị.
        public Dijkstra(int iNumVertices)
        {
            _iNumVertices = iNumVertices;
            _strPath = _strMoneyMin = "";

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
            _adijacencyList[v].Add((u, weight));
        }

        public Pair[] dijkstra(int s)
        {
            Pair[] result = new Pair[_iNumVertices]; // lưu distance min và đỉnh pre.
            int[] visited = new int[_iNumVertices]; // đánh dấu các đỉnh đã thăm.

            for (int i = 0; i < _iNumVertices; ++i)
            {
                result[i] = new Pair(int.MaxValue, i);
                visited[i] = 0;
            }
            result[s] = new Pair(0, s);

            var sSet = new SortedSet<(int distance, int vertices)>();
            sSet.Add((0, s));
            while (sSet.Count > 0)
            {
                var current = sSet.First();
                sSet.Remove(current);

                int currentVertex = current.vertices;
                int currentDistance = current.distance;


                if (visited[currentVertex] == 1) continue;

                foreach (var (v, weight) in _adijacencyList[currentVertex])
                {
                    int newDistance = currentDistance + weight;
                    if (newDistance < result[v].Value1)
                    {
                        // xóa phần tử trùng.
                        sSet.Remove((newDistance, v));

                        result[v].Value1 = newDistance;
                        result[v].Value2 = currentVertex;
                    }

                    sSet.Add((newDistance, v));
                }

                visited[currentVertex] = 1;
            }

            return result;

        }

        // chuyển số thành tên quốc gia.
        string numberTOCountryNane(int iNum)
        {
            string strCountry = "";

            if (iNum == 0)
            {
                strCountry = "PhiLipPines";
            }
            else if (iNum == 1)
            {
                strCountry = "Thailand";
            }
            else if (iNum == 2)
            {
                strCountry = "Myanmar";
            }
            else if (iNum == 3)
            {
                strCountry = "cambodia";
            }
            else if (iNum == 4)
            {
                strCountry = "Singapore";
            }
            else if (iNum == 5)
            {
                strCountry = "Indonesia";
            }
            else if (iNum == 6)
            {
                strCountry = "Laos";
            }
            else if (iNum == 7)
            {
                strCountry = "Việt Nam";
            }
            else if (iNum == 8)
            {
                strCountry = "Malaysia";
            }
            else
            {
                strCountry = "Brunei";
            }

            return strCountry;

        }

        public void result(int s, int e)
        {
            Pair[] pathAnDistance = dijkstra(s);

            List<int> p = new List<int>();

            if (pathAnDistance[e].Value1 != int.MaxValue)
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
                    string country = numberTOCountryNane(p[i]);
                    path = (i == p.Count - 1) ? path + $"{country}" : path + $"{country}->";
                }

                _strMoneyMin = pathAnDistance[e].Value1 + "";
                _strPath = path;
            }
            else
            {
                _strPath = _strMoneyMin = "không tìm thấy đường đi";
            } 

        }
    }
}
