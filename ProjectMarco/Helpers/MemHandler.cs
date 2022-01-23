using Memory;

namespace ProjectMarco.Helpers
{
	public class MemHandler
	{
		private Mem _mem;

		public MemHandler()
		{
			_mem = new Mem();
		}

		public void CloseProcess() { _mem.CloseProcess(); }
	}
}
