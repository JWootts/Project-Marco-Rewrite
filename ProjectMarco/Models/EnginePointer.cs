using ProjectMarco.Helpers;
using ProjectMarco.Interface;
using System;

namespace ProjectMarco.Models
{
	public class EnginePointer : IModel
	{
		private string _engine = "engine.dll+";

		public EnginePointer(int dwClientState)
		{
			int? returnVal = MemHandler.ReturnHandler().ReadInt(_engine + Convert.ToString(dwClientState, 16));
			this.Offset = (returnVal != null ? returnVal : 0) ;
		}

		public int? Offset { get; set; }

		public void WritePointer(IModel model, int offsetPlus, int toWrite)
		{
			int _offset = (model.Offset != null ? (int)model.Offset : 0);

			MemHandler.ReturnHandler().WriteMemory(Convert.ToString((Offset != null ? (int)Offset : 0) + (model.Offset != null ? (int)model.Offset : 0) + offsetPlus, 16), "float", toWrite.ToString());
		}

		public float ReadPointer(IModel model)
		{
			return MemHandler.ReturnHandler().ReadFloat(Convert.ToString((Offset != null ? (int)Offset : 0) + (model.Offset != null ? (int)model.Offset : 0), 16));
		}
	}
}
