using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using SharpDX.XInput;
using static System.Windows.Forms.AxHost;

namespace Ucak_Savasi
{
    public partial class Form1 : Form
    {

        bool joyictic_control = true;
        bool gonder = false;
        
        //--------------------------------------------------//

        string kaybeden = "";

        // Goruntu işleme yeri
        int mermiHiz_yapay = 20;
        bool ates_yapay = false;
        int vurulan_hedef_goruntu = 0;
        bool ulti_ates = false;
        
        // Oyuncu yeri
        int solHareket = 0;
        int ducakHareketHiz = 13;
        Random rnd = new Random();
        int mermiHiz = 20;
        bool ates = false;
        int Puan = 0;
        int Puan_yapay = 0;
        int vurulan_hedef_oyuncu = 0;

        public Form1()
        {
            InitializeComponent();

            //-------------------------- Oyuncu uçak başlangıç ayarları -----------------------//          Burası tamam 

            ducak1.Top = -1000;
            ducak2.Top = -3000;
            ducak3.Top = -4500;

            ducak_mermi_1.Top = -1100;
            ducak_mermi_1.Left = ducak1.Left + 40;

            ducak_mermi_2.Top = -3400;
            ducak_mermi_2.Left = ducak2.Left + 40;

            ducak_mermi_3.Top = -5130;
            ducak_mermi_3.Left = ducak3.Left + 40;

            mermi.Top = -100;
            mermi.Left = -100;

            //---------------------- Görüntü işleme uçak başlangıç ayarları -------------------//         Burası tamam

            ducak_yapay_1.Top = -1000;
            ducak_yapay_2.Top = -3000;
            ducak_yapay_3.Top = -4500;

            ducak_mermi_yapay_1.Top = -1100;
            ducak_mermi_yapay_1.Left = ducak1.Left - 600 + 40;

            ducak_mermi_yapay_2.Top = -3400;
            ducak_mermi_yapay_2.Left = ducak2.Left - 600 + 40;

            ducak_mermi_yapay_3.Top = -5130;
            ducak_mermi_yapay_3.Left = ducak3.Left - 600 + 40;
            

            mermi_yapay_.Top = -100;
            mermi_yapay_.Left = -100;
        }

        private void ducak1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer3.Enabled = true;

            heart.Left = 900;
            heart.Top = 900;

            panel_info.Visible = false;
            pictureBox2.Visible = false;
            carpma.Visible = false;
            carpma_yapay.Visible = false;

            var controller = new Controller(UserIndex.One);
            if (!controller.IsConnected)
            {
                MessageBox.Show("Joystick Cihazı Bağlı Değil.","Hata", MessageBoxButtons.OK);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                timer1.Start();
                panel_info.Visible = false;
                timer2.Enabled = true;
                timer1.Enabled = true;
            }
            if (e.KeyCode == Keys.P)
            {
                timer1.Stop();
               
            }

            if (e.KeyCode == Keys.Left)
            {
                if (bucak.Location.X < 600) { solHareket = 0; } else { solHareket =- 20; }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (bucak.Location.X > 1200)
                {
                    solHareket = 0;
                }
                else
                {
                    solHareket = 20;
                }
            }
            else if (e.KeyCode == Keys.Space)
            {

                if (ates == false)
                {
                    mermiHiz = 20;
                    mermi.Left = bucak.Left + 40;
                    mermi.Top = bucak.Top;
                    ates = true;
                }
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                solHareket = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                solHareket = 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (Puan == 70 || Puan == 140 || Puan == 210 || Puan == 280 || Puan == 350 || Puan == 420)
            {
                gonder = true;
                int ranP = rnd.Next(630, 1000);

                heart.Top = -100;
                heart.Left = ranP;
            }

            if (gonder == true && heart.Top < 800)
            {
                heart.Top += 12;
            }

            var controller = new Controller(UserIndex.One);
            var state = controller.GetState();

            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start))
            {
                oyunSonu(true);
            }

            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Back))
            {
                timer1.Enabled = false;
                timer1.Stop();
            }
            
            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft))
            {
                if (bucak.Location.X < 600) 
                { 
                    solHareket = 0;
                } 
                else 
                {
                    bucak.Left -= 20;
                }
            }
            else if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight))
            {
                if (bucak.Location.X > 1200)
                {
                    solHareket = 0;
                }
                else
                {
                    bucak.Left += 20;
                }
            }
            else if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A))
            {

                if (ates == false)
                {
                    mermiHiz = 20;
                    mermi.Left = bucak.Left + 40;
                    mermi.Top = bucak.Top;
                    ates = true;
                }
            }

            if (bucak.Location.X < 600)
            {
                bucak.Left = 600;
            }
            else if (bucak.Location.X > 1200)
            {
                bucak.Left = 1200;
            }
            carpma.Left = bucak.Left + 25;
            carpma.Top = bucak.Top + 30;
            
            carpma_yapay.Left = bucak_goruntu.Left + 25;
            carpma_yapay.Top = bucak_goruntu.Top + 30;

            timer1.Enabled = false;
            
            //Görüntü İşleme Kodları //                                          

            var frm = Form.ActiveForm;
            Rectangle rect = new Rectangle(0, 0, 635, 704);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(0, 91, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            

         
            Mat src = BitmapConverter.ToMat(bmp);
            ////Conversion to grayscale.
            Mat gray = new Mat(src.Size(), MatType.CV_8UC1);

            gray = src.CvtColor(ColorConversionCodes.BGR2GRAY);

            ////Blurring to reduce high frequency noise to make our contour detection process more accurate.
            Mat blurred = new Mat();
            blurred = gray.GaussianBlur(new OpenCvSharp.Size(1, 1), 0);

            Mat threshold = new Mat(blurred.Size(), MatType.CV_8UC1);
            threshold = gray.Threshold(104, 255, ThresholdTypes.Binary);
            Cv2.Threshold(gray, gray, thresh: 104, maxval: 255, type: ThresholdTypes.Binary);
            ////find contours
            Bitmap image3 = BitmapConverter.ToBitmap(threshold);
            // 
           
            var detectorParams = new SimpleBlobDetector.Params
            {

                MinDistBetweenBlobs = 1, // 10 pixels between blobs
                MinRepeatability = 1,
                MinThreshold = 90,
                MaxThreshold = 255,

                FilterByArea = true,
                //FilterByArea = false,
                MinArea =200, // 10 pixels squared
                MaxArea = 100000,

                FilterByCircularity = false,
                //FilterByCircularity = true,
                //MinCircularity = 0.0F,

                FilterByConvexity = false,
                //FilterByConvexity = true,
                MinConvexity = 1,
                MaxConvexity = 2,

                FilterByInertia = false,
                MinInertiaRatio = 1,

                FilterByColor = true,
                BlobColor = 255,
                // FilterByConvexity = con,
                //FilterByConvexity = true,


            };
            var simpleBlobDetector = SimpleBlobDetector.Create(detectorParams);
            var keyPoints = simpleBlobDetector.Detect(threshold);

            int[] konumlarX = new int[220];
            int[] konumlarY = new int[220];
            //richTextBox1.AppendText("keyPoints: {0}" + " " + keyPoints.Length);

            int x = 0;
            
            foreach (var keyPoint in keyPoints)
            {
                x++;
                // konumlarX[x] = (Convert.ToInt32(keyPoint.Pt.X) - 20);
                konumlarX[x] = (Convert.ToInt32(keyPoint.Pt.X) - 20);
                konumlarY[x] = (Convert.ToInt32(keyPoint.Pt.Y) - 20);
                

                if (keyPoint.Pt.Y < 588)
                {
                    Cv2.Rectangle(threshold,
                        new OpenCvSharp.Point(konumlarX[x] - 10, konumlarY[x]),
                        new OpenCvSharp.Point(konumlarX[x] + 50, konumlarY[x] + 55),
                        Scalar.White, 1);
                }
            }

            // Hedefi vurma kodları ------------------------------------------------------- //


            int hedef_x = konumlarX[x] - 30; // Hedefin x ekseni
            int farki_x = Math.Abs(Math.Abs(hedef_x) - Math.Abs(bucak_goruntu.Left)); 

            int hedef_y = konumlarY[x]; // Hedefin y ekseni
            int farki_y = -1 * (hedef_y - bucak_goruntu.Top); 

                // Bayrak değişkeni

           if (hedef_x > bucak_goruntu.Left)
            {
                if (farki_x <= 25)
                {
                    bucak_goruntu.Left = hedef_x;
                }
                else
                {
                    bucak_goruntu.Left += 25;
                }
            }
            else if (hedef_x < bucak_goruntu.Left)
            {
                if (farki_x <= 25)
                {
                    bucak_goruntu.Left = hedef_x;
                }
                else
                {
                    bucak_goruntu.Left -= 25;
                }
            }
            else if (hedef_x == bucak_goruntu.Left) // Hedefe atıldığında ve daha önce atış yapılmamışsa | devamlı atış yapan kısım
            {
                
                if (!ates_yapay && farki_y > 93)
                {
                    mermiHiz_yapay = 20;
                    mermi_yapay_.Left = bucak_goruntu.Left + 40;
                    mermi_yapay_.Top = bucak_goruntu.Top - 40;
                    ates_yapay = true;
                }
                else if (ates_yapay && mermi_yapay_.Top < 0)
                {
                    ates_yapay = false;
                    mermiHiz_yapay = 0;
                    mermi_yapay_.Top = -100;
                    mermi_yapay_.Left = -100;
                }
            }

            // -------------------------------------------------------------------------------- //

            Bitmap image33 = BitmapConverter.ToBitmap(threshold);
             pictureBox2.Image = image33;
             pictureBox2.Refresh();

            //-------------------- Genel Ayar Yeri ----------------//

            lblsonuc_player.Text = "Puan : " + Puan.ToString();
            lblsonuc_yapay.Text = "Puan : " + Puan_yapay.ToString();

            can_yapay.Text = "% " + progressBar2.Value.ToString();
            can_player.Text = "% " + progressBar1.Value.ToString();

            //----------------------------- Oyuncu uçak ayarları güncelleme yeri ---------------------//    Burası tamam

            bucak.Left += solHareket;
            mermi.Top -= mermiHiz;
            
            ducak1.Top += ducakHareketHiz;
            ducak2.Top += ducakHareketHiz;
            ducak3.Top += ducakHareketHiz;

            // Uçak mermi ayarları //

            ducak_mermi_1.Top += ducakHareketHiz + 2;
            ducak_mermi_2.Top += ducakHareketHiz + 2;
            ducak_mermi_3.Top += ducakHareketHiz + 2;

            //----------------------------- Görüntü işleme uçak ayarları güncelleme yeri -------------//    Burası tamam

            mermi_yapay_.Top -= mermiHiz_yapay;

            ducak_yapay_1.Top += ducakHareketHiz;
            ducak_yapay_2.Top += ducakHareketHiz;
            ducak_yapay_3.Top += ducakHareketHiz;

            // Uçak mermi ayarları //

            ducak_mermi_yapay_1.Top += ducakHareketHiz + 2;
            ducak_mermi_yapay_2.Top += ducakHareketHiz + 2;
            ducak_mermi_yapay_3.Top += ducakHareketHiz + 2;

            //----------------------- Görüntü işleme Ve Oyuncu Ortak Ayar Yeri ------------------------//       660 sonuna gönde öyle bir sorgu yaz canım <3



            if ((ducak1.Top >= 700 && ducak_yapay_1.Top >= 700)) // OK
            {
                int ranP = rnd.Next(630, 750); // Ortak değişken konum belirtiyor. Y Ekseninde. .

                //---- Oyuncu Ayarları ----// 


                ducak1.Top = -1000;
                ducak1.Left = ranP;

                ducak_mermi_1.Top = -1100;
                ducak_mermi_1.Left = ranP + 40;

                //---- Görüntü İşleme Ayarları ----//

                ducak_yapay_1.Top = -1000;
                ducak_yapay_1.Left = ranP - 600; //

                ducak_mermi_yapay_1.Top = -1100;
                ducak_mermi_yapay_1.Left = ranP - 600 + 40;
            }

            if ((ducak2.Top >= 700 && ducak_yapay_2.Top >= 700)) // OK
            {
                int ranP = rnd.Next(750, 850); // Ortak değişken konum belirtiyor. Y Ekseninde. .

                //---- Oyuncu Ayarları ----// 

                ducak2.Top = -3000;
                ducak2.Left = ranP;

                ducak_mermi_2.Top = -3400;
                ducak_mermi_2.Left = ranP + 40;

                //---- Görüntü İşleme Ayarları ----//

                ducak_yapay_2.Top = -3000;
                ducak_yapay_2.Left = ranP - 600; //

                ducak_mermi_yapay_2.Top = -3400;
                ducak_mermi_yapay_2.Left = ranP - 600 + 40;
            }

            if((ducak3.Top >= 700 && ducak_yapay_3.Top >= 700)) // OK
            {
                int ranP = rnd.Next(850, 950); // Ortak değişken konum belirtiyor. Y Ekseninde. . 

                //---- Oyuncu Ayarları ----// 

                ducak3.Top = -4500;
                ducak3.Left = ranP;

                ducak_mermi_3.Top = -5130;
                ducak_mermi_3.Left = ranP + 40;

                //---- Görüntü İşleme Ayarları ----//

                ducak_yapay_3.Top = -4500;
                ducak_yapay_3.Left = ranP - 600; //

                ducak_mermi_yapay_3.Top = -5130;
                ducak_mermi_yapay_3.Left = ranP - 600 + 40;

            }


            // Oyuncunun karşısındaki uçaklar kaçar ise çalışacak kodlar // // OK

            if (ducak1.Top >= 670 && ducak1.Top <= 700)
            {
                carpma.Visible = true;

                ducak1.Top = 10000;

                if (progressBar1.Value <= 10) { oyunSonu(); }
                else { progressBar1.Value -= 10; }
            }

            if (ducak2.Top >= 670 && ducak2.Top <= 700)
            {
                carpma.Visible = true;

                ducak2.Top = 10000;

                if (progressBar1.Value <= 10) { oyunSonu(); }
                else { progressBar1.Value -= 10; }
            }

            if (ducak3.Top >= 670 && ducak3.Top <= 700)
            {
                carpma.Visible = true;

                ducak3.Top = 10000;

                if (progressBar1.Value <= 10) { oyunSonu(); }
                else { progressBar1.Value -= 10; }
            }


            // Görüntü işlemenin karşısındaki uçaklar kaçar ise çalışacak kodlar 

            if (ducak_yapay_1.Top >= 670 && ducak_yapay_1.Top <= 700)
            {
                carpma_yapay.Visible = true;
             
                ducak_yapay_1.Top = 10000;

                if (progressBar2.Value <= 10) { oyunSonu(); }
                else { progressBar2.Value -= 10; }
            }

            if (ducak_yapay_2.Top >= 670 && ducak_yapay_2.Top <= 700)
            {
                carpma_yapay.Visible = true;

                ducak_yapay_2.Top = 10000;

                if (progressBar2.Value <= 10) { oyunSonu(); }
                else { progressBar2.Value -= 10; }
            }
           
            if (ducak_yapay_3.Top >= 670 && ducak_yapay_3.Top <= 700)
            {
                carpma_yapay.Visible = true;

                ducak_yapay_3.Top = 10000;

                if (progressBar2.Value <= 10) { oyunSonu(); }
                else { progressBar2.Value -= 10; }
            }

            //-----------------------------------------------------------------------------------------//

            if (ates && mermi.Top < 0)         // Oyuncu mermi ayarı sürekli güncellenen yer
            {
                ates = false;
                mermiHiz = 0;
                mermi.Top = -100;
                mermi.Left = -100;
            }

            Vurulma();
            
            //-------------------------------------------------------------------------------------------------------/
            //   Oyuncu progressbar renk ayarı      //

            if (progressBar1.Value <= 100 && progressBar1.Value >= 75) { progressBar1.ForeColor = Color.Green; }
            else if (progressBar1.Value >= 50) { progressBar1.ForeColor = Color.Orange; }
            else { progressBar1.ForeColor = Color.Red; }

                                          // Görüntü işleme progressbar renk ayarı //

            if (progressBar2.Value <= 100 && progressBar2.Value >= 75) { progressBar2.ForeColor = Color.Green; }
            else if (progressBar2.Value >= 50) { progressBar2.ForeColor = Color.Orange; }
            else { progressBar2.ForeColor = Color.Red; }

            //-------------------------------------------------------------------------------------------------------/

            hedef_goruntu.Text = "Vurulan Uçak Sayısı : " + (Puan_yapay / 5).ToString();
            hedef_oyuncu.Text = "Vurulan Uçak Sayısı : " + (Puan / 5).ToString();

            if (panel_info.Visible == true)
            { 
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
            }


        }
        private void Vurulma()       // ates değiskeni bakılması gerek !
        {
            // Can kazanma kodları 

            if (heart.Bounds.IntersectsWith(bucak.Bounds))
            {
                heart.Left = 900;
                heart.Top = 900;

                if (progressBar1.Value != 100)
                {
                    progressBar1.Value += 10;
                }
            }

            //----------------- Oyuncu veya Görüntü işleme ile uçak vurulursa çalışacak kodlar --------------------//
            //timer2.Enabled = true;
            // Oyuncu gemiyi vurursa çalışacak kodlar // // OK

            if (mermi.Bounds.IntersectsWith(ducak1.Bounds)) // Oyuncu 1. Gemiyi vurursa çalışacak kodlar.
            {
                Puan += 5;

                ducak1.Top = 100000;
                ducak1.Left = 100000;

                ducak_mermi_1.Top = 100000;
                ducak_mermi_1.Left = 100000;

                
                ates = false;
                mermiHiz = 0;
                mermi.Top = -100;
                mermi.Left = -100;

            }
            else if (mermi.Bounds.IntersectsWith(ducak2.Bounds)) // Oyuncu 2. Gemiyi vurursa çalışacak kodlar.
            {
                Puan += 5;

                ducak2.Top = 100000;
                ducak2.Left = 100000;

                ducak_mermi_2.Top = 100000;
                ducak_mermi_2.Left = 100000;

                ates = false;
                mermiHiz = 0;
                mermi.Top = -100;
                mermi.Left = -100;

            }
            else if (mermi.Bounds.IntersectsWith(ducak3.Bounds)) // Oyuncu 3. Gemiyi vurursa çalışacak kodlar.
            {
                Puan += 5;

                ducak3.Top = 100000;
                ducak3.Left = 100000;

                ducak_mermi_3.Top = 100000;
                ducak_mermi_3.Left = 100000;

                ates = false;
                mermiHiz = 0;
                mermi.Top = -100;
                mermi.Left = -100;
            }

            // Görüntü işleme gemiyi vurursa çalışacak kodlar //
            if (mermi_yapay_.Bounds.IntersectsWith(ducak_yapay_1.Bounds)) // Görüntü işleme 1. Gemiyi vurursa çalışacak kodlar.
            {
                Puan_yapay += 5;

                ducak_yapay_1.Top = 900;
                ducak_yapay_1.Left = 900;

                ducak_mermi_yapay_1.Top = 900;
                ducak_mermi_yapay_1.Left = 900 + 40;

                ates_yapay = false;
                mermiHiz_yapay = 0;
                mermi_yapay_.Top = -100;
                mermi_yapay_.Left = -100;
            }
            else if (mermi_yapay_.Bounds.IntersectsWith(ducak_yapay_2.Bounds)) // Görüntü işleme 2. Gemiyi vurursa çalışacak kodlar.
            {
                Puan_yapay += 5;

                ducak_yapay_2.Top = 900;
                ducak_yapay_2.Left = 900;

                ducak_mermi_yapay_2.Top = 900;
                ducak_mermi_yapay_2.Left = 900 + 40;

                ates_yapay = false;
                mermiHiz_yapay = 0;
                mermi_yapay_.Top = -100;
                mermi_yapay_.Left = -100;
            }
            else if (mermi_yapay_.Bounds.IntersectsWith(ducak_yapay_3.Bounds)) // Görüntü işleme 3. Gemiyi vurursa çalışacak kodlar.
            {
                Puan_yapay += 5;

                ducak_yapay_3.Top = 900;
                ducak_yapay_3.Left = 900;

                ducak_mermi_yapay_3.Top = 900;
                ducak_mermi_yapay_3.Left = 900 + 40;

                ates_yapay = false;
                mermiHiz_yapay = 0;
                mermi_yapay_.Top = -100;
                mermi_yapay_.Left = -100;
            }


            //----------------- Oyuncu veya Görüntü işleme ile karşıdan gelen uçak mermileri bizi vurursa --------------------//

            // Oyuncunun karşısındaki uçaklardan mermi yerse çalışacak kodlar //

            if (ducak_mermi_1.Bounds.IntersectsWith(bucak.Bounds))
            {
                carpma.Visible = true;

                ducak_mermi_1.Top = 900;
                ducak_mermi_1.Left = 900;

                if (progressBar1.Value <= 10) { oyunSonu(); }
                else { progressBar1.Value -= 10; }
            }
            else if (ducak_mermi_2.Bounds.IntersectsWith(bucak.Bounds))
            {
                carpma.Visible = true;

                ducak_mermi_2.Top = 900;
                ducak_mermi_2.Left = 900;

                if (progressBar1.Value <= 10) { oyunSonu(); }
                else { progressBar1.Value -= 10; }
            }
            else if (ducak_mermi_3.Bounds.IntersectsWith(bucak.Bounds))
            {
                carpma.Visible = true;

                ducak_mermi_3.Top = 900;
                ducak_mermi_3.Left = 900;

                if (progressBar1.Value <= 10) { oyunSonu(); }
                else { progressBar1.Value -= 10; }
            }

            // Görüntü işleme karşısındaki uçaklardan mermi yerse çalışacak kodlar //       PROGRESSBAR AYARLANACAK. . !

            if (ducak_mermi_yapay_1.Bounds.IntersectsWith(bucak_goruntu.Bounds))
            {
                carpma_yapay.Visible = true;

                ducak_mermi_yapay_1.Top = 900;
                ducak_mermi_yapay_1.Left = 900;

                if (progressBar2.Value <= 10) { oyunSonu(); }
                else { progressBar2.Value -= 10; }

            }
            else if (ducak_mermi_yapay_2.Bounds.IntersectsWith(bucak_goruntu.Bounds))
            {
                carpma_yapay.Visible = true;

                ducak_mermi_yapay_2.Top = 900;
                ducak_mermi_yapay_2.Left = 900;

                if (progressBar2.Value <= 10) { oyunSonu(); }
                else { progressBar2.Value -= 10; }
            }
            else if (ducak_mermi_yapay_3.Bounds.IntersectsWith(bucak_goruntu.Bounds))
            {
                carpma_yapay.Visible = true;

                ducak_mermi_yapay_3.Top = 900;
                ducak_mermi_yapay_3.Left = 900;

                if (progressBar2.Value <= 10) { oyunSonu(); }
                else { progressBar2.Value -= 10; }
            }


            ///-------------------------------- Oyuncu ve görüntü işleme mermileri vurursa çalışacak kodlar --------------------------------//

            // Oyuncu mermiyi vurursa çalışacak kodlar //

            if (mermi.Bounds.IntersectsWith(ducak_mermi_1.Bounds))
            {
                ducak_mermi_1.Top = 900;
                ducak_mermi_1.Left = 900;
            }
            else if (mermi.Bounds.IntersectsWith(ducak_mermi_2.Bounds))
            {
                ducak_mermi_2.Top = 900;
                ducak_mermi_2.Left = 900;
            }
            else if (mermi.Bounds.IntersectsWith(ducak_mermi_3.Bounds))
            {
                ducak_mermi_3.Top = 900;
                ducak_mermi_3.Left = 900;
            }

            // Görüntü işleme mermiyi vurursa çalışacak kodlar //

            if (mermi_yapay_.Bounds.IntersectsWith(ducak_mermi_yapay_1.Bounds))
            {
                ducak_mermi_yapay_1.Top = 900;
                ducak_mermi_yapay_1.Left = 900;
            }
            else if (mermi_yapay_.Bounds.IntersectsWith(ducak_mermi_yapay_2.Bounds))
            {
                ducak_mermi_yapay_2.Top = 900;
                ducak_mermi_yapay_2.Left = 900;
            }
            else if (mermi_yapay_.Bounds.IntersectsWith(ducak_mermi_yapay_3.Bounds))
            {
                ducak_mermi_yapay_3.Top = 900;
                ducak_mermi_yapay_3.Left = 900;
            }

            //------------------------------------------------------------------------------------------------------------------------------//

        }

        private void oyunSonu(bool control = false)
        {
            timer2.Enabled = false;
            timer1.Enabled = false;

            carpma.Visible = true;

            if (progressBar1.Value <= 10)
            {
                kaybeden = "Oyuncu";
            }
            else { kaybeden = "Yapay Zeka"; }

            if (!control)
            {
            kazanilan_puan.Text = "Puan : " + Puan.ToString();
                panel_info.Visible = true;
                panel_info.Refresh();
                kazanan.Refresh();
                kazanilan_puan.Refresh();
                System.Threading.Thread.Sleep(100);
            }

            Puan = 0;
            Puan_yapay = 0;

            lblsonuc_player.Text = "0";
            lblsonuc_yapay.Text = "0";

            progressBar1.Value = 100;
            progressBar2.Value = 100;

            // Oyuncu ayarları sıfırlama yeri //

            ducak1.Top = 900;
            ducak2.Top = 900;
            ducak3.Top = 900;

            ducak_mermi_1.Top = 900;
            ducak_mermi_1.Left = 900;

            ducak_mermi_2.Top = 900;
            ducak_mermi_2.Left = 900;

            ducak_mermi_3.Top = 900;
            ducak_mermi_3.Left = 900;

            mermi.Top = -100;
            mermi.Left = -100;


            // Görüntü işleme ayarları sıfırlama yeri //

            ducak_yapay_1.Top = 900;
            ducak_yapay_2.Top = 900;
            ducak_yapay_3.Top = 900;

            ducak_mermi_yapay_1.Top = 900;
            ducak_mermi_yapay_1.Left = 900;

            ducak_mermi_yapay_2.Top = 900;
            ducak_mermi_yapay_2.Left = 900;

            ducak_mermi_yapay_3.Top = 900;
            ducak_mermi_yapay_3.Left = 900;

            mermi_yapay_.Top = -100;
            mermi_yapay_.Left = -100;

            ates_yapay = false;

            
            //panel_info.Visible = true;
            timer1.Enabled = false;
            timer2.Enabled = false;


            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblsonuc_Click(object sender, EventArgs e)
        {

        }

        private void bucak_Click(object sender, EventArgs e)
        {

        }

        private void ducak_mermi_1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            carpma.Visible = false;
            carpma_yapay.Visible = false;
        }

        private void carpma_yapay_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void panel_info_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            var controller = new Controller(UserIndex.One);
            var state = controller.GetState();

            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start))
            {
                timer1.Start();
                panel_info.Visible = false;
                timer2.Enabled = true;
                timer1.Enabled = true;
            }


        }
    }
}
