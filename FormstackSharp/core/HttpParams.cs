using System.Collections.Generic;
using System.Reflection;

namespace FormstackSharp
{
	/// <summary>
	/// HTTP Parameter string base class.
	/// </summary>
	public class HttpParams : Dictionary<string, string>
	{
		/// <summary>
		/// Converts the assigned key / value pairs into a useable HTTP parameter string.
		/// </summary>
		/// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:FormstackSharp.core.HttpParams"/>.</returns>
		public override string ToString()
		{
			// Init the param string.
			var paramString = "";

			// Ensure there are params.
			if (this.Keys.Count > 0)
			{
				// Process each key.
				foreach (var key in this.Keys)
				{
					string value = string.Empty;
					this.TryGetValue(key, out value);
					paramString += $"&{key.ToLower()}={value}";
				}

				// Replace the initial ampersand '&' with a ?.
				if (!string.IsNullOrWhiteSpace(paramString))
					paramString = "?" + paramString.Substring((1));
			}

			// Return the generated value.
			return paramString;
		}

		/// <summary>
		/// Public overridable param string generation method.
		/// </summary>
		/// <param name="obj">Parameter object</param>
		/// <returns>HTTP Param string.</returns>
		public virtual string Generate( object obj )
		{
			// Create a new params object.
			var httpParams = new HttpParams();

			// Process each property of the type.
			PropertyInfo[] properties = obj.GetType().GetProperties();
			foreach (PropertyInfo p in properties)
				httpParams.Add(p.Name, p.GetValue(obj).ToString());

			// Return the object as a param string.
			return httpParams.ToString();
		}
	}
}