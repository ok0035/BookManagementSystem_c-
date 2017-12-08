namespace 도서검색시스템
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.condition = new System.Windows.Forms.ComboBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.menuAdd = new System.Windows.Forms.Button();
            this.menuModify = new System.Windows.Forms.Button();
            this.menuDelete = new System.Windows.Forms.Button();
            this.addNameText = new System.Windows.Forms.TextBox();
            this.addWriterText = new System.Windows.Forms.TextBox();
            this.addPublisherText = new System.Windows.Forms.TextBox();
            this.addPriceText = new System.Windows.Forms.TextBox();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.addWriterLabel = new System.Windows.Forms.Label();
            this.addPublisherLabel = new System.Windows.Forms.Label();
            this.addPriceLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.menuList = new System.Windows.Forms.Button();
            this.bookDataTable = new System.Windows.Forms.DataGridView();
            this.제목 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.저자 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.출판사 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.priceSort = new System.Windows.Forms.Button();
            this.ganadaSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTable)).BeginInit();
            this.addGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // condition
            // 
            this.condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.condition.FormattingEnabled = true;
            this.condition.Items.AddRange(new object[] {
            "제목",
            "저자",
            "출판사"});
            this.condition.Location = new System.Drawing.Point(12, 12);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(121, 20);
            this.condition.TabIndex = 0;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(139, 11);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(196, 21);
            this.searchText.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(341, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 21);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "검색";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // menuAdd
            // 
            this.menuAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuAdd.Location = new System.Drawing.Point(88, 416);
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(40, 23);
            this.menuAdd.TabIndex = 11;
            this.menuAdd.Text = "추가";
            this.menuAdd.UseVisualStyleBackColor = true;
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuModify
            // 
            this.menuModify.Location = new System.Drawing.Point(134, 416);
            this.menuModify.Name = "menuModify";
            this.menuModify.Size = new System.Drawing.Size(40, 23);
            this.menuModify.TabIndex = 12;
            this.menuModify.Text = "수정";
            this.menuModify.UseVisualStyleBackColor = true;
            this.menuModify.Click += new System.EventHandler(this.menuModify_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Location = new System.Drawing.Point(180, 416);
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(40, 23);
            this.menuDelete.TabIndex = 13;
            this.menuDelete.Text = "삭제";
            this.menuDelete.UseVisualStyleBackColor = true;
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // addNameText
            // 
            this.addNameText.Location = new System.Drawing.Point(57, 14);
            this.addNameText.Name = "addNameText";
            this.addNameText.Size = new System.Drawing.Size(243, 21);
            this.addNameText.TabIndex = 16;
            this.addNameText.Visible = false;
            // 
            // addWriterText
            // 
            this.addWriterText.Location = new System.Drawing.Point(57, 39);
            this.addWriterText.Name = "addWriterText";
            this.addWriterText.Size = new System.Drawing.Size(243, 21);
            this.addWriterText.TabIndex = 17;
            this.addWriterText.Visible = false;
            // 
            // addPublisherText
            // 
            this.addPublisherText.Location = new System.Drawing.Point(57, 66);
            this.addPublisherText.Name = "addPublisherText";
            this.addPublisherText.Size = new System.Drawing.Size(243, 21);
            this.addPublisherText.TabIndex = 18;
            this.addPublisherText.Visible = false;
            // 
            // addPriceText
            // 
            this.addPriceText.Location = new System.Drawing.Point(57, 93);
            this.addPriceText.Name = "addPriceText";
            this.addPriceText.Size = new System.Drawing.Size(243, 21);
            this.addPriceText.TabIndex = 19;
            this.addPriceText.Visible = false;
            this.addPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addPriceText_KeyPress);
            // 
            // addNameLabel
            // 
            this.addNameLabel.AutoSize = true;
            this.addNameLabel.BackColor = System.Drawing.Color.White;
            this.addNameLabel.Location = new System.Drawing.Point(20, 17);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(29, 12);
            this.addNameLabel.TabIndex = 20;
            this.addNameLabel.Text = "제목";
            this.addNameLabel.Visible = false;
            // 
            // addWriterLabel
            // 
            this.addWriterLabel.AutoSize = true;
            this.addWriterLabel.BackColor = System.Drawing.Color.White;
            this.addWriterLabel.Location = new System.Drawing.Point(20, 42);
            this.addWriterLabel.Name = "addWriterLabel";
            this.addWriterLabel.Size = new System.Drawing.Size(29, 12);
            this.addWriterLabel.TabIndex = 21;
            this.addWriterLabel.Text = "저자";
            this.addWriterLabel.Visible = false;
            // 
            // addPublisherLabel
            // 
            this.addPublisherLabel.AutoSize = true;
            this.addPublisherLabel.BackColor = System.Drawing.Color.White;
            this.addPublisherLabel.Location = new System.Drawing.Point(8, 69);
            this.addPublisherLabel.Name = "addPublisherLabel";
            this.addPublisherLabel.Size = new System.Drawing.Size(41, 12);
            this.addPublisherLabel.TabIndex = 22;
            this.addPublisherLabel.Text = "출판사";
            this.addPublisherLabel.Visible = false;
            // 
            // addPriceLabel
            // 
            this.addPriceLabel.AutoSize = true;
            this.addPriceLabel.BackColor = System.Drawing.Color.White;
            this.addPriceLabel.Location = new System.Drawing.Point(20, 96);
            this.addPriceLabel.Name = "addPriceLabel";
            this.addPriceLabel.Size = new System.Drawing.Size(29, 12);
            this.addPriceLabel.TabIndex = 23;
            this.addPriceLabel.Text = "가격";
            this.addPriceLabel.Visible = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(92, 120);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "추가";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // menuList
            // 
            this.menuList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuList.Location = new System.Drawing.Point(12, 416);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(70, 23);
            this.menuList.TabIndex = 25;
            this.menuList.Text = "전체보기";
            this.menuList.UseVisualStyleBackColor = true;
            this.menuList.Click += new System.EventHandler(this.menuList_Click);
            // 
            // bookDataTable
            // 
            this.bookDataTable.AllowUserToAddRows = false;
            this.bookDataTable.AllowUserToDeleteRows = false;
            this.bookDataTable.AllowUserToResizeColumns = false;
            this.bookDataTable.AllowUserToResizeRows = false;
            this.bookDataTable.BackgroundColor = System.Drawing.Color.White;
            this.bookDataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bookDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.bookDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.제목,
            this.저자,
            this.출판사,
            this.가격});
            this.bookDataTable.Location = new System.Drawing.Point(12, 38);
            this.bookDataTable.MultiSelect = false;
            this.bookDataTable.Name = "bookDataTable";
            this.bookDataTable.ReadOnly = true;
            this.bookDataTable.RowHeadersVisible = false;
            this.bookDataTable.RowTemplate.Height = 23;
            this.bookDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookDataTable.Size = new System.Drawing.Size(631, 372);
            this.bookDataTable.TabIndex = 26;
            // 
            // 제목
            // 
            this.제목.FillWeight = 240F;
            this.제목.HeaderText = "책 제목";
            this.제목.Name = "제목";
            this.제목.ReadOnly = true;
            this.제목.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.제목.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.제목.Width = 240;
            // 
            // 저자
            // 
            this.저자.FillWeight = 200F;
            this.저자.HeaderText = "저자";
            this.저자.Name = "저자";
            this.저자.ReadOnly = true;
            this.저자.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.저자.Width = 200;
            // 
            // 출판사
            // 
            this.출판사.HeaderText = "출판사";
            this.출판사.Name = "출판사";
            this.출판사.ReadOnly = true;
            this.출판사.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 가격
            // 
            this.가격.FillWeight = 70F;
            this.가격.HeaderText = "가격(원)";
            this.가격.Name = "가격";
            this.가격.ReadOnly = true;
            this.가격.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.가격.Width = 70;
            // 
            // addGroupBox
            // 
            this.addGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addGroupBox.BackColor = System.Drawing.Color.White;
            this.addGroupBox.Controls.Add(this.cancelButton);
            this.addGroupBox.Controls.Add(this.modifyButton);
            this.addGroupBox.Controls.Add(this.addNameLabel);
            this.addGroupBox.Controls.Add(this.addWriterLabel);
            this.addGroupBox.Controls.Add(this.addButton);
            this.addGroupBox.Controls.Add(this.addPublisherLabel);
            this.addGroupBox.Controls.Add(this.addPriceText);
            this.addGroupBox.Controls.Add(this.addPriceLabel);
            this.addGroupBox.Controls.Add(this.addPublisherText);
            this.addGroupBox.Controls.Add(this.addWriterText);
            this.addGroupBox.Controls.Add(this.addNameText);
            this.addGroupBox.Location = new System.Drawing.Point(165, 120);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(305, 162);
            this.addGroupBox.TabIndex = 27;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(173, 120);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(92, 120);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 25;
            this.modifyButton.Text = "수정";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Visible = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(304, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 14);
            this.label1.TabIndex = 28;
            this.label1.Text = "※목록에서 도서 선택 후 추가, 수정 및 삭제를 할 수 있습니다";
            // 
            // priceSort
            // 
            this.priceSort.Location = new System.Drawing.Point(592, 10);
            this.priceSort.Name = "priceSort";
            this.priceSort.Size = new System.Drawing.Size(50, 21);
            this.priceSort.TabIndex = 29;
            this.priceSort.Text = "가격순";
            this.priceSort.UseVisualStyleBackColor = true;
            this.priceSort.Click += new System.EventHandler(this.priceSort_Click);
            // 
            // ganadaSort
            // 
            this.ganadaSort.Location = new System.Drawing.Point(521, 10);
            this.ganadaSort.Name = "ganadaSort";
            this.ganadaSort.Size = new System.Drawing.Size(65, 21);
            this.ganadaSort.TabIndex = 30;
            this.ganadaSort.Text = "가나다순";
            this.ganadaSort.UseVisualStyleBackColor = true;
            this.ganadaSort.Click += new System.EventHandler(this.ganadaSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 15);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "정렬 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(654, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ganadaSort);
            this.Controls.Add(this.priceSort);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.menuAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuDelete);
            this.Controls.Add(this.menuModify);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.menuList);
            this.Controls.Add(this.bookDataTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "도서 관리 시스템";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTable)).EndInit();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox condition;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button menuAdd;
        private System.Windows.Forms.Button menuModify;
        private System.Windows.Forms.Button menuDelete;
        private System.Windows.Forms.TextBox addNameText;
        private System.Windows.Forms.TextBox addWriterText;
        private System.Windows.Forms.TextBox addPublisherText;
        private System.Windows.Forms.TextBox addPriceText;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.Label addWriterLabel;
        private System.Windows.Forms.Label addPublisherLabel;
        private System.Windows.Forms.Label addPriceLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button menuList;
        private System.Windows.Forms.DataGridView bookDataTable;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 가격;
        private System.Windows.Forms.DataGridViewTextBoxColumn 출판사;
        private System.Windows.Forms.DataGridViewTextBoxColumn 저자;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제목;
        private System.Windows.Forms.Button priceSort;
        private System.Windows.Forms.Button ganadaSort;
        private System.Windows.Forms.Label label2;
    }
}

