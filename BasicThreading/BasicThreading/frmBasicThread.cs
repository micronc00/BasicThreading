using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyThreads
{
    public partial class frmBasicThread : Form
    {
        public frmBasicThread()
        {
            InitializeComponent();
        }

        public void MyThreads()
        {
            lbl_Thread.Text = "-Before starting thread-";


            MyThreadClass ThreadClass = new MyThreadClass();

            Thread threadA = new Thread(new ThreadStart(ThreadClass.thread1));

            Thread threadB = new Thread(new ThreadStart(ThreadClass.thread2));

            threadA.Name = "Thread A Process";
            Console.WriteLine("-Before starting thread-");
            threadA.Start();

            threadB.Name = "Thread B Process";
            Console.WriteLine("-Before starting thread-");
            threadB.Start();

            threadA.Join();
            threadB.Join();

            Console.WriteLine("-Ends of Thread-");

            lbl_Thread.Text = "-Ends of Thread-";
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            MyThreads();
        }
    }
}
