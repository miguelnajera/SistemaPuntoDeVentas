﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewModels.Library
{
    public class UploadImage
    {
        private OpenFileDialog fd = new OpenFileDialog();   

        public void CargarImagen(PictureBox pictureBox)
        {
            //Establece la propiedad de WaitOnload a true significa que la imagen
            //se carga de forma sincronica

            pictureBox.WaitOnLoad = true;
            fd.Filter = "Todos(*.*)|*.*|Imagenes: *.jpg;*.gif;*.png;*.bmp|";
            fd.ShowDialog();
            if(fd.FileName != string.Empty)
            {
                pictureBox.ImageLocation = fd.FileName;
            }
        }

        public Image ResizeImage(Image srcImagen, int newWidth, int newHeight)
        {
            using (var imagenBitmap = new Bitmap(newWidth, newHeight, PixelFormat.Format32bppRgb))
            {
                imagenBitmap.SetResolution(Convert.ToInt32(srcImagen.HorizontalResolution), Convert.ToInt32(srcImagen.HorizontalResolution));
                using (var imagenGraphics = Graphics.FromImage(imagenBitmap))
                {
                    imagenGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                    imagenGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    imagenGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    imagenGraphics.DrawImage(srcImagen, new Rectangle(0, 0, newWidth, newHeight),
                        new Rectangle(0, 0, srcImagen.Width, srcImagen.Height), GraphicsUnit.Pixel);
                    MemoryStream imagenMemoryStream = new MemoryStream();
                    imagenBitmap.Save(imagenMemoryStream, ImageFormat.Png);
                    srcImagen= Image.FromStream(imagenMemoryStream);
                }
            }
            return srcImagen;
        }

        public byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
