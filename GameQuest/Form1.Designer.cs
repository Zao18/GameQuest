namespace GameQuest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Button btnNext;
        private Button btnPrevious;
        private Button btnShowAll;

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
            btnNext = new Button();
            btnPrevious = new Button();
            btnShowAll = new Button();
            txt1 = new TextBox();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.ActiveCaption;
            btnNext.Location = new Point(521, 293);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 36);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = SystemColors.ActiveCaption;
            btnPrevious.Location = new Point(184, 293);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(104, 36);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Back";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = SystemColors.ActiveCaption;
            btnShowAll.Location = new Point(352, 293);
            btnShowAll.Margin = new Padding(2);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(104, 36);
            btnShowAll.TabIndex = 2;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // txt1
            // 
            txt1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt1.Location = new Point(50, 30);
            txt1.Multiline = true;
            txt1.Name = "txt1";
            txt1.ScrollBars = ScrollBars.Vertical;
            txt1.Size = new Size(700, 220);
            txt1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(txt1);
            Controls.Add(btnShowAll);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
    }
}