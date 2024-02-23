using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachFileSaving.View.Forms.ConfirmationForms
{
    public partial class OperationConfirmedForm : Form
    {
        private Image gifImage;
        public OperationConfirmedForm()
        {
            InitializeComponent();
            gifImage = Properties.Resources.GIFГалочкаЗелёная;
            pictureBox1.Image = gifImage;
            ImageAnimator.Animate(gifImage,OnFrameChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void OnFrameChanged(object sender, EventArgs e)
        {
            // Проверяем, является ли текущий кадр последним
            if (pictureBox1.Image != null && !ImageAnimator.CanAnimate(gifImage))
            {
                // Если это последний кадр, останавливаем анимацию
                ImageAnimator.StopAnimate(gifImage, OnFrameChanged);
            }
        }
    }
}
