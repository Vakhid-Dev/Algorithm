namespace Tree
{
    class Sort
    {
        /* Sieve(a,b,i) i - елемент который просеиваеться
         *
         *
         */

        public void HeapSort(ref double[] a, int n)
        {
            // Построение пирамиды
            int k = n / 2;
            while (k > 0)
            {
                --k;

                Sieve(ref a, n, k);
            }

            k = n;
            while (k > 1)
            {
                --k;
                Swap(ref a[0], ref a[k]);
                Sieve(ref a, k, 0);

            }

        }

        public void Sieve(ref double[] a, int n, int i)
        {
            while (true)
            {
                // Вычисляем левого сына
                int s0 = (2 * i) + 1;
                // Если левый сын явл терминальным узлом
                if (s0 >= n)
                {
                    break;
                }
                // Вычисляем правого сына
                int s1 = s0 + 1;
                int s = s0;
                // Если правый сын имееться и правый сын явл старшим
                if (s1 < n && a[s1] > a[s0])
                {
                    s = s1;
                }

                if (a[i] >= a[s1])
                {
                    break;
                }
                Swap(ref a[i], ref a[s]);
                i = s;

            }
        }

        public void Swap(ref double a, ref double b)
        {
            double c = a;
            a = b;
            b = c;
        }

    }

    class Search
    {
    }
}