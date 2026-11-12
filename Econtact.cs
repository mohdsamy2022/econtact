using econtact.References.econtactClasses;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text;


namespace econtact
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();
        private string documentContents;
        public string stringToPrint;
        private void buttonadd_Click(object sender, EventArgs e)
        {
            //get the value from input fields
            c.FirstName = textBoxfirstname.Text;
            c.LastName = textBoxlastname.Text;
            c.ContactNo = textBoxcontactno.Text;
            c.Address = textBoxaddress.Text;
            c.Gender = comboBoxGender.Text;
            //inserting data into database using the method created
            bool success = c.Insert(c);
            if (success == true)
            {
                //successfully inserted
                MessageBox.Show("new contact inserted successfully");
                Clear();
            }
            else
            {
                //failed to add contact
                MessageBox.Show("failed to add new contact, please try again");
            }
            //load data on datagridview
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void Econtact_Load(object sender, EventArgs e)
        {
            //load data on datagridview
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
            buttonUpdate.Enabled = false;
            buttondelete.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //method to clear fields
        public void Clear()
        {
            textBoxfirstname.Text = "";
            textBoxlastname.Text = "";
            textBoxcontactno.Text = "";
            textBoxaddress.Text = "";
            comboBoxGender.Text = "";
            textBoxContactID.Text = "";
            buttondelete.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonadd.Enabled = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //get data from textboxes
            c.ContactId = int.Parse(textBoxContactID.Text);
            c.FirstName = textBoxfirstname.Text;
            c.LastName = textBoxlastname.Text;
            c.ContactNo = textBoxcontactno.Text;
            c.Address = textBoxaddress.Text;
            c.Gender = comboBoxGender.Text;
            //update data into database
            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("contact has been updated successfully");
                //load data into datagrid view
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //call clear method
                Clear();
            }
            else
            {
                MessageBox.Show("failed to update contact..please try again");
            }
        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from datagrid view and laod it to text box
            //identify the row on which the mouse is clicked
            int rowIndex = e.RowIndex;
            textBoxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxfirstname.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxlastname.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxcontactno.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxaddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
            buttondelete.Enabled = true;
            buttonUpdate.Enabled = true;
            buttonadd.Enabled = false;
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            //get the contactid from an application
            c.ContactId = Convert.ToInt32(textBoxContactID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("contact has been deleted successfully");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("failed to delete contact..please try again");
            }
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            //get the value from textbox
            string keyword = textBoxsearch.Text;

            SQLiteConnection conn = new SQLiteConnection(myconnstr);
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM tbl_contact WHERE Firstname LIKE '%" + keyword + "%' OR Lastname LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%' OR ContactNo LIKE '%" + keyword + "%' OR gender LIKE '%" + keyword + "%' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap bitmap1 = new Bitmap(dgvContactList.Width, dgvContactList.Height);
            //dgvContactList.DrawToBitmap(bitmap1, new Rectangle(0, 0, dgvContactList.Width, dgvContactList.Height));
            //e.Graphics.DrawImage(bitmap1, 120, 20);

            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, this.Font,
              e.MarginBounds.Size, StringFormat.GenericTypographic,
              out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page.
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
            e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);

            // If there are no more pages, reset the string to be printed.
            if (!e.HasMorePages)
                stringToPrint = documentContents;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            stringToPrint = Data_Grid_to_String(dgvContactList, ',');
            printDocument1.DocumentName = stringToPrint;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            ToolStripButton b = new ToolStripButton();
            b.Image = ((ToolStrip)(printPreviewDialog1.Controls[1])).ImageList.Images[0];
            b.DisplayStyle = ToolStripItemDisplayStyle.Image;
            b.Click += printPreview_PrintClick;
            ((ToolStrip)(printPreviewDialog1.Controls[1])).Items.RemoveAt(0);
            ((ToolStrip)(printPreviewDialog1.Controls[1])).Items.Insert(0, b);
            printPreviewDialog1.ShowDialog();

        }
        private void printPreview_PrintClick(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    //stringToPrint = printDocument1.DocumentName;
                    printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ToString());
            }
        }
        public static string Data_Grid_to_String(DataGridView dgv, char delimiter)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value);
                    sb.Append(delimiter);
                    sb.Append(" ");
                }
                sb.Remove(sb.Length - 2, 2); // Removes the last delimiter
                sb.AppendLine();
            }
            return sb.ToString();
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            print print = new print();
            print.Show();
            /*stringToPrint = Data_Grid_to_String(dgvContactList, ',');
            printDocument1.DocumentName = stringToPrint;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            ToolStripButton b = new ToolStripButton();
            b.Image = ((ToolStrip)(printPreviewDialog1.Controls[1])).ImageList.Images[0];
            b.DisplayStyle = ToolStripItemDisplayStyle.Image;
            b.Click += printPreview_PrintClick;
            ((ToolStrip)(printPreviewDialog1.Controls[1])).Items.RemoveAt(0);
            ((ToolStrip)(printPreviewDialog1.Controls[1])).Items.Insert(0, b);
            printPreviewDialog1.ShowDialog();*/
        }
    }
}