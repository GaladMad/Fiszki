namespace Fiszki.View
{
    partial class Editor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveListButton = new System.Windows.Forms.Button();
            this.ListDataGridView = new System.Windows.Forms.DataGridView();
            this.EnglishColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolishColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButtonF = new System.Windows.Forms.Button();
            this.EditorListcomboBox = new System.Windows.Forms.ComboBox();
            this.AddListButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.RemoveListButton);
            this.panel1.Controls.Add(this.ListDataGridView);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.CancelButtonF);
            this.panel1.Controls.Add(this.EditorListcomboBox);
            this.panel1.Controls.Add(this.AddListButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 493);
            this.panel1.TabIndex = 0;
            // 
            // RemoveListButton
            // 
            this.RemoveListButton.Location = new System.Drawing.Point(180, 12);
            this.RemoveListButton.Name = "RemoveListButton";
            this.RemoveListButton.Size = new System.Drawing.Size(100, 30);
            this.RemoveListButton.TabIndex = 5;
            this.RemoveListButton.Text = "Remove list";
            this.RemoveListButton.UseVisualStyleBackColor = true;
            this.RemoveListButton.Click += new System.EventHandler(this.RemoveListButton_Click);
            // 
            // ListDataGridView
            // 
            this.ListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnglishColumn,
            this.PolishColumn});
            this.ListDataGridView.Location = new System.Drawing.Point(30, 50);
            this.ListDataGridView.Name = "ListDataGridView";
            this.ListDataGridView.RowHeadersVisible = false;
            this.ListDataGridView.RowTemplate.Height = 24;
            this.ListDataGridView.Size = new System.Drawing.Size(370, 340);
            this.ListDataGridView.TabIndex = 4;
            // 
            // EnglishColumn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EnglishColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.EnglishColumn.HeaderText = "English";
            this.EnglishColumn.MaxInputLength = 100;
            this.EnglishColumn.Name = "EnglishColumn";
            this.EnglishColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EnglishColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PolishColumn
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PolishColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.PolishColumn.HeaderText = "Polish";
            this.PolishColumn.MaxInputLength = 100;
            this.PolishColumn.Name = "PolishColumn";
            this.PolishColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PolishColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(250, 410);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 30);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButtonF
            // 
            this.CancelButtonF.Location = new System.Drawing.Point(30, 410);
            this.CancelButtonF.Name = "CancelButtonF";
            this.CancelButtonF.Size = new System.Drawing.Size(150, 30);
            this.CancelButtonF.TabIndex = 2;
            this.CancelButtonF.Text = "Cancel";
            this.CancelButtonF.UseVisualStyleBackColor = true;
            this.CancelButtonF.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditorListcomboBox
            // 
            this.EditorListcomboBox.FormattingEnabled = true;
            this.EditorListcomboBox.Location = new System.Drawing.Point(31, 12);
            this.EditorListcomboBox.Name = "EditorListcomboBox";
            this.EditorListcomboBox.Size = new System.Drawing.Size(121, 24);
            this.EditorListcomboBox.TabIndex = 1;
            this.EditorListcomboBox.Text = "Choose a list";
            this.EditorListcomboBox.SelectedIndexChanged += new System.EventHandler(this.EditorListcomboBox_Click);
            // 
            // AddListButton
            // 
            this.AddListButton.Location = new System.Drawing.Point(300, 12);
            this.AddListButton.Name = "AddListButton";
            this.AddListButton.Size = new System.Drawing.Size(100, 30);
            this.AddListButton.TabIndex = 0;
            this.AddListButton.Text = "Add list";
            this.AddListButton.UseVisualStyleBackColor = true;
            this.AddListButton.Click += new System.EventHandler(this.AddListButton_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 493);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddListButton;
        private System.Windows.Forms.ComboBox EditorListcomboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButtonF;
        private System.Windows.Forms.DataGridView ListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolishColumn;
        private System.Windows.Forms.Button RemoveListButton;
    }
}