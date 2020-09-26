using System.Drawing;

namespace GameSearchAppXamarin.Services
{
    public interface IStatusBarStyleManager
    {
        void SetLightTheme(Color color);
        void SetDarkTheme(Color color);
    }
}
