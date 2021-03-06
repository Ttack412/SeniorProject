
namespace Word_Search
{
    partial class Form6
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.wordSearchView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.hill = new System.Windows.Forms.ColumnHeader();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(151, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 29;
            this.button1.Text = "Submit Word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(151, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 32);
            this.button3.TabIndex = 28;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 32);
            this.button2.TabIndex = 26;
            this.button2.Text = "Complete Word Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(291, 12);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(115, 364);
            this.checkedListBox.TabIndex = 25;
            // 
            // wordSearchView
            // 
            this.wordSearchView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.hill});
            this.wordSearchView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wordSearchView.HideSelection = false;
            this.wordSearchView.Location = new System.Drawing.Point(12, 12);
            this.wordSearchView.Name = "wordSearchView";
            this.wordSearchView.Size = new System.Drawing.Size(273, 262);
            this.wordSearchView.TabIndex = 24;
            this.wordSearchView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ColumnHeader";
            // 
            // btnInstructions
            // 
            this.btnInstructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInstructions.Location = new System.Drawing.Point(11, 280);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(134, 32);
            this.btnInstructions.TabIndex = 30;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(11, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 32);
            this.button4.TabIndex = 31;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 396);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.wordSearchView);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.ListView wordSearchView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader hill;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button button4;
    }
}