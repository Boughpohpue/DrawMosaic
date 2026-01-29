using System.Collections.Generic;
using System.Drawing;

namespace Mosaic
{
    public static class PointExtensions
    {
        public static Point Add(this Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point Sub(this Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static Point AddXSubY(this Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y - p2.Y);
        }

        public static Point SubXAddY(this Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y + p2.Y);
        }

        public static Point Reverted(this Point p)
        {
            return new Point(p.Y, p.X);
        }

        public static Point Reverted(this Point p, Point center)
        {
            var deltaPoint = p.Sub(center);

            return center.Add(deltaPoint.Reverted());
        }

        public static Point MirroredV(this Point p, Point center, bool reverted = false)
        {
            var deltaPoint = p.Sub(center);

            return reverted
                ? center.SubXAddY(deltaPoint.Reverted())
                : center.SubXAddY(deltaPoint);
        }

        public static Point MirroredH(this Point p, Point center, bool reverted = false)
        {
            var deltaPoint = p.Sub(center);

            return reverted
                ? center.AddXSubY(deltaPoint.Reverted())
                : center.AddXSubY(deltaPoint);
        }

        public static Point MirroredVH(this Point p, Point center, bool reverted = false)
        {
            var deltaPoint = p.Sub(center);

            return reverted
                ? center.Sub(deltaPoint.Reverted())
                : center.Sub(deltaPoint);
        }

        public static void Revert(this Point p)
        {
            p = new Point(p.Y, p.X);
        }

        public static void Clear(this Point p, int clearValue = 0)
        {
            p = new Point(clearValue, clearValue);
        }

        public static Dictionary<MosaicLevel, Dictionary<MosaicPoint, Point>> GetMosaicPointsDictionary(this Point p, Point center)
        {
            var mirrorVertical = p.MirroredV(center);
            var mirrorHorizontal = p.MirroredH(center);
            var mirrorVerticalHorizontal = p.MirroredVH(center);
            var revertedPoint = p.Reverted(center);
            var revertedMirrorVertical = p.MirroredV(center, true);
            var revertedMirrorHorizontal = p.MirroredH(center, true);
            var revertedMirrorVerticalHorizontal = p.MirroredVH(center, true);

            return new Dictionary<MosaicLevel, Dictionary<MosaicPoint, Point>>
            {
                { MosaicLevel.None, new Dictionary<MosaicPoint, Point> { 
                    { MosaicPoint.Base, p } } 
                },

                { MosaicLevel.X2V, new Dictionary<MosaicPoint, Point> { 
                    { MosaicPoint.Base, p }, 
                    { MosaicPoint.MirrorVertical, mirrorVertical } } 
                },

                { MosaicLevel.X2H, new Dictionary<MosaicPoint, Point> { 
                    { MosaicPoint.Base, p }, 
                    { MosaicPoint.MirrorHorizontal, mirrorHorizontal } } 
                },

                { MosaicLevel.X4, new Dictionary<MosaicPoint, Point> { 
                    { MosaicPoint.Base, p }, 
                    { MosaicPoint.MirrorVertical, mirrorVertical }, 
                    { MosaicPoint.MirrorHorizontal, mirrorHorizontal }, 
                    { MosaicPoint.MirrorVerticalHorizontal, mirrorVerticalHorizontal } } 
                },

                { MosaicLevel.X8, new Dictionary<MosaicPoint, Point> { 
                    { MosaicPoint.Base, p }, 
                    { MosaicPoint.MirrorVertical, mirrorVertical },
                    { MosaicPoint.MirrorHorizontal, mirrorHorizontal }, 
                    { MosaicPoint.MirrorVerticalHorizontal, mirrorVerticalHorizontal },
                    { MosaicPoint.RevertedBase, revertedPoint }, 
                    { MosaicPoint.RevertedMirrorVertical, revertedMirrorVertical },
                    { MosaicPoint.RevertedMirrorHorizontal, revertedMirrorHorizontal }, 
                    { MosaicPoint.RevertedMirrorVerticalHorizontal, revertedMirrorVerticalHorizontal } } 
                }
            };
        }
    }
}
