namespace Memory_Mapped_File_Viewer_Tool
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            FileName = new TextBox();
            OutputBox = new RichTextBox();
            button2 = new Button();
            CharCount = new Label();
            LoopReadTimer = new System.Windows.Forms.Timer(components);
            LoopReadCheckBox = new CheckBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 512);
            label1.Name = "label1";
            label1.Size = new Size(352, 25);
            label1.TabIndex = 0;
            label1.Text = "Memory Mapped File Viewer  By: Tracer755";
            // 
            // button1
            // 
            button1.Location = new Point(1070, 512);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CloseApplication;
            // 
            // FileName
            // 
            FileName.BackColor = Color.Black;
            FileName.ForeColor = Color.White;
            FileName.Location = new Point(12, 12);
            FileName.Name = "FileName";
            FileName.PlaceholderText = "Memory Mapped File Name";
            FileName.Size = new Size(366, 31);
            FileName.TabIndex = 2;
            // 
            // OutputBox
            // 
            OutputBox.BackColor = Color.Black;
            OutputBox.ForeColor = Color.White;
            OutputBox.Location = new Point(12, 49);
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(1170, 455);
            OutputBox.TabIndex = 3;
            OutputBox.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(952, 512);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Read File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CharCount
            // 
            CharCount.AutoSize = true;
            CharCount.ForeColor = Color.White;
            CharCount.Location = new Point(370, 512);
            CharCount.Name = "CharCount";
            CharCount.Size = new Size(0, 25);
            CharCount.TabIndex = 5;
            // 
            // LoopReadTimer
            // 
            LoopReadTimer.Tick += LoopReadTimerTick;
            // 
            // LoopReadCheckBox
            // 
            LoopReadCheckBox.AutoSize = true;
            LoopReadCheckBox.ImageAlign = ContentAlignment.TopCenter;
            LoopReadCheckBox.Location = new Point(832, 520);
            LoopReadCheckBox.Name = "LoopReadCheckBox";
            LoopReadCheckBox.Size = new Size(22, 21);
            LoopReadCheckBox.TabIndex = 6;
            LoopReadCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(860, 517);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 7;
            label2.Text = "Live Read";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1194, 558);
            Controls.Add(label2);
            Controls.Add(LoopReadCheckBox);
            Controls.Add(CharCount);
            Controls.Add(button2);
            Controls.Add(OutputBox);
            Controls.Add(FileName);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Tracer755's Memory Mapped File Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox FileName;
        private RichTextBox OutputBox;
        private Button button2;
        private Label CharCount;
        private System.Windows.Forms.Timer LoopReadTimer;
        private CheckBox LoopReadCheckBox;
        private Label label2;
    }
}