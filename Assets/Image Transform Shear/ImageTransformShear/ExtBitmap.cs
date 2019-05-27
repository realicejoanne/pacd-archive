/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace ImageTransformShear
{
    public static class ExtBitmap
    {
        public static Bitmap CopyToSquareCanvas(this Bitmap sourceBitmap, int canvasWidthLenght)
        {
            float ratio = 1.0f;
            int maxSide = sourceBitmap.Width > sourceBitmap.Height ?
                          sourceBitmap.Width : sourceBitmap.Height;

            ratio = (float)maxSide / (float)canvasWidthLenght;

            Bitmap bitmapResult = (sourceBitmap.Width > sourceBitmap.Height ?
                                    new Bitmap(canvasWidthLenght, (int)(sourceBitmap.Height / ratio))
                                    : new Bitmap((int)(sourceBitmap.Width / ratio), canvasWidthLenght));

            using (Graphics graphicsResult = Graphics.FromImage(bitmapResult))
            {
                graphicsResult.CompositingQuality = CompositingQuality.HighQuality;
                graphicsResult.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsResult.PixelOffsetMode = PixelOffsetMode.HighQuality;

                graphicsResult.DrawImage(sourceBitmap,
                                        new Rectangle(0, 0,
                                            bitmapResult.Width, bitmapResult.Height),
                                        new Rectangle(0, 0,
                                            sourceBitmap.Width, sourceBitmap.Height),
                                            GraphicsUnit.Pixel);
                graphicsResult.Flush();
            }

            return bitmapResult;
        }

        public static Point ShearXY(this Point source, double shearX,
                                                       double shearY,
                                                       int offsetX, 
                                                       int offsetY)
        {
            Point result = new Point();

            result.X = (int)(Math.Round(source.X + shearX * source.Y));
            result.X -= offsetX;

            result.Y = (int)(Math.Round(source.Y + shearY * source.X));
            result.Y -= offsetY;

            return result;
        }

        public static Bitmap ShearImage(this Bitmap sourceBitmap,
                                       double shearX,
                                       double shearY)
        {
            BitmapData sourceData =
                       sourceBitmap.LockBits(new Rectangle(0, 0,
                       sourceBitmap.Width, sourceBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];

            byte[] resultBuffer = new byte[sourceData.Stride *
                                           sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0,
                                       pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            int xOffset = (int)Math.Round(sourceBitmap.Width * 
                                                shearX / 2.0);

            int yOffset = (int)Math.Round(sourceBitmap.Height * 
                                                  shearY / 2.0);

            int sourceXY = 0;
            int resultXY = 0;

            Point sourcePoint = new Point();
            Point resultPoint = new Point();

            Rectangle imageBounds = new Rectangle(0, 0,
                                    sourceBitmap.Width,
                                   sourceBitmap.Height);

            for (int row = 0; row < sourceBitmap.Height; row++)
            {
                for (int col = 0; col < sourceBitmap.Width; col++)
                {
                    sourceXY = row * sourceData.Stride + col * 4;

                    sourcePoint.X = col;
                    sourcePoint.Y = row;

                    if (sourceXY >= 0 && 
                        sourceXY + 3 < pixelBuffer.Length)
                    {
                        resultPoint = sourcePoint.ShearXY(shearX, 
                                        shearY, xOffset, yOffset);

                        resultXY = resultPoint.Y * sourceData.Stride +
                                   resultPoint.X * 4;

                        if (imageBounds.Contains(resultPoint) &&
                                              resultXY >= 0)
                        {
                            if (resultXY + 6 <= resultBuffer.Length)
                            {
                                resultBuffer[resultXY + 4] =
                                     pixelBuffer[sourceXY];

                                resultBuffer[resultXY + 5] =
                                     pixelBuffer[sourceXY + 1];

                                resultBuffer[resultXY + 6] =
                                     pixelBuffer[sourceXY + 2];

                                resultBuffer[resultXY + 7] = 255;
                            }

                            if (resultXY - 3 >= 0)
                            {
                                resultBuffer[resultXY - 4] =
                                     pixelBuffer[sourceXY];

                                resultBuffer[resultXY - 3] =
                                     pixelBuffer[sourceXY + 1];

                                resultBuffer[resultXY - 2] =
                                     pixelBuffer[sourceXY + 2];

                                resultBuffer[resultXY - 1] = 255;
                            }

                            if (resultXY + 3 < resultBuffer.Length)
                            {
                                resultBuffer[resultXY] =
                                 pixelBuffer[sourceXY];

                                resultBuffer[resultXY + 1] =
                                 pixelBuffer[sourceXY + 1];

                                resultBuffer[resultXY + 2] =
                                 pixelBuffer[sourceXY + 2];

                                resultBuffer[resultXY + 3] = 255;
                            }
                        }
                    }
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width,
                                             sourceBitmap.Height);

            BitmapData resultData =
                       resultBitmap.LockBits(new Rectangle(0, 0,
                       resultBitmap.Width, resultBitmap.Height),
                       ImageLockMode.WriteOnly,
                       PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0,
                                       resultBuffer.Length);

            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }
    }  
}
