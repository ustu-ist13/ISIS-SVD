using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine.VendorInterface
{
    public interface IDevice
    {
        /// <summary>
        /// Название устройства
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Статус устройства
        /// </summary>
        bool Status { get; set; }
    }
}
