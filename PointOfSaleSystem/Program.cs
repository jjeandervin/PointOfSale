using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using PointOfSale.Bus;
using PointOfSale.Entity;

namespace PointOfSaleSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var kernel = new StandardKernel();
            ModuleLoadExtensions.Load(kernel, Assembly.GetExecutingAssembly());
            var productManager = kernel.Get<IProductManager>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PointOfSaleSystem(productManager));
            
        }

    }
}
