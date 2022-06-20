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
        frmInstrumentation frm;
        public frmCommentDetail(frmInstrumentation frm)
        {
            InitializeComponent();
            this.frm = frm;
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
                if (soundsDatas.SoundId != null)
                {
                    soundsDatas.SoundId = Convert.ToInt32(soundId.Text);
                    soundsDatas.SubsoundId = null;
                }
                else if (soundsDatas.SubsoundId != null)
                {
                    soundsDatas.SubsoundId = Convert.ToInt32(subsoundId.Text);
                    soundsDatas.SoundId = null;
                }
                soundsDatas.SoundBase64 = sound64TextBox.Text;
                if (_soundDatasManager.Update(soundsDatas))
                {
                    MessageBox.Show("Комментарий изменён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frm.LoadData();
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
