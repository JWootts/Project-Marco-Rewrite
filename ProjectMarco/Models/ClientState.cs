using ProjectMarco.Interface;

namespace ProjectMarco.Models
{
	public class ClientState : IModel
	{

		public ClientState(int _offset)
		{
			this.Offset = _offset;
		}

		public int? Offset { get; set; }

		public string clientString { get; } = "client.dll+";
	}
}
