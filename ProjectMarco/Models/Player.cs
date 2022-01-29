using ProjectMarco.Helpers;
using ProjectMarco.Interface;
using System;

namespace ProjectMarco.Models
{
	public class Player : IModel
	{
		public Player(int dwLocalPlayer, string clientStr)
		{
			int? returnVal = MemHandler.ReturnHandler().ReadInt(clientStr + Convert.ToString(dwLocalPlayer, 16));
			this.Offset = (returnVal != null ? returnVal : 0);
		}

		public Player(int _offset)
		{
			this.Offset = _offset;
		}

		public int? Offset { get; set; }
		public Team _team { get; set; }
		public Crosshair _crosshair { get; set; }
		public Ground _onGround { get; set; }
		public Glow _glow { get; set; }
	}
}
