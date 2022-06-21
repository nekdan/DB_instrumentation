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
        CategoriesManager _categoriesManager = new CategoriesManager();
        InstumentsManager _instumentsManager = new InstumentsManager();
        SubinstumentsManager _subinstumentsManager = new SubinstumentsManager();
        SoundsManager _soundsManager = new SoundsManager();
        SubsoundsManager _subsoundsManager = new SubsoundsManager();

        private void categoriesСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            instrumentsListBox.Items.Clear();
            trackListBox.Items.Clear();
            int id = (int)categoriesСomboBox.SelectedValue;
            //Categories category = (Categories)categoriesСomboBox.SelectedItem;
            //MessageBox.Show(id.ToString() + ". " + category.Name);
            //if (category != null)
            //{}

            //instrumentsListBox.Items.Add(category);            
            
            var instuments = _instumentsManager.GetAll();
            var subinstuments = _subinstumentsManager.GetAll();
            foreach (var instument in instuments)
            {
                if (instument.CategoryId == id)
                {
                    instrumentsListBox.Items.Add(instument.Name);
                    foreach (var subinstument in subinstuments)
                    {
                        if (instument.Id == subinstument.InstumentId)
                            instrumentsListBox.Items.Add(subinstument.Name);
                    }                    
                }
            }            
        }
        private void instrumentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackListBox.Items.Clear();
            //int id_instuments = (int)instrumentsListBox.SelectedValue;
            string name_instument = instrumentsListBox.SelectedItem.ToString();
            MessageBox.Show(name_instument);

            var instuments = _instumentsManager.GetAll();
            var subinstuments = _subinstumentsManager.GetAll();

            var sounds = _soundsManager.GetAll();
            var subsounds = _subsoundsManager.GetAll();

            foreach (var instument in instuments)
            {
                if (instument.Name == name_instument)
                {
                    int id_instument = instument.Id;
                    foreach (var sound in sounds)
                    {
                        if (sound.InstumentId == id_instument)
                        {
                            trackListBox.Items.Add(sound.Name);
                            foreach (var subsound in subsounds)
                            {
                                if (sound.Id == subsound.SoundId)
                                    trackListBox.Items.Add(subsound.Name);
                            }
                        }
                    }
                    foreach (var subinstument in subinstuments)
                    {
                        if (instument.Id == subinstument.InstumentId)
                            instrumentsListBox.Items.Add(subinstument.Name);
                    }
                }
            }

            /*
            foreach (var sound in sounds)
            {
                if (sound.InstumentId == 1)
                {
                    trackListBox.Items.Add(sound.Name);
                    foreach (var subsound in subsounds)
                    {
                        if (sound.Id == subsound.SoundId)
                            trackListBox.Items.Add(subsound.Name);
                    }
                }
            }
            */

            //Instuments instument = (Instuments)instrumentsListBox.SelectedItem;
            //MessageBox.Show(instument.Id.ToString() + ". " + instument.Name);
            //Sounds sound1 = (Sounds)trackListBox.SelectedItem;
            //MessageBox.Show(id.ToString() + ". " + sound);
            //MessageBox.Show(sound1.Id + ". " + sound1.Name);
            //trackListBox.Items.Add(sound1.Name);
            //int id = (int)instrumentsListBox.SelectedValue;
            

            /*
            var sounds = _soundsManager.GetAll();
            foreach (var sound in sounds)
            {
                trackListBox.Items.Add(sound.Name);
            }
            /*
            int id = (int)instrumentsListBox.SelectedValue;
            //Categories category = (Categories)categoriesСomboBox.SelectedItem;
            //instrumentsListBox.Items.Add(category);
            var instuments = _instumentsManager.GetAll();
            var subinstuments = _subinstumentsManager.GetAll();
            foreach (var instument in instuments)
            {
                if (instument.CategoryId == id)
                {
                    instrumentsListBox.Items.Add(instument.Name);
                    foreach (var subinstument in subinstuments)
                    {
                        if (instument.Id == subinstument.InstumentId)
                            instrumentsListBox.Items.Add(subinstument.Name);
                    }
                }
            }
            */
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

        public void LoadData()
        {
            var soundDatas = _soundDatasManager.GetAll();
            soundDatasGridView.Rows.Clear();
            foreach (var soundData in soundDatas)
            {
                soundDatasGridView.Rows.Add(soundData.Id, soundData.Description, soundData.SoundId, soundData.SubsoundId, soundData.SoundBase64);
            }
            /*
            var categories = _categoriesManager.GetAll();
            categoriesСomboBox.Items.Clear();
            foreach (var category in categories)
            {
                categoriesСomboBox.Items.Add(category.Name);
            }            
            
            var instuments = _instumentsManager.GetAll();            
            foreach (var instument in instuments)
            {
                instrumentsListBox.Items.Add(instument.Name);
            }
            

            var subsounds = _subsoundsManager.GetAll();
            trackListBox.Items.Clear();
            foreach (var sound in subsounds)
            {
                trackListBox.Items.Add(sound);
            }
            */
        }

        private void button_save_comment_Click(object sender, EventArgs e)
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
                soundsDatas.Description = commentTextBox.Text;
                if (_soundDatasManager.Add(soundsDatas))
                {
                    MessageBox.Show("Комментарий добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Комментарий не добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            LoadData();
        }

        private void soundDatasGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = soundDatasGridView.SelectedRows[0];
                frmCommentDetail frm = new frmCommentDetail(this);
                //this.Hide();
                //frm.Show();
                frm.idLabel.Text = dr.Cells[0].Value.ToString();
                frm.commentTextBox.Text = dr.Cells[1].Value.ToString();
                if (dr.Cells[2].Value != null)
                {
                    frm.soundId.Text = dr.Cells[2].Value.ToString();
                    frm.subsoundId.Text = null;
                }
                else if (dr.Cells[3].Value != null)
                {
                    frm.soundId.Text = null;
                    frm.subsoundId.Text = dr.Cells[3].Value.ToString();
                }
                if (dr.Cells[4].Value != null)
                frm.sound64TextBox.Text = dr.Cells[4].Value.ToString();
                else frm.sound64TextBox.Text = null;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void soundDatasGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = soundDatasGridView.SelectedRows[0];
                if (MessageBox.Show("Вы хотите удалить всю запись с музыкальным файлом?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = _soundDatasManager.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Запись полностью удалена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //LoadData();
                        soundDatasGridView.Rows.Remove(dr);
                    }
                    else
                    {
                        MessageBox.Show("Запись не удалена", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}