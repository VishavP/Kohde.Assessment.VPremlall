using System;
using Kohde.Assessment.Container;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kohde.Assessment.UnitTest
{
    [TestClass]
    public class IoCTestSection
    {
        [TestMethod]
        public void DependancyInjectionTest()
        {
            Program.PerformIoCActions();
            SimpleContainer simpleContainer = new SimpleContainer();
            SamsungDevice device = new SamsungDevice();
            simpleContainer.RegisterInstance<IDevice>(device);
            DeviceProcessor deviceProcessor = new DeviceProcessor(device);
            simpleContainer.RegisterInstance<IDeviceProcessor>(deviceProcessor);
            deviceProcessor = (DeviceProcessor)simpleContainer.Resolve(typeof(IDeviceProcessor));
            var processor = deviceProcessor as IDeviceProcessor;
            Assert.IsNotNull(processor, "IDeviceProcessor has not been implemented correctly");
            // call the GetDevicePrice method
            Console.WriteLine("Device Price: {0:C}", processor.GetDevicePrice());
        }
    }
}
