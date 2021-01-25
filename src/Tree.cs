namespace Tree
{
    class Sort
    {
        /* Sieve(a,b,i) i - ������� ������� �������������
         *
         *
         */

        public void HeapSort(ref double[] a, int n)
        {
            // ���������� ��������
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
                // ��������� ������ ����
                int s0 = (2 * i) + 1;
                // ���� ����� ��� ��� ������������ �����
                if (s0 >= n)
                {
                    break;
                }
                // ��������� ������� ����
                int s1 = s0 + 1;
                int s = s0;
                // ���� ������ ��� �������� � ������ ��� ��� �������
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