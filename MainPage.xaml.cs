using CommunityToolkit.Maui.Animations;
using System;

namespace Proyecto7
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btPag1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag1());
        }

        private void btFirma(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Firma());
        }

        private void btPag2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag2());
        }

        private void btPag3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag3());
        }

        private void btPag4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag4());
        }

        private void btPag5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag5());
        }

        public async void Animate()
        {
            var fadeAnimation = new FadeAnimation();
            await fadeAnimation.Animate(bt1);
            await fadeAnimation.Animate(bt2);
            await fadeAnimation.Animate(bt3);
            await fadeAnimation.Animate(bt4);
            await fadeAnimation.Animate(bt5);
            await fadeAnimation.Animate(bt6);
            await fadeAnimation.Animate(bta);
            await fadeAnimation.Animate(label1);
            await fadeAnimation.Animate(img1);

        }

        private void btani(object sender, EventArgs e)
        {
            Animate();
        }
    }

}
