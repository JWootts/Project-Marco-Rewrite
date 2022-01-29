using ProjectMarco.Helpers;
using ProjectMarco.Interface;
using System;

namespace ProjectMarco.Models
{
	public class Glow : IModel
	{
		public Glow(Player plr, int _offset)
		{
			int? returnVal = MemHandler.ReturnHandler().ReadInt(Convert.ToString((int)plr.Offset + _offset, 16));
			this.Offset = (returnVal != null ? returnVal : 0);
		}

		public Glow(int m_iGlowIndex)
		{
			this.Offset = m_iGlowIndex;
		}

		public int? Offset { get; set; }
	}
}
