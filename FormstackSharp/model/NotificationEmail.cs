using Newtonsoft.Json;

namespace FormstackSharp
{
	/// <summary>
	/// Formstack - Notification Email class.
	/// </summary>
	public class NotificationEmail
	{
		/// <summary>
		/// Unique Notification Email ID.
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// Unique Form ID.
		/// </summary>
		[JsonProperty("form")]
		public int FormID { get; set; }

		/// <summary>
		/// Name of the notification email.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The type of from address (noreply, custom, field).
		/// </summary>
		[JsonProperty("from_type")]
		public string FromType { get; set; }

		/// <summary>
		/// Custom email address or field id.
		/// </summary>
		[JsonProperty("from_value")]
		public string FromValue { get; set; }

		/// <summary>
		/// Email address to send notification to ("\n" delimited).
		/// </summary>
		[JsonProperty("recipients")]
		public string Recipients { get; set; }

		/// <summary>
		/// The subject of the email.
		/// </summary>
		[JsonProperty("subject")]
		public string Subject { get; set; }

		/// <summary>
		/// The email message (if type = fields).
		/// </summary>
		[JsonProperty("message")]
		public string Message { get; set; }

		/// <summary>
		/// What is included in the message (data, link, or fields).
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// Flag to not include empty fields in the email.
		/// </summary>
		[JsonProperty("hide_empty")]
		public bool HideEmpty { get; set; } = false;

		/// <summary>
		/// Flag to show section headings in email.
		/// </summary>
		[JsonProperty("show_section")]
		public bool ShowSection { get; set; } = false;

		/// <summary>
		/// Only attach files if under this limit (in KBytes).
		/// </summary>
		[JsonProperty("attach_limit")]
		public string AttachLimit { get; set; }

		/// <summary>
		/// Whether the Notification Email should be Rich HTML or Plain Text (html, plaintext)
		/// </summary>
		[JsonProperty("format")]
		public string Format { get; set; }

		/// <summary>
		/// Field logic.See Field Logic section below.
		/// </summary>
		[JsonProperty("logic")]
		public object Logic { get; set; }

	}
}