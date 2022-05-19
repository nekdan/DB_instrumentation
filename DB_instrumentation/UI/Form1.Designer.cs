namespace DB_instrumentation
{
    partial class frmInstrumentation
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.instrumentsListBox = new System.Windows.Forms.ListBox();
            this.label_instruments = new System.Windows.Forms.Label();
            this.trackListBox = new System.Windows.Forms.ListBox();
            this.label_track = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.label_comment = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_save_comment = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // instrumentsListBox
            // 
            this.instrumentsListBox.FormattingEnabled = true;
            this.instrumentsListBox.ItemHeight = 20;
            this.instrumentsListBox.Location = new System.Drawing.Point(12, 65);
            this.instrumentsListBox.Name = "instrumentsListBox";
            this.instrumentsListBox.Size = new System.Drawing.Size(353, 424);
            this.instrumentsListBox.TabIndex = 2;
            // 
            // label_instruments
            // 
            this.label_instruments.AutoSize = true;
            this.label_instruments.Location = new System.Drawing.Point(23, 42);
            this.label_instruments.Name = "label_instruments";
            this.label_instruments.Size = new System.Drawing.Size(103, 20);
            this.label_instruments.TabIndex = 3;
            this.label_instruments.Text = "Инстурменты";
            this.label_instruments.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackListBox
            // 
            this.trackListBox.FormattingEnabled = true;
            this.trackListBox.ItemHeight = 20;
            this.trackListBox.Location = new System.Drawing.Point(376, 65);
            this.trackListBox.Name = "trackListBox";
            this.trackListBox.Size = new System.Drawing.Size(479, 424);
            this.trackListBox.TabIndex = 4;
            // 
            // label_track
            // 
            this.label_track.AutoSize = true;
            this.label_track.Location = new System.Drawing.Point(390, 42);
            this.label_track.Name = "label_track";
            this.label_track.Size = new System.Drawing.Size(50, 20);
            this.label_track.TabIndex = 5;
            this.label_track.Text = "Треки";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(872, 168);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(359, 120);
            this.commentTextBox.TabIndex = 6;
            this.commentTextBox.Text = "";
            // 
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.Location = new System.Drawing.Point(881, 144);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(107, 20);
            this.label_comment.TabIndex = 7;
            this.label_comment.Text = "Комментарий";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(872, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 76);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button_save_comment
            // 
            this.button_save_comment.Location = new System.Drawing.Point(1137, 294);
            this.button_save_comment.Name = "button_save_comment";
            this.button_save_comment.Size = new System.Drawing.Size(94, 29);
            this.button_save_comment.TabIndex = 9;
            this.button_save_comment.Text = "Сохранить";
            this.button_save_comment.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1243, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmInstrumentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 497);
            this.Controls.Add(this.button_save_comment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.label_track);
            this.Controls.Add(this.trackListBox);
            this.Controls.Add(this.label_instruments);
            this.Controls.Add(this.instrumentsListBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInstrumentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB instrumentation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private ListBox instrumentsListBox;
        private Label label_instruments;
        private ListBox trackListBox;
        private Label label_track;
        private RichTextBox commentTextBox;
        private Label label_comment;
        private PictureBox pictureBox1;
        private Button button_save_comment;
        private MenuStrip menuStrip1;
    }
}