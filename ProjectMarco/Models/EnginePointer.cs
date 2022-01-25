using ProjectMarco.Helpers;
using ProjectMarco.Interface;
using System;

namespace ProjectMarco.Models
{
	public static class EnginePointer
	{
		public static int Offset { get; set; }

		public static void WritePointer(IModel model, int offsetPlus, int toWrite)
		{
			MemHandler.ReturnHandler().WriteMemory(Convert.ToString(Offset + model.Offset + offsetPlus, 16), "float", toWrite.ToString());
		}

		public static float ReadPointer(IModel model)
		{
			return MemHandler.ReturnHandler().ReadFloat(Convert.ToString(Offset + model.Offset, 16));
		}
	}
}
