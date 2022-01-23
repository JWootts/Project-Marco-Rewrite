using System.IO;
using System.Net;

namespace ProjectMarco.Helpers
{
	public static class DataExtractor
	{
		private const string GITHUB_URI = "https://raw.githubusercontent.com/JWootts/marco_offsets/main/export.json";
		private static string[] INVALID_CHARS = new string[] { "\r", "\n", "\\", "\"", "{" };


		public static void ExtractOffsetData()
		{
			string returnVals = GET(GITHUB_URI);

			foreach (var c in INVALID_CHARS)
			{
				returnVals = returnVals.Replace(c, string.Empty);
			}
		}

		private static string GET(string uri)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				return reader.ReadToEnd();
			}
		}

	}
}
