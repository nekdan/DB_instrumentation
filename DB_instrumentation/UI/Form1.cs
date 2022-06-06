using DB_instrumentation.Manager;
using DB_instrumentation.Models;
using DB_instrumentation.UI;

namespace DB_instrumentation
{
    public partial class frmInstrumentation : Form
    {
        public frmInstrumentation()
        {
            InitializeComponent();
        }

        SoundDatasManager _soundDatasManager = new SoundDatasManager();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            var soundDatas = _soundDatasManager.GetAll();
            soundDatasGridView.Rows.Clear();
            foreach (var soundData in soundDatas)
            {
                soundDatasGridView.Rows.Add(soundData.Id, soundData.Description, soundData.SoundId, soundData.SubsoundId);
            }
        }

        private void button_save_comment_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(commentTextBox.Text))
                {
                    MessageBox.Show("���������� ������� �����������", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    commentTextBox.Focus();
                    return;
                }
                SoundsDatas soundsDatas = new SoundsDatas();
                soundsDatas.Description = commentTextBox.Text;
                if (_soundDatasManager.Add(soundsDatas))
                {
                    MessageBox.Show("����������� ��������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("����������� �� ��������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            commentTextBox.Text = String.Empty;
            instrumentsListBox.Items.Clear();
            LoadData();
        }

        private void soundDatasGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = soundDatasGridView.SelectedRows[0];
                frmCommentDetail frm = new frmCommentDetail();
                //this.Hide();
                //frm.Show();
                frm.idLabel.Text = dr.Cells[0].Value.ToString();
                frm.commentTextBox.Text = dr.Cells[1].Value.ToString();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}