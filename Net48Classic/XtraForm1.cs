using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Net48Classic
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            string appName = Application.ProductName;
            string appVersion = Application.ProductVersion.Split('+')[0]; // Remove hash if present

            string appBitDepth = Environment.Is64BitProcess ? "64-bit" : "32-bit";
            string appArchitecture = RuntimeInformation.ProcessArchitecture.ToString();
            string appFramework = RuntimeInformation.FrameworkDescription;

            string osVersion = Environment.OSVersion.VersionString;
            string osBitDepth = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
            string osArchitecture = RuntimeInformation.OSArchitecture.ToString();

            Text =
                $"Application: {appName} [{appVersion}] " +
                $"running as {appBitDepth} {appArchitecture} " +
                $"using {appFramework} " +
                $"on {osVersion} {osBitDepth} and {osArchitecture} processor";

        }

    }
}