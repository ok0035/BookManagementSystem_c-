using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace 도서검색시스템
{
    [Serializable]
    class Book
    {
        public string name { get; set; } // 책이름
        public string writer { get; set; } // 저자
        public string publisher { get; set; } // 출판사
        public int price { get; set; } // 책가격
        public int maxMatchCnt;

        public Book(string name, string writer, string publisher, int price)
        {

            this.name = name;
            this.writer = writer;
            this.publisher = publisher;
            this.price = price;

        }

        public void InitCnt()
        {
            maxMatchCnt = 0;
        }
    }
}
