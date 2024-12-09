namespace Gauss
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Variancia = new System.Windows.Forms.Label();
            this.label_Szoras = new System.Windows.Forms.Label();
            this.label_Osztalyok = new System.Windows.Forms.Label();
            this.label_N = new System.Windows.Forms.Label();
            this.label_Max = new System.Windows.Forms.Label();
            this.label_Atlag = new System.Windows.Forms.Label();
            this.label_Min = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Min);
            this.groupBox1.Controls.Add(this.label_Atlag);
            this.groupBox1.Controls.Add(this.label_Max);
            this.groupBox1.Controls.Add(this.label_Variancia);
            this.groupBox1.Controls.Add(this.label_Szoras);
            this.groupBox1.Controls.Add(this.label_Osztalyok);
            this.groupBox1.Controls.Add(this.label_N);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(955, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 485);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Az adatsor jellemzői";
            // 
            // label_Variancia
            // 
            this.label_Variancia.AutoSize = true;
            this.label_Variancia.Location = new System.Drawing.Point(24, 201);
            this.label_Variancia.Name = "label_Variancia";
            this.label_Variancia.Size = new System.Drawing.Size(67, 16);
            this.label_Variancia.TabIndex = 4;
            this.label_Variancia.Text = "Variancia:";
            // 
            // label_Szoras
            // 
            this.label_Szoras.AutoSize = true;
            this.label_Szoras.Location = new System.Drawing.Point(24, 234);
            this.label_Szoras.Name = "label_Szoras";
            this.label_Szoras.Size = new System.Drawing.Size(52, 16);
            this.label_Szoras.TabIndex = 3;
            this.label_Szoras.Text = "Szórás:";
            // 
            // label_Osztalyok
            // 
            this.label_Osztalyok.AutoSize = true;
            this.label_Osztalyok.Location = new System.Drawing.Point(24, 268);
            this.label_Osztalyok.Name = "label_Osztalyok";
            this.label_Osztalyok.Size = new System.Drawing.Size(64, 16);
            this.label_Osztalyok.TabIndex = 2;
            this.label_Osztalyok.Text = "osztályok";
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Location = new System.Drawing.Point(24, 36);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(23, 16);
            this.label_N.TabIndex = 0;
            this.label_N.Text = "N: ";
            // 
            // label_Max
            // 
            this.label_Max.AutoSize = true;
            this.label_Max.Location = new System.Drawing.Point(24, 135);
            this.label_Max.Name = "label_Max";
            this.label_Max.Size = new System.Drawing.Size(80, 16);
            this.label_Max.TabIndex = 5;
            this.label_Max.Text = "legnagyobb";
            // 
            // label_Atlag
            // 
            this.label_Atlag.AutoSize = true;
            this.label_Atlag.Location = new System.Drawing.Point(24, 103);
            this.label_Atlag.Name = "label_Atlag";
            this.label_Atlag.Size = new System.Drawing.Size(37, 16);
            this.label_Atlag.TabIndex = 6;
            this.label_Atlag.Text = "atlag";
            // 
            // label_Min
            // 
            this.label_Min.AutoSize = true;
            this.label_Min.Location = new System.Drawing.Point(24, 70);
            this.label_Min.Name = "label_Min";
            this.label_Min.Size = new System.Drawing.Size(64, 16);
            this.label_Min.TabIndex = 7;
            this.label_Min.Text = "Legisebb";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 485);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mérési adatok sűrűség függvénye";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.Label label_Variancia;
        private System.Windows.Forms.Label label_Szoras;
        private System.Windows.Forms.Label label_Osztalyok;
        private System.Windows.Forms.Label label_Min;
        private System.Windows.Forms.Label label_Atlag;
        private System.Windows.Forms.Label label_Max;
    }
}

