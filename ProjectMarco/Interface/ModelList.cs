using Newtonsoft.Json;
using ProjectMarco.Models;
using System.Collections.Generic;

namespace ProjectMarco.Interface
{
	public class ModelList
	{
		private const int MAX_PLAYERS = 32;
		protected Dictionary<int, Player> allPlayers = new Dictionary<int, Player>(); //Dict to hold all players within game

		protected Crosshair _crosshair;
		protected ClientState _clientState;
		protected EnginePointer _enginePointer;
		protected Player _player;
		protected Flash _flash;
		protected ForceJump _forceJump;
		protected Glow _glow;
		protected Team _team;


		/* continue with these --- may need to reorder JSON to match if need objects loaded first
		protected Ground _ground;
		protected PlayerResource _playerResource;
		protected ShotsFired _shotsFired;
		*/

		[JsonProperty(PropertyName = "dwClientState")]
		protected int dwClientState
		{
			get => (int)_clientState.Offset;
			set
			{
				_enginePointer = new EnginePointer(value);
				_clientState = new ClientState(value);
			}
		}

		[JsonProperty(PropertyName = "m_iCrosshairId")]
		protected int m_iCrosshairId
		{
			get => (int)_crosshair.Offset; set { _crosshair = new Crosshair(value); }
		}

		[JsonProperty(PropertyName = "dwLocalPlayer")]
		protected int dwLocalPlayer
		{
			get => (int)_player.Offset;
			set
			{
				_player = new Player(value, _clientState.clientString);
			}
		}

		[JsonProperty(PropertyName = "m_flFlashMaxAlpha")]
		protected int m_flFlashMaxAlpha
		{
			get => (int)_flash.Offset;
			set
			{
				_flash = new Flash(dwLocalPlayer, value);
			}
		}

		[JsonProperty(PropertyName = "dwForceJump")]
		protected string m_ForceJump
		{
			get => _forceJump.Offset;
			set
			{
				_forceJump = new ForceJump(_clientState.clientString, int.Parse(value));
			}
		}

		[JsonProperty(PropertyName = "m_iGlowIndex")]
		protected int m_iGlowIndex
		{
			get => (int)_glow.Offset;
			set
			{
				_glow = new Glow(value);
			}
		}

		[JsonProperty(PropertyName = "m_iTeamNum")]
		protected int TeamNum
		{
			get => (int)_team.Offset;
			set
			{
				_team = new Team(value);
			}
		}

		[JsonProperty(PropertyName = "dwEntityList")]
		protected int dwEntityList
		{
			set
			{
				for (int i = 1; i < MAX_PLAYERS; ++i)
				{
					Player tmpPlayer = new Player(value + i * 0x10, _clientState.clientString);
					tmpPlayer._glow = new Glow(tmpPlayer, m_iGlowIndex);
					tmpPlayer._team = new Team(tmpPlayer, TeamNum);

					if (!allPlayers.ContainsKey((int)tmpPlayer.Offset))
						allPlayers.Add((int)tmpPlayer.Offset, tmpPlayer);
				}
			}
		}

		//To-continue
	}
}
