﻿using System;
using System.Collections.Generic;
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
    }
}
