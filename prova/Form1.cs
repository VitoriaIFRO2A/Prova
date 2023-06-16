namespace prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matricula = md_matricula.Text;
            string CPF = mb_cpf.Text;
            string Nome = md_nome.Text;
            string funçao = md_funçao.Text;
            int funcaxinha = Convert.ToInt32(funçao);
            string salario = md_salario.Text;
            int salarião = Convert.ToInt32(salario);

            int Medico = funcaxinha;
            int Ti = funcaxinha;
            int Adm = funcaxinha;
          
            Funcionario funcionario = new Funcionario(Medico, Ti, Adm);
            
        }

        private void md_salario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}