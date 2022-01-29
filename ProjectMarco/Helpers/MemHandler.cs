using Memory;
using System;

namespace ProjectMarco.Helpers
{
	public static class MemHandler
	{
		private static Mem _mem = new Mem();

		static MemHandler()
		{
			try
			{
				var PID = _mem.GetProcIdFromName("csgo");
				_mem.OpenProcess(PID);

			}catch(Exception ex)
			{

			}
		}
		
		public static void CloseProcess() { _mem.CloseProcess(); }

		public static Mem ReturnHandler()
		{
			return _mem;
		}
	}
}
