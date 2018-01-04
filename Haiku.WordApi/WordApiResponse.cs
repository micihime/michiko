using System;
using System.IO;
using System.Net;

namespace Haiku.WordApi
{
    /// <summary>
    /// class representing word API response
    /// </summary>
    public static class WordApiResponse
    {
        /// <summary>
        /// Gets the response.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <exception cref="System.ApplicationException"></exception>
        public static string GetResponseStream(HttpWebRequest request)
        {
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    string responseValue = string.Empty;

                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        string message = String.Format("Request failed. Received HTTP {0}", response.StatusCode);
                        throw new ApplicationException(message);
                    }

                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                responseValue = reader.ReadToEnd();
                            }
                        }
                    }

                    return responseValue;
                }
            }
            catch (WebException ex)
            {
                return null;
            }
        }
    }
}
