using Biolog.Models;
using IO.Swagger.Api;
using IO.Swagger.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Biolog.services
{
    public class DashboardService
    {

        public Dashboard KpiDetails(Dashboard board, User user)
        {
            string url = WebConfigurationManager.AppSettings["ReportingServerURL"];
            board.KpiModel = new List<KpiModel>();
            //Get KPIs
            KpisApi kpiObj = new KpisApi(IO.Swagger.Client.Configuration.DefaultApiClient);

            var kpis = kpiObj.GetKpisString(0, 0, "", "", "", "", user.Username, user.Password, url);

            JObject jObject = JObject.Parse(kpis);

            int count = 0;
            if (((Newtonsoft.Json.Linq.JContainer)jObject.Last.Last).Count > 0)
            {
                foreach (var item in ((Newtonsoft.Json.Linq.JContainer)jObject.Last.Last).ToList())
                {
                    if (item.ToString().Substring(item.ToString().IndexOf("Path") + 9).StartsWith("Hoxworth"))
                    {
                        count++;
                        KpiModel model = new KpiModel();
                        var startIndex = item.ToString().IndexOf("Name");
                        startIndex = startIndex + 8;
                        var endINdex = item.ToString().IndexOf("Description");
                        endINdex = endINdex - 7;
                        model.Name = item.ToString().Substring(startIndex, (endINdex - startIndex));

                        var values = item.ToString().Substring(item.ToString().IndexOf("Values"));
                        startIndex = values.IndexOf("Value\":");
                        startIndex = startIndex + 9;
                        endINdex = values.ToString().IndexOf(",");
                        endINdex = endINdex - 1;
                        model.Value = values.ToString().Substring(startIndex, (endINdex - startIndex));

                        //startIndex = values.IndexOf("Goal\":");
                        //startIndex = startIndex + 7;
                        //endINdex = values.ToString().IndexOf("Status");
                        //endINdex = endINdex - 8;
                        //model.Goal = values.ToString().Substring(startIndex, (endINdex - startIndex));

                        //int percentComplete = (int)Math.Round((double)(100 * Convert.ToDouble(model.Value)) / Convert.ToDouble(model.Goal));
                        //model.Percent = percentComplete + "%";

                        startIndex = values.IndexOf("Status\":");
                        startIndex = startIndex + 9;
                        endINdex = values.ToString().IndexOf("TrendSet");
                        endINdex = endINdex - 7;
                        model.Status = values.ToString().Substring(startIndex, (endINdex - startIndex));

                        board.KpiModel.Add(model);
                    }

                }
            }
            board.KpiCount = count;
            return board;
        }


        public Dashboard PowerBIDetails(Dashboard board, User user)
        {
            string url = WebConfigurationManager.AppSettings["ReportingServerURL"];
            board.PowerBiModelList = new List<PowerBiModel>();
            //Get KPIs
            PowerBIReportsApi pwBi = new PowerBIReportsApi(IO.Swagger.Client.Configuration.DefaultApiClient);

            var power = pwBi.GetPowerBIReportsString(0, 0, "", "", "", "", user.Username, user.Password, url);

            JObject jObject = JObject.Parse(power);
            board.PowerBiCount = ((Newtonsoft.Json.Linq.JContainer)jObject.Last.Last).Count;

            if (((Newtonsoft.Json.Linq.JContainer)jObject.Last.Last).Count > 0)
            {
                foreach (var item in ((Newtonsoft.Json.Linq.JContainer)jObject.Last.Last).ToList())
                {
                    PowerBiModel model = new PowerBiModel();
                    var startIndex = item.ToString().IndexOf("Name");
                    startIndex = startIndex + 8;
                    var endINdex = item.ToString().IndexOf("Description");
                    endINdex = endINdex - 7;
                    model.Name = item.ToString().Substring(startIndex, (endINdex - startIndex));
                    board.PowerBiModelList.Add(model);
                }
            }
            return board;
        }


        public Dashboard SSRSReportDetails(Dashboard board, User user)
        {
            string url = WebConfigurationManager.AppSettings["ReportingServerURL"];
            board.ReportModelList = new List<ReportModel>();
            //Get KPIs
            ReportsApi pwBi = new ReportsApi(IO.Swagger.Client.Configuration.DefaultApiClient);

            var power = pwBi.GetReportsString(0, 0, "", "", "", "", user.Username, user.Password, url);

            JObject jObject = JObject.Parse(power);
            int count = 0;

            if (((Newtonsoft.Json.Linq.JContainer)jObject.Last.Last).Count > 0)
            {
                foreach (var item in ((Newtonsoft.Json.Linq.JContainer)jObject.Last.Last).ToList())
                {
                    if (item.ToString().Substring(item.ToString().IndexOf("Path") + 9).StartsWith("Hoxworth"))
                    {
                        count++;
                        ReportModel model = new ReportModel();
                        var startIndex = item.ToString().IndexOf("Name");
                        startIndex = startIndex + 8;
                        var endINdex = item.ToString().IndexOf("Description");
                        endINdex = endINdex - 7;
                        model.Name = item.ToString().Substring(startIndex, (endINdex - startIndex));
                        board.ReportModelList.Add(model);
                    }
                }
            }
            board.ReportCount = count;
            return board;
        }
    }
}