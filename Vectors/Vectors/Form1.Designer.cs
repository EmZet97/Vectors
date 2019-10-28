namespace Vectors
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.VectorsComboBox = new System.Windows.Forms.ComboBox();
            this.Vector2ComboBox = new System.Windows.Forms.ComboBox();
            this.VectorProductButton = new System.Windows.Forms.Button();
            this.ScalarProductButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VectorsComboBox
            // 
            this.VectorsComboBox.FormattingEnabled = true;
            this.VectorsComboBox.Location = new System.Drawing.Point(278, 208);
            this.VectorsComboBox.Name = "VectorsComboBox";
            this.VectorsComboBox.Size = new System.Drawing.Size(204, 21);
            this.VectorsComboBox.TabIndex = 0;
            this.VectorsComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Vector2ComboBox
            // 
            this.Vector2ComboBox.FormattingEnabled = true;
            this.Vector2ComboBox.Location = new System.Drawing.Point(278, 244);
            this.Vector2ComboBox.Name = "Vector2ComboBox";
            this.Vector2ComboBox.Size = new System.Drawing.Size(204, 21);
            this.Vector2ComboBox.TabIndex = 1;
            // 
            // VectorProductButton
            // 
            this.VectorProductButton.Location = new System.Drawing.Point(387, 281);
            this.VectorProductButton.Name = "VectorProductButton";
            this.VectorProductButton.Size = new System.Drawing.Size(95, 23);
            this.VectorProductButton.TabIndex = 2;
            this.VectorProductButton.Text = "Vector Product";
            this.VectorProductButton.UseVisualStyleBackColor = true;
            this.VectorProductButton.Click += new System.EventHandler(this.VectorProductButton_Click);
            // 
            // ScalarProductButton
            // 
            this.ScalarProductButton.Location = new System.Drawing.Point(278, 281);
            this.ScalarProductButton.Name = "ScalarProductButton";
            this.ScalarProductButton.Size = new System.Drawing.Size(94, 23);
            this.ScalarProductButton.TabIndex = 3;
            this.ScalarProductButton.Text = "Scalar Product";
            this.ScalarProductButton.UseVisualStyleBackColor = true;
            this.ScalarProductButton.Click += new System.EventHandler(this.ScalarProductButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(278, 390);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(204, 20);
            this.textBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.ScalarProductButton);
            this.Controls.Add(this.VectorProductButton);
            this.Controls.Add(this.Vector2ComboBox);
            this.Controls.Add(this.VectorsComboBox);
            this.Name = "Form1";
            this.Text = "Vectors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VectorsComboBox;
        private System.Windows.Forms.ComboBox Vector2ComboBox;
        private System.Windows.Forms.Button VectorProductButton;
        private System.Windows.Forms.Button ScalarProductButton;
        private System.Windows.Forms.TextBox textBox;
    }
}

