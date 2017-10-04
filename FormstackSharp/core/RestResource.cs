using System.Net;

namespace FormstackSharp
{
	/// <summary>
	/// Base REST Resource class.
	/// </summary>
	public abstract class RestResource
	{
		/// <summary>
		/// Endpoint for the rest resource.
		/// </summary>
		public abstract string Endpoint { get; protected set; }

		/// <summary>
		/// Gets the json.
		/// </summary>
		/// <value>The json.</value>
		public string JSON { get; private set; }

		/// <summary>
		/// Gets or sets the request.
		/// </summary>
		/// <value>The request.</value>
		private HttpWebRequest request { get; set; }

		/// <summary>
		/// Gets or sets the request.
		/// </summary>
		/// <value>The request.</value>
		protected HttpWebResponse Response { get; set; }

		/// <summary>
		/// Sends the request using the the specified token and args.
		/// Loads the Resonse.
		/// </summary>
		/// <returns>The initialize.</returns>
		/// <param name="token">Auth token.</param>
		/// <param name="parameters">HTTP params.</param>
		public async void Execute(string token, HttpParams parameters)
		{
			// Create the HTTP request.
			this.request = (HttpWebRequest)WebRequest.Create($"https://www.formstack.com/api/v2/{this.Endpoint}.json" + parameters);

			// Assign the method.
			this.request.Method = "Post";

			// Set the accept type to json.
			this.request.Accept = "application/json";
			this.request.ContentType = "application/json";

			// Set the api key header.
			this.request.Headers["Authorization"] = token;

			// Get the Response.
			this.Response = await this.request.GetResponseAsync() as HttpWebResponse;

			// Extract the JSON.
			using (var reader = new System.IO.StreamReader(this.Response.GetResponseStream()))
			{
				//  Store the JSON text string.
				this.JSON = reader.ReadToEnd();
			}
		}
	}
}
