using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace reddittoWP
{
    public partial class FiltersForm : Form
    {
        Form1 form_pointer;
        public FiltersForm(Form1 f)
        {
            form_pointer = f;
            InitializeComponent();
        }

        private void btn_save_filters_Click(object sender, EventArgs e)
        {
            string writeString = "";
            using (StringReader sr = new StringReader(tb_filters.Text))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    writeString = writeString + Environment.NewLine + line;
                }
            }
            File.WriteAllText(Environment.CurrentDirectory + "removelist.txt", writeString);
            form_pointer.LoadRemoveList();
            form_pointer.AddLogEntry("Remove_list reloaded.");
            this.Close();
        }

        private void FiltersForm_Load(object sender, EventArgs e)
        {
            bool first = true;
            foreach (string s in form_pointer.getRemoveList())
            {
                if (first)
                {
                    tb_filters.AppendText(s);
                    first = false;
                }
                else
                {
                    tb_filters.AppendText(Environment.NewLine + s);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
