namespace Inspector
{
    partial class Settings_form
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
            this.Measurements_path = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Measurements_path
            // 
            this.Measurements_path.Location = new System.Drawing.Point(24, 25);
            this.Measurements_path.Name = "Measurements_path";
            this.Measurements_path.Size = new System.Drawing.Size(174, 23);
            this.Measurements_path.TabIndex = 0;
            this.Measurements_path.Text = "selecteaza folderul cu masuratori";
            this.Measurements_path.UseVisualStyleBackColor = true;
            this.Measurements_path.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Measurements_path);
            this.Name = "Settings_form";
            this.Text = "Settings_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Measurements_path;
    }
}