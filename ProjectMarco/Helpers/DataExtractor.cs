using Newtonsoft.Json;
using ProjectMarco.Interface;
using System.IO;
using System.Net;

namespace ProjectMarco.Helpers
{
	public static class DataExtractor
	{
		private const string GITHUB_URI = "https://raw.githubusercontent.com/JWootts/marco_offsets/main/export.json";

		public static void ExtractOffsetData()
		{
			ModelList _imodels = JsonConvert.DeserializeObject<ModelList>(GET(GITHUB_URI));

			

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
