﻿using FormstackSharp.model;
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
		public class GetParams : HttpParams
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
			this.Execute(token, settings.Generate(settings));

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
			/// <summary>
			/// Single column layout.
			/// </summary>
			SingleColumn = 1,

			/// <summary>
			/// Two column layout.
			/// </summary>
			TwoColumn = 2,

			/// <summary>
			/// Three column layout.
			/// </summary>
			ThreeColumn = 3,

			/// <summary>
			/// Four column layout.
			/// </summary>
			FourColumn = 4
		}

		/// <summary>
		/// ISO 639-1 Language Codes.
		/// </summary>
		public static class LanguageCodes
		{
			/// <summary>
			/// Arabic language code.
			/// </summary>
			public const string Arabic = "ar";

			/// <summary>
			/// Bulgarian language code.
			/// </summary>
			public const string Bulgarian = "bg";

			/// <summary>
			/// Catalan language code.
			/// </summary>
			public const string Catalan = "ca";

			/// <summary>
			/// Chinese language code.
			/// </summary>
			public const string Chinese = "zh";

			/// <summary>
			/// Czech language code.
			/// </summary>
			public const string Czech = "cs";

			/// <summary>
			/// Danish language code.
			/// </summary>
			public const string Danish = "da";

			/// <summary>
			/// German language code.
			/// </summary>
			public const string German = "de";

			/// <summary>
			/// Greek language code.
			/// </summary>
			public const string Greek = "el";

			/// <summary>
			/// English language code.
			/// </summary>
			public const string English = "en";

			/// <summary>
			/// Spanish language code.
			/// </summary>
			public const string Spanish = "es";

			/// <summary>
			/// Finnish language code.
			/// </summary>
			public const string Finnish = "fi";
		}

		/// <summary>
		/// HTTP Post request params.
		/// </summary>
		public class PostParams : HttpParams
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
		/// <param name="settings">Post request parameters.</param>
		/// <returns>New form data.</returns>
		public Form Post(string token, PostParams settings)
		{
			// Execute the request.
			this.Execute(token, settings.Generate(settings));

			// Deserialize the json response to a pre-cast type.
			return JsonConvert.DeserializeObject<Form>(this.JSON);
		}
	}

	/// <summary>
	/// Forms - PUT.
	/// </summary>
	public partial class Forms
	{
		/// <summary>
		/// HTTP Post request params.
		/// </summary>
		public class PutParams : HttpParams
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
		/// HTTP PUT - Forms - Update the details of the specified form.
		/// </summary>
		/// <param name="token">Auth token.</param>
		/// <param name="settings">Put request parameters.</param>
		/// <returns><see cref="ApiResponse"/> info for the update call.</returns>
		public ApiResponse Put(string token, PutParams settings)
		{
			// Execute the request.
			this.Execute(token, settings.Generate(settings));

			// Deserialize the json response to a pre-cast type.
			return JsonConvert.DeserializeObject<ApiResponse>(this.JSON);
		}
	}
}