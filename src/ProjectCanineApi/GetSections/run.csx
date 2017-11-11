#r "System.Configuration"

using System.Net;
using System.Configuration;
using Belgrade.SqlClient;
using Belgrade.SqlClient.SqlDb;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
	log.Info("C# HTTP trigger function GetSections processed a request.");

	try
	{
		string ConnectionString = ConfigurationManager.ConnectionStrings["ProjectCanineDb"].ConnectionString;

		var httpStatus = HttpStatusCode.OK;
		string body =
			await (new QueryMapper(ConnectionString)
						.OnError(ex => { httpStatus = HttpStatusCode.InternalServerError; }))
			.GetStringAsync("select * from dbo.Sections order by SectionNumber for json path");
		return new HttpResponseMessage() { Content = new StringContent(body), StatusCode = httpStatus };

	}
	catch (Exception ex)
	{
		log.Error($"C# Http trigger function GetSections exception: {ex.Message}");
		return new HttpResponseMessage() { Content = new StringContent(""), StatusCode = HttpStatusCode.InternalServerError };
	}
}