namespace DemoLanguageDetect
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.probOutput = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Probability:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result:";
            // 
            // probOutput
            // 
            this.probOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.probOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.probOutput.Enabled = false;
            this.probOutput.Location = new System.Drawing.Point(103, 170);
            this.probOutput.Name = "probOutput";
            this.probOutput.Size = new System.Drawing.Size(123, 22);
            this.probOutput.TabIndex = 6;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.result.Enabled = false;
            this.result.ForeColor = System.Drawing.SystemColors.WindowText;
            this.result.Location = new System.Drawing.Point(103, 198);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(123, 22);
            this.result.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "String Input:";
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inputText.Enabled = false;
            this.inputText.Location = new System.Drawing.Point(103, 21);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(256, 140);
            this.inputText.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.ClientSize = new System.Drawing.Size(365, 262);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.probOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox probOutput;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputText;
    }
}