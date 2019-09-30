namespace CSAY_ANN
{
    partial class FrmANN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelANNDraw = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCalculateANN = new System.Windows.Forms.Button();
            this.BtnInputANNPara = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNeuronSize = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColHiddenLayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHNeurons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtHiddenLayers = new System.Windows.Forms.TextBox();
            this.TxtOutputNeurons = new System.Windows.Forms.TextBox();
            this.TxtInputNeurons = new System.Windows.Forms.TextBox();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelANNDraw
            // 
            this.PanelANNDraw.BackColor = System.Drawing.Color.Black;
            this.PanelANNDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelANNDraw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PanelANNDraw.Location = new System.Drawing.Point(0, 0);
            this.PanelANNDraw.Name = "PanelANNDraw";
            this.PanelANNDraw.Size = new System.Drawing.Size(940, 572);
            this.PanelANNDraw.TabIndex = 0;
            this.PanelANNDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelANNDraw_Paint);
            this.PanelANNDraw.Resize += new System.EventHandler(this.PanelANNDraw_Resize);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.BtnAbout);
            this.panel1.Controls.Add(this.BtnCalculateANN);
            this.panel1.Controls.Add(this.BtnInputANNPara);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtNeuronSize);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtHiddenLayers);
            this.panel1.Controls.Add(this.TxtOutputNeurons);
            this.panel1.Controls.Add(this.TxtInputNeurons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 572);
            this.panel1.TabIndex = 1;
            // 
            // BtnCalculateANN
            // 
            this.BtnCalculateANN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCalculateANN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCalculateANN.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnCalculateANN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnCalculateANN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalculateANN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculateANN.ForeColor = System.Drawing.Color.White;
            this.BtnCalculateANN.Location = new System.Drawing.Point(13, 180);
            this.BtnCalculateANN.Name = "BtnCalculateANN";
            this.BtnCalculateANN.Size = new System.Drawing.Size(198, 33);
            this.BtnCalculateANN.TabIndex = 12;
            this.BtnCalculateANN.Text = "ANN Calculation";
            this.BtnCalculateANN.UseVisualStyleBackColor = false;
            this.BtnCalculateANN.Click += new System.EventHandler(this.BtnCalculateANN_Click);
            // 
            // BtnInputANNPara
            // 
            this.BtnInputANNPara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnInputANNPara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnInputANNPara.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnInputANNPara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnInputANNPara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInputANNPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInputANNPara.ForeColor = System.Drawing.Color.White;
            this.BtnInputANNPara.Location = new System.Drawing.Point(13, 141);
            this.BtnInputANNPara.Name = "BtnInputANNPara";
            this.BtnInputANNPara.Size = new System.Drawing.Size(198, 33);
            this.BtnInputANNPara.TabIndex = 11;
            this.BtnInputANNPara.Text = "Input ANN Parameters";
            this.BtnInputANNPara.UseVisualStyleBackColor = false;
            this.BtnInputANNPara.Click += new System.EventHandler(this.BtnInputANNPara_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(8, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Neuron Size";
            // 
            // TxtNeuronSize
            // 
            this.TxtNeuronSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtNeuronSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNeuronSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNeuronSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtNeuronSize.Location = new System.Drawing.Point(110, 284);
            this.TxtNeuronSize.Name = "TxtNeuronSize";
            this.TxtNeuronSize.Size = new System.Drawing.Size(100, 22);
            this.TxtNeuronSize.TabIndex = 8;
            this.TxtNeuronSize.Text = "50";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(13, 102);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(198, 33);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Draw Network";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHiddenLayers,
            this.ColHNeurons});
            this.dataGridView.Location = new System.Drawing.Point(12, 420);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(183, 140);
            this.dataGridView.TabIndex = 6;
            // 
            // ColHiddenLayers
            // 
            this.ColHiddenLayers.HeaderText = "Hidden Layers";
            this.ColHiddenLayers.Name = "ColHiddenLayers";
            this.ColHiddenLayers.ReadOnly = true;
            this.ColHiddenLayers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColHiddenLayers.Width = 103;
            // 
            // ColHNeurons
            // 
            this.ColHNeurons.HeaderText = "Neurons";
            this.ColHNeurons.Name = "ColHNeurons";
            this.ColHNeurons.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColHNeurons.Width = 60;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(9, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hidden Layers";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(9, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Neurons";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(9, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Neurons";
            // 
            // TxtHiddenLayers
            // 
            this.TxtHiddenLayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtHiddenLayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtHiddenLayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHiddenLayers.ForeColor = System.Drawing.Color.Lime;
            this.TxtHiddenLayers.Location = new System.Drawing.Point(111, 392);
            this.TxtHiddenLayers.Name = "TxtHiddenLayers";
            this.TxtHiddenLayers.Size = new System.Drawing.Size(100, 22);
            this.TxtHiddenLayers.TabIndex = 2;
            this.TxtHiddenLayers.TextChanged += new System.EventHandler(this.TxtHiddenLayers_TextChanged);
            // 
            // TxtOutputNeurons
            // 
            this.TxtOutputNeurons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtOutputNeurons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtOutputNeurons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOutputNeurons.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtOutputNeurons.Location = new System.Drawing.Point(111, 355);
            this.TxtOutputNeurons.Name = "TxtOutputNeurons";
            this.TxtOutputNeurons.Size = new System.Drawing.Size(100, 22);
            this.TxtOutputNeurons.TabIndex = 1;
            this.TxtOutputNeurons.Text = "1";
            // 
            // TxtInputNeurons
            // 
            this.TxtInputNeurons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtInputNeurons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtInputNeurons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInputNeurons.ForeColor = System.Drawing.Color.OrangeRed;
            this.TxtInputNeurons.Location = new System.Drawing.Point(111, 317);
            this.TxtInputNeurons.Name = "TxtInputNeurons";
            this.TxtInputNeurons.Size = new System.Drawing.Size(100, 22);
            this.TxtInputNeurons.TabIndex = 0;
            this.TxtInputNeurons.Text = "1";
            // 
            // BtnAbout
            // 
            this.BtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAbout.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.Color.White;
            this.BtnAbout.Location = new System.Drawing.Point(13, 219);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(198, 33);
            this.BtnAbout.TabIndex = 13;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // FrmANN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelANNDraw);
            this.Name = "FrmANN";
            this.Text = "CSAY ANN SCHEME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmANNDraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelANNDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHiddenLayers;
        private System.Windows.Forms.TextBox TxtOutputNeurons;
        private System.Windows.Forms.TextBox TxtInputNeurons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHiddenLayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHNeurons;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNeuronSize;
        private System.Windows.Forms.Button BtnInputANNPara;
        private System.Windows.Forms.Button BtnCalculateANN;
        private System.Windows.Forms.Button BtnAbout;
    }
}

