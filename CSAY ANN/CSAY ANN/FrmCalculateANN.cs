using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSAY_ANN
{
    public partial class FrmCalculateANN : Form
    {
        int i, j,k;
        int TotalColumn;
        int ColIndex=1;
        int NewRows=0, TotalRows = 0;
        float Mean1, StdDev1;
        float NormalizedX,Input_X;

        float sum;

        float[] Hidden_Input = new float[100];

        public FrmCalculateANN()
        {
            InitializeComponent();
        }

        private void FrmCalculateANN_Load(object sender, EventArgs e)
        {
            try
            {
                GenerateParameterTable();
                SetFontAndColorOfDatagridview();

                TxtCalcMean.Text = FrmInputANNParameters.Temp_Mean.ToString();
                TxtCalcStdDev.Text = FrmInputANNParameters.Temp_StdDev.ToString();
            }
            catch
            {

            }
        }

        public void SetFontAndColorOfDatagridview()
        {
            dataGridView.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dataGridView.ForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkTurquoise;

            dataGridView.DefaultCellStyle.Font = new Font("Comic Sans MS", 9);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 9);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DimGray;

            dataGridView.AllowUserToResizeRows = false;

        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Rows.Clear();
                TotalRows = 0;
                TxtTotalRows.Text = TotalRows.ToString();
            }
            catch
            {

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRemoveAt_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Rows.RemoveAt(Convert.ToInt32(TxtRemoveAt.Text)-1);
                TotalRows--;
                TxtTotalRows.Text = TotalRows.ToString();
                for (i = 0; i < TotalRows; i++)
                {
                    dataGridView.Rows[i].Cells[0].Value = i + 1;
                }
            }
            catch
            {

            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                CalculateOutput();
            }
            catch
            {

            }
        }

        public void CalculateOutput()
        {
            int start1, ColIndex1;
            Mean1 = Convert.ToSingle(TxtCalcMean.Text);
            StdDev1 = Convert.ToSingle(TxtCalcStdDev.Text);

            for(i = 0; i < TotalRows; i++)
            {
                /*
                for(j = 0; j < 3; j++)
                {
                    Input_X = Convert.ToSingle(dataGridView.Rows[i].Cells[2].Value);
                    NormalizedX = (Input_X - Mean1) / StdDev1;
                }*/

                //Input columns... just increase ColIndex
                ColIndex1 = 1;
                start1 = ColIndex1;
                for (j = start1; j <= FrmANN.NeuronsInNetworkLayer[0]; j++)
                {
                    ColIndex1++;
                }

                // Normalized Input columns
                start1 = ColIndex1;
                for (j = start1; j < start1 + FrmANN.NeuronsInNetworkLayer[0]; j++)
                {
                    Input_X = Convert.ToSingle(dataGridView.Rows[i].Cells[ColIndex1 - FrmANN.NeuronsInNetworkLayer[0]].Value);
                    NormalizedX = (Input_X - Mean1) / StdDev1;

                    dataGridView.Rows[i].Cells[ColIndex1].Value = NormalizedX.ToString();

                    ColIndex1++;
                }

                //Hidden Neuron columns
                for (k = 1; k <= FrmANN.HiddenLayers; k++) // indicates current hidden layer
                {
                    start1 = ColIndex1;

                    //Store value of neurons of previous layer i.e. (k-1) layer
                    for (int l = 0; l < FrmANN.NeuronsInNetworkLayer[k - 1]; l++)
                    {
                        Hidden_Input[l] = Convert.ToSingle(dataGridView.Rows[i].Cells[ColIndex1 - FrmANN.NeuronsInNetworkLayer[k-1]+l].Value);
                    }

                    for (j = start1; j < start1 + FrmANN.NeuronsInNetworkLayer[k]; j++) // indicates each neurons of current layer
                    {
                        sum = 0;
                        for (int l = 0; l < FrmANN.NeuronsInNetworkLayer[k - 1]; l++) // operate on all neurons of previous layer
                        {
                            //sum += Hidden_Input[l];
                            sum += FrmInputANNParameters.Weights[k-1, l, j-start1] * Hidden_Input[l]; // multiply by weights
                                                                                                    
                        }
                        //sum += 1; //add bias
                        sum += FrmInputANNParameters.Bias[k,j-start1] ; //add bias

                        if (FrmInputANNParameters.ActivationFunction == "relu")
                        {
                            sum = Relu(sum);
                        }
                        else if(FrmInputANNParameters.ActivationFunction == "sigmoid")
                        {
                            sum = Sigmoid(sum);
                        }

                        dataGridView.Rows[i].Cells[ColIndex1].Value = (sum).ToString();
                        ColIndex1++;
                    }
                }

                //Predicted Output columns
                start1 = ColIndex1;

                //Store value of neurons of previous layer i.e. last hidden layer
                //[FrmANN.TotalLayers - 2] = last hidden layer
                //[FrmANN.TotalLayers - 1] = output layer
                for (int l = 0; l < FrmANN.NeuronsInNetworkLayer[FrmANN.TotalLayers - 2]; l++)
                {
                    Hidden_Input[l] = Convert.ToSingle(dataGridView.Rows[i].Cells[ColIndex1 - FrmANN.NeuronsInNetworkLayer[FrmANN.TotalLayers - 2] + l].Value);

                }

                for (j = start1; j < start1 + FrmANN.NeuronsInNetworkLayer[FrmANN.TotalLayers - 1]; j++) //indicates each neurons of output layer
                {
                    sum = 0;
                    for (int l = 0; l < FrmANN.NeuronsInNetworkLayer[FrmANN.TotalLayers - 2]; l++) // operate on all neurons of last hidden layer
                    {
                        //sum += Hidden_Input[l];
                        sum += FrmInputANNParameters.Weights[FrmANN.TotalLayers-2, l, j - start1] * Hidden_Input[l]; // multiply by weights
                    }

                    sum += FrmInputANNParameters.Bias[FrmANN.TotalLayers - 1, j - start1]; //add bias

                    dataGridView.Rows[i].Cells[ColIndex1].Value = (sum).ToString();
                    ColIndex1++;
                }

                // Actual output columns
                start1 = ColIndex1;
                for (j = start1; j < start1 + FrmANN.NeuronsInNetworkLayer[FrmANN.TotalLayers - 1]; j++)
                {
                    ColIndex1++;
                }

                //Error columns
                start1 = ColIndex1;
                
                float Error,Y_Pred,Y_Act;
                //Store value of neurons of previous layer
                for (j = start1; j < start1 + FrmANN.NeuronsInNetworkLayer[FrmANN.TotalLayers - 1]; j++)
                {
                    Y_Pred = Convert.ToSingle(dataGridView.Rows[i].Cells[ColIndex1 - 2 * FrmANN.NeuronsInNetworkLayer[FrmANN.TotalLayers - 1]].Value);

                    Y_Act = Convert.ToSingle(dataGridView.Rows[i].Cells[ColIndex1 - FrmANN.NeuronsInNetworkLayer[FrmANN.TotalLayers - 1]].Value);

                    Error = Math.Abs(Y_Pred - Y_Act);

                    dataGridView.Rows[i].Cells[ColIndex1].Value = Error.ToString();
                    ColIndex1++;
                }
            }
        }

        public float Relu(float X)
        {
            float value;
            if(X <= 0)
            {
                value = 0;
            }
            else
            {
                value = X;
            }
            return value;
        }

        public float Sigmoid(float X)
        {
            float value;
            value = Convert.ToSingle(1 / (1 + Math.Exp(-X)));
            return value;
        }

        private void BtnAddRows_Click(object sender, EventArgs e)
        {
            try
            {
                NewRows = Convert.ToInt32(TxtRows.Text);
                for(i = 1; i <= NewRows; i++)
                {
                    dataGridView.Rows.Add();
                    dataGridView.Rows[TotalRows].Cells[0].Value = TotalRows+1;
                    TotalRows++;
                }
                TxtTotalRows.Text = TotalRows.ToString();
            }
            catch
            {

            }
        }

        public void GenerateParameterTable()
        {
            try
            {
                //Total columns in calculation table
                TotalColumn = 1 + FrmInputANNParameters.TotalNeurons + FrmANN.NeuronsInNetworkLayer[0] +
                              FrmANN.NeuronsInNetworkLayer[FrmANN.TotalLayers - 1] * 2;
                
                // Add Columns
                dataGridView.ColumnCount = TotalColumn;

                // Name of Input columns
                int start = ColIndex;
                for (i = start; i <= FrmANN.NeuronsInNetworkLayer[0]; i++)
                {
                    dataGridView.Columns[ColIndex].Name = "Input_" + (ColIndex - 1).ToString();
                    dataGridView.Columns[ColIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
                    //dataGridView.Columns[ColIndex].Width = 80;
                    ColIndex++;
                }

                // Name of Normalized Input columns
                start = ColIndex;
                for (i = start; i < start + FrmANN.NeuronsInNetworkLayer[0]; i++)
                {
                    dataGridView.Columns[ColIndex].Name = "Normalized_" + (i-start).ToString();
                    dataGridView.Columns[ColIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
                    //dataGridView.Columns[ColIndex].Width = 80;
                    ColIndex++;
                }

                // Name of Hidden Neuron columns
                for (i = 1; i <= FrmANN.HiddenLayers; i++)
                {
                    start = ColIndex;
                    for (j = start; j < start + FrmANN.NeuronsInNetworkLayer[i]; j++)
                    {
                        dataGridView.Columns[ColIndex].Name = "Hidden_" + (i).ToString() + "_" + (j-start).ToString();
                        dataGridView.Columns[ColIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
                        //dataGridView.Columns[ColIndex].Width = 80;
                        ColIndex++;
                    }
                }

                // Name of Predicted Output columns
                start = ColIndex;
                for (i = start; i < start + FrmANN.NeuronsInNetworkLayer[FrmANN.TotalLayers - 1]; i++)
                {
                    dataGridView.Columns[ColIndex].Name = "Y_Pred_" + (i-start).ToString();
                    dataGridView.Columns[ColIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
                    //dataGridView.Columns[ColIndex].Width = 80;
                    ColIndex++;
                }

                // Name of actual output columns
                start = ColIndex;
                for (i = start; i < start + FrmANN.NeuronsInNetworkLayer[FrmANN.TotalLayers - 1]; i++) 
                {
                    dataGridView.Columns[ColIndex].Name = "Y_act_" + (i - start).ToString();
                    dataGridView.Columns[ColIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
                    //dataGridView.Columns[ColIndex].Width = 80;
                    ColIndex++;
                }

                // Name of Error columns
                start = ColIndex;
                for (i = start; i < start + FrmANN.NeuronsInNetworkLayer[FrmANN.TotalLayers - 1]; i++)
                {
                    dataGridView.Columns[ColIndex].Name = "Error_" + (i - start).ToString();
                    dataGridView.Columns[ColIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
                    //dataGridView.Columns[ColIndex].Width = 80;
                    ColIndex++;
                }

                /*//Add Rows
                dataGridView.Rows.Clear();
                for (i = 0; i < FrmInputANNParameters.MaxNeuron + 1; i++)
                {
                    dataGridView.Rows.Add();
                    if (i == FrmInputANNParameters.MaxNeuron)
                    {
                        dataGridView.Rows[i].Cells[0].Value = "Bias";
                    }
                    else
                    {
                        dataGridView.Rows[i].Cells[0].Value = "Weights" + (i + 1).ToString();
                    }
                }*/
            }
            catch
            {

            }
        }
    }
}
