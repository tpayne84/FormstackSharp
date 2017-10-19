using Newtonsoft.Json;

namespace FormstackSharp.model
{
	/// <summary>
	/// From model.
	/// </summary>
	public partial class Form
	{
		/// <summary>
		/// The most recent submission id created.
		/// </summary>
		[JsonProperty("last_submission_id")]
		public string LastSubmissionId { get; set; }

		/// <summary>
		/// Total submission count.
		/// </summary>
		[JsonProperty("submissions")]
		public long Submissions { get; set; }

		/// <summary>
		/// Data URL.
		/// </summary>
		[JsonProperty("data_url")]
		public string DataUrl { get; set; }

		/// <summary>
		/// Created timestamp.
		/// </summary>
		[JsonProperty("created")]
		public string Created { get; set; }

		/// <summary>
		/// Form ID.
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Form name.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Caption applied to the submit button.
		/// </summary>
		[JsonProperty("submit_button_title")]
		public string SubmitButtonTitle { get; set; }

		/// <summary>
		/// Most recent submission timestamp.
		/// </summary>
		[JsonProperty("last_submission_time")]
		public string LastSubmissionTime { get; set; }

		/// <summary>
		/// RSS URL.
		/// </summary>
		[JsonProperty("rss_url")]
		public string RssUrl { get; set; }

		/// <summary>
		/// Summary URL.
		/// </summary>
		[JsonProperty("summary_url")]
		public string SummaryUrl { get; set; }

		/// <summary>
		/// Form last updated timestamp.
		/// </summary>
		[JsonProperty("updated")]
		public string Updated { get; set; }

		/// <summary>
		/// Unread submission count.
		/// </summary>
		[JsonProperty("submissions_unread")]
		public long SubmissionsUnread { get; set; }

		/// <summary>
		/// Submission count for today.
		/// </summary>
		[JsonProperty("submissions_today")]
		public long SubmissionsToday { get; set; }

		/// <summary>
		/// Timezone local identifier string... Format example: "US/Eastern"
		/// </summary>
		[JsonProperty("timezone")]
		public string Timezone { get; set; }

		/// <summary>
		/// Form URL.
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }

		/// <summary>
		/// Thumbnail URL.
		/// </summary>
		[JsonProperty("thumnail_url")]
		public string ThumbnailUrl { get; set; }

		/// <summary>
		/// Total view count.
		/// </summary>
		[JsonProperty("views")]
		public string Views { get; set; }

		/// <summary>
		/// Unique(?) view key.
		/// </summary>
		[JsonProperty("viewkey")]
		public string ViewKey { get; set; }

		/// <summary>
		/// Is deleted flag.
		/// </summary>
		[JsonProperty("deleted")]
		public bool Deleted { get; set; }

		/// <summary>
		/// Database id.
		/// </summary>
		[JsonProperty("db")]
		public string Db { get; set; }

		/// <summary>
		/// Is encrypted flag.
		/// </summary>
		[JsonProperty("encrypted")]
		public bool Encrypted { get; set; }

		/// <summary>
		/// Is inactive flag.
		/// </summary>
		[JsonProperty("inactive")]
		public bool Inactive { get; set; }

		/// <summary>
		/// Folder name, ( default: "none" ).
		/// </summary>
		[JsonProperty("folder")]
		public string Folder { get; set; }

		/// <summary>
		/// HTML Escaped javascript code.
		/// </summary>
		[JsonProperty("javascript")]
		public string Javascript { get; set; }

		/// <summary>
		/// Pre-generated renderable, HTML.
		/// </summary>
		[JsonProperty("html")]
		public string Html{ get; set; }

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
