namespace atividadeWFA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarro = new System.Windows.Forms.Button();
            this.btnCaminhao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(509, 144);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seja bem vindo ao programa de cadastro e consulta de caminhão e carro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarro
            // 
            this.btnCarro.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCarro.Location = new System.Drawing.Point(35, 313);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(218, 86);
            this.btnCarro.TabIndex = 2;
            this.btnCarro.Text = "Carro";
            this.btnCarro.UseVisualStyleBackColor = false;
            this.btnCarro.Click += new System.EventHandler(this.btnCarro_Click);
            // 
            // btnCaminhao
            // 
            this.btnCaminhao.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCaminhao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaminhao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaminhao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCaminhao.Location = new System.Drawing.Point(555, 313);
            this.btnCaminhao.Name = "btnCaminhao";
            this.btnCaminhao.Size = new System.Drawing.Size(218, 86);
            this.btnCaminhao.TabIndex = 3;
            this.btnCaminhao.Text = " Caminhão";
            this.btnCaminhao.UseVisualStyleBackColor = false;
            this.btnCaminhao.Click += new System.EventHandler(this.btnCaminhao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCaminhao);
            this.Controls.Add(this.btnCarro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.Button btnCaminhao;
    }
}

