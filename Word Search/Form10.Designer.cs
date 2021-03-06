
namespace Word_Search
{
    partial class Form10
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.wordSearchView = new System.Windows.Forms.ListView();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordSearchView
            // 
            this.wordSearchView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wordSearchView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.wordSearchView.HideSelection = false;
            this.wordSearchView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.wordSearchView.Location = new System.Drawing.Point(12, 12);
            this.wordSearchView.Name = "wordSearchView";
            this.wordSearchView.Size = new System.Drawing.Size(452, 426);
            this.wordSearchView.TabIndex = 0;
            this.wordSearchView.UseCompatibleStateImageBehavior = false;
            // 
            // checkedListBox
            // 
            this.checkedListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(470, 12);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(119, 508);
            this.checkedListBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit Word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(243, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Complete Word Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(318, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInstructions.Location = new System.Drawing.Point(12, 489);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(146, 40);
            this.btnInstructions.TabIndex = 6;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(164, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 541);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.wordSearchView);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ListView wordSearchView;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button button4;
    }
}

