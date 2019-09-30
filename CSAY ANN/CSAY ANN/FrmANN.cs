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
    public partial class FrmANN : Form
    {
        public static int[] NeuronsInNetworkLayer = new int[10];
        public static  int TotalLayers = 6, HiddenLayers; 
        int i, j,k;
        public static  int NeuronSize = 25;

        private void PanelANNDraw_Resize(object sender, EventArgs e)
        {
            //ResizeRedraw = true;
            Refresh();
        }


        private void FrmANNDraw_Load(object sender, EventArgs e)
        {
            try
            {
                SetFontAndColorOfDatagridview();
            }
            catch
            {

            }
        }
         
        public void SetFontAndColorOfDatagridview()
        {
            dataGridView.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dataGridView.ForeColor = Color.Lime;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            //dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Lime;

            dataGridView.DefaultCellStyle.Font = new Font("Comic Sans MS", 9);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 9);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DimGray;

            dataGridView.AllowUserToResizeRows = false;
        }
        public void InputData()
        {
            try
            {
                NeuronSize = Convert.ToInt32(TxtNeuronSize.Text);
                HiddenLayers = Convert.ToInt32(TxtHiddenLayers.Text);

                TotalLayers = HiddenLayers + 2;

                NeuronsInNetworkLayer[0] = Convert.ToInt32(TxtInputNeurons.Text);
                int index = 1;
                for(i = 0; i < HiddenLayers; i++)
                {
                    NeuronsInNetworkLayer[index] = Convert.ToInt32(dataGridView.Rows[i].Cells[1].Value);
                    index++;
                }
                NeuronsInNetworkLayer[TotalLayers - 1] = Convert.ToInt32(TxtOutputNeurons.Text);
            }
            catch
            {

            }
        }

        public void GenerateRows()
        {
            HiddenLayers = Convert.ToInt32(TxtHiddenLayers.Text);
            dataGridView.Rows.Clear();

            for(i = 0; i < HiddenLayers; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = "HiddenLayer" + (i+1).ToString();
            }
        }

        private void BtnInputANNPara_Click(object sender, EventArgs e)
        {
            FrmInputANNParameters fInANN = new FrmInputANNParameters();
            fInANN.Show();
        }

       

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            InputData();
            Refresh();

            //PanelANNDraw_Paint(sender, e1);
        }

        private void BtnCalculateANN_Click(object sender, EventArgs e)
        {
            FrmCalculateANN fcANN = new FrmCalculateANN();
            fcANN.Show();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Artificial Neural Network \nPredict values after creating ANN\n" +
                "Currently valid for 1 input and 1 output only\nVersion 2019.1\nCreated on: June 07, 2019\n-Ajay Yadav");
        }

        private void TxtHiddenLayers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GenerateRows();
            }
            catch
            {

            }
        }

        public FrmANN()
        {
            InitializeComponent();
        }

        private void PanelANNDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Pen RedPen = new Pen(Color.Red, 1);

            var WideX = PanelANNDraw.ClientSize.Width;
            var HeightY = PanelANNDraw.ClientSize.Height;

           /* NeuronsInNetworkLayer[0] = 1; // Input
            NeuronsInNetworkLayer[1] = 5;
            NeuronsInNetworkLayer[2] = 7;
            NeuronsInNetworkLayer[3] = 5;
            NeuronsInNetworkLayer[4] = 2;
            NeuronsInNetworkLayer[5] = 1; // Output*/

            /*
            //Input layer
            for (i = 0; i< NeuronsInInputLayer; i++)
            {
                g.DrawEllipse(RedPen, (WideX ) / 4, (HeightY - NeuronsInInputLayer * 50) / 2, 50, 50);
            }
            */
            Pen DwgColor;
            //Hidden layers
            for (i = 0; i < TotalLayers; i++)
            {
                for(j=0;j<NeuronsInNetworkLayer[i];j++)
                {
                    //g.DrawEllipse(Pens.Green, (WideX - NeuronsInHiddenLayer[i]*50)/2 + 50 * j, HeightY/4 + (i+1) *100, 50, 50);
                    if (i == 0)
                    {
                        DwgColor = new Pen(Color.OrangeRed, 1);
                    }
                    else if(i == (TotalLayers-1))
                    {
                        DwgColor = new Pen(Color.DodgerBlue, 1);
                    }
                    else
                    {
                        DwgColor = new Pen(Color.Lime, 1);
                    }

                    g.DrawEllipse(DwgColor, 
                        (WideX)/4 + i * (NeuronSize*2) , 
                        (HeightY - NeuronsInNetworkLayer[i] * NeuronSize) /3 + (NeuronSize + NeuronSize / 5) * j, 
                        NeuronSize, NeuronSize);

                }
            }

            //Draw line
            DwgColor = new Pen(Color.Turquoise, 1);
            for (i = 0; i < TotalLayers - 1; i++)
            {
                for (j = 0; j < NeuronsInNetworkLayer[i]; j++)
                {
                    for(k = 0; k < NeuronsInNetworkLayer[i + 1]; k++)
                    {
                        g.DrawLine(DwgColor, 
                            (WideX) / 4 + i * (NeuronSize * 2) + NeuronSize, 
                            (HeightY - NeuronsInNetworkLayer[i] * NeuronSize) / 3 + (NeuronSize + NeuronSize / 5) * j + NeuronSize/2,
                            (WideX) / 4 + (i+1) * (NeuronSize * 2), 
                            (HeightY - NeuronsInNetworkLayer[i+1] * NeuronSize) / 3 + (NeuronSize + NeuronSize / 5) * k + NeuronSize / 2);
                    }
                }
            }

            /* //Output layer
             for (i = 0; i < NeuronsInInputLayer; i++)
             {
                 g.DrawEllipse(Pens.DodgerBlue, (WideX + (HiddenLayers+1) * 150) / 4, (HeightY - OutputLayer * 50) / 2, 50, 50);
             }
             */
            //g.DrawEllipse(RedPen, WideX/2, HeightY/2, 50, 50);

        }
    }
}
