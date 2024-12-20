using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS_WindowsForms
{
    public partial class laba28 : Form
    {
        public laba28()
        {
            InitializeComponent();
        }

        private void laba28_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += DataGridView1_CellContentClick;
            DataGridViewRowHeaderCell rowcell;
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            for (int i = 1; i < 10; i++)
            {
                DataGridViewColumn col = new DataGridViewColumn() { Name = i.ToString() + "column", HeaderText = i.ToString(), AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, CellTemplate = cell };
                rowcell = new DataGridViewRowHeaderCell() { Value = i.ToString() };
                DataGridViewRow row = new DataGridViewRow() { HeaderCell = rowcell };
                dataGridView1.Columns.Add(col);
                dataGridView1.Rows.Add(row);

            }

            cell = new DataGridViewTextBoxCell();
            List<string> row1 = new List<string>();
            string y;


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    y = $"{dataGridView1.Rows[i].HeaderCell.Value}{dataGridView1.Columns[j].HeaderText}";

                    row1.Add($"{Convert.ToInt32(y) * Convert.ToInt32(y)}");
                }
                dataGridView1.Rows[i].SetValues(row1.ToArray());
                row1.Clear();
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    y = $"{dataGridView1.Rows[i].HeaderCell.Value}{dataGridView1.Columns[j].HeaderText}";

                    row1.Add($"{Convert.ToInt32(y)} * {Convert.ToInt32(y)} = {Convert.ToInt32(y) * Convert.ToInt32(y)}");
                }

                for (int k = 0; k < 9; k++)
                {
                    dataGridView1.Rows[i].Cells[k].ToolTipText = row1[k];
                    

                }
                row1.Clear();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView snd = sender as DataGridView;
            MessageBox.Show($"{snd.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText}", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            snd.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
            return;
        }

    }
}
