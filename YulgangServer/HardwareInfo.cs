using System;
using System.Management;

namespace YulgangServer
{
	internal class HardwareInfo
	{
		public static string GetProcessorId()
		{
			ManagementClass managementClass = new ManagementClass("win32_processor");
			ManagementObjectCollection instances = managementClass.GetInstances();
			string result = string.Empty;
			using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = instances.GetEnumerator())
			{
				if (managementObjectEnumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
					result = managementObject.Properties["processorID"].Value.ToString();
				}
			}
			return result;
		}

		public static string GetHDDSerialNo()
		{
			ManagementClass managementClass = new ManagementClass("Win32_LogicalDisk");
			ManagementObjectCollection instances = managementClass.GetInstances();
			string text = "";
			foreach (ManagementObject item in instances)
			{
				text += Convert.ToString(item["VolumeSerialNumber"]);
			}
			return text;
		}

		public static string GetMACAddress()
		{
			ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
			ManagementObjectCollection instances = managementClass.GetInstances();
			string text = string.Empty;
			foreach (ManagementObject item in instances)
			{
				if (text == string.Empty && (bool)item["IPEnabled"])
				{
					text = item["MacAddress"].ToString();
				}
				item.Dispose();
			}
			return text.Replace(":", "");
		}

		public static string GetBoardMaker()
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				try
				{
					return item.GetPropertyValue("Manufacturer").ToString();
				}
				catch
				{
				}
			}
			return "Board Maker: Unknown";
		}

		public static string GetBoardProductId()
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				try
				{
					return item.GetPropertyValue("Product").ToString();
				}
				catch
				{
				}
			}
			return "Product: Unknown";
		}

		public static string GetCdRomDrive()
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_CDROMDrive");
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				try
				{
					return item.GetPropertyValue("Drive").ToString();
				}
				catch
				{
				}
			}
			return "CD ROM Drive Letter: Unknown";
		}

		public static string GetBIOSmaker()
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				try
				{
					return item.GetPropertyValue("Manufacturer").ToString();
				}
				catch
				{
				}
			}
			return "BIOS Maker: Unknown";
		}

		public static string GetBIOSserNo()
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				try
				{
					return item.GetPropertyValue("SerialNumber").ToString();
				}
				catch
				{
				}
			}
			return "BIOS Serial Number: Unknown";
		}

		public static string GetBIOScaption()
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				try
				{
					return item.GetPropertyValue("Caption").ToString();
				}
				catch
				{
				}
			}
			return "BIOS Caption: Unknown";
		}

		public static string GetAccountName()
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_UserAccount");
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				try
				{
					return item.GetPropertyValue("Name").ToString();
				}
				catch
				{
				}
			}
			return "User Account Name: Unknown";
		}

		public static string GetPhysicalMemory()
		{
			ManagementScope scope = new ManagementScope();
			ObjectQuery query = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(scope, query);
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			long num = 0L;
			long num2 = 0L;
			foreach (ManagementObject item in managementObjectCollection)
			{
				num2 = Convert.ToInt64(item["Capacity"]);
				num += num2;
			}
			return (num / 1024 / 1024).ToString() + "MB";
		}

		public static string GetNoRamSlots()
		{
			int num = 0;
			ManagementScope scope = new ManagementScope();
			ObjectQuery query = new ObjectQuery("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray");
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(scope, query);
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			foreach (ManagementObject item in managementObjectCollection)
			{
				num = Convert.ToInt32(item["MemoryDevices"]);
			}
			return num.ToString();
		}

		public static string GetCPUManufacturer()
		{
			string text = string.Empty;
			ManagementClass managementClass = new ManagementClass("Win32_Processor");
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementObject item in instances)
			{
				if (text == string.Empty)
				{
					text = item.Properties["Manufacturer"].Value.ToString();
				}
			}
			return text;
		}

		public static int GetCPUCurrentClockSpeed()
		{
			int num = 0;
			ManagementClass managementClass = new ManagementClass("Win32_Processor");
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementObject item in instances)
			{
				if (num == 0)
				{
					num = Convert.ToInt32(item.Properties["CurrentClockSpeed"].Value.ToString());
				}
			}
			return num;
		}

		public static string GetDefaultIPGateway()
		{
			ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
			ManagementObjectCollection instances = managementClass.GetInstances();
			string text = string.Empty;
			foreach (ManagementObject item in instances)
			{
				if (text == string.Empty && (bool)item["IPEnabled"])
				{
					text = item["DefaultIPGateway"].ToString();
				}
				item.Dispose();
			}
			return text.Replace(":", "");
		}

		public static double? GetCpuSpeedInGHz()
		{
			double? result = null;
			using (ManagementClass managementClass = new ManagementClass("Win32_Processor"))
			{
				using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementClass.GetInstances().GetEnumerator())
				{
					if (managementObjectEnumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
						result = 0.001 * (double)(uint)managementObject.Properties["CurrentClockSpeed"].Value;
						return result;
					}
				}
			}
			return result;
		}

		public static string GetCurrentLanguage()
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				try
				{
					return item.GetPropertyValue("CurrentLanguage").ToString();
				}
				catch
				{
				}
			}
			return "BIOS Maker: Unknown";
		}

		public static string GetOSInformation()
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				try
				{
					return ((string)item["Caption"]).Trim() + ", " + (string)item["Version"] + ", " + (string)item["OSArchitecture"];
				}
				catch
				{
				}
			}
			return "BIOS Maker: Unknown";
		}

		public static string GetProcessorInformation()
		{
			ManagementClass managementClass = new ManagementClass("win32_processor");
			ManagementObjectCollection instances = managementClass.GetInstances();
			string result = string.Empty;
			foreach (ManagementObject item in instances)
			{
				string text = (string)item["Name"];
				text = text.Replace("(TM)", "™").Replace("(tm)", "™").Replace("(R)", "®")
					.Replace("(r)", "®")
					.Replace("(C)", "©")
					.Replace("(c)", "©")
					.Replace("    ", " ")
					.Replace("  ", " ");
				result = text + ", " + (string)item["Caption"] + ", " + (string)item["SocketDesignation"];
			}
			return result;
		}

		public static string GetComputerName()
		{
			ManagementClass managementClass = new ManagementClass("Win32_ComputerSystem");
			ManagementObjectCollection instances = managementClass.GetInstances();
			string result = string.Empty;
			foreach (ManagementObject item in instances)
			{
				result = (string)item["Name"];
			}
			return result;
		}
	}
}
