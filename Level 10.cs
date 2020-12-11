using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code
{
    class Level_10
    {
        static long[] cache = new long[200];
        static List<long> jolts = new List<long>();
        static void Main_10(string[] args)
        {
            long[] testAdapterArray = {
                28,
33,
18,
42,
31,
14,
46,
20,
48,
47,
24,
23,
49,
45,
19,
38,
39,
11,
1,
32,
25,
35,
8,
17,
7,
9,
4,
2,
34,
10,
3
            };
            long[] adapterArray = {84,
60,
10,
23,
126,
2,
128,
63,
59,
69,
127,
73,
140,
55,
154,
133,
36,
139,
4,
70,
110,
97,
153,
105,
41,
106,
79,
145,
35,
134,
146,
148,
13,
77,
49,
107,
46,
138,
88,
152,
83,
120,
52,
114,
159,
158,
53,
76,
16,
28,
89,
25,
42,
66,
119,
3,
17,
67,
94,
99,
7,
56,
85,
122,
18,
20,
43,
160,
54,
113,
29,
130,
19,
135,
30,
80,
116,
91,
161,
115,
141,
102,
37,
157,
129,
34,
147,
142,
151,
68,
78,
24,
90,
121,
123,
33,
98,
1,
40};

            // 0 1 2 3
            // 0 1 3
            // 0 2 3
            // 0 1 3
            // 0 3
            foreach (long n in adapterArray)
            {
                jolts.Add(n);
            }

            //long oneDiff = 0;
            //long threeDiff = 0;
            jolts.Sort();
            //foreach(long o in adapters){
            //    Console.WriteLine(o);
            //}
            /*for (long i = 0; i <adapters.Count;i++){
                if(i==adapters.Count-3) break;
                if(adapters[i+3]-adapters[i] == 3) {
                    possibilities*=5;
                }
                if(adapters[i+1]-adapters[i] == 1){
                    if(adapters[i+2]-adapters[i] ==)
                }
                
                
            }*/
            //Console.WriteLine((oneDiff+1).ToString() +" " + (threeDiff+1).ToString());
            //Console.WriteLine(possibilities);
            Console.WriteLine(anotherLayer(0));
            
        }
        private static long anotherLayer(long num)
        {
            if (cache[num] != 0)
            {
                return cache[num];
            }
            long layerCount = 0;
            if (jolts.Contains(num + 1))
            {
                if (num + 1 == jolts[jolts.Count - 1])
                {
                    layerCount++;
                }
                else
                {
                    layerCount += anotherLayer(num + 1);
                }
            }
            if (jolts.Contains(num + 2))
            {
                if (num + 2 == jolts[jolts.Count - 1])
                {
                    layerCount++;
                }
                else
                {
                    layerCount += anotherLayer(num + 2);
                }
            }
            if (jolts.Contains(num + 3))
            {
                if (num + 3 == jolts[jolts.Count - 1])
                {
                    layerCount++;
                }
                else
                {
                    layerCount += anotherLayer(num + 3);
                }
            }
            cache[num] = layerCount;
            return layerCount;

        }
    }
}