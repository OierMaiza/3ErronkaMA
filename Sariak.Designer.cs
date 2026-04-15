namespace EuskalMus
{
    partial class Sariak
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

        private void InitializeComponent()
        {
            this.lblTitulua = new System.Windows.Forms.Label();
            this.lblTxapelketa = new System.Windows.Forms.Label();
            this.cmbTxapelketa = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl4_10 = new System.Windows.Forms.Label();
            this.txt4_10 = new System.Windows.Forms.TextBox();
            this.btnGorde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulua
            // 
            this.lblTitulua.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulua.Location = new System.Drawing.Point(20, 20);
            this.lblTitulua.Name = "lblTitulua";
            this.lblTitulua.Size = new System.Drawing.Size(400, 30);
            this.lblTitulua.TabIndex = 0;
            this.lblTitulua.Text = "SARIAK KUDEATU";
            // 
            // lblTxapelketa
            // 
            this.lblTxapelketa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTxapelketa.Location = new System.Drawing.Point(20, 70);
            this.lblTxapelketa.Name = "lblTxapelketa";
            this.lblTxapelketa.Size = new System.Drawing.Size(120, 25);
            this.lblTxapelketa.TabIndex = 1;
            this.lblTxapelketa.Text = "Txapelketa:";
            // 
            // cmbTxapelketa
            // 
            this.cmbTxapelketa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTxapelketa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTxapelketa.Location = new System.Drawing.Point(150, 68);
            this.cmbTxapelketa.Name = "cmbTxapelketa";
            this.cmbTxapelketa.Size = new System.Drawing.Size(260, 31);
            this.cmbTxapelketa.TabIndex = 2;
            this.cmbTxapelketa.SelectedIndexChanged += new System.EventHandler(this.cmbTxapelketa_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl1.Location = new System.Drawing.Point(20, 120);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(120, 25);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "1. Saria:";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt1.Location = new System.Drawing.Point(150, 118);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(260, 30);
            this.txt1.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl2.Location = new System.Drawing.Point(20, 165);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(120, 25);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "2. Saria:";
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt2.Location = new System.Drawing.Point(150, 163);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(260, 30);
            this.txt2.TabIndex = 6;
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl3.Location = new System.Drawing.Point(20, 210);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(120, 25);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "3. Saria:";
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt3.Location = new System.Drawing.Point(150, 208);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(260, 30);
            this.txt3.TabIndex = 8;
            // 
            // lbl4_10
            // 
            this.lbl4_10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl4_10.Location = new System.Drawing.Point(20, 255);
            this.lbl4_10.Name = "lbl4_10";
            this.lbl4_10.Size = new System.Drawing.Size(120, 25);
            this.lbl4_10.TabIndex = 9;
            this.lbl4_10.Text = "4-10. Sariak:";
            // 
            // txt4_10
            // 
            this.txt4_10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt4_10.Location = new System.Drawing.Point(150, 253);
            this.txt4_10.Name = "txt4_10";
            this.txt4_10.Size = new System.Drawing.Size(260, 30);
            this.txt4_10.TabIndex = 10;
            // 
            // btnGorde
            // 
            this.btnGorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGorde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGorde.FlatAppearance.BorderSize = 0;
            this.btnGorde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorde.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGorde.ForeColor = System.Drawing.Color.White;
            this.btnGorde.Location = new System.Drawing.Point(150, 310);
            this.btnGorde.Name = "btnGorde";
            this.btnGorde.Size = new System.Drawing.Size(150, 45);
            this.btnGorde.TabIndex = 11;
            this.btnGorde.Text = "GORDE";
            this.btnGorde.UseVisualStyleBackColor = false;
            this.btnGorde.Click += new System.EventHandler(this.btnGorde_Click);
            // 
            // Sariak
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(432, 373);
            this.Controls.Add(this.lblTitulua);
            this.Controls.Add(this.lblTxapelketa);
            this.Controls.Add(this.cmbTxapelketa);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lbl4_10);
            this.Controls.Add(this.txt4_10);
            this.Controls.Add(this.btnGorde);
            this.Name = "Sariak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EuskalMus - Sariak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // ── Kontrolen deklarazioa ────────────────────────────────────────
        private System.Windows.Forms.Label lblTitulua;
        private System.Windows.Forms.Label lblTxapelketa;
        private System.Windows.Forms.ComboBox cmbTxapelketa;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl4_10;
        private System.Windows.Forms.TextBox txt4_10;
        private System.Windows.Forms.Button btnGorde;
    }
}