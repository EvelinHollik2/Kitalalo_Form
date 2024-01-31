namespace WindowsFormsApp_Kitallo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.buttonTip = new System.Windows.Forms.Button();
            this.listBoxTip = new System.Windows.Forms.ListBox();
            this.textBoxkitalalo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(311, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Találd ki a szót!";
            // 
            // textBoxTip
            // 
            this.textBoxTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTip.Location = new System.Drawing.Point(143, 195);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(129, 35);
            this.textBoxTip.TabIndex = 1;
            this.textBoxTip.TextChanged += new System.EventHandler(this.textBoxTip_TextChanged);
            // 
            // buttonTip
            // 
            this.buttonTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTip.Location = new System.Drawing.Point(328, 195);
            this.buttonTip.Name = "buttonTip";
            this.buttonTip.Size = new System.Drawing.Size(142, 33);
            this.buttonTip.TabIndex = 2;
            this.buttonTip.Text = "TIP";
            this.buttonTip.UseVisualStyleBackColor = true;
            this.buttonTip.Click += new System.EventHandler(this.buttonTip_Click);
            // 
            // listBoxTip
            // 
            this.listBoxTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxTip.FormattingEnabled = true;
            this.listBoxTip.ItemHeight = 29;
            this.listBoxTip.Location = new System.Drawing.Point(514, 146);
            this.listBoxTip.Name = "listBoxTip";
            this.listBoxTip.Size = new System.Drawing.Size(399, 207);
            this.listBoxTip.TabIndex = 3;
            // 
            // textBoxkitalalo
            // 
            this.textBoxkitalalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxkitalalo.Location = new System.Drawing.Point(143, 96);
            this.textBoxkitalalo.Name = "textBoxkitalalo";
            this.textBoxkitalalo.ReadOnly = true;
            this.textBoxkitalalo.Size = new System.Drawing.Size(129, 35);
            this.textBoxkitalalo.TabIndex = 4;
            this.textBoxkitalalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxkitalalo.TextChanged += new System.EventHandler(this.textBoxkitalalo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 492);
            this.Controls.Add(this.textBoxkitalalo);
            this.Controls.Add(this.listBoxTip);
            this.Controls.Add(this.buttonTip);
            this.Controls.Add(this.textBoxTip);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.Button buttonTip;
        private System.Windows.Forms.ListBox listBoxTip;
        private System.Windows.Forms.TextBox textBoxkitalalo;
    }
}

