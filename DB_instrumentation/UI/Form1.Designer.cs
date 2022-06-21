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
            this.components = new System.ComponentModel.Container();
            this.categoriesСomboBox = new System.Windows.Forms.ComboBox();
            this.instrumentsListBox = new System.Windows.Forms.ListBox();
            this.label_instruments = new System.Windows.Forms.Label();
            this.trackListBox = new System.Windows.Forms.ListBox();
            this.label_track = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.label_comment = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_save_comment = new System.Windows.Forms.Button();
            this.soundDatasGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoundId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubsoundId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sound_Base64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundDatasGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriesСomboBox
            // 
            this.categoriesСomboBox.DataSource = _categoriesManager.GetAll();
            this.categoriesСomboBox.DisplayMember = "Name";
            this.categoriesСomboBox.ValueMember = "Id";
            this.categoriesСomboBox.FormattingEnabled = true;
            this.categoriesСomboBox.Location = new System.Drawing.Point(11, 5);
            this.categoriesСomboBox.Name = "categoriesСomboBox";
            this.categoriesСomboBox.Size = new System.Drawing.Size(151, 28);
            this.categoriesСomboBox.TabIndex = 1;
            this.categoriesСomboBox.SelectedIndexChanged += categoriesСomboBox_SelectedIndexChanged;
            // 
            // instrumentsListBox
            // 
            this.instrumentsListBox.FormattingEnabled = true;
            this.instrumentsListBox.ItemHeight = 20;
            this.instrumentsListBox.Location = new System.Drawing.Point(12, 65);
            this.instrumentsListBox.Name = "instrumentsListBox";
            this.instrumentsListBox.Size = new System.Drawing.Size(353, 424);
            this.instrumentsListBox.TabIndex = 2;
            this.instrumentsListBox.DisplayMember = "Name";
            this.instrumentsListBox.ValueMember = "Id";
            this.instrumentsListBox.SelectedIndexChanged += instrumentsListBox_SelectedIndexChanged;
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
            this.trackListBox.DisplayMember = "Name";
            this.trackListBox.ValueMember = "Id";
            //this.trackListBox.DataSource = _soundsManager.GetAll();
            this.trackListBox.SelectedIndexChanged += trackListBox_SelectedIndexChanged;
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
            this.button_save_comment.Click += new System.EventHandler(this.button_save_comment_Click);
            // 
            // soundDatasGridView
            // 
            this.soundDatasGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.soundDatasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soundDatasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Comment,
            this.SoundId,
            this.SubsoundId,
            this.Sound_Base64});
            this.soundDatasGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.soundDatasGridView.Location = new System.Drawing.Point(12, 509);
            this.soundDatasGridView.Name = "soundDatasGridView";
            this.soundDatasGridView.RowHeadersWidth = 51;
            this.soundDatasGridView.RowTemplate.Height = 29;
            this.soundDatasGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.soundDatasGridView.Size = new System.Drawing.Size(1219, 106);
            this.soundDatasGridView.TabIndex = 11;
            this.soundDatasGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.soundDatasGridView_CellContentClick);
            this.soundDatasGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.soundDatasGridView_RowHeaderMouseDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            // 
            // SoundId
            // 
            this.SoundId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SoundId.HeaderText = "Sound Id";
            this.SoundId.MinimumWidth = 6;
            this.SoundId.Name = "SoundId";
            this.SoundId.Width = 97;
            // 
            // SubsoundId
            // 
            this.SubsoundId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SubsoundId.HeaderText = "Subsound Id";
            this.SubsoundId.MinimumWidth = 6;
            this.SubsoundId.Name = "SubsoundId";
            this.SubsoundId.Width = 120;
            // 
            // Sound_Base64
            // 
            this.Sound_Base64.HeaderText = "Sound_Base64";
            this.Sound_Base64.MinimumWidth = 6;
            this.Sound_Base64.Name = "Sound_Base64";
            this.Sound_Base64.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sound_Base64.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // categoriesManagerBindingSource
            // 
            this.categoriesManagerBindingSource.DataSource = typeof(DB_instrumentation.Manager.CategoriesManager);
            // 
            // frmInstrumentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 627);
            this.Controls.Add(this.soundDatasGridView);
            this.Controls.Add(this.button_save_comment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.label_track);
            this.Controls.Add(this.trackListBox);
            this.Controls.Add(this.label_instruments);
            this.Controls.Add(this.instrumentsListBox);
            this.Controls.Add(this.categoriesСomboBox);
            this.Name = "frmInstrumentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB instrumentation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundDatasGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TrackListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ComboBox categoriesСomboBox;
        private ListBox instrumentsListBox;
        private Label label_instruments;
        private ListBox trackListBox;
        private Label label_track;
        private RichTextBox commentTextBox;
        private Label label_comment;
        private PictureBox pictureBox1;
        private Button button_save_comment;
        private DataGridView soundDatasGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Comment;
        private DataGridViewTextBoxColumn SoundId;
        private DataGridViewTextBoxColumn SubsoundId;
        private DataGridViewTextBoxColumn Sound_Base64;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private BindingSource categoriesManagerBindingSource;
    }
}