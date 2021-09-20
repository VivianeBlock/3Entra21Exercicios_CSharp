
namespace MultiRetorno
{
    partial class Exec03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exec03));
            this.dgHistorico = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEmCaixaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DespesasDoMesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GanhoDoMesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLiquidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeLucrouCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textGanhos = new System.Windows.Forms.TextBox();
            this.textDespesas = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHistorico
            // 
            this.dgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.ValorEmCaixaCol,
            this.DespesasDoMesCol,
            this.GanhoDoMesCol,
            this.ValorLiquidoCol,
            this.SeLucrouCol});
            this.dgHistorico.Location = new System.Drawing.Point(15, 23);
            this.dgHistorico.Name = "dgHistorico";
            this.dgHistorico.Size = new System.Drawing.Size(796, 253);
            this.dgHistorico.TabIndex = 0;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.Width = 50;
            // 
            // ValorEmCaixaCol
            // 
            this.ValorEmCaixaCol.HeaderText = "Valor em caixa";
            this.ValorEmCaixaCol.Name = "ValorEmCaixaCol";
            this.ValorEmCaixaCol.Width = 150;
            // 
            // DespesasDoMesCol
            // 
            this.DespesasDoMesCol.HeaderText = "Despesas do mes";
            this.DespesasDoMesCol.Name = "DespesasDoMesCol";
            this.DespesasDoMesCol.Width = 150;
            // 
            // GanhoDoMesCol
            // 
            this.GanhoDoMesCol.HeaderText = "Ganho do mes";
            this.GanhoDoMesCol.Name = "GanhoDoMesCol";
            this.GanhoDoMesCol.Width = 150;
            // 
            // ValorLiquidoCol
            // 
            this.ValorLiquidoCol.HeaderText = "Valor Liquido";
            this.ValorLiquidoCol.Name = "ValorLiquidoCol";
            this.ValorLiquidoCol.Width = 150;
            // 
            // SeLucrouCol
            // 
            this.SeLucrouCol.HeaderText = "Se Lucrou";
            this.SeLucrouCol.Name = "SeLucrouCol";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Indigo;
            this.btnSair.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSair.Location = new System.Drawing.Point(18, 399);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(138, 36);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(43, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ganhos do Mês:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Indigo;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(446, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Despesas do Mês:";
            // 
            // textGanhos
            // 
            this.textGanhos.Location = new System.Drawing.Point(203, 312);
            this.textGanhos.Name = "textGanhos";
            this.textGanhos.Size = new System.Drawing.Size(141, 33);
            this.textGanhos.TabIndex = 4;
            // 
            // textDespesas
            // 
            this.textDespesas.Location = new System.Drawing.Point(609, 312);
            this.textDespesas.Name = "textDespesas";
            this.textDespesas.Size = new System.Drawing.Size(141, 33);
            this.textDespesas.TabIndex = 5;
            // 
            // btnCalcula
            // 
            this.btnCalcula.BackColor = System.Drawing.Color.Magenta;
            this.btnCalcula.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalcula.Location = new System.Drawing.Point(637, 393);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(174, 49);
            this.btnCalcula.TabIndex = 6;
            this.btnCalcula.Text = "Calcula Mês";
            this.btnCalcula.UseVisualStyleBackColor = false;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // Exec03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 456);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.textDespesas);
            this.Controls.Add(this.textGanhos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgHistorico);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Exec03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec03";
            this.Load += new System.EventHandler(this.Exec03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEmCaixaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DespesasDoMesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GanhoDoMesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLiquidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeLucrouCol;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textGanhos;
        private System.Windows.Forms.TextBox textDespesas;
        private System.Windows.Forms.Button btnCalcula;
    }
}