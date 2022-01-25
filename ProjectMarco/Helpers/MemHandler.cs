using Memory;

namespace ProjectMarco.Helpers
{
	public static class MemHandler
	{
		private static Mem _mem = new Mem();

		public static void CloseProcess() { _mem.CloseProcess(); }

		public static Mem ReturnHandler()
		{
			return _mem;
		}
	}
}
