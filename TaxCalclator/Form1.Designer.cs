namespace TaxCalclator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnSrch = new Button();
            label1 = new Label();
            DayClcGrid = new DataGridView();
            BtnAdd = new Button();
            ViewAllBtn = new Button();
            AddTextBox = new TextBox();
            AddDateTime = new DateTimePicker();
            DayDateTime = new DateTimePicker();
            AllClcGrid = new DataGridView();
            label2 = new Label();
            AllclcText = new Label();
            ContentLable = new Label();
            resontext = new TextBox();
            label3 = new Label();
            button1 = new Button();
            DeleteText = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DayClcGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllClcGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnSrch
            // 
            BtnSrch.Cursor = Cursors.Hand;
            BtnSrch.FlatStyle = FlatStyle.Popup;
            BtnSrch.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold);
            BtnSrch.Location = new Point(771, 69);
            BtnSrch.Name = "BtnSrch";
            BtnSrch.Size = new Size(129, 44);
            BtnSrch.TabIndex = 0;
            BtnSrch.Text = "Search";
            BtnSrch.UseVisualStyleBackColor = true;
            BtnSrch.Click += BtnSrch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 41);
            label1.TabIndex = 1;
            label1.Text = "Expense calculator";
            // 
            // DayClcGrid
            // 
            DayClcGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DayClcGrid.Location = new Point(515, 119);
            DayClcGrid.Name = "DayClcGrid";
            DayClcGrid.RowHeadersWidth = 51;
            DayClcGrid.Size = new Size(379, 355);
            DayClcGrid.TabIndex = 2;
            // 
            // BtnAdd
            // 
            BtnAdd.Cursor = Cursors.Hand;
            BtnAdd.FlatStyle = FlatStyle.Popup;
            BtnAdd.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold);
            BtnAdd.Location = new Point(233, 134);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(144, 56);
            BtnAdd.TabIndex = 3;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // ViewAllBtn
            // 
            ViewAllBtn.Cursor = Cursors.Hand;
            ViewAllBtn.FlatStyle = FlatStyle.Popup;
            ViewAllBtn.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewAllBtn.Location = new Point(265, 227);
            ViewAllBtn.Name = "ViewAllBtn";
            ViewAllBtn.Size = new Size(130, 41);
            ViewAllBtn.TabIndex = 4;
            ViewAllBtn.Text = "view all";
            ViewAllBtn.UseVisualStyleBackColor = true;
            ViewAllBtn.Click += ViewAllBtn_Click;
            // 
            // AddTextBox
            // 
            AddTextBox.Location = new Point(12, 163);
            AddTextBox.Name = "AddTextBox";
            AddTextBox.Size = new Size(107, 27);
            AddTextBox.TabIndex = 6;
            AddTextBox.TextChanged += AddTextBox_TextChanged;
            // 
            // AddDateTime
            // 
            AddDateTime.Location = new Point(3, 69);
            AddDateTime.Name = "AddDateTime";
            AddDateTime.Size = new Size(250, 27);
            AddDateTime.TabIndex = 7;
            // 
            // DayDateTime
            // 
            DayDateTime.Location = new Point(515, 40);
            DayDateTime.Name = "DayDateTime";
            DayDateTime.Size = new Size(250, 27);
            DayDateTime.TabIndex = 8;
            // 
            // AllClcGrid
            // 
            AllClcGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllClcGrid.Location = new Point(12, 274);
            AllClcGrid.Name = "AllClcGrid";
            AllClcGrid.RowHeadersWidth = 51;
            AllClcGrid.Size = new Size(304, 200);
            AllClcGrid.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 193);
            label2.Name = "label2";
            label2.Size = new Size(389, 31);
            label2.TabIndex = 10;
            label2.Text = "The total amount of disbursement:";
            // 
            // AllclcText
            // 
            AllclcText.AutoSize = true;
            AllclcText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AllclcText.ForeColor = SystemColors.ActiveCaption;
            AllclcText.Location = new Point(12, 229);
            AllclcText.Name = "AllclcText";
            AllclcText.Size = new Size(0, 31);
            AllclcText.TabIndex = 11;
            // 
            // ContentLable
            // 
            ContentLable.AutoSize = true;
            ContentLable.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ContentLable.ForeColor = SystemColors.ActiveCaption;
            ContentLable.Location = new Point(293, 58);
            ContentLable.Name = "ContentLable";
            ContentLable.Size = new Size(0, 28);
            ContentLable.TabIndex = 12;
            // 
            // resontext
            // 
            resontext.Location = new Point(12, 134);
            resontext.Name = "resontext";
            resontext.Size = new Size(196, 27);
            resontext.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 99);
            label3.Name = "label3";
            label3.Size = new Size(196, 28);
            label3.TabIndex = 14;
            label3.Text = "Reson And Expense";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold);
            button1.Location = new Point(771, 10);
            button1.Name = "button1";
            button1.Size = new Size(129, 44);
            button1.TabIndex = 15;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DeleteText
            // 
            DeleteText.Location = new Point(658, 12);
            DeleteText.Name = "DeleteText";
            DeleteText.Size = new Size(107, 27);
            DeleteText.TabIndex = 16;
            DeleteText.TextChanged += DeleteText_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(548, 9);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 17;
            label4.Text = "Select Id :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(716, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 486);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(DeleteText);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(resontext);
            Controls.Add(ContentLable);
            Controls.Add(AllclcText);
            Controls.Add(label2);
            Controls.Add(AllClcGrid);
            Controls.Add(DayDateTime);
            Controls.Add(AddDateTime);
            Controls.Add(AddTextBox);
            Controls.Add(ViewAllBtn);
            Controls.Add(BtnAdd);
            Controls.Add(DayClcGrid);
            Controls.Add(label1);
            Controls.Add(BtnSrch);
            Name = "Form1";
            Text = "Expense Calclaitor";
            ((System.ComponentModel.ISupportInitialize)DayClcGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllClcGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSrch;
        private Label label1;
        private DataGridView DayClcGrid;
        private Button BtnAdd;
        private Button ViewAllBtn;
        private TextBox AddTextBox;
        private DateTimePicker AddDateTime;
        private DateTimePicker DayDateTime;
        private DataGridView AllClcGrid;
        private Label label2;
        private Label AllclcText;
        private Label ContentLable;
        private TextBox resontext;
        private Label label3;
        private Button button1;
        private TextBox DeleteText;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
