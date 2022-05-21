using DB_instrumentation.Models;

namespace DB_instrumentation
{
    public partial class frmInstrumentation : Form
    {
        public frmInstrumentation()
        {
            InitializeComponent();
        }

        ApplicationDbContext _dbContext = new ApplicationDbContext();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                _dbContext.SoundsDatas.Add(soundsDatas);
                if (_dbContext.SaveChanges() > 0)
                {
                    MessageBox.Show("Комментарий добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}