namespace ECE_480_Project
{
    partial class ResultWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.Label();
            this.probOutput = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.resultWindowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultWindowBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainWindowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resultWindowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultWindowBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Probability:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "String Input:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.input.Cursor = System.Windows.Forms.Cursors.Default;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(87, 17);
            this.input.MaximumSize = new System.Drawing.Size(193, 114);
            this.input.MinimumSize = new System.Drawing.Size(193, 114);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(193, 114);
            this.input.TabIndex = 12;
            this.input.Text = "input...";
            // 
            // probOutput
            // 
            this.probOutput.AutoSize = true;
            this.probOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.probOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.probOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probOutput.ForeColor = System.Drawing.Color.Blue;
            this.probOutput.Location = new System.Drawing.Point(87, 145);
            this.probOutput.Name = "probOutput";
            this.probOutput.Size = new System.Drawing.Size(55, 22);
            this.probOutput.TabIndex = 13;
            this.probOutput.Text = "prob...";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.Red;
            this.result.Location = new System.Drawing.Point(87, 174);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(68, 23);
            this.result.TabIndex = 14;
            this.result.Text = "result...";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 43);
            this.button3.TabIndex = 32;
            this.button3.Text = "Back to Main Window";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.backToMain_Click);
            // 
            // resultWindowBindingSource
            // 
            this.resultWindowBindingSource.DataSource = typeof(ECE_480_Project.ResultWindow);
            // 
            // resultWindowBindingSource1
            // 
            this.resultWindowBindingSource1.DataSource = typeof(ECE_480_Project.ResultWindow);
            // 
            // mainWindowBindingSource
            // 
            this.mainWindowBindingSource.DataSource = typeof(ECE_480_Project.mainWindow);
            // 
            // ResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.ClientSize = new System.Drawing.Size(300, 224);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.probOutput);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ResultWindow";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.resultWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultWindowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultWindowBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource resultWindowBindingSource;
        private System.Windows.Forms.BindingSource resultWindowBindingSource1;
        private System.Windows.Forms.BindingSource mainWindowBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label input;
        private System.Windows.Forms.Label probOutput;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button3;
    }
}