namespace SisAgroVeterinaria.Consultas
{
    partial class cUsuarios
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
            this.UsuariodataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.buscarcomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariodataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariodataGridView1
            // 
            this.UsuariodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariodataGridView1.Location = new System.Drawing.Point(31, 122);
            this.UsuariodataGridView1.Name = "UsuariodataGridView1";
            this.UsuariodataGridView1.Size = new System.Drawing.Size(647, 270);
            this.UsuariodataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(167, 63);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(411, 20);
            this.BuscartextBox.TabIndex = 9;
            // 
            // buscarcomboBox
            // 
            this.buscarcomboBox.FormattingEnabled = true;
            this.buscarcomboBox.Items.AddRange(new object[] {
            "Id",
            "Nombre"});
            this.buscarcomboBox.Location = new System.Drawing.Point(31, 62);
            this.buscarcomboBox.Name = "buscarcomboBox";
            this.buscarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.buscarcomboBox.TabIndex = 8;
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 452);
            this.Controls.Add(this.UsuariodataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.buscarcomboBox);
            this.Name = "cUsuarios";
            this.Text = "cUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.UsuariodataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsuariodataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.ComboBox buscarcomboBox;
    }
}