
namespace AmIpositive
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputIntager = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(70, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input an integer";
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(73, 165);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(183, 65);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = " ";
            // 
            // inputIntager
            // 
            this.inputIntager.Location = new System.Drawing.Point(176, 81);
            this.inputIntager.Name = "inputIntager";
            this.inputIntager.Size = new System.Drawing.Size(80, 20);
            this.inputIntager.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputIntager);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Am I Positive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputIntager;
        private System.Windows.Forms.Button button1;
    }
}

