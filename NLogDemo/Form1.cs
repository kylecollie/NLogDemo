using System;
using System.Windows.Forms;

namespace NLogDemo
{
    public partial class frmNLogDemo : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public frmNLogDemo()
        {
            InitializeComponent();
        }
        //https://github.com/nlog/NLog/wiki/How-to-log-exceptions
        private void btnTrace_Click(object sender, EventArgs e)
        {
            logger.Trace("This is a trace message.");
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            logger.Debug("This is a debug message.");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            logger.Info("This is an info message.");
        }

        private void btnWarn_Click(object sender, EventArgs e)
        {
            logger.Warn("This is a warning message.");
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            try
            {
                lblResult.Text =  (Convert.ToDecimal(tbxDividend.Text) / Convert.ToDecimal(tbxDivisor.Text)).ToString();
                lblResult.Visible = true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "This is an error message.");
            }
        }

        private void btnFatal_Click(object sender, EventArgs e)
        {
            logger.Fatal("This is a fatal message.");
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            //off
        }
    }
}
