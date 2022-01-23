using ProjectMarco.Interface;

namespace ProjectMarco.Models
{
	public class Player : IModel
	{
		public int Offset { get; set; }
		public Team _team { get; set; }
		public Crosshair _crosshair { get; set; }
		public Ground _onGround { get; set; }
		public ForceJump _forceJump { get; set; }
		public Glow _glow { get; set; }
	}
}
