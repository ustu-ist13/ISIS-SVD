﻿using System.Collections;
using System.Collections.Generic;

namespace VendorMachine.VendorInterface
{
    /// <summary>
    /// Интерфейс обслуживания автомата
    /// </summary>
    interface IService 
    {
        /// <summary>
        /// Оповестить техника
        /// </summary>
        void NotifyTechnician();
        /// <summary>
        /// Протестировать устройства на работоспособность
        /// </summary>
        void TestDevices(IEnumerable<IDevice> devices);
        /// <summary>
        /// Отправить письма на почту техника
        /// </summary>
        void SendMail();
    }
}
