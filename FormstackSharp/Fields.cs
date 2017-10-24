using Newtonsoft.Json;
using System;

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
		public override string Endpoint { get; } = "field";
	}

	/// <summary>
	/// Fields - GET.
	/// </summary>
	public partial class Fields
	{ 
		/// <summary>
		/// HTTP Get request params.
		/// </summary>
		public class GetParams : HttpParams
		{
			/// <summary>
			/// Form ID to get the fields from.
			/// </summary>
			[JsonProperty("id")]
			bool FormID { get; set; } = false;
		}

		/// <summary>
		/// Get all fields for the specified form.
		/// </summary>
		/// <param name="token">Auth token.</param>
		/// <param name="settings">Get request parameters.</param>
		/// <returns><see cref="Field[]"/> of all fields for the specified <see cref="Form"/>.</returns>
		public Field[] Get( string token, GetParams settings )
		{
			// Be sure the form ID is passed.
			if( !settings.ContainsKey("FormID") )
				throw new ArgumentException("FormID");

			// Extract the form id.
			string formId;
			settings.TryGetValue("FormID", out formId);

			// Execute the request.
			this.Execute(token, $"form/{formId}/{this.Endpoint}", string.Empty );

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
			this.Execute(token, "TODO",  settings.Generate(settings));

			// Deserialize the json response to a pre-cast type.
			return JsonConvert.DeserializeObject<Field[]>(this.JSON);
		}
	}
}