namespace VendorMachine.VendorInterfaces
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
        void TestDevices();
    }
}
