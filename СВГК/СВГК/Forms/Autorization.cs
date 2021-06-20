using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СВГК
{
    public partial class Autorization : Form
    {
        public static string настоящийПароль = "qwerty";
        Glavnoe_menu gm = new Glavnoe_menu();

        public Autorization()
        {
            InitializeComponent();
        }

        private string text = String.Empty;
  
        private void Autorization_Load(object sender, EventArgs e)
        {
            
            captcha_img.Visible = false;
            change_captcha.Visible = false;
            captcha.Visible = false;
            input_captcha.Visible = false;
            captcha_img.Image = this.CreateImage(captcha_img.Width, captcha_img.Height);
        }

        private void enter_Click(object sender, EventArgs e)
        {

            { //передача логина в главное окно
                gm.fio.Text = this.login.Text;
            }

            string loginstr = login.Text;
            string parol = password.Text;
            {
                if ((parol == настоящийПароль) && (loginstr != "") && (captcha.Text == ""))
                {
                    gm.Show();
                    Hide();
                }

                if (parol != настоящийПароль)
                {
                    MessageBox.Show("Вы неверно ввели пароль!");
                    logo.Visible = false;
                    captcha_img.Visible = true;
                    change_captcha.Visible = true;
                    captcha.Visible = true;
                    input_captcha.Visible = true;
                }

                if (loginstr == "")
                {
                    MessageBox.Show("Вы неверно указали логин!");
                    logo.Visible = false;
                    captcha_img.Visible = true;
                    change_captcha.Visible = true;
                    captcha.Visible = true;
                    input_captcha.Visible = true;
                }
            }

            {
                if ((captcha.Text == this.text) && (parol == настоящийПароль) && (loginstr != ""))
                {
                    gm.Show();
                    Hide();
                }

                if (captcha_img.Visible == true)
                {
                    if (captcha.Text != this.text && parol == настоящийПароль && loginstr != "")
                    {
                        MessageBox.Show("Неверно введена капча!");
                    }
                }

            }

        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            //Добавим различные цвета
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void change_captcha_Click(object sender, EventArgs e)
        {
            captcha_img.Image = this.CreateImage(captcha_img.Width, captcha_img.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            password.UseSystemPasswordChar = true;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Время сессии уже составляет 5 минут, у вас есть ровно столько же, чтобы убраться отсюда");
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Время сессии истекло!");
            Application.Exit();
        }
    }
}
