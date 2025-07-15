namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listTitle = new ListBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            button_start = new Button();
            button_stop = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // listTitle
            // 
            listTitle.FormattingEnabled = true;
            listTitle.ItemHeight = 15;
            listTitle.Location = new Point(48, 12);
            listTitle.Name = "listTitle";
            listTitle.Size = new Size(318, 454);
            listTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(397, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "StartPoint";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(397, 52);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 94);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "StopPoint";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(399, 128);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // button_start
            // 
            button_start.Location = new Point(397, 167);
            button_start.Name = "button_start";
            button_start.Size = new Size(75, 23);
            button_start.TabIndex = 5;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // button_stop
            // 
            button_stop.Location = new Point(399, 210);
            button_stop.Name = "button_stop";
            button_stop.Size = new Size(75, 23);
            button_stop.TabIndex = 6;
            button_stop.Text = "Stop";
            button_stop.UseVisualStyleBackColor = true;
            button_stop.Click += button_stop_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(button_stop);
            Controls.Add(button_start);
            Controls.Add(numericUpDown2);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(listTitle);
            Name = "Form1";
            Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listTitle;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Button button_start;
        private Button button_stop;
    }
}
