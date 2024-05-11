

using Computation.UI.Forms;
using Computation.UI.Forms.Inventory;
using Computation.UI.Forms.Person;
using Computation.UI.MainData.Person;
using OfficeOpenXml;

namespace Computation.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new ToolbarForm1());
            
        }
    }
}
