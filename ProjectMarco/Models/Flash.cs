using ProjectMarco.Interface;

namespace ProjectMarco.Models
{
	public class Flash : IModel
	{
		public Flash(int player, int flFlashMaxAlpha)
		{
			this.Offset = player + flFlashMaxAlpha;
		}
		
		public int? Offset { get; set; }
	}
}
