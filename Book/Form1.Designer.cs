
namespace Book
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ImageRow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pubdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Has = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.HasButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 21);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(538, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SerchButton_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ImageRow,
            this.title,
            this.author,
            this.publisher,
            this.isbn,
            this.pubdate,
            this.Has});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(12, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(646, 383);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ImageRow
            // 
            this.ImageRow.Text = "Image";
            this.ImageRow.Width = 82;
            // 
            // title
            // 
            this.title.Text = "제목";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.Width = 200;
            // 
            // author
            // 
            this.author.Text = "저자";
            this.author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // publisher
            // 
            this.publisher.Text = "출판사";
            this.publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // isbn
            // 
            this.isbn.Text = "isbn";
            this.isbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.isbn.Width = 100;
            // 
            // pubdate
            // 
            this.pubdate.Text = "출간일";
            this.pubdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pubdate.Width = 80;
            // 
            // Has
            // 
            this.Has.Text = "보유여부";
            this.Has.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(82, 116);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(338, 428);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(320, 21);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "추가";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Location = new System.Drawing.Point(12, 428);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(320, 21);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "제거";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // HasButton
            // 
            this.HasButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HasButton.Location = new System.Drawing.Point(597, 12);
            this.HasButton.Name = "HasButton";
            this.HasButton.Size = new System.Drawing.Size(61, 21);
            this.HasButton.TabIndex = 5;
            this.HasButton.Text = "보유목록";
            this.HasButton.UseVisualStyleBackColor = true;
            this.HasButton.Click += new System.EventHandler(this.HasButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 461);
            this.Controls.Add(this.HasButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(686, 200);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ImageRow;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader publisher;
        private System.Windows.Forms.ColumnHeader isbn;
        private System.Windows.Forms.ColumnHeader pubdate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader Has;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button HasButton;
    }
}

