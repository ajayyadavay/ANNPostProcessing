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
    public partial class FrmInputANNParameters : Form
    {
        int i, j, k;
        int ColIndex = 1;
        public static int TotalNeurons=0, MaxNeuron;

        public static float[,,] Weights = new float[20,500, 500]; // [layer N, neruon of layer N, neruon to layer N+1]
        public static float[,] Bias = new float[500, 500];  // Bias of [layer N, neruon of layer N]
        public static float Temp_Mean, Temp_StdDev;

        public static string ActivationFunction;

        public FrmInputANNParameters()
        {
            InitializeComponent();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            //Mean and standard deviation
            Temp_Mean = Convert.ToSingle(TxtMean.Text);
            Temp_StdDev = Convert.ToSingle(TxtStdDev.Text);

            //weights
            int ColIndexForWeight = 1;
            for(i = 0; i < FrmANN.TotalLayers - 1; i++)
            {
                for(j = 0; j < FrmANN.NeuronsInNetworkLayer[i]; j++)
                {
                    for (k = 0; k < FrmANN.NeuronsInNetworkLayer[i + 1]; k++)
                    {
                        Weights[i,j, k] = Convert.ToSingle(dataGridView.Rows[k].Cells[ColIndexForWeight].Value);
                    }
                    ColIndexForWeight++;
                }
            }

            //bias
            int tempIndex = 2;
            for (i = 1; i < FrmANN.TotalLayers; i++)
            {
                for (j = 0; j < FrmANN.NeuronsInNetworkLayer[i]; j++)
                {
                    Bias[i, j] = Convert.ToSingle(dataGridView.Rows[MaxNeuron].Cells[tempIndex].Value);
                    tempIndex++;
                }
            }

            MessageBox.Show("Accepted !");
        }

        private void ComboBoxActivationFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivationFunction = ComboBoxActivationFunc.Text;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BtnCalcMeanStdDev_Click(object sender, EventArgs e)
        {
            FrmCalcMeanStdDev fMeanStddev = new FrmCalcMeanStdDev();
            fMeanStddev.Show();
        }

        private void FrmInputANNParameters_Load(object sender, EventArgs e)
        {
            try
            {
                GenerateParameterTable();
                SetFontAndColorOfDatagridview();
                AddElementsToComboBox();
            }
            catch
            {

            }
        }

        public void AddElementsToComboBox()
        {
            try
            {
                ComboBoxActivationFunc.Items.Add("Select Activation Function");
                ComboBoxActivationFunc.Items.Add("relu");
                ComboBoxActivationFunc.Items.Add("sigmoid");
            }
            catch
            {

            }
        }

        public void SetFontAndColorOfDatagridview()
        {
            dataGridView.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dataGridView.ForeColor = Color.DarkOrange;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkSalmon;

            dataGridView.DefaultCellStyle.Font = new Font("Comic Sans MS", 9);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 9);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DimGray;

            dataGridView.AllowUserToResizeRows = false;

        }

        public void GenerateParameterTable()
        {
            try
            {
                // calcuating total number of neurons in the ANN
                TotalNeurons = 0;
                for (i = 0; i < FrmANN.TotalLayers; i++)
                {
                    TotalNeurons += FrmANN.NeuronsInNetworkLayer[i];
                }

                // Add Columns
                dataGridView.ColumnCount = TotalNeurons + 1;

                /*// Name of columns
                for (i = 1; i <= TotalNeurons; i++)
                {
                    dataGridView.Columns[i].Name = i.ToString();
                    dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dataGridView.Columns[i].Width = 70;
                }*/

                int start;
                // Name of columns
                for (i = 0; i < FrmANN.TotalLayers; i++)
                {
                    start = ColIndex;
                    for (j = start; j < start + FrmANN.NeuronsInNetworkLayer[i]; j++)
                    {
                        dataGridView.Columns[ColIndex].Name = "Neurons_" + (i).ToString() + "_" + (j - start).ToString();
                        dataGridView.Columns[ColIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
                        //dataGridView.Columns[ColIndex].Width = 80;
                        ColIndex++;
                    }
                }

                // Find maximum number of neruons
                MaxNeuron = FrmANN.NeuronsInNetworkLayer[0];
                for (i = 1; i < FrmANN.TotalLayers; i++)
                {
                    if (MaxNeuron < FrmANN.NeuronsInNetworkLayer[i])
                    {
                        MaxNeuron = FrmANN.NeuronsInNetworkLayer[i];
                    }
                }

                //Add Rows
                dataGridView.Rows.Clear();
                for (i = 0; i < MaxNeuron + 1; i++)
                {
                    dataGridView.Rows.Add();
                    if (i == MaxNeuron)
                    {
                        dataGridView.Rows[i].Cells[0].Value = "Bias";
                    }
                    else
                    {
                        dataGridView.Rows[i].Cells[0].Value = "Weights" + (i + 1).ToString();
                    }
                }
            }
            catch
            {

            }
        }
    }
}
