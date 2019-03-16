using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenshotSaver
{
    public partial class Form1 : Form
    {
        string fileSavePath;
        string documentName;
        int cnt = 1;
        public Form1()
        {
            //Application.AddMessageFilter(m_filter);
            //this.KeyUp+= new KeyEventHandler(key_press);
            InitializeComponent();
        }
        BackgroundWorker bgw = new BackgroundWorker();
        private void btn_Start_Click(object sender, EventArgs e)
        {
            fileSavePath = txt_Path.Text;
            documentName = txt_DocName.Text;
            //bgw.DoWork += new DoWorkEventHandler(Worker_Test);
            //Worker.RunWorkerAsync(2000);
            KeyboardListener.s_KeyEventHandler += new EventHandler(KeyboardListener_s_KeyEventHandler);
        }
        public void ScreenCapture(string initialDirectory,string filename)
        {
            using (BackgroundWorker worker = new BackgroundWorker())
            {
                Thread.Sleep(0);
                this.Refresh();
                worker.DoWork += delegate (object sender, DoWorkEventArgs e) {
                    BackgroundWorker wkr = sender as BackgroundWorker;
                    Rectangle bounds = new Rectangle(Location, Size);
                    Thread.Sleep(300);
                    //Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
                    Size screenSize = Screen.AllScreens.Select(s=>s.Bounds).Aggregate(Rectangle.Union).Size;
                    Bitmap bitmap = new Bitmap(screenSize.Width,screenSize.Height);
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        //g.CopyFromScreen(Location, Point.Empty, bitmap.Size);
                        g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, screenSize);
                    }
                    e.Result = bitmap;
                };
                worker.RunWorkerCompleted += delegate (object sender, RunWorkerCompletedEventArgs e) {
                    if (e.Error != null)
                    {
                        Exception err = e.Error;
                        while (err.InnerException != null)
                        {
                            err = err.InnerException;
                        }
                        MessageBox.Show(err.Message, "Screen Capture",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if (e.Cancelled == true)
                    {
                    }
                    else if (e.Result != null)
                    {
                        if (e.Result is Bitmap)
                        {
                            Bitmap bitmap = (Bitmap)e.Result;
                            string path = fileSavePath != "" ? fileSavePath : initialDirectory;
                            bitmap.Save(path+ "/"+filename+".jpg");
                        }
                    }
                };
                worker.RunWorkerAsync();
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }
        private void KeyboardListener_s_KeyEventHandler(object sender, EventArgs e)
        {
            KeyboardListener.UniversalKeyEventArgs eventArgs = (KeyboardListener.UniversalKeyEventArgs)e;
            
            // 256 : key down    257 : key up
            if (eventArgs.m_Msg == 257 && eventArgs.m_Key==44)
            {
                string fName = documentName != "" ? documentName : "image";
                //ScreenCapture(fileSavePath);
                ScreenCapture(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    fName +Convert.ToString(cnt));
                cnt++;
            }

        }
    }
}
