namespace Proyecto7
{
    public partial class Pag4 : ContentPage
    {
        public Pag4()
        {
            InitializeComponent();
        }

        private void Btplay(object sender, EventArgs e)
        {
            audio.Play();
        }

        private void Btpause(object sender, EventArgs e)
        {
            audio.Pause();
        }

        private void Btstop(object sender, EventArgs e)
        {
            audio.Stop();
        }
    }
}