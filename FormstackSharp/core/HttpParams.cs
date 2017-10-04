using System.Collections.Generic;
using System.Reflection;

namespace FormstackSharp
{
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

		public static HttpParams Generate( object obj )
		{
			var httpParams = new HttpParams();

			PropertyInfo[] properties = obj.GetType().GetProperties();
			foreach (PropertyInfo p in properties)
			{
				httpParams.Add(p.Name, p.GetValue(obj).ToString());
			}

			return httpParams;
		}
	}
}