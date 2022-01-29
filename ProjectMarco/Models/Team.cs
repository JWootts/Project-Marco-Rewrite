using ProjectMarco.Helpers;
using ProjectMarco.Interface;
using System;

namespace ProjectMarco.Models
{
	public class Team : IModel
	{
		public Team(Player plr, int teamNum)
		{
			int? returnVal = MemHandler.ReturnHandler().ReadInt(Convert.ToString((int)plr.Offset + teamNum, 16));
			this.Offset = (returnVal != null ? returnVal : 0);
		}

		public Team(int teamNum)
		{
			this.Offset = teamNum;
		}

		public int? Offset { get; set; }
		public int TeamID { get; set; }
		public Crosshair _teamCrosshair { get; set; }
	}
}
