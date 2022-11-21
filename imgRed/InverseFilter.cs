
using System;
using System.Drawing;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace imgRed
    {

        public class InverseFilter
        {

   
        public static int Clamp(int value, int min, int max)
            {
                if (value < min)
                    return min;
                if (value >= max)
                    return max-1;
                return value;
            }
        public static Bitmap ExecuteAv(Bitmap sourceImage)
        {
            Bitmap resultImage = Average(sourceImage);
            return resultImage;
        }

        public static Bitmap ExecuteG(Bitmap sourceImage)
        {
            Bitmap resultImage = Gray(sourceImage);
            return resultImage;
        }

        public static Bitmap ExecuteAutoCon(Bitmap sourceImage)
        {
            Bitmap resultImage = AutoContrast(sourceImage);
            return resultImage;
        }

        public static Bitmap ExecuteBinLevel(Bitmap sourceImage)
        {
            Bitmap resultImage = BinLevel(sourceImage);
            return resultImage;
        }

        public static Bitmap ExecuteNiblack(Bitmap sourceImage)
        {
            Bitmap resultImage = Niblack(sourceImage);
            return resultImage;
        }
        public static Bitmap ExecuteGlGist(Bitmap sourceImage)
        {
            Bitmap resultImage = GlobGist(sourceImage);
            return resultImage;
        }
        
        public static Bitmap ExecuteSalt(Bitmap sourceImage)
        {
            Bitmap resultImage = SaltNoise(sourceImage);
            return resultImage;
        }

        public static Bitmap ExecuteGause(Bitmap sourceImage)
        {
            Bitmap resultImage = GauseNoise(sourceImage);        
            return resultImage;
        }

        public static Bitmap ExecuteMedian(Bitmap sourceImage)
        {
            Bitmap resultImage = Median(sourceImage);
            return resultImage;
        }
        public static Bitmap ExecuteGausFilter(Bitmap sourceImage)
        {
            Bitmap resultImage = GausFilter(sourceImage);
            return resultImage;
        }
        public static float ExecutePSNR(Bitmap oldImage,Bitmap newImage)
        {
            float resultImage = PSNR(oldImage, newImage);
            return resultImage;
        }

        public static float ExecuteSSIM(Bitmap oldImage, Bitmap newImage)
        {
            float resultImage = SSIM(oldImage, newImage);
            return resultImage;
        }

        public static float SSIM(Bitmap oldImage, Bitmap newImage)
        {
            float MSE = 0;

            int width = oldImage.Width, height = oldImage.Height;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color colorOld = oldImage.GetPixel(i, j);
                    Color colorNew = newImage.GetPixel(i, j);
                    int y = colorOld.R, x = colorNew.R;
                    MSE += (float)Math.Pow(x - y, 2);
                }
            }
            MSE /= width * height;
            float PSNR = (float)(10 * Math.Log10((Math.Pow(255, 2) / MSE)));
            return PSNR;
        }

        public static float PSNR(Bitmap oldImage, Bitmap newImage)
        {
            float MSE=0;

            int width =oldImage.Width,height=oldImage.Height;
            for(int i = 0; i < width; i++)
            {
                for(int j=0; j < height; j++)
                {
                    Color colorOld = oldImage.GetPixel(i, j);
                    Color colorNew = newImage.GetPixel(i, j);
                    int y = colorOld.R, x = colorNew.R;
                    MSE += (float)Math.Pow(x - y, 2);
                }
            }
            MSE /= width * height;
            float PSNR = (float)(10 * Math.Log10((Math.Pow(255,2)/MSE)));
            return PSNR;
        }

        private static Bitmap Median(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            
            int[,] arr = new int[3,3];
            double med=0;
            
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for(int j = 0; j < sourceImage.Height; j++)
                {
                    for(int k = -1; k <= 1; k++)
                    {
                        for(int l = -1; l <= 1; l++)
                        {
                            Color col = sourceImage.GetPixel(Clamp(i + k,0,sourceImage.Width), Clamp(j + l, 0, sourceImage.Height));
                            med += col.R;
                        }
                    }
                    med = med / 9;
                    Color resCol = Color.FromArgb((int)med, (int)med, (int)med);
                    resultImage.SetPixel(i, j, resCol);
                    med = 0;

                }
            }
            return resultImage;
        }

        private static Bitmap GauseNoise(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            Random rand = new Random();
            double Mu = 0;
            double Sigma = 20;
            int size = 100;
            double[] intensity = new double[size];
            byte[] noise = new byte[sourceImage.Width * sourceImage.Height];
            int count = 0;
            double sum = 0;
            for (int i = 0; i < intensity.Length; i++)
            {
                intensity[i] = (1 / (Math.Sqrt(2 * Math.PI * Sigma))) * Math.Exp(-Math.Pow(i - Mu, 2) / (2 * Math.Pow(Sigma, 2)));
                sum += intensity[i];

            }

            for (int i = 0; i < intensity.Length; i++)
            {
                intensity[i] /= sum;
                intensity[i] *= noise.Length;
                intensity[i] = (int)Math.Floor(intensity[i]);
            }
            for (int i = 0; i < intensity.Length; i++)
            {
                for (int j = 0; j < (int)intensity[i]; j++)
                {
                    noise[count + j] = (byte)i;
                }
                count += (int)intensity[i];
            }

            for (int i = 0; i < noise.Length - count; i++)
            {
                noise[count + i] = 0;
            }

            noise = noise.OrderBy(x => rand.Next()).ToArray();
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    int res = Clamp(sourceImage.GetPixel(i, j).R + noise[sourceImage.Height * i + j], 0, 255);
                    resultImage.SetPixel(i, j, Color.FromArgb(res, res, res));
                }
            }
            return resultImage;
        }
        private static Bitmap SaltNoise(Bitmap sourceImage)
        {

            Bitmap resultImage = sourceImage;
            Random coordRand = new Random();
            int countNoise = (int)((sourceImage.Width * sourceImage.Height)/10);
            for(int i = 0; i < countNoise; i++)
            {
             
                 int x = coordRand.Next(0, sourceImage.Width);
                 int y = coordRand.Next(0, sourceImage.Height);
                resultImage.SetPixel(x, y, Color.White);

            }

            return resultImage;
        }


        private static Bitmap GausFilter(Bitmap sourceImage)
        {
           
            Bitmap resultImage = sourceImage;

            int w_size = 3;

            int radiusX = w_size / 2;
            int radiusY = w_size / 2;
            float sigma = 0.5f;
            double gauss, sumGauss = 0;

            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    sumGauss = 0;
                    for (int l = -radiusY; l <= radiusY; l++)
                    {
                        for (int k = -radiusX; k <= radiusX; k++)
                        {
                            int idX = Clamp(i + k, 0, sourceImage.Width - 1);
                            int idY = Clamp(j + l, 0, sourceImage.Height - 1);
                            Color neighborColor = sourceImage.GetPixel(idX, idY);
                            gauss = 1 / (2 * Math.PI * Math.Pow(sigma, 2)) * Math.Exp(-(Math.Pow(l, 2) + Math.Pow(k, 2)) / (2 * Math.Pow(sigma, 2)));
                            sumGauss += gauss * neighborColor.R;
                        }
                    }
                    Color resultColor = Color.FromArgb(Clamp((int)sumGauss, 0, 255), Clamp((int)sumGauss, 0, 255), Clamp((int)sumGauss, 0, 255));
                    resultImage.SetPixel(i, j, resultColor);
                }
            }
           
            return resultImage;
        }

        //про последнюю лабу без 3 пункта

        //шум гауса белый шум , усреднение , гауса PSNR SSIM
        private static Bitmap GlobGist(Bitmap sourceImage)
        { 
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            int[] h = CalculateHistogram(sourceImage);//гистограмма



            int hSum = h.Sum();
            int x_min = hSum * (int)0.05;

            for (int i = 0; i < 255; i++)
            {
                if (h[i] < x_min)
                {
                    x_min -= h[i];
                    h[i] = 0;
                }
                else
                {
                    h[i] -= x_min;
                }
                if (x_min == 0) break;

            }

            int x_max = hSum * (int)0.05;

            for (int i = 255; i < 0; i--)
            {
                if (x_max > h[i])
                {
                    x_max -= h[i];
                    h[i] = 0;
                }
                else
                {
                    h[i] -= x_max;
                }
                if (x_max == 0) break;

            }


            int weight = 0;
            for (int i = 0; i < 255; i++)
            {
                weight += h[i] * i;
            }

            int T = (int)(weight / h.Sum());

            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color color = sourceImage.GetPixel(x, y);
                    if (color.G <= T) resultImage.SetPixel(x, y, Color.White);
                    else resultImage.SetPixel(x, y, Color.Black);

                }



            return resultImage;
        }
        public static int[] CalculateHistogram(Bitmap sourceimage)
        {
            int[] h = new int[256];

            for (int y = 0; y < sourceimage.Height; y++)
                for (int x = 0; x < sourceimage.Width; x++)
                {
                    Color color = sourceimage.GetPixel(x, y);
                    h[color.R]++;
                }

            return h;
        }
        private static Bitmap Niblack(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    float constant = -0.2f;
                    int radius = 1;
                    int matrixSize = (1 + 2 * radius) * (1 + 2 * radius);

                    int intesitySum = 0;
                    int resultI;

                    int deviation;

                    for (int l = -radius; l <= radius; l++)
                        for (int k = -radius; k <= radius; k++)
                        {
                            int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                            int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                            Color neighborColor = sourceImage.GetPixel(idX, idY);

                            intesitySum += (int)neighborColor.R;

                        }

                    resultI = (int)(intesitySum / matrixSize);
                    intesitySum = 0;

                    for (int l = -radius; l <= radius; l++)
                        for (int k = -radius; k <= radius; k++)
                        {
                            int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                            int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                            Color neighborColor = sourceImage.GetPixel(idX, idY);

                            intesitySum += (int)Math.Pow(neighborColor.R - resultI, 2);

                        }

                    deviation = (int)Math.Sqrt(intesitySum / matrixSize);

                    byte T = (byte)(resultI + (byte)(constant * deviation));


                    Color color = sourceImage.GetPixel(x, y);
                    if (color.R >= T) resultImage.SetPixel(x,y, Color.White);
                    else resultImage.SetPixel(x, y, Color.Black);

                }
            return resultImage;
        }
        private static Bitmap BinLevel(Bitmap sourceImage)
            {
                int level = 125;
                Color resultColor;
                Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
                for (int i = 0; i < sourceImage.Width; i++)
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        Color sourceColor = sourceImage.GetPixel(i, j);
                        double Intensity = 0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B;
                    if (Intensity < level)  { resultColor = Color.FromArgb(0, 0, 0); }
                                     else { resultColor = Color.FromArgb(255, 255, 255); }
                        resultImage.SetPixel(i, j, resultColor);
                    }
                return resultImage;

            }

            public static Bitmap Gray(Bitmap sourceImage)
            {
                Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
                for (int i = 0; i < sourceImage.Width; i++)
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        Color sourceColor = sourceImage.GetPixel(i, j);
                        double Intensity = 0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B;
                        Color resultColor = Color.FromArgb(Clamp((int)Intensity, 0, 255),
                                                            Clamp((int)Intensity, 0, 255),
                                                            Clamp((int)Intensity, 0, 255));
                        resultImage.SetPixel(i, j, resultColor);
                    }
                return resultImage;
            }

            public static Bitmap AutoContrast(Bitmap sourceImage)
            {
                double minCR = 255, maxCR = 0;
                double minCG = 255, maxCG = 0;
                double minCB = 255, maxCB = 0;
                double Intensity = 0;
                Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
                for (int i = 0; i < sourceImage.Width; i++)
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        Color sourceColor = sourceImage.GetPixel(i, j);
                        Intensity = 0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B;
                        if (Intensity > maxCR)
                            maxCR = Intensity;
                        if (Intensity < minCR)
                            minCR = Intensity;

                        if (Intensity > maxCG)
                            maxCG = Intensity;
                        if (Intensity < minCG)
                            minCG = Intensity;

                        if (Intensity > maxCB)
                            maxCB = Intensity;
                        if (Intensity < minCB)
                            minCB = Intensity;
                    }
                for (int i = 0; i < sourceImage.Width; i++)
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        Color sourceColor = sourceImage.GetPixel(i, j);
                        double new_InR = ((double)sourceColor.R - minCR) / (maxCR - minCR) * 255.0;
                        double new_InG = ((double)sourceColor.G - minCG) / (maxCR - minCG) * 255.0;
                        double new_InB = ((double)sourceColor.B - minCB) / (maxCR - minCB) * 255.0;

                        Color resultColor = Color.FromArgb(Clamp((int)new_InR, 0, 255),
                                                           Clamp((int)new_InG, 0, 255),
                                                           Clamp((int)new_InB, 0, 255));
                        resultImage.SetPixel(i, j, resultColor);
                    }
                return resultImage;
            }

            public static Bitmap Average(Bitmap sourceImage)
                {
                    double avR=0, avG=0, avB=0;
                    Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
                    for (int i = 0; i < sourceImage.Width; i++)
                    {
                        for (int j = 0; j < sourceImage.Height; j++)
                        {
                            for (int k = -1; k <= 1; k++)
                            {
                                for (int l = -1; l <= 1; l++)
                                {                           
                                    Color sourceColor = sourceImage.GetPixel(Clamp(i + k, 0,sourceImage.Width), Clamp(j + l, 0, sourceImage.Height));
                                    avR += sourceColor.R;
                                    avG += sourceColor.G;
                                    avB += sourceColor.B;
                                }
                            }
                        avR = avR / 9;
                        avG = avG / 9;
                        avB = avB / 9;
                        Color resultColor = Color.FromArgb((int)avR, (int)avG, (int)avB);
                        avR = 0;
                        avG = 0;
                        avB = 0;
                        resultImage.SetPixel(i, j, resultColor);
                        }
                    }
                     return resultImage;
            }
        }
    }
