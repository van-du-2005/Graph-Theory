using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_dijkstra_c_
{
    internal class pair
    {
        int _iValue1, _iValue2;

       public pair(int iValue1, int iValue2)
        {
            _iValue1 = iValue1;
            _iValue2 = iValue2;
        }

        public int Value1
        {
            get { return _iValue1; }
            set { _iValue1 = value; }
        }

        public int Value2
        {
            get { return _iValue2; }
            set { _iValue2 = value; }
        }
    }

}
