namespace econtact
{
    partial class Econtact
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            pictureBox1 = new PictureBox();
            labelContactID = new Label();
            textBoxContactID = new TextBox();
            labelfirstname = new Label();
            textBoxfirstname = new TextBox();
            labellastname = new Label();
            textBoxlastname = new TextBox();
            labelcontactno = new Label();
            textBoxcontactno = new TextBox();
            labeladdress = new Label();
            textBoxaddress = new TextBox();
            labelgender = new Label();
            comboBoxGender = new ComboBox();
            buttonadd = new Button();
            buttonUpdate = new Button();
            buttondelete = new Button();
            buttonclear = new Button();
            dgvContactList = new DataGridView();
            labelsearch = new Label();
            textBoxsearch = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(235, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelContactID
            // 
            labelContactID.AutoSize = true;
            labelContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelContactID.Location = new Point(52, 65);
            labelContactID.Name = "labelContactID";
            labelContactID.Size = new Size(82, 21);
            labelContactID.TabIndex = 1;
            labelContactID.Text = "Contact ID";
            // 
            // textBoxContactID
            // 
            textBoxContactID.Location = new Point(148, 63);
            textBoxContactID.Name = "textBoxContactID";
            textBoxContactID.ReadOnly = true;
            textBoxContactID.Size = new Size(100, 23);
            textBoxContactID.TabIndex = 2;
            // 
            // labelfirstname
            // 
            labelfirstname.AutoSize = true;
            labelfirstname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelfirstname.Location = new Point(49, 106);
            labelfirstname.Name = "labelfirstname";
            labelfirstname.Size = new Size(83, 21);
            labelfirstname.TabIndex = 3;
            labelfirstname.Text = "First name";
            // 
            // textBoxfirstname
            // 
            textBoxfirstname.Location = new Point(148, 106);
            textBoxfirstname.Name = "textBoxfirstname";
            textBoxfirstname.Size = new Size(100, 23);
            textBoxfirstname.TabIndex = 4;
            // 
            // labellastname
            // 
            labellastname.AutoSize = true;
            labellastname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labellastname.Location = new Point(49, 150);
            labellastname.Name = "labellastname";
            labellastname.Size = new Size(81, 21);
            labellastname.TabIndex = 5;
            labellastname.Text = "Last name";
            // 
            // textBoxlastname
            // 
            textBoxlastname.Location = new Point(148, 148);
            textBoxlastname.Name = "textBoxlastname";
            textBoxlastname.Size = new Size(100, 23);
            textBoxlastname.TabIndex = 6;
            // 
            // labelcontactno
            // 
            labelcontactno.AutoSize = true;
            labelcontactno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelcontactno.Location = new Point(49, 191);
            labelcontactno.Name = "labelcontactno";
            labelcontactno.Size = new Size(91, 21);
            labelcontactno.TabIndex = 7;
            labelcontactno.Text = "Contact No.";
            // 
            // textBoxcontactno
            // 
            textBoxcontactno.Location = new Point(148, 189);
            textBoxcontactno.Name = "textBoxcontactno";
            textBoxcontactno.Size = new Size(100, 23);
            textBoxcontactno.TabIndex = 8;
            // 
            // labeladdress
            // 
            labeladdress.AutoSize = true;
            labeladdress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labeladdress.Location = new Point(52, 235);
            labeladdress.Name = "labeladdress";
            labeladdress.Size = new Size(66, 21);
            labeladdress.TabIndex = 9;
            labeladdress.Text = "Address";
            // 
            // textBoxaddress
            // 
            textBoxaddress.Location = new Point(148, 224);
            textBoxaddress.Multiline = true;
            textBoxaddress.Name = "textBoxaddress";
            textBoxaddress.Size = new Size(100, 61);
            textBoxaddress.TabIndex = 10;
            // 
            // labelgender
            // 
            labelgender.AutoSize = true;
            labelgender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelgender.Location = new Point(57, 309);
            labelgender.Name = "labelgender";
            labelgender.Size = new Size(61, 21);
            labelgender.TabIndex = 11;
            labelgender.Text = "Gender";
            // 
            // comboBoxGender
            // 
            comboBoxGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(148, 301);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(121, 29);
            comboBoxGender.TabIndex = 12;
            // 
            // buttonadd
            // 
            buttonadd.BackColor = Color.PaleGreen;
            buttonadd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonadd.Location = new Point(135, 346);
            buttonadd.Name = "buttonadd";
            buttonadd.RightToLeft = RightToLeft.No;
            buttonadd.Size = new Size(75, 30);
            buttonadd.TabIndex = 13;
            buttonadd.Text = "Add";
            buttonadd.UseVisualStyleBackColor = false;
            buttonadd.Click += buttonadd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.LightBlue;
            buttonUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(235, 346);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 30);
            buttonUpdate.TabIndex = 14;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.Red;
            buttondelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttondelete.Location = new Point(329, 346);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(75, 30);
            buttondelete.TabIndex = 15;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // buttonclear
            // 
            buttonclear.BackColor = Color.Yellow;
            buttonclear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonclear.Location = new Point(421, 346);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(75, 30);
            buttonclear.TabIndex = 16;
            buttonclear.Text = "Clear";
            buttonclear.UseVisualStyleBackColor = false;
            buttonclear.Click += buttonclear_Click;
            // 
            // dgvContactList
            // 
            dgvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactList.Location = new Point(303, 106);
            dgvContactList.Name = "dgvContactList";
            dgvContactList.RowTemplate.Height = 25;
            dgvContactList.Size = new Size(292, 224);
            dgvContactList.TabIndex = 17;
            dgvContactList.RowHeaderMouseClick += dgvContactList_RowHeaderMouseClick;
            // 
            // labelsearch
            // 
            labelsearch.AutoSize = true;
            labelsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelsearch.Location = new Point(303, 77);
            labelsearch.Name = "labelsearch";
            labelsearch.Size = new Size(57, 21);
            labelsearch.TabIndex = 18;
            labelsearch.Text = "Search";
            // 
            // textBoxsearch
            // 
            textBoxsearch.Location = new Point(366, 77);
            textBoxsearch.Name = "textBoxsearch";
            textBoxsearch.Size = new Size(229, 23);
            textBoxsearch.TabIndex = 19;
            textBoxsearch.TextChanged += textBoxsearch_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(575, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(303, 22);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 21;
            label1.Text = "E-Contact";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.PaleGoldenrod;
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.Location = new Point(502, 346);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 30);
            btnPrint.TabIndex = 22;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click_1;
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 388);
            Controls.Add(btnPrint);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(textBoxsearch);
            Controls.Add(labelsearch);
            Controls.Add(dgvContactList);
            Controls.Add(buttonclear);
            Controls.Add(buttondelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonadd);
            Controls.Add(comboBoxGender);
            Controls.Add(labelgender);
            Controls.Add(textBoxaddress);
            Controls.Add(labeladdress);
            Controls.Add(textBoxcontactno);
            Controls.Add(labelcontactno);
            Controls.Add(textBoxlastname);
            Controls.Add(labellastname);
            Controls.Add(textBoxfirstname);
            Controls.Add(labelfirstname);
            Controls.Add(textBoxContactID);
            Controls.Add(labelContactID);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Econtact";
            Text = "EContact";
            Load += Econtact_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelContactID;
        private TextBox textBoxContactID;
        private Label labelfirstname;
        private TextBox textBoxfirstname;
        private Label labellastname;
        private TextBox textBoxlastname;
        private Label labelcontactno;
        private TextBox textBoxcontactno;
        private Label labeladdress;
        private TextBox textBoxaddress;
        private Label labelgender;
        private ComboBox comboBoxGender;
        private Button buttonadd;
        private Button buttonUpdate;
        private Button buttondelete;
        private Button buttonclear;
        private DataGridView dgvContactList;
        private Label labelsearch;
        private TextBox textBoxsearch;
        private PictureBox pictureBox2;
        private Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
        private Button btnPrint;
    }
}