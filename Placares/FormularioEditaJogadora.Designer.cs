namespace Placares
{
    partial class FormularioEditaJogadora
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Jogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.placarViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placarViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.placarViewModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placarViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placarViewModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placarViewModelBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(658, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 228);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jogo,
            this.Placar,
            this.MinTemporada,
            this.MaxTemporada,
            this.RecordMin,
            this.RecordMax});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // Jogo
            // 
            this.Jogo.DataPropertyName = "Jogo";
            this.Jogo.HeaderText = "Jogo";
            this.Jogo.Name = "Jogo";
            this.Jogo.ReadOnly = true;
            // 
            // Placar
            // 
            this.Placar.DataPropertyName = "Placar";
            this.Placar.HeaderText = "Placar";
            this.Placar.Name = "Placar";
            this.Placar.ReadOnly = true;
            // 
            // MinTemporada
            // 
            this.MinTemporada.DataPropertyName = "MinTemporada";
            this.MinTemporada.HeaderText = "Min Temporada";
            this.MinTemporada.Name = "MinTemporada";
            this.MinTemporada.ReadOnly = true;
            // 
            // MaxTemporada
            // 
            this.MaxTemporada.DataPropertyName = "MaxTemporada";
            this.MaxTemporada.HeaderText = "Max Temporada";
            this.MaxTemporada.Name = "MaxTemporada";
            this.MaxTemporada.ReadOnly = true;
            // 
            // RecordMin
            // 
            this.RecordMin.DataPropertyName = "RecordMinimo";
            this.RecordMin.HeaderText = "Record Min";
            this.RecordMin.Name = "RecordMin";
            this.RecordMin.ReadOnly = true;
            // 
            // RecordMax
            // 
            this.RecordMax.DataPropertyName = "RecordMaximo";
            this.RecordMax.HeaderText = "Record Max";
            this.RecordMax.Name = "RecordMax";
            this.RecordMax.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // placarViewModelBindingSource
            // 
            this.placarViewModelBindingSource.DataSource = typeof(Placares.ViewModels.PlacarViewModel);
            // 
            // placarViewModelBindingSource1
            // 
            this.placarViewModelBindingSource1.DataSource = typeof(Placares.ViewModels.PlacarViewModel);
            // 
            // placarViewModelBindingSource2
            // 
            this.placarViewModelBindingSource2.DataSource = typeof(Placares.ViewModels.PlacarViewModel);
            // 
            // FormularioEditaJogadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormularioEditaJogadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editando jogadora";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placarViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placarViewModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placarViewModelBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource placarViewModelBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource placarViewModelBindingSource2;
        private System.Windows.Forms.BindingSource placarViewModelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placar;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordMax;
    }
}