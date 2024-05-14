namespace wfCalculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNb1.MaxLength == 0 && txtNb2.MaxLength == 0)
            {
                MessageBox.Show("Veuillez Saisir un nombre");
            }
            else 
            { 
                
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            
        }
    }
}