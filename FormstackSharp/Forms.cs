using FormstackSharp.model;
using Newtonsoft.Json;

namespace FormstackSharp
{
	/// <summary>
	/// Formstack - Forms resource.
	/// </summary>
	public partial class Forms : RestResource
	{
		/// <summary>
		/// Form resource endpoint.
		/// </summary>
		public override string Endpoint { get; protected set; } = "form";
	}

	/// <summary>
	/// Forms - GET.
	/// </summary>
	public partial class Forms
	{ 
		/// <summary>
		/// HTTP Get request params.
		/// </summary>
		public class GetParams
		{
			/// <summary>
			/// Flag to return forms in lists separated by folder.
			/// </summary>
			[JsonProperty("folders")]
			bool Folders { get; set; } = false;

			/// <summary>
			/// Page to use when paginating through forms. 
			/// Starts at 1.
			/// </summary>
			[JsonProperty("page")]
			int Page { get; set; } = 1;

			/// <summary>
			/// Number of forms to return per page. 
			/// Minimum page limit is 10.
			/// </summary>
			[JsonProperty("per_page")]
			public int PerPage { get; set; } = 10;
		}

		/// <summary>
		/// HTTP GET - Forms - Get all forms in your account.
		/// </summary>
		/// <param name="token">Auth token.</param>
		/// <param name="settings">Get request parameters.</param>
		/// <returns><see cref="Form[]"/> of all forms in the account.</returns>
		public Form[] Get( string token, GetParams settings )
		{
			// Execute the request.
			this.Execute(token, HttpParams.Generate(settings) );

			// Deserialize the json response to a pre-cast type.
			return JsonConvert.DeserializeObject<Form[]>(this.JSON);
		}
	}

	/// <summary>
	/// Forms - POST.
	/// </summary>
	public partial class Forms {

		/// <summary>
		/// Syntactical sugar for the form column layout.
		/// </summary>
		public enum FormLayout
		{
			SingleColumn = 1,
			TwoColumn = 2,
			ThreeColumn = 3,
			FourColumn = 4
		}

		/// <summary>
		/// ISO 639-1 Language Codes.
		/// </summary>
		public static class LanguageCodes
		{
			public const string Arabic = "ar";
			public const string Bulgarian = "bg";
			public const string Catalan = "ca";
			public const string Chinese = "zh";
			public const string Czech = "cs";
			public const string Danish = "da";
			public const string German = "de";
			public const string Greek = "el";
			public const string English = "en";
			public const string Spanish = "es";
			public const string Finnish = "fi";
		}

		/// <summary>
		/// HTTP Post request params.
		/// </summary>
		public class PostParams
		{
			/// <summary>
			/// The form name.
			/// </summary>
			[JsonProperty("name")]
			public string Name { get; set; }

			/// <summary>
			/// Flag to disable or enable submissions to be saved in our database.
			/// </summary>
			[JsonProperty("db")]
			public bool Db { get; set; } = true;

			/// <summary>
			/// Template ID for the template you want to use.
			/// </summary>
			[JsonProperty("template")]
			public string Template { get; set; }

			/// <summary>
			/// Number (1-4) of columns the form layout will have.
			/// </summary>
			[JsonProperty("num_columns")]
			public FormLayout NumColumns { get; set; }

			/// <summary>
			/// Sets the default field label position. Possible values are: "top" or "left"
			/// </summary>
			[JsonProperty("label_position")]
			public string LabelPosition;

			/// <summary>
			/// Sets the submit button title.
			/// </summary>
			[JsonProperty("submit_button_title")]
			public string SubmitButtonTitle { get; set; } = "Submit Form";

			/// <summary>
			/// Sets a password for the form.
			/// </summary>
			[JsonProperty("password")]
			public string Password { get; set; }

			/// <summary>
			/// Flag to disable or enable SSL (only available on accounts that have security features).
			/// </summary>
			[JsonProperty("use_ssl")]
			public bool UseSsl { get; set; } = false;

			/// <summary>
			/// Sets the timezone for the form.
			/// </summary>
			[JsonProperty("timezone")]
			public string Timezone { get; set; } = "US/Eastern";

			/// <summary>
			/// Sets the language for the form - use ISO 639-1 language codes.
			/// Note: Pre-defined codes can be found in class <see cref="LanguageCodes"/>.
			/// </summary>
			[JsonProperty("language")]
			public string Language { get; set; } = "en";

			/// <summary>
			/// Flag to make the form active/inactive.
			/// </summary>
			[JsonProperty("active")]
			public bool Active { get; set; } = true;

			/// <summary>
			/// The message to show when the form is inactive.
			/// </summary>
			[JsonProperty("disabled_message")]
			public string DisabledMessage { get; set; }

			/// <summary>
			/// Array of Field resources.
			/// </summary>
			[JsonProperty("fields")]
			public Field[] Fields { get; set; }

			/// <summary>
			/// Array of email notifications.
			/// </summary>
			[JsonProperty("notifications")]
			public NotificationEmail[] Notifications { get; set; }
		}

		/// <summary>
		/// HTTP POST - Forms - Create a new form in your account.
		/// </summary>
		/// <param name="token">Auth token.</param>
		/// <param name="settings">Get request parameters.</param>
		/// <returns><see cref="Form[]"/> of all forms in the account.</returns>
		public Form[] Post(string token, GetParams settings)
		{
			// Execute the request.
			this.Execute(token, HttpParams.Generate(settings));

			// Deserialize the json response to a pre-cast type.
			return JsonConvert.DeserializeObject<Form[]>(this.JSON);
		}
	}
}