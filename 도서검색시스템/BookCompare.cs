using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace 도서검색시스템
{
    [Serializable]
    class BookCompare : IComparer<Book>
    {
        public bool priceSort;
        public bool ganadaSort;

        public BookCompare(bool pricesort, bool ganadasort)
        {
            priceSort = pricesort;
            ganadaSort = ganadasort;
        }

        public int Compare(Book x, Book y) // 검색 정확도가 높은 순으로 정렬
        {
            if (x.maxMatchCnt > y.maxMatchCnt) return -1;
            if (x.maxMatchCnt < y.maxMatchCnt) return 1;
            return 0;
        }

        public int compareByGanada1(Book x, Book y) // 가나다순으로 정렬
        {

            if (string.Compare(x.name, y.name) > 0) return 1;
            if (string.Compare(x.name, y.name) < 0) return -1;
            return 0;
        }

        public int compareByGanada2(Book x, Book y) // 가나다 역순으로 정렬
        {

            if (string.Compare(x.name, y.name) > 0) return -1;
            if (string.Compare(x.name, y.name) < 0) return 1;
            return 0;
        }

        public int compareByPrice1(Book x, Book y) // 가격 오름차순으로 정렬
        {
            if (x.price > y.price) return 1;
            if (x.price < y.price) return -1;
            return 0;
        }

        public int compareByPrice2(Book x, Book y) // 가격 내림차순으로 정렬
        {
            if (x.price > y.price) return -1;
            if (x.price < y.price) return 1;
            return 0;
        }
    }
}
