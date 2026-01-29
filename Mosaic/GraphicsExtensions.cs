using System.Drawing;

namespace Mosaic
{
    public static class GraphicsExtensions
    {
        public static void DrawMosaicLines(this Graphics graphics, Pen pen, Point centerPoint, Point startPoint, Point endPoint, MosaicLevel mosaicLevel)
        {
            var startMosaicPoints = startPoint.GetMosaicPointsDictionary(centerPoint);
            var endMosaicPoints = endPoint.GetMosaicPointsDictionary(centerPoint);

            foreach (var smp in startMosaicPoints[mosaicLevel])
            {
                graphics.DrawLine(
                    pen, 
                    smp.Value, 
                    endMosaicPoints[mosaicLevel][smp.Key]);
            }
        }
    }
}
