namespace DB_instrumentation.UI
{
    partial class frmCommentDetail
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
            this.button_update_comment = new System.Windows.Forms.Button();
            this.label_comment = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_update_comment
            // 
            this.button_update_comment.Location = new System.Drawing.Point(495, 301);
            this.button_update_comment.Name = "button_update_comment";
            this.button_update_comment.Size = new System.Drawing.Size(140, 34);
            this.button_update_comment.TabIndex = 12;
            this.button_update_comment.Text = "Обновить";
            this.button_update_comment.UseVisualStyleBackColor = true;
            this.button_update_comment.Click += new System.EventHandler(this.button_update_comment_Click);
            // 
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.Location = new System.Drawing.Point(21, 18);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(107, 20);
            this.label_comment.TabIndex = 11;
            this.label_comment.Text = "Комментарий";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(12, 42);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(623, 253);
            this.commentTextBox.TabIndex = 10;
            this.commentTextBox.Text = "";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(585, 18);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 20);
            this.idLabel.TabIndex = 13;
            this.idLabel.Visible = false;
            // 
            // frmCommentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 382);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.button_update_comment);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.commentTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCommentDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCommentDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_update_comment;
        private Label label_comment;
        public Label idLabel;
        public RichTextBox commentTextBox;
    }
}