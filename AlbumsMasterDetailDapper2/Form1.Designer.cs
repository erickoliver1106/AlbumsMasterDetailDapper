namespace AlbumsMasterDetailDapper2
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtReleaseDate = new DateTimePicker();
            txtAuthor = new TextBox();
            label2 = new Label();
            txtAlbumName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSongAdd = new Button();
            txtMinutes = new TextBox();
            label5 = new Label();
            txtSongName = new TextBox();
            label4 = new Label();
            grdSongs = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSongs).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtReleaseDate);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAlbumName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(42, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(955, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Album";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(524, 25);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "Release Date";
            // 
            // txtReleaseDate
            // 
            txtReleaseDate.Location = new Point(620, 22);
            txtReleaseDate.Name = "txtReleaseDate";
            txtReleaseDate.Size = new Size(218, 23);
            txtReleaseDate.TabIndex = 4;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(102, 83);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(233, 23);
            txtAuthor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 86);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Author";
            // 
            // txtAlbumName
            // 
            txtAlbumName.Location = new Point(102, 22);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.Size = new Size(233, 23);
            txtAlbumName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 25);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSongAdd);
            groupBox2.Controls.Add(txtMinutes);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSongName);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(42, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(955, 141);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Song";
            // 
            // btnSongAdd
            // 
            btnSongAdd.Location = new Point(417, 62);
            btnSongAdd.Name = "btnSongAdd";
            btnSongAdd.Size = new Size(75, 23);
            btnSongAdd.TabIndex = 4;
            btnSongAdd.Text = "Add";
            btnSongAdd.UseVisualStyleBackColor = true;
            btnSongAdd.Click += btnSongAdd_Click;
            // 
            // txtMinutes
            // 
            txtMinutes.Location = new Point(102, 96);
            txtMinutes.Name = "txtMinutes";
            txtMinutes.Size = new Size(233, 23);
            txtMinutes.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 99);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 8;
            label5.Text = "Minutes";
            // 
            // txtSongName
            // 
            txtSongName.Location = new Point(102, 37);
            txtSongName.Name = "txtSongName";
            txtSongName.Size = new Size(233, 23);
            txtSongName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 40);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Name";
            // 
            // grdSongs
            // 
            grdSongs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSongs.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            grdSongs.Location = new Point(42, 343);
            grdSongs.Name = "grdSongs";
            grdSongs.Size = new Size(955, 263);
            grdSongs.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Name";
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Minutes";
            Column2.HeaderText = "Minutes";
            Column2.Name = "Column2";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(916, 620);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 651);
            Controls.Add(btnSave);
            Controls.Add(grdSongs);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdSongs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private DateTimePicker txtReleaseDate;
        private TextBox txtAuthor;
        private Label label2;
        private TextBox txtAlbumName;
        private Label label1;
        private TextBox txtMinutes;
        private Label label5;
        private TextBox txtSongName;
        private Label label4;
        private DataGridView grdSongs;
        private Button btnSave;
        private Button btnSongAdd;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
