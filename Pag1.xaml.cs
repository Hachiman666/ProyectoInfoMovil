using CommunityToolkit.Maui.Animations;
using CommunityToolkit.Maui.Extensions;

namespace Proyecto7
{
    public partial class Pag1 : ContentPage
    {
        public Pag1()
        {
            InitializeComponent();
            Genera();
            Animate();
        }

        public void Genera()
        {
            var modelo = DeviceInfo.Model;
            Info1.Text = $"Modelo: {modelo}";

            var nombre = DeviceInfo.Name;
            Info2.Text = $"Nombre: {nombre}";

            var dispo = DeviceInfo.DeviceType;
            Info3.Text = $"Dispositivo: {dispo}";

            var plataforma = DeviceInfo.Platform;
            Info4.Text = $"Plataforma: {plataforma}";

            var manofactura = DeviceInfo.Manufacturer;
            Info5.Text = $"Manofactura: {manofactura}";

            var version = DeviceInfo.Version;
            Info6.Text = $"version: {version}";

            var current = DeviceInfo.Current;
            Info7.Text = $"Current: {current}";
        }

        public async void Animate()
        {
            var fadeAnimation = new FadeAnimation();
            await fadeAnimation.Animate(Info1);
            await fadeAnimation.Animate(Info2);
            await fadeAnimation.Animate(Info3);
            await fadeAnimation.Animate(Info4);
            await fadeAnimation.Animate(Info5);
            await fadeAnimation.Animate(Info6);
            await fadeAnimation.Animate(Info7);
            await fadeAnimation.Animate(img1);

        }

    }
}