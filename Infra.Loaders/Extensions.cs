using System.Drawing;

namespace Infra.Loaders
{
    public static class Extensions
    {
        public static bool IsBlack(this Color color)
        {
            return color.A == 255 && color.R == 0 && color.G == 0 && color.B == 0;
        }
    }
}
