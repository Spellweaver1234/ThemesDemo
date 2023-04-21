using Xamarin.Forms;
using Xamarin.Forms.Themes;

namespace ThemesDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public enum Themes
        {
            Dark,
            Light
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            SwitchTheme(Themes.Light);

        }

        private void SwitchTheme(Themes theme)
        {
            var resources = App.Current.Resources;

            switch (theme)
            {
                case Themes.Dark:
                    resources.MergedWith = typeof(DarkThemeResources);
                    break;
                case Themes.Light:
                    resources.MergedWith = typeof(LightThemeResources);
                    break;
            }
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            SwitchTheme(Themes.Dark);
        }
    }
}

