namespace Proyecto7
{
    public partial class Pag3 : ContentPage
    {
        public Pag3()
        {
            InitializeComponent();
        }

        private void Btplay(object sender, EventArgs e)
        {
            media.Play();
        }

        private void Btpause(object sender, EventArgs e)
        {
            media.Pause();
        }

        private void Btstop(object sender, EventArgs e)
        {
            media.Stop();
        }
    }
}