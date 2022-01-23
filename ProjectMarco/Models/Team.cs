using ProjectMarco.Interface;

namespace ProjectMarco.Models
{
	public class Team : IModel
	{
		public int Offset { get; set; }
		public int TeamID { get; set; }
		public Crosshair _teamCrosshair { get; set; }
	}
}
