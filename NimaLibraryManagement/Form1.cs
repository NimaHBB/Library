using System;
using System.Drawing;
using System.Windows.Forms;

namespace NimaLibraryManagement
{
    public partial class Form1 : Form
    {
        frm_Book book = new frm_Book();
        public int Curr_BookID;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Library_DatabaseDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.Library_DatabaseDataSet.Book);
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 60;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //if (row.Cells[5].Value.ToString()=="Available")
                //{
                //    row.Cells[5].Style.ForeColor = System.Drawing.Color.Green;
                //}
            }
        }

        public void change_HeaderText()
        {
            int i = 0;
            try
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    switch (column.HeaderText)
                    {
                        case "BookId":
                            column.Name = "BookId";
                            column.HeaderText = "شماره";
                            column.Width = 60;
                            break;
                        case "BookTitle":
                            column.Name = "BookTitle";
                            column.HeaderText = "عنوان کتاب";
                            column.Width = 300;
                            break;
                        case "BookSubject":
                            column.Name = "BookSubject";
                            column.HeaderText = "دسته بندی";
                            column.Width = 100;
                            break;
                        case "BookPublisher":
                            column.Name = "BookPublisher";
                            column.HeaderText = "ناشر";
                            column.Width = 200;
                            break;
                        case "BookStatus":
                            column.Name = "BookStatus";
                            column.HeaderText = "وضعیت";
                            column.Width = 80;
                            break;
                        case "By":
                            column.Name = "By";
                            column.HeaderText = "توسط";
                            column.Width = 80;
                            break;
                        case "BookWriter":
                            column.Name = "BookWriter";
                            column.HeaderText = "نویسنده/مترجم";
                            column.Width = 200;
                            break;
                        case "Count":
                            column.Name = "Count";
                            column.HeaderText = "تعداد";
                            column.Width = 40;
                            break;
                        case "CatId":
                            column.Name = "CatId";
                            //column.HeaderText = "شماره دسته";
                            column.Visible = false;
                            break;


                        default:
                            break;
                    }
                }
            }
            catch (Exception x)
            {

            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            change_HeaderText();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (book.IsDisposed)
            {
                book = new frm_Book();
            }
            book.TopLevel = false;
            book.Parent = this;
            book.Show();
            book.mode = "new";
            book.BringToFront();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (book.IsDisposed)
                {
                    book = new frm_Book();
                }
                book.TopLevel = false;
                book.Parent = this;
                book.Location = new Point(200, 100);
                book.Show();
                book.BringToFront();

                book.btn_Edit.Enabled = true;
                Curr_BookID = int.Parse(dataGridView1.CurrentRow.Cells["BookId"].Value.ToString());
                var curr_Book = Library_DatabaseDataSet.Book.FindByBookId(Curr_BookID);
                if (curr_Book != null)
                {
                    book.txt_Nr.Text = curr_Book.BookId.ToString();
                    book.txt_Name.Text = curr_Book.BookTitle.ToString();
                    book.txt_Writer.Text = !curr_Book.IsBookWriterNull() ? curr_Book.BookWriter : "";
                    //book.txt_Translator.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    book.cmb_Category.Text = curr_Book.BookSubject.ToString();
                    book.txt_Publisher.Text = curr_Book.BookPublisher.ToString();
                    _ = !curr_Book.IsCountNull() ? book.txt_Count.Text = curr_Book.Count.ToString() : book.txt_Count.Text = "";
                    book.mode = "edit";
                    if (!string.IsNullOrEmpty(curr_Book.BookImage))
                    {
                        book.pictureBox1.BackgroundImage = new Bitmap(curr_Book.BookImage.ToString());
                        book.BImage = curr_Book.BookImage?.ToString();
                        book.pictureBox1.Image = null;
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.bookBindingSource1.EndEdit();
            //this.bookTableAdapter.Update(this.Library_DatabaseDataSet.Book);
            //this.Library_DatabaseDataSet.AcceptChanges();
            //this.bookTableAdapter.Fill(this.Library_DatabaseDataSet.Book);

        }
    }
}
