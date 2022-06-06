using DB_instrumentation.Manager;
using DB_instrumentation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_instrumentation.UI
{
    public partial class frmCommentDetail : Form
    {
        public frmCommentDetail()
        {
            InitializeComponent();
        }
        SoundDatasManager _soundDatasManager = new SoundDatasManager();

        private void button_update_comment_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(commentTextBox.Text))
                {
                    MessageBox.Show("Пожалуйста введите комментарий", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    commentTextBox.Focus();
                    return;
                }
                SoundsDatas soundsDatas = new SoundsDatas();
                soundsDatas.Id = Convert.ToInt32(idLabel.Text);
                soundsDatas.Description = commentTextBox.Text;
                if (_soundDatasManager.Update(soundsDatas))
                {
                    MessageBox.Show("Комментарий изменён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Комментарий не изменён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
