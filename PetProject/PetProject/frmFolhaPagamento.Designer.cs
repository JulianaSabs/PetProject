
namespace ProjetoMyPets
{
    partial class frmFolhaPagamento
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtFolha = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.chkPlanoSaude = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(76, 84);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(162, 23);
            this.txtSalario.TabIndex = 0;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            this.txtSalario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalario_KeyDown);
            // 
            // txtFolha
            // 
            this.txtFolha.Location = new System.Drawing.Point(337, 84);
            this.txtFolha.Name = "txtFolha";
            this.txtFolha.Size = new System.Drawing.Size(162, 23);
            this.txtFolha.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(76, 304);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(142, 45);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // chkPlanoSaude
            // 
            this.chkPlanoSaude.AutoSize = true;
            this.chkPlanoSaude.Location = new System.Drawing.Point(76, 171);
            this.chkPlanoSaude.Name = "chkPlanoSaude";
            this.chkPlanoSaude.Size = new System.Drawing.Size(91, 19);
            this.chkPlanoSaude.TabIndex = 3;
            this.chkPlanoSaude.Text = "Plano Saúde";
            this.chkPlanoSaude.UseVisualStyleBackColor = true;
            this.chkPlanoSaude.CheckedChanged += new System.EventHandler(this.chkPlanoSaude_CheckedChanged);
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkPlanoSaude);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtFolha);
            this.Controls.Add(this.txtSalario);
            this.Name = "frmFolhaPagamento";
            this.Text = "frmFolhaPagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtFolha;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox chkPlanoSaude;
    }
}