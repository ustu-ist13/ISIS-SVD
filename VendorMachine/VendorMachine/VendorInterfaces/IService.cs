namespace VendorMachine.VendorInterfaces
{
    /// <summary>
    /// Интерфейс обслуживания автомата
    /// </summary>
    interface IService //пока не знаю, что сюда пихать
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
