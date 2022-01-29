using Newtonsoft.Json;
using ProjectMarco.Models;

namespace ProjectMarco.Interface
{
	partial class ModelList
	{
		private Crosshair _crosshair = new Crosshair();
		private ClientState _clientState = new ClientState();
		private EnginePointer _enginePointer;

		[JsonProperty(PropertyName = "m_iCrosshairId")]
		int m_iCrosshairId
		{
			get => (int)_crosshair.Offset; set { _crosshair.Offset = value; }
		}

		[JsonProperty(PropertyName = "dwClientState")]
		int dwClientState 
		{
			get => (int)_clientState.Offset; 
			set
			{
				_enginePointer = new EnginePointer(value);
				_clientState.Offset = value;
			}
		}


		//To-continue
	}
}
