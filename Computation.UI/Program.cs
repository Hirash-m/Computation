

using Computation.UI.Forms.Inventory;
using Computation.UI.Forms.Person;

namespace Computation.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
           

            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new InventoryForm());
            
        }
    }
}
