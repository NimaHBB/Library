using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;
using System.Threading;
using System.Globalization;
using System.IO;

namespace NimaLibraryManagement
{
    public partial class frm_Book : Form
    {

        OleDbConnection conn = new OleDbConnection(NimaLibraryManagement.Properties.Settings.Default.Library_DatabaseConnectionString.ToString());
        OleDbDataAdapter da = new OleDbDataAdapter();
        public string mode = "";
        double BId = 0;
        string BName = "";
        string BSubject = "";
        string BPublisher = "";
        string BWriter = "";
        public string BImage = "";
        string TempText = "";

        string msgCaption = "";

        public frm_Book()
        {
            InitializeComponent();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //btn_Save.Location = btn_Edit.Location;
            mode = "edit";
            btn_Save.Enabled = true;
            btn_Save.Visible = true;

            btn_Edit.Enabled = false;
            btn_Edit.Visible = false;

            btn_Add.Enabled = false;
            btn_Add.Visible = false;

            txt_Count.ReadOnly = false;
            txt_Name.ReadOnly = false;
            txt_Publisher.ReadOnly = false;
            txt_Translator.ReadOnly = false;
            txt_Writer.ReadOnly = false;
            book_Price.ReadOnly = false;
            sale_Price.ReadOnly = false;
            cmb_Category.Enabled = true;
        }

        public bool SaveBook()
        {
            
            try
            {
                BId= BId = double.Parse(this.txt_Nr.Text);
                BName = this.txt_Name.Text;
                BSubject = this.cmb_Category.Text;
                BPublisher = this.txt_Publisher.Text;
                BWriter = this.txt_Writer.Text;
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                if (mode=="new")
                {
                    MessageBox.Show("جدید");
                }
                if (mode=="edit")
                {
                    string query = "UPDATE Book SET " +
                        "[BookTitle] = '"+ BName + "'" +
                        ",[BookSubject] = '" + BSubject + "'" +
                        ",[BookPublisher] = '" + BPublisher + "'" +
                        ",[BookWriter] = '" + BWriter + "'" +
                        ",[By] = '" + System.Environment.UserName + "'" +
                        ",[BookImage] = '" + BImage + "'" +
                        " WHERE BookId = " + BId +"";
                    var accessUpdateCommand = new OleDbCommand(query, conn);
                    da.UpdateCommand = accessUpdateCommand;
                    da.UpdateCommand.ExecuteNonQuery();
                }

                conn.Close();
                return true;
            }
            catch (Exception x)
            {
                msgCaption = "خطا در ذخیره سازی مشخصات کتاب";
                ErrorLog(x, msgCaption);
                return false;
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveBook();

            btn_Save.Enabled = false;
            btn_Save.Visible = false;

            btn_Edit.Visible = true;
            btn_Edit.Enabled = true;

            btn_Add.Visible = true;
            btn_Add.Enabled = true;

            txt_Count.ReadOnly = true;
            txt_Name.ReadOnly = true;
            txt_Publisher.ReadOnly = true;
            txt_Translator.ReadOnly = true;
            txt_Writer.ReadOnly = true;
            book_Price.ReadOnly = true;
            sale_Price.ReadOnly = true;
            cmb_Category.Enabled = false;
        }

        private void frm_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DatabaseDataSet.Category' table. You can move, or remove it, as needed
            this.categoryTableAdapter.Fill(this.library_DatabaseDataSet.Category);
            

        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                        (control as TextBox).ReadOnly = false;
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);
            pictureBox1.BackgroundImage = null;
            pictureBox1.Image = NimaLibraryManagement.Properties.Resources.no_image_icon_23494;
            BImage = null;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            mode = "new";
            btn_Add.Enabled = false;
            //btn_Save.Location = btn_Edit.Location;
            btn_Save.Enabled = true;

            btn_Edit.Enabled = false;
            btn_Edit.Visible = false;

            ClearTextBoxes();
            cmb_Category.Enabled = true;
            cmb_Category.Text = "";
        }

        private void Picture_contextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (btn_Save.Enabled)
            {
                ToolStripMenuItemSelectPic.Enabled = true;
                if (pictureBox1.BackgroundImage != null)
                {
                    ToolStripMenuItemDeletePic.Enabled = true;
                    //ToolStripMenuItemViewPic.Enabled = true;

                }
                else
                {
                    ToolStripMenuItemDeletePic.Enabled = false;
                    //ToolStripMenuItemViewPic.Enabled = false;
                }
            }
            else
            {
                ToolStripMenuItemSelectPic.Enabled = false;
                ToolStripMenuItemDeletePic.Enabled = false;
                //ToolStripMenuItemViewPic.Enabled = false;
            }
            _ = pictureBox1.BackgroundImage != null ? ToolStripMenuItemViewPic.Enabled = true : ToolStripMenuItemViewPic.Enabled = false;
        }

        private void Picture_contextMenu_Opened(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemDeletePic_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = null;
            TempText = BImage;
            BImage = null;
            File.GetAccessControl(TempText);
            File.Delete(TempText);
            pictureBox1.Image = NimaLibraryManagement.Properties.Resources.no_image_icon_23494;
        }

        private void ToolStripMenuItemSelectPic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

       
        public void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                pictureBox1.BackgroundImage = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = null;
                BImage = Application.StartupPath + @"\Base\Images\" + this.txt_Name.Text + System.IO.Path.GetExtension(openFileDialog1.FileName);
                File.Copy(openFileDialog1.FileName,BImage,true);
                ToolStripMenuItemViewPic.Enabled = true;
            }
            catch (Exception x)
            {
                msgCaption = "خطا در ذخیره سازی عکس";
                ErrorLog(x,msgCaption);
            }

        }
       
            public void ErrorLog(Exception _ex, string caption)
            { 
                MessageBox.Show("شرح خطا" + Environment.NewLine + Environment.NewLine + _ex.ToString(), caption);
            }
        public void OpenImage()
        {
            frm_PhotoViewer _PhotoViewer = null;
            if (_PhotoViewer == null)
            {
                _PhotoViewer = new frm_PhotoViewer();
            }
            _PhotoViewer.BackgroundImage = pictureBox1.BackgroundImage;
            _PhotoViewer.Text = this.txt_Name.Text;
            _PhotoViewer.Show();
        }
        private void ToolStripMenuItemViewPic_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            _ = pictureBox1.BackgroundImage != null ? pictureBox1.Cursor = Cursors.Hand : pictureBox1.Cursor = Cursors.Default;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackgroundImage != null)
            {
                OpenImage();
            }
        }
    }
}
