namespace TimeControlAudio
{
    partial class frmMain
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
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.btIniciar = new MetroFramework.Controls.MetroTile();
            this.btParar = new MetroFramework.Controls.MetroTile();
            this.txtTempo = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // btIniciar
            // 
            this.btIniciar.ActiveControl = null;
            this.btIniciar.Location = new System.Drawing.Point(137, 178);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(98, 60);
            this.btIniciar.Style = MetroFramework.MetroColorStyle.Green;
            this.btIniciar.TabIndex = 0;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btIniciar.UseSelectable = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btParar
            // 
            this.btParar.ActiveControl = null;
            this.btParar.Location = new System.Drawing.Point(241, 178);
            this.btParar.Name = "btParar";
            this.btParar.Size = new System.Drawing.Size(98, 60);
            this.btParar.Style = MetroFramework.MetroColorStyle.Red;
            this.btParar.TabIndex = 1;
            this.btParar.Text = "Parar";
            this.btParar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btParar.UseSelectable = true;
            this.btParar.Click += new System.EventHandler(this.btParar_Click);
            // 
            // txtTempo
            // 
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempo.Location = new System.Drawing.Point(23, 74);
            this.txtTempo.Mask = "90:00:00";
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(316, 98);
            this.txtTempo.TabIndex = 2;
            this.txtTempo.Text = "000000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 261);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.btParar);
            this.Controls.Add(this.btIniciar);
            this.Name = "frmMain";
            this.Text = "Controlador tempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private MetroFramework.Controls.MetroTile btIniciar;
        private MetroFramework.Controls.MetroTile btParar;
        private System.Windows.Forms.MaskedTextBox txtTempo;
        private System.Windows.Forms.Timer timer1;
    }
}

