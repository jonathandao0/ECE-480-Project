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
            this.probOutput = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fastbrainRuntime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.slowbrainRuntime = new System.Windows.Forms.Label();
            this.runtimeBox = new System.Windows.Forms.GroupBox();
            this.showInput = new System.Windows.Forms.TextBox();
            this.resultWindowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultWindowBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainWindowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runtimeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultWindowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultWindowBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Probability:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
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
            // probOutput
            // 
            this.probOutput.AutoSize = true;
            this.probOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.probOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.probOutput.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probOutput.ForeColor = System.Drawing.Color.Blue;
            this.probOutput.Location = new System.Drawing.Point(89, 218);
            this.probOutput.MaximumSize = new System.Drawing.Size(55, 22);
            this.probOutput.MinimumSize = new System.Drawing.Size(55, 22);
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
            this.result.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.Red;
            this.result.Location = new System.Drawing.Point(89, 245);
            this.result.MaximumSize = new System.Drawing.Size(100, 26);
            this.result.MinimumSize = new System.Drawing.Size(100, 26);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 26);
            this.result.TabIndex = 14;
            this.result.Text = "result...";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 43);
            this.button3.TabIndex = 32;
            this.button3.Text = "Back to Main Window";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.backToMain_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fast Brain:";
            // 
            // fastbrainRuntime
            // 
            this.fastbrainRuntime.AutoSize = true;
            this.fastbrainRuntime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fastbrainRuntime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fastbrainRuntime.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastbrainRuntime.ForeColor = System.Drawing.Color.Green;
            this.fastbrainRuntime.Location = new System.Drawing.Point(74, 22);
            this.fastbrainRuntime.MaximumSize = new System.Drawing.Size(55, 22);
            this.fastbrainRuntime.MinimumSize = new System.Drawing.Size(55, 22);
            this.fastbrainRuntime.Name = "fastbrainRuntime";
            this.fastbrainRuntime.Size = new System.Drawing.Size(55, 22);
            this.fastbrainRuntime.TabIndex = 34;
            this.fastbrainRuntime.Text = "runtime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Slow Brain:";
            // 
            // slowbrainRuntime
            // 
            this.slowbrainRuntime.AutoSize = true;
            this.slowbrainRuntime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.slowbrainRuntime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slowbrainRuntime.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slowbrainRuntime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.slowbrainRuntime.Location = new System.Drawing.Point(74, 42);
            this.slowbrainRuntime.MaximumSize = new System.Drawing.Size(55, 22);
            this.slowbrainRuntime.MinimumSize = new System.Drawing.Size(55, 22);
            this.slowbrainRuntime.Name = "slowbrainRuntime";
            this.slowbrainRuntime.Size = new System.Drawing.Size(55, 22);
            this.slowbrainRuntime.TabIndex = 36;
            this.slowbrainRuntime.Text = "runtime";
            // 
            // runtimeBox
            // 
            this.runtimeBox.Controls.Add(this.slowbrainRuntime);
            this.runtimeBox.Controls.Add(this.label8);
            this.runtimeBox.Controls.Add(this.fastbrainRuntime);
            this.runtimeBox.Controls.Add(this.label6);
            this.runtimeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runtimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runtimeBox.Location = new System.Drawing.Point(14, 135);
            this.runtimeBox.Name = "runtimeBox";
            this.runtimeBox.Size = new System.Drawing.Size(139, 72);
            this.runtimeBox.TabIndex = 37;
            this.runtimeBox.TabStop = false;
            this.runtimeBox.Text = "Runtime (msec):";
            // 
            // showInput
            // 
            this.showInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.showInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.showInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showInput.Location = new System.Drawing.Point(88, 13);
            this.showInput.Multiline = true;
            this.showInput.Name = "showInput";
            this.showInput.ReadOnly = true;
            this.showInput.Size = new System.Drawing.Size(212, 117);
            this.showInput.TabIndex = 38;
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
            this.ClientSize = new System.Drawing.Size(318, 289);
            this.Controls.Add(this.showInput);
            this.Controls.Add(this.runtimeBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.probOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ResultWindow";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.resultWindow_Load);
            this.runtimeBox.ResumeLayout(false);
            this.runtimeBox.PerformLayout();
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
        private System.Windows.Forms.Label probOutput;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label fastbrainRuntime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label slowbrainRuntime;
        private System.Windows.Forms.GroupBox runtimeBox;
        protected System.Windows.Forms.TextBox showInput;
    }
}