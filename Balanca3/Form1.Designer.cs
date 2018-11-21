namespace Balanca3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbPorta = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.cbPorta = new System.Windows.Forms.ComboBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnReceber = new System.Windows.Forms.Button();
            this.txtRecebe = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnParar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnPararR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPorta
            // 
            this.lbPorta.AutoSize = true;
            this.lbPorta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPorta.Location = new System.Drawing.Point(12, 39);
            this.lbPorta.Name = "lbPorta";
            this.lbPorta.Size = new System.Drawing.Size(35, 13);
            this.lbPorta.TabIndex = 0;
            this.lbPorta.Text = "Porta:";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.ForeColor = System.Drawing.Color.Green;
            this.btnConectar.Location = new System.Drawing.Point(208, 29);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(138, 33);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // cbPorta
            // 
            this.cbPorta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPorta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPorta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbPorta.FormattingEnabled = true;
            this.cbPorta.Location = new System.Drawing.Point(53, 36);
            this.cbPorta.Name = "cbPorta";
            this.cbPorta.Size = new System.Drawing.Size(149, 21);
            this.cbPorta.TabIndex = 2;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.ForeColor = System.Drawing.Color.Red;
            this.btnDesconectar.Location = new System.Drawing.Point(352, 29);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(138, 33);
            this.btnDesconectar.TabIndex = 4;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceber.ForeColor = System.Drawing.Color.Green;
            this.btnReceber.Location = new System.Drawing.Point(45, 250);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(138, 34);
            this.btnReceber.TabIndex = 7;
            this.btnReceber.Text = "Receber Peso";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // txtRecebe
            // 
            this.txtRecebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecebe.Cursor = System.Windows.Forms.Cursors.No;
            this.txtRecebe.Location = new System.Drawing.Point(15, 93);
            this.txtRecebe.Multiline = true;
            this.txtRecebe.Name = "txtRecebe";
            this.txtRecebe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecebe.Size = new System.Drawing.Size(475, 124);
            this.txtRecebe.TabIndex = 6;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 4800;
            this.serialPort1.DataBits = 7;
            this.serialPort1.PortName = "COM3";
            // 
            // btnParar
            // 
            this.btnParar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnParar.Location = new System.Drawing.Point(189, 250);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(138, 34);
            this.btnParar.TabIndex = 8;
            this.btnParar.Text = "Gerar TXT";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Peso Capturado:";
            // 
            // btnPararR
            // 
            this.btnPararR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPararR.ForeColor = System.Drawing.Color.Red;
            this.btnPararR.Location = new System.Drawing.Point(333, 250);
            this.btnPararR.Name = "btnPararR";
            this.btnPararR.Size = new System.Drawing.Size(138, 34);
            this.btnPararR.TabIndex = 10;
            this.btnPararR.Text = "Para de Receber";
            this.btnPararR.UseVisualStyleBackColor = true;
            this.btnPararR.Click += new System.EventHandler(this.btnPararR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(509, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPararR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.txtRecebe);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.cbPorta);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lbPorta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balança";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPorta;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox cbPorta;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnReceber;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecebe;
        private System.Windows.Forms.Button btnPararR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

