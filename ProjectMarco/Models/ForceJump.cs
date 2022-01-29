using ProjectMarco.Interface;
using System;

namespace ProjectMarco.Models
{
	public class ForceJump
	{
		public ForceJump(string clientStr, int m_ForceJump)
		{
			this.Offset = clientStr + Convert.ToString(m_ForceJump, 16);
		}
		
		public string Offset { get; set; } = "";
	}
}
