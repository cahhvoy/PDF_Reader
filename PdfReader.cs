using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PDF_Reader
{
    public partial class PdfReader : Form
        {
            public PdfReader()
                {
                    InitializeComponent();
                }

            private void PdfReader_Load(object sender, EventArgs e)
                {
                    toolStripStatusLabelActivity.Text = ".......";
                    
                    tabControlTop.TabPages.Add("p2", "pagetwo");
                    TabPage newPage = tabControlTop.TabPages["p2"];
                    newPage.BackColor= Color.White;
                    tabControlTop.SelectTab(newPage);
                    
                    //PDFSharp.CreatePDF();
               }



         
        }
}
