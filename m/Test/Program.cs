// See https://aka.ms/new-console-template for more information
using InTheHand.Net.Bluetooth;
using InTheHand.Net;
using InTheHand.Net.Sockets;

Console.WriteLine("Hello, World!");
BluetoothClient client = new BluetoothClient();
//获取电脑蓝牙
BluetoothRadio radio = BluetoothRadio.PrimaryRadio;
//设置电脑蓝牙可被搜索到
radio.Mode = RadioMode.Connectable;
//需要连接的蓝牙模块的唯一标识符
//这里需要注意一下，虽然下面foreach里能根据蓝牙名称找到唯一标识符，但是我们这里也要给个默认值，否则的话下面会有报错提示
BluetoothAddress blueAddress = new BluetoothAddress(new byte[] { 0x8e, 0xed, 0x10, 0xa3, 0xa8, 0xaa });
//搜索蓝牙设备，10秒
BluetoothDeviceInfo[] devices = client.DiscoverDevices();
//从搜索到的所有蓝牙设备中选择需要的那个
foreach (var item in devices)
{
    Console.WriteLine(item.DeviceName);
    //根据蓝牙名字找
    //if (item.DeviceName.Equals("BarCode Scanner HID"))
    //{
    //    Console.WriteLine(item.DeviceAddress);
    //    Console.WriteLine(item.DeviceName);
    //    //获得蓝牙模块的唯一标识符
    //    blueAddress = item.DeviceAddress;
    //    break;
    //}
}
