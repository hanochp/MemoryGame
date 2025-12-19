namespace MemoryGame
{
    partial class MemoryGame
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
            tblMain = new TableLayoutPanel();
            lblTurnsTaken = new Label();
            btnStart = new Button();
            btnRestart = new Button();
            lblSetsFound = new Label();
            tblOutput = new TableLayoutPanel();
            pictureBox15 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tblMain.SuspendLayout();
            tblOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.Controls.Add(lblTurnsTaken, 2, 0);
            tblMain.Controls.Add(btnStart, 0, 0);
            tblMain.Controls.Add(btnRestart, 1, 0);
            tblMain.Controls.Add(lblSetsFound, 3, 0);
            tblMain.Controls.Add(tblOutput, 0, 1);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 99.99999F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 657F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(989, 726);
            tblMain.TabIndex = 0;
            // 
            // lblTurnsTaken
            // 
            lblTurnsTaken.Anchor = AnchorStyles.None;
            lblTurnsTaken.BackColor = Color.Coral;
            lblTurnsTaken.BorderStyle = BorderStyle.Fixed3D;
            lblTurnsTaken.Font = new Font("Lucida Sans", 18F);
            lblTurnsTaken.Location = new Point(519, 12);
            lblTurnsTaken.Name = "lblTurnsTaken";
            lblTurnsTaken.Size = new Size(196, 44);
            lblTurnsTaken.TabIndex = 6;
            lblTurnsTaken.Text = "Turns Taken: 0";
            lblTurnsTaken.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.None;
            btnStart.BackColor = Color.PaleGreen;
            btnStart.Font = new Font("Lucida Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(35, 8);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(176, 52);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // btnRestart
            // 
            btnRestart.Anchor = AnchorStyles.None;
            btnRestart.BackColor = Color.Coral;
            btnRestart.Font = new Font("Lucida Sans", 18F);
            btnRestart.ForeColor = SystemColors.ControlText;
            btnRestart.Location = new Point(282, 8);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(176, 52);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            // 
            // lblSetsFound
            // 
            lblSetsFound.Anchor = AnchorStyles.None;
            lblSetsFound.BackColor = Color.PaleGreen;
            lblSetsFound.BorderStyle = BorderStyle.Fixed3D;
            lblSetsFound.Font = new Font("Lucida Sans", 18F);
            lblSetsFound.Location = new Point(767, 12);
            lblSetsFound.Name = "lblSetsFound";
            lblSetsFound.Size = new Size(196, 44);
            lblSetsFound.TabIndex = 3;
            lblSetsFound.Text = "Sets Found: 0";
            lblSetsFound.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblOutput
            // 
            tblOutput.ColumnCount = 5;
            tblMain.SetColumnSpan(tblOutput, 4);
            tblOutput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblOutput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblOutput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblOutput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblOutput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblOutput.Controls.Add(pictureBox15, 4, 2);
            tblOutput.Controls.Add(pictureBox14, 3, 2);
            tblOutput.Controls.Add(pictureBox13, 2, 2);
            tblOutput.Controls.Add(pictureBox12, 1, 2);
            tblOutput.Controls.Add(pictureBox11, 0, 2);
            tblOutput.Controls.Add(pictureBox10, 4, 1);
            tblOutput.Controls.Add(pictureBox9, 3, 1);
            tblOutput.Controls.Add(pictureBox8, 2, 1);
            tblOutput.Controls.Add(pictureBox7, 1, 1);
            tblOutput.Controls.Add(pictureBox6, 0, 1);
            tblOutput.Controls.Add(pictureBox5, 4, 0);
            tblOutput.Controls.Add(pictureBox4, 3, 0);
            tblOutput.Controls.Add(pictureBox3, 2, 0);
            tblOutput.Controls.Add(pictureBox2, 1, 0);
            tblOutput.Controls.Add(pictureBox1, 0, 0);
            tblOutput.Dock = DockStyle.Fill;
            tblOutput.Location = new Point(3, 72);
            tblOutput.Name = "tblOutput";
            tblOutput.RowCount = 3;
            tblOutput.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblOutput.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblOutput.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblOutput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblOutput.Size = new Size(983, 651);
            tblOutput.TabIndex = 4;
            // 
            // pictureBox15
            // 
            pictureBox15.BorderStyle = BorderStyle.Fixed3D;
            pictureBox15.Dock = DockStyle.Fill;
            pictureBox15.Location = new Point(787, 437);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(193, 211);
            pictureBox15.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox15.TabIndex = 14;
            pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.BorderStyle = BorderStyle.Fixed3D;
            pictureBox14.Dock = DockStyle.Fill;
            pictureBox14.Location = new Point(591, 437);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(190, 211);
            pictureBox14.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox14.TabIndex = 13;
            pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BorderStyle = BorderStyle.Fixed3D;
            pictureBox13.Dock = DockStyle.Fill;
            pictureBox13.Location = new Point(395, 437);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(190, 211);
            pictureBox13.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox13.TabIndex = 12;
            pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BorderStyle = BorderStyle.Fixed3D;
            pictureBox12.Dock = DockStyle.Fill;
            pictureBox12.Location = new Point(199, 437);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(190, 211);
            pictureBox12.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox12.TabIndex = 11;
            pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BorderStyle = BorderStyle.Fixed3D;
            pictureBox11.Dock = DockStyle.Fill;
            pictureBox11.Location = new Point(3, 437);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(190, 211);
            pictureBox11.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox11.TabIndex = 10;
            pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BorderStyle = BorderStyle.Fixed3D;
            pictureBox10.Dock = DockStyle.Fill;
            pictureBox10.Location = new Point(787, 220);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(193, 211);
            pictureBox10.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox10.TabIndex = 9;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BorderStyle = BorderStyle.Fixed3D;
            pictureBox9.Dock = DockStyle.Fill;
            pictureBox9.Location = new Point(591, 220);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(190, 211);
            pictureBox9.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox9.TabIndex = 8;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BorderStyle = BorderStyle.Fixed3D;
            pictureBox8.Dock = DockStyle.Fill;
            pictureBox8.Location = new Point(395, 220);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(190, 211);
            pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BorderStyle = BorderStyle.Fixed3D;
            pictureBox7.Dock = DockStyle.Fill;
            pictureBox7.Location = new Point(199, 220);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(190, 211);
            pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Location = new Point(3, 220);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(190, 211);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Location = new Point(787, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(193, 211);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Location = new Point(591, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(190, 211);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(395, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(190, 211);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(199, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MemoryGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 726);
            Controls.Add(tblMain);
            Name = "MemoryGame";
            Text = "Memory Game";
            tblMain.ResumeLayout(false);
            tblOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblSetsFound;
        private Button btnStart;
        private Button btnRestart;
        private TableLayoutPanel tblOutput;
        private PictureBox pictureBox15;
        private PictureBox pictureBox14;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblTurnsTaken;
    }
}
