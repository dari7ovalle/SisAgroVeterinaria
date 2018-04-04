namespace SisAgroVeterinaria.Consultas
{
    partial class cCiudades
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
            this.CiudaddataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.BuscarcomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CiudaddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CiudaddataGridView
            // 
            this.CiudaddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CiudaddataGridView.Location = new System.Drawing.Point(22, 72);
            this.CiudaddataGridView.Name = "CiudaddataGridView";
            this.CiudaddataGridView.Size = new System.Drawing.Size(647, 270);
            this.CiudaddataGridView.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(158, 13);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(411, 20);
            this.BuscartextBox.TabIndex = 5;
            // 
            // BuscarcomboBox
            // 
            this.BuscarcomboBox.FormattingEnabled = true;
            this.BuscarcomboBox.Items.AddRange(new object[] {
            "Id",
            "Nombre"});
            this.BuscarcomboBox.Location = new System.Drawing.Point(22, 12);
            this.BuscarcomboBox.Name = "BuscarcomboBox";
            this.BuscarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.BuscarcomboBox.TabIndex = 4;
            // 
            // cCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 387);
            this.Controls.Add(this.CiudaddataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.BuscarcomboBox);
            this.Name = "cCiudades";
            this.Text = "cCiudades";
            ((System.ComponentModel.ISupportInitialize)(this.CiudaddataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CiudaddataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.ComboBox BuscarcomboBox;
    }
}