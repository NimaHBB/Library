
namespace NimaLibraryManagement
{
    partial class frm_Book
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Book));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Nr = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Writer = new System.Windows.Forms.TextBox();
            this.txt_Translator = new System.Windows.Forms.TextBox();
            this.txt_Publisher = new System.Windows.Forms.TextBox();
            this.library_DatabaseDataSet = new NimaLibraryManagement.Library_DatabaseDataSet();
            this.categoryTableAdapter = new NimaLibraryManagement.Library_DatabaseDataSetTableAdapters.CategoryTableAdapter();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.book_Price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sale_Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Picture_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemSelectPic = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDeletePic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemViewPic = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Picture_contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 59);
            this.panel1.TabIndex = 0;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Edit.BackgroundImage = global::NimaLibraryManagement.Properties.Resources.Edit;
            this.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.Enabled = false;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Gold;
            this.btn_Edit.Location = new System.Drawing.Point(11, 6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Edit.Size = new System.Drawing.Size(82, 45);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Image = global::NimaLibraryManagement.Properties.Resources._new;
            this.btn_Add.Location = new System.Drawing.Point(160, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(40, 40);
            this.btn_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Add.TabIndex = 2;
            this.btn_Add.TabStop = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Enabled = false;
            this.btn_Save.Image = global::NimaLibraryManagement.Properties.Resources.speichern;
            this.btn_Save.Location = new System.Drawing.Point(99, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(40, 40);
            this.btn_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Save.TabIndex = 0;
            this.btn_Save.TabStop = false;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "شماره";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "عنوان";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "مترجم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(616, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "مولف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(586, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "دسته بندی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(623, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "ناشر";
            // 
            // txt_Nr
            // 
            this.txt_Nr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nr.Location = new System.Drawing.Point(451, 87);
            this.txt_Nr.Name = "txt_Nr";
            this.txt_Nr.ReadOnly = true;
            this.txt_Nr.Size = new System.Drawing.Size(100, 27);
            this.txt_Nr.TabIndex = 7;
            this.txt_Nr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(22, 205);
            this.txt_Name.MaxLength = 254;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Name.Size = new System.Drawing.Size(529, 27);
            this.txt_Name.TabIndex = 8;
            // 
            // txt_Writer
            // 
            this.txt_Writer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Writer.HideSelection = false;
            this.txt_Writer.Location = new System.Drawing.Point(22, 245);
            this.txt_Writer.MaxLength = 90;
            this.txt_Writer.Name = "txt_Writer";
            this.txt_Writer.ReadOnly = true;
            this.txt_Writer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Writer.Size = new System.Drawing.Size(529, 27);
            this.txt_Writer.TabIndex = 9;
            // 
            // txt_Translator
            // 
            this.txt_Translator.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Translator.Location = new System.Drawing.Point(22, 285);
            this.txt_Translator.MaxLength = 90;
            this.txt_Translator.Name = "txt_Translator";
            this.txt_Translator.ReadOnly = true;
            this.txt_Translator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Translator.Size = new System.Drawing.Size(529, 27);
            this.txt_Translator.TabIndex = 10;
            // 
            // txt_Publisher
            // 
            this.txt_Publisher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Publisher.Location = new System.Drawing.Point(22, 365);
            this.txt_Publisher.MaxLength = 90;
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.ReadOnly = true;
            this.txt_Publisher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Publisher.Size = new System.Drawing.Size(529, 27);
            this.txt_Publisher.TabIndex = 12;
            // 
            // library_DatabaseDataSet
            // 
            this.library_DatabaseDataSet.DataSetName = "Library_DatabaseDataSet";
            this.library_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Count
            // 
            this.txt_Count.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Count.Location = new System.Drawing.Point(22, 325);
            this.txt_Count.MaxLength = 3;
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.ReadOnly = true;
            this.txt_Count.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Count.Size = new System.Drawing.Size(100, 27);
            this.txt_Count.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "تعداد موجود";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.library_DatabaseDataSet;
            // 
            // cmb_Category
            // 
            this.cmb_Category.DataSource = this.categoryBindingSource;
            this.cmb_Category.DisplayMember = "CatName";
            this.cmb_Category.Enabled = false;
            this.cmb_Category.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cmb_Category.Location = new System.Drawing.Point(256, 325);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Category.Size = new System.Drawing.Size(295, 27);
            this.cmb_Category.TabIndex = 16;
            this.cmb_Category.ValueMember = "ID";
            // 
            // book_Price
            // 
            this.book_Price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_Price.Location = new System.Drawing.Point(417, 404);
            this.book_Price.Name = "book_Price";
            this.book_Price.ReadOnly = true;
            this.book_Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.book_Price.Size = new System.Drawing.Size(134, 27);
            this.book_Price.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(562, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "قیمت روی جلد";
            // 
            // sale_Price
            // 
            this.sale_Price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_Price.Location = new System.Drawing.Point(22, 404);
            this.sale_Price.Name = "sale_Price";
            this.sale_Price.ReadOnly = true;
            this.sale_Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sale_Price.Size = new System.Drawing.Size(134, 27);
            this.sale_Price.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(167, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "قیمت فروش کتابخانه";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ContextMenuStrip = this.Picture_contextMenu;
            this.pictureBox1.Image = global::NimaLibraryManagement.Properties.Resources.no_image_icon_23494;
            this.pictureBox1.Location = new System.Drawing.Point(22, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 125);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Picture_contextMenu
            // 
            this.Picture_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSelectPic,
            this.ToolStripMenuItemDeletePic,
            this.toolStripSeparator1,
            this.ToolStripMenuItemViewPic});
            this.Picture_contextMenu.Name = "contextMenuStrip1";
            this.Picture_contextMenu.Size = new System.Drawing.Size(262, 76);
            this.Picture_contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.Picture_contextMenu_Opening);
            this.Picture_contextMenu.Opened += new System.EventHandler(this.Picture_contextMenu_Opened);
            // 
            // ToolStripMenuItemSelectPic
            // 
            this.ToolStripMenuItemSelectPic.Image = global::NimaLibraryManagement.Properties.Resources._new;
            this.ToolStripMenuItemSelectPic.Name = "ToolStripMenuItemSelectPic";
            this.ToolStripMenuItemSelectPic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ToolStripMenuItemSelectPic.Size = new System.Drawing.Size(261, 22);
            this.ToolStripMenuItemSelectPic.Text = "انتخاب / تغییر تصویر روی جلد";
            this.ToolStripMenuItemSelectPic.Click += new System.EventHandler(this.ToolStripMenuItemSelectPic_Click);
            // 
            // ToolStripMenuItemDeletePic
            // 
            this.ToolStripMenuItemDeletePic.Image = global::NimaLibraryManagement.Properties.Resources.Daco_1234014;
            this.ToolStripMenuItemDeletePic.Name = "ToolStripMenuItemDeletePic";
            this.ToolStripMenuItemDeletePic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.ToolStripMenuItemDeletePic.Size = new System.Drawing.Size(261, 22);
            this.ToolStripMenuItemDeletePic.Text = "حذف تصویر";
            this.ToolStripMenuItemDeletePic.Click += new System.EventHandler(this.ToolStripMenuItemDeletePic_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(258, 6);
            // 
            // ToolStripMenuItemViewPic
            // 
            this.ToolStripMenuItemViewPic.Image = global::NimaLibraryManagement.Properties.Resources.expand__2561;
            this.ToolStripMenuItemViewPic.Name = "ToolStripMenuItemViewPic";
            this.ToolStripMenuItemViewPic.Size = new System.Drawing.Size(261, 22);
            this.ToolStripMenuItemViewPic.Text = "مشاهده تصویر";
            this.ToolStripMenuItemViewPic.Click += new System.EventHandler(this.ToolStripMenuItemViewPic_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frm_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sale_Price);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.book_Price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Publisher);
            this.Controls.Add(this.txt_Translator);
            this.Controls.Add(this.txt_Writer);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Nr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مشخصات کتاب";
            this.Load += new System.EventHandler(this.frm_Book_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Picture_contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_Save;
        private System.Windows.Forms.PictureBox btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Library_DatabaseDataSet library_DatabaseDataSet;

        private Library_DatabaseDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_Nr;
        public System.Windows.Forms.TextBox txt_Name;
        public System.Windows.Forms.TextBox txt_Writer;
        public System.Windows.Forms.TextBox txt_Translator;
        public System.Windows.Forms.TextBox txt_Publisher;
        public System.Windows.Forms.TextBox txt_Count;

        private System.Windows.Forms.BindingSource categoryBindingSource;
        public System.Windows.Forms.ComboBox cmb_Category;
        public System.Windows.Forms.TextBox book_Price;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox sale_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip Picture_contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSelectPic;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDeletePic;
        public System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewPic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}