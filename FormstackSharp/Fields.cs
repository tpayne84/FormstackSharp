using Newtonsoft.Json;

namespace FormstackSharp
{
	/// <summary>
	/// Formstack - Fields resource.
	/// </summary>
	public partial class Fields : RestResource
	{
		/// <summary>
		/// Field resource endpoint.
		/// </summary>
		public override string Endpoint { get; protected set; } = "field";
	}

	/// <summary>
	/// Fields - GET.
	/// </summary>
	public partial class Fields
	{ 
		/// <summary>
		/// HTTP Get request params.
		/// </summary>
		public class GetParams
		{
			/// <summary>
			/// Specific field ID.
			/// </summary>
			[JsonProperty("id")]
			bool ID { get; set; } = false;

			/// <summary>
			/// Form ID.
			/// </summary>
			[JsonProperty("form_id")]
			int FormID { get; set; } = 1;
		}

		/// <summary>
		/// Get all fields for the specified form.
		/// </summary>
		/// <param name="token">Auth token.</param>
		/// <param name="settings">Get request parameters.</param>
		/// <returns><see cref="Field[]"/> of all fields for the specified <see cref="Form"/>.</returns>
		public Field[] Get( string token, GetParams settings )
		{
			// Execute the request.
			this.Execute(token, HttpParams.Generate(settings));

			// Deserialize the json response to a pre-cast type.
			return JsonConvert.DeserializeObject<Field[]>(this.JSON);
		}
	}

	/// <summary>
	/// Fields - POST.
	/// </summary>
	public partial class Fields
	{
		/// <summary>
		/// HTTP Post request params.
		/// </summary>
		public class PostParams : GetParams {}

		/// <summary>
		/// HTTP POST - Forms - Create a new form in your account.
		/// </summary>
		/// <param name="token">Auth token.</param>
		/// <param name="settings">Get request parameters.</param>
		/// <returns><see cref="Field[]"/> of all forms in the account.</returns>
		public Field[] Post(string token, PostParams settings)
		{
			// Execute the request.
			this.Execute(token, HttpParams.Generate(settings));

			// Deserialize the json response to a pre-cast type.
			return JsonConvert.DeserializeObject<Field[]>(this.JSON);
		}
	}
}