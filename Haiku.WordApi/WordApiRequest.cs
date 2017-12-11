using System.Net;

namespace Haiku.DataPreparation
{
    /// <summary>
    /// 
    /// </summary>
    public static class WordApiRequest
    {
        const string ENDPOINT_WORD = "https://wordsapiv1.p.mashape.com/words/";

        const string GET_METHOD = "GET";
        const string CONTENT_TYPE = "application/json";
        const string MASHAPE_KEY = "RGb2GatLjsmsh2QzXLHIf0cMaJnrp1gMuJCjsnlsS3dh3vUCji";

        /// <summary>
        /// Creates the get word request.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns></returns>
        public static HttpWebRequest CreateGetWordRequest(string word)
        {
            return CreateGetRequest(ENDPOINT_WORD, GET_METHOD, word);
        }

        /// <summary>
        /// Creates the get request.
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="method">The method.</param>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        private static HttpWebRequest CreateGetRequest(string endpoint, string method, string parameter)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpoint + parameter);
            request.Method = method;
            request.ContentType = CONTENT_TYPE;
            request.Headers["X-Mashape-Key"] = MASHAPE_KEY;
            return request;
        }        
    }
}
