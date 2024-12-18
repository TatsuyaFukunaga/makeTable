namespace makeTable
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
            textBoxDBName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonDBConnect = new Button();
            dataGridView1 = new DataGridView();
            listBoxTableName = new ListBox();
            buttonTableConnect = new Button();
            richTextBoxDataAppend = new RichTextBox();
            buttonDataAppend = new Button();
            buttonDropData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxDBName
            // 
            textBoxDBName.Location = new Point(15, 40);
            textBoxDBName.Margin = new Padding(4, 4, 4, 4);
            textBoxDBName.Name = "textBoxDBName";
            textBoxDBName.Size = new Size(193, 31);
            textBoxDBName.TabIndex = 0;
            textBoxDBName.TextChanged += textBoxDBName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 1;
            label1.Text = "データベース名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 3;
            label2.Text = "テーブル名";
            // 
            // buttonDBConnect
            // 
            buttonDBConnect.Location = new Point(236, 40);
            buttonDBConnect.Margin = new Padding(4, 4, 4, 4);
            buttonDBConnect.Name = "buttonDBConnect";
            buttonDBConnect.Size = new Size(118, 36);
            buttonDBConnect.TabIndex = 6;
            buttonDBConnect.Text = "DB接続";
            buttonDBConnect.UseVisualStyleBackColor = true;
            buttonDBConnect.Click += buttonDBConnect_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 162);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(815, 164);
            dataGridView1.TabIndex = 7;
            // 
            // listBoxTableName
            // 
            listBoxTableName.FormattingEnabled = true;
            listBoxTableName.ItemHeight = 25;
            listBoxTableName.Location = new Point(15, 119);
            listBoxTableName.Margin = new Padding(4, 4, 4, 4);
            listBoxTableName.Name = "listBoxTableName";
            listBoxTableName.Size = new Size(194, 29);
            listBoxTableName.TabIndex = 8;
            // 
            // buttonTableConnect
            // 
            buttonTableConnect.Location = new Point(236, 119);
            buttonTableConnect.Margin = new Padding(4, 4, 4, 4);
            buttonTableConnect.Name = "buttonTableConnect";
            buttonTableConnect.Size = new Size(118, 36);
            buttonTableConnect.TabIndex = 9;
            buttonTableConnect.Text = "Table接続";
            buttonTableConnect.UseVisualStyleBackColor = true;
            buttonTableConnect.Click += buttonTableConnect_Click;
            // 
            // richTextBoxDataAppend
            // 
            richTextBoxDataAppend.Location = new Point(20, 371);
            richTextBoxDataAppend.Margin = new Padding(4, 4, 4, 4);
            richTextBoxDataAppend.Name = "richTextBoxDataAppend";
            richTextBoxDataAppend.Size = new Size(653, 212);
            richTextBoxDataAppend.TabIndex = 10;
            richTextBoxDataAppend.Text = "1001\t秋山\t男\t80\n1002\t久保田\t女\t100\n1003\t佐々木\t女\t65\n1004\t佐藤\t男\t75\n1005\t鈴木\t女\t60\n1006\t田中\t男\t90\n1007\t土屋\t女\t55";
            // 
            // buttonDataAppend
            // 
            buttonDataAppend.Location = new Point(739, 471);
            buttonDataAppend.Margin = new Padding(4, 4, 4, 4);
            buttonDataAppend.Name = "buttonDataAppend";
            buttonDataAppend.Size = new Size(118, 36);
            buttonDataAppend.TabIndex = 11;
            buttonDataAppend.Text = "Data追加";
            buttonDataAppend.UseVisualStyleBackColor = true;
            buttonDataAppend.Click += buttonDataAppend_Click;
            // 
            // buttonDropData
            // 
            buttonDropData.Location = new Point(838, 235);
            buttonDropData.Margin = new Padding(4, 4, 4, 4);
            buttonDropData.Name = "buttonDropData";
            buttonDropData.Size = new Size(118, 36);
            buttonDropData.TabIndex = 12;
            buttonDropData.Text = "Data削除";
            buttonDropData.UseVisualStyleBackColor = true;
            buttonDropData.Click += buttonDropData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 650);
            Controls.Add(buttonDropData);
            Controls.Add(buttonDataAppend);
            Controls.Add(richTextBoxDataAppend);
            Controls.Add(buttonTableConnect);
            Controls.Add(listBoxTableName);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDBConnect);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDBName);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDBName;
        private Label label1;
        private Label label2;
        private Button buttonDBConnect;
        private DataGridView dataGridView1;
        private ListBox listBoxTableName;
        private Button buttonTableConnect;
        private RichTextBox richTextBoxDataAppend;
        private Button buttonDataAppend;
        private Button buttonDropData;
    }
}
