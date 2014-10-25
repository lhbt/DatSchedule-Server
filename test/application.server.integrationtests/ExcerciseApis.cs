﻿using System.Collections.Specialized;
using System.Net;
using NUnit.Framework;

namespace application.server.integrationtests
{
    public class ExcerciseApis
    {
        [Test]
        public void TestInitiateGetMethod()
        {
            var data = Http.Get("http://datschedule.apphb.com/initiate");
            Assert.That(data.Contains("initiated"));
        }
    }

    public static class Http
    {
        public static byte[] Post(string uri, NameValueCollection pairs)
        {
            byte[] response = null;
            using (WebClient client = new WebClient())
            {
                response = client.UploadValues(uri, pairs);
            }
            return response;
        }

        public static string Get(string uri)
        {
            string response;
            using (WebClient client = new WebClient())
            {
                response = client.DownloadString(uri);
            }
            return response;
        }
    }
}
