#r "System.Configuration"
#r "System.Data"

using System.Net;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Belgrade.SqlClient;
using Belgrade.SqlClient.SqlDb;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
	log.Info("C# HTTP trigger function InsertTestResults processed a request.");

	try
	{
		string ConnectionString = ConfigurationManager.ConnectionStrings["ProjectCanineDb"].ConnectionString;
        
        string json = req.Content.ReadAsStringAsync().Result;

        using (SqlConnection conn = new SqlConnection(str))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("dbo.InsertTestResults", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var param = new SqlParameter("@json", SqlDbType.VarChar, -1);
                param.Value = json;
                cmd.Parameters.Add(param);

                int rows = await cmd.ExecuteNonQueryAsync();

                return new HttpResponseMessage() { Content = new StringContent(rows.ToString(), StatusCode = httpStatus };
            }
        }

        return new HttpResponseMessage() { Content = new StringContent(body), StatusCode = httpStatus };

	}
	catch (Exception ex)
	{
		log.Error($"C# Http trigger function exception: {ex.Message}");
		return new HttpResponseMessage() { Content = new StringContent(""), StatusCode = HttpStatusCode.InternalServerError };
	}
}