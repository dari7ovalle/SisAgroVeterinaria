namespace SisAgroVeterinaria.Consultas
{
    partial class cProductos
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
            this.ProductodataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.BuscarcomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductodataGridView1
            // 
            this.ProductodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductodataGridView1.Location = new System.Drawing.Point(23, 112);
            this.ProductodataGridView1.Name = "ProductodataGridView1";
            this.ProductodataGridView1.Size = new System.Drawing.Size(647, 270);
            this.ProductodataGridView1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(159, 53);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(411, 20);
            this.BuscartextBox.TabIndex = 13;
            // 
            // BuscarcomboBox
            // 
            this.BuscarcomboBox.FormattingEnabled = true;
            this.BuscarcomboBox.Items.AddRange(new object[] {
            "Id",
            "Nombre"});
            this.BuscarcomboBox.Location = new System.Drawing.Point(23, 52);
            this.BuscarcomboBox.Name = "BuscarcomboBox";
            this.BuscarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.BuscarcomboBox.TabIndex = 12;
            // 
            // cProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 432);
            this.Controls.Add(this.ProductodataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.BuscarcomboBox);
            this.Name = "cProductos";
            this.Text = "cProductos";
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductodataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.ComboBox BuscarcomboBox;
    }
}