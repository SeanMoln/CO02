using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
namespace CO02
{
    public partial class Form1 : Form
    {
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            ds = new DataSet();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            string DataSouse = textBox1.Text;
            if(string.IsNullOrEmpty(DataSouse))
            {
                MessageBox.Show("未選擇資料來源檔案");
                return;
            }
            COMReadExcel(DataSouse);
            MessageBox.Show("讀取Excel成功");
            OUT.Enabled = true;
        }

        private void dotdot_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }
        private void COMReadExcel(string fileName)
        {
            var app = new Excel.Application();
            app.Visible = true;
            var wb = app.Workbooks.Open(fileName);
            ds.Reset();
            foreach(Excel.Worksheet ws in wb.Sheets)
            {
                var dt = new DataTable(ws.Name);
                foreach(var c in ws.UsedRange.Rows[1].Cells)
                {
                    dt.Columns.Add(c.Value);

                }
                for (int r = 2;r<=ws.UsedRange.Rows.Count; r++)
                {
                    var nr = dt.NewRow();
                    foreach(var c in ws.UsedRange.Rows[r].Cells)
                    {
                        nr[c.Column - 1] = c.Value;
                    }
                    dt.Rows.Add(nr);
                }
                ds.Tables.Add(dt);
                comboBox1.Items.Add(dt.TableName);
            }
            app.Quit();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tn = comboBox1.SelectedItem.ToString();
            this.Text = tn;
            var dt = ds.Tables[tn];
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            Form_load(selectedRow);
        }
        private void  Form_load (DataGridViewRow NN)
        {
            var ff = new Form2(NN);
            ff.Show();


        }
    }
}
