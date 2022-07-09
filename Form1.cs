namespace Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VectoresApp vectoresApp = new VectoresApp();
            vectoresApp.MdiParent = this;
            vectoresApp.Show();
        }

        private void app1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App1 app1 =new App1();
            app1.MdiParent=this;
            app1.Show();
        }

        private void app2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App2 app2 =new App2();
            app2.MdiParent=this;
            app2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void app4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatricesApp matricesApp =new MatricesApp();
            matricesApp.MdiParent=this;
            matricesApp.Show();
        }
    }
}