using Newtonsoft.Json;

namespace FormstackSharp.model
{
		public partial class Form
		{
			[JsonProperty("last_submission_id")]
			public string LastSubmissionId { get; set; }

			[JsonProperty("submissions")]
			public long Submissions { get; set; }

			[JsonProperty("data_url")]
			public string DataUrl { get; set; }

			[JsonProperty("created")]
			public string Created { get; set; }

			[JsonProperty("id")]
			public string Id { get; set; }

			[JsonProperty("name")]
			public string Name { get; set; }

			[JsonProperty("last_submission_time")]
			public string LastSubmissionTime { get; set; }

			[JsonProperty("rss_url")]
			public string RssUrl { get; set; }

			[JsonProperty("summary_url")]
			public string SummaryUrl { get; set; }

			[JsonProperty("updated")]
			public string Updated { get; set; }

			[JsonProperty("submissions_unread")]
			public long SubmissionsUnread { get; set; }

			[JsonProperty("timezone")]
			public string Timezone { get; set; }

			[JsonProperty("url")]
			public string Url { get; set; }

			[JsonProperty("views")]
			public string Views { get; set; }
		}

		public partial class GettingStarted
		{
			public static GettingStarted FromJson(string json)
			{
				return JsonConvert.DeserializeObject<GettingStarted>(json, Converter.Settings);
			}
		}

		public static class Serialize
		{
			public static string ToJson(this GettingStarted self)
			{
				return JsonConvert.SerializeObject(self, Converter.Settings);
			}
		}

		public class Converter
		{
			public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
			{
				MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
				DateParseHandling = DateParseHandling.None,
			};
		}
	}

}
