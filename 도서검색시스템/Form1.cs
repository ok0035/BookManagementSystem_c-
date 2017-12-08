using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;


namespace 도서검색시스템
{
    [Serializable] // 입출력을 호출할때 클래스를 보호
    public partial class Form1 : Form
    {

        List<Book> books;
        Search search;
        BookCompare compare;

        public Form1()
        {
            InitializeComponent();

            books = new List<Book>();

            //파일 입출력 프로젝트/Bin폴더 안에 있는 Book_Info.dat를 불러옴
            using (Stream input = File.OpenRead("Book_Info.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                books = (List<Book>)formatter.Deserialize(input);
            }

            search = new Search();
            compare = new BookCompare(true, true);

            books.Sort(compare.compareByGanada1); // 가나다 순으로 정렬     
            foreach (Book book in books)
            {
                bookDataTable.Rows.Add(book.name, book.writer, book.publisher, book.price);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bookDataTable.ClearSelection();
            condition.Text = "제목";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchText.Text.Length <= 1)
            {
                MessageBox.Show("최소 두 글자를 입력하셔야 합니다.");
                return;
            }
            else bookDataTable.Rows.Clear(); // 데이터 테이블에 같은 정보가 계속해서 추가되지 않도록 방지
            // 제목 검색 
            if (condition.Text == "제목")
            {
                search.SearchBookName(books, searchText.Text);
                books.Sort(compare);
                foreach (Book book in books)
                    if (book.maxMatchCnt >= 1)
                    {
                        bookDataTable.Rows.Add(book.name, book.writer, book.publisher, book.price);
                    }

                foreach (Book book in books)
                    book.InitCnt();
            }

            // 저자 검색
            else if (condition.Text == "저자")
            {
                search.SearchBookWriter(books, searchText.Text);
                books.Sort(compare.Compare);
                foreach (Book book in books)
                    if (book.maxMatchCnt >= 1)
                    {
                        bookDataTable.Rows.Add(book.name, book.writer, book.publisher, book.price);
                    }

                foreach (Book book in books)
                    book.InitCnt();

            }

            // 출판사 검색
            else if (condition.Text == "출판사")
            {
                search.SearchBookPublisher(books, searchText.Text);
                books.Sort(compare);
                foreach (Book book in books)
                    if (book.maxMatchCnt >= 1)
                    {
                        bookDataTable.Rows.Add(book.name, book.writer, book.publisher, book.price);
                    }

                foreach (Book book in books)
                    book.InitCnt();

            }

            else
                MessageBox.Show("검색 조건을 선택하세요.");

            bookDataTable.ClearSelection();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            books.Add(new Book(addNameText.Text, addWriterText.Text, addPublisherText.Text, Convert.ToInt32(addPriceText.Text)));
            //책을 추가하고 Book_Info.dat 을 업데이트
            SaveBookInfo();
            //업데이트한 Book_Info.dat를 다시 불러옴
            LoadBookInfo();

            MessageBox.Show("도서가 추가되었습니다.\r\n[" +addNameText.Text + "]");

            //텍스트 초기화
            addNameText.Text = "";
            addWriterText.Text = "";
            addPublisherText.Text = "";
            addPriceText.Text = "";

            bookDataTable.Rows.Clear(); // 테이블 지우기
            books.Sort(compare.compareByGanada1); // 가나다 순으로 정렬  
            foreach (Book book in books)
            {
                bookDataTable.Rows.Add(book.name, book.writer, book.publisher, book.price);
            }

        }

        public void SaveBookInfo()
        {
            //입출력 파일 생성
            using (Stream output = File.Create("Book_Info.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, books);
            }
        }

        public void LoadBookInfo()
        {
            //입출력 파일 불러오기
            using (Stream input = File.OpenRead("Book_Info.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                books = (List<Book>)formatter.Deserialize(input);
            }
        }

        private void menuList_Click(object sender, EventArgs e)
        {
            bookDataTable.Rows.Clear(); // 테이블 지우기
            books.Sort(compare.compareByGanada1); // 가나다 순으로 정렬  

            foreach (Book book in books)
            {
                bookDataTable.Rows.Add(book.name, book.writer, book.publisher, book.price);
            }

            bookDataTable.ClearSelection();
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bookDataTable.Rows.Count; i++)
            {
                if (bookDataTable.Rows[i].Selected == true)
                {
                    foreach (Book book in books)
                    {
                        if ((string)bookDataTable[0, i].Value == book.name)
                        {
                            bookDataTable.Rows.Remove(bookDataTable.Rows[i]);
                            MessageBox.Show("도서가 삭제되었습니다.\r\n[" + book.name + "]");
                            books.Remove(book);
                            break;
                        }
                    }
                }
            }

            SaveBookInfo();
            LoadBookInfo();

            bookDataTable.ClearSelection();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bookDataTable.Rows.Count; i++)
            {
                if (bookDataTable.Rows[i].Selected == true)
                {

                    foreach (Book book in books)
                    {
                        if ((string)bookDataTable[0, i].Value == book.name)
                        {
                            book.name = addNameText.Text;
                            book.writer = addWriterText.Text;
                            book.publisher = addPublisherText.Text;
                            book.price = Convert.ToInt32(addPriceText.Text);
                            MessageBox.Show("도서가 수정되었습니다.\r\n[" + book.name + "]");
                            break;
                        }
                    }
                    
                    SaveBookInfo();
                    LoadBookInfo();

                    addNameText.Text = "";
                    addWriterText.Text = "";
                    addPublisherText.Text = "";
                    addPriceText.Text = "";

                    falseEdit();

                    bookDataTable.Rows.Clear();
                    foreach (Book book in books)
                    {
                        bookDataTable.Rows.Add(book.name, book.writer, book.publisher, book.price);
                    }
                }
            }
            bookDataTable.ClearSelection();
        }

        private void menuModify_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < bookDataTable.Rows.Count; i++)
            {
                if (bookDataTable.Rows[i].Selected == true)
                {
                    trueEdit();          
                    modifyButton.Visible = true;

                    addNameText.Text = books[i].name;
                    addWriterText.Text = books[i].writer;
                    addPublisherText.Text = books[i].publisher;
                    addPriceText.Text = Convert.ToString(books[i].price);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            falseEdit();
        }

        private void addPriceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //가격 텍스트에서 숫자만 입력받기 위한 예외처리문
            if (char.IsDigit(e.KeyChar) == false)
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Enter))
                {
                    e.Handled = true; // 문자가 Text에 입력되기 전에 막아줌
                    MessageBox.Show("숫자만 입력하세요.");
                    addPriceText.Clear();
                }
            }
        }

        private void priceSort_Click(object sender, EventArgs e)
        {
            bookDataTable.Rows.Clear(); // 테이블 지우기
            if (compare.priceSort == true)
            {
                books.Sort(compare.compareByPrice1); // 가격 오름차순으로 정렬
                compare.priceSort = false;
            }

            else {
                books.Sort(compare.compareByPrice2); // 가격 내림차순으로 정렬
                compare.priceSort = true;
            }

            foreach (Book book in books)
            {
                bookDataTable.Rows.Add(book.name, book.writer, book.publisher, book.price);
            }

            bookDataTable.ClearSelection();
        }

        private void ganadaSort_Click(object sender, EventArgs e)
        {
            bookDataTable.Rows.Clear(); // 테이블 지우기
            if (compare.ganadaSort == false)
            {
                books.Sort(compare.compareByGanada1); // 가나다 순으로 정렬
                compare.ganadaSort = true;
            }

            else {
                books.Sort(compare.compareByGanada2); // 가나다 역순으로 정렬
                compare.ganadaSort = false;
            }

            foreach (Book book in books)
            {
                bookDataTable.Rows.Add(book.name, book.writer, book.publisher, book.price);
            }
            bookDataTable.ClearSelection();
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            trueEdit();
            cancelButton.Visible = true;
            addButton.Visible = true;
            modifyButton.Visible = false;

            addNameText.Text = "";
            addWriterText.Text = "";
            addPublisherText.Text = "";
            addPriceText.Text = "";
        }

        public void trueEdit()
        {
            addGroupBox.Visible = true;
            addNameLabel.Visible = true;
            addNameText.Visible = true;
            addPublisherLabel.Visible = true;
            addPublisherText.Visible = true;
            addPriceLabel.Visible = true;
            addPriceText.Visible = true;
            addWriterLabel.Visible = true;
            addWriterText.Visible = true;
            addButton.Visible = true;
            cancelButton.Visible = true;
        }

        public void falseEdit()
        {
            addNameLabel.Visible = false;
            addNameText.Visible = false;
            addPublisherLabel.Visible = false;
            addPublisherText.Visible = false;
            addPriceLabel.Visible = false;
            addPriceText.Visible = false;
            addWriterLabel.Visible = false;
            addWriterText.Visible = false;
            addButton.Visible = false;
            addGroupBox.Visible = false;
            cancelButton.Visible = false;
        }
    }
}
