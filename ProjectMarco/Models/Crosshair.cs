using Newtonsoft.Json;
using ProjectMarco.Interface;

namespace ProjectMarco.Models
{
	public class Crosshair : IModel
	{
		public Crosshair(int _offset)
		{
			this.Offset = _offset;
		}

		public int? Offset { get ; set; }
	}
}
