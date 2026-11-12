using econtact.References.econtactClasses;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace econtact
{
    public partial class print : Form
    {
        public print()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();
        private void print_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            ReportDataSource datasource = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\STAR DUST\\source\\repos\\econtact\\print.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
