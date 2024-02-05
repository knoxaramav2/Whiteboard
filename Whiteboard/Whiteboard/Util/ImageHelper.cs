using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Whiteboard.Util
{
    internal static class ImageHelper
    {
        internal static Image Resize(Image image, int width, int height)
        {
            var nszRct = new Rectangle(0, 0, width, height);
            var nszImg = new Bitmap(width, height);
            nszImg.SetResolution(image.Width, image.Height);

            using var graphics = Graphics.FromImage(nszImg);
            graphics.CompositingMode = CompositingMode.SourceCopy;
            graphics.CompositingQuality = CompositingQuality.HighSpeed;
            graphics.InterpolationMode = InterpolationMode.Bicubic;
            graphics.SmoothingMode = SmoothingMode.HighSpeed;

            using var wrap = new ImageAttributes();
            wrap.SetWrapMode(WrapMode.TileFlipXY);
            graphics.DrawImage(image, nszRct, 0, 0, image.Width, image.Height, 
                GraphicsUnit.Pixel, wrap);
            return nszImg;
        }
    }
}
