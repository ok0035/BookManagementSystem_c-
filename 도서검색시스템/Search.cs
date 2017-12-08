using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace 도서검색시스템
{
    [Serializable]
    class Search
    {

        public void SearchBookName(List<Book> books, string searchName) {

            int SearchLen = searchName.Length - 1;
            int MatchCount = 0;
            int Max = 0;

            foreach (Book book in books)
            {
                for (int i = 0; i < book.name.Length - SearchLen; i++)
                {
                    for (int j = 0; j < SearchLen; j++) {
                        if (i == 0 && (book.name[j] == searchName[j])) MatchCount++;
                        else if (book.name[i + j] == searchName[j] && book.name[i + j + 1] == searchName[j + 1]) // 적어도 두글자 이상 일치 했을때 검색
                                MatchCount++;

                    }

                    if (Max < MatchCount)
                    {
                        Max = MatchCount;
                        book.maxMatchCnt = Max;
                    }
                }
                Max = 0;
                MatchCount = 0;
            }
        }

        public void SearchBookPublisher(List<Book> books, string searchName)
        {

            int SearchLen = searchName.Length - 1;
            int MatchCount = 0;
            int Max = 0;

            foreach (Book book in books)
            {
                for (int i = 0; i < book.publisher.Length - SearchLen; i++)
                {
                    for (int j = 0; j < SearchLen; j++)
                        if (book.publisher[i + j] == searchName[j] && book.publisher[i + j + 1] == searchName[j + 1])
                                MatchCount++;

                    if (Max < MatchCount)
                    {
                        Max = MatchCount;
                        book.maxMatchCnt = Max;
                    }
                }
                Max = 0;
                MatchCount = 0;
            }
        }

        public void SearchBookWriter(List<Book> books, string searchName)
        {
            int SearchLen = searchName.Length - 1;
            int MatchCount = 0;
            int Max = 0;

            foreach (Book book in books)
            {
                for (int i = 0; i < book.writer.Length - SearchLen; i++)
                {

                    for (int j = 0; j < SearchLen; j++)
                        if (book.writer[i + j] == searchName[j] && book.writer[i + j + 1] == searchName[j+1])
                                MatchCount++;

                    if (Max < MatchCount)
                    {
                        Max = MatchCount;
                        book.maxMatchCnt = Max;
                    }

                }
                Max = 0;
                MatchCount = 0;
            }
        }
    }
}
