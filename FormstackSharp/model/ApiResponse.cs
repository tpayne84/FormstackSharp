using Newtonsoft.Json;

namespace FormstackSharp.model
{
	/// <summary>
	/// API Response object.
	/// </summary>
	public class ApiResponse
	{
		/// <summary>
		/// Status value.
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }

		/// <summary>
		/// Error message.
		/// </summary>
		[JsonProperty("error")]
		public bool ErrorMessage{ get; set; }

		/// <summary>
		/// Success flag.
		/// </summary>
		[JsonProperty("success")]
		public bool Success { get; set; }

		/// <summary>
		/// ID Reference.
		/// </summary>
		[JsonProperty("id")]
		public int ID { get; set; }

		/// <summary>
		/// HTTP response code.
		/// </summary>
		[JsonProperty("success")]
		public int Code { get; set; }
	}
}
