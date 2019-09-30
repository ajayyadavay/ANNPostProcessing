using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAY_ANN
{
    public partial class FrmCalcMeanStdDev : Form
    {
        float[] X = new float[5];
        float[] Z = new float[5];

        float SolvedMean, SolvedStdDev;

        int i, j;
        public FrmCalcMeanStdDev()
        {
            InitializeComponent();
        }

        private void FrmCalcMeanStdDev_Load(object sender, EventArgs e)
        {
            try
            {
                GenerateRows();
                SetFontAndColorOfDatagridview();
            }
            catch
            {

            }
        }
        public void GenerateRows()
        {
            for(int i = 0; i < 2; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        public void SetFontAndColorOfDatagridview()
        {
            dataGridView.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dataGridView.ForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            //dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView.DefaultCellStyle.Font = new Font("Comic Sans MS", 9);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 9);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DimGray;

            dataGridView.AllowUserToResizeRows = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PasteToGidCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedCells.Count < 1) return;

                string[] lines;

                int row = dataGridView.SelectedCells[0].RowIndex;
                int col = dataGridView.SelectedCells[0].ColumnIndex;

                //get copied values
                lines = Clipboard.GetText().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                string[] values;
                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].Split('\t');

                    if (row >= dataGridView.Rows.Count || dataGridView.Rows[row].IsNewRow) continue;
                    //if (row >= dataGridViewMusking.Rows.Count || dataGridViewMusking.Rows[row].IsNewRow) dataGridViewMusking.Rows.Add();
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (col + j >= dataGridView.Columns.Count) continue;
                        dataGridView.Rows[row].Cells[col + j].Value = values[j];
                    }

                    row++;
                }
            }
            catch
            {

            }
        }

        private void BtnCalcMeanStdDev_Click_1(object sender, EventArgs e)
        {
            try
            {
                Solve();
            }
            catch
            {

            }
        }

        public void Solve() 
        {
            //Input data
            for(i=0;i<2;i++)
            {
                X[i] = Convert.ToSingle(dataGridView.Rows[i].Cells[1].Value);
                Z[i] = Convert.ToSingle(dataGridView.Rows[i].Cells[2].Value);
            }

            //Solve for Standard deviation
            SolvedStdDev = (X[0] - X[1]) / (Z[0] - Z[1]);

            //solve for mean
            SolvedMean = X[1] - SolvedStdDev * Z[1];

            //output mean and standard deviation
            TxtCalculatedMean.Text = SolvedMean.ToString();
            TxtCalculatedStdDev.Text = SolvedStdDev.ToString();

            //send mean and standard deviation to parameter form
            FrmInputANNParameters form = (FrmInputANNParameters)Application.OpenForms["FrmInputANNParameters"];
            form.TxtMean.Text = TxtCalculatedMean.Text;
            form.TxtStdDev.Text = TxtCalculatedStdDev.Text;
        }
    }
}
