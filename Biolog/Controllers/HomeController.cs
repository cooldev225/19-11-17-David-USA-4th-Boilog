using Biolog.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using Biolog.WebReference;
using Newtonsoft.Json.Linq;
using Biolog.services;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Biolog.Models.Guide;

namespace Biolog.Controllers
{
    public class HomeController : Controller
    {
        private const string URL = "http://52.191.118.216:80/reports/";
        private DashboardService _dbService;
        private List<string> _folders=new List<string>();
        private string _url = "";

        void InitialFunc() {
            ReportingService2010 rs = new ReportingService2010();
            Models.User user = (Models.User)Session["user"];
            _url = WebConfigurationManager.AppSettings["ReportingServerURL"];
            rs.Credentials = new System.Net.NetworkCredential(user.Username, user.Password, _url);
            var items = rs.ListChildren("/", true); //Hoxworth Name Path
            for (var i = 0; i < items.Length; i++)
            {
                if (items[i].TypeName.Equals("Folder"))
                {
                    for(var j = 0; j < items.Length; j++)
                    {
                        if (items[j].Path.Equals("/"+items[i].Name + "/" + items[j].Name)&&(items[j].TypeName.Equals("PowerBIReport") || items[j].TypeName.Equals("Report")))
                        {
                            _folders.Add(items[i].Name);
                            break;
                        }
                    }
                }
            }
        }

        public ActionResult Index(string cfd="")
        {
            if (CheckUserSession())
            {
                this.InitialFunc();

                ViewBag.folders = _folders;
                ViewBag.current_folder = cfd;
                if (cfd.Equals("") && _folders.Count > 0) ViewBag.current_folder = _folders[0];

                _dbService = new DashboardService();
                Dashboard board = new Dashboard();
                board = _dbService.KpiDetails(board, (Models.User)Session["user"]);

                //Get PowerBiReports
                //board = _dbService.PowerBIDetails(board, (Models.User)Session["user"]);
                //Get Reports
                //board = _dbService.SSRSReportDetails(board, (Models.User)Session["user"]);

                ReportingService2010 rs = new ReportingService2010();
                Models.User user = (Models.User)Session["user"];
                rs.Credentials = new System.Net.NetworkCredential(user.Username, user.Password, _url);
                var items = rs.ListChildren("/"+ ViewBag.current_folder, true); //Hoxworth Name Path
                board.PowerBiModelList = new List<PowerBiModel>();
                int pcnt = 0;
                for (var i = 0; i < items.Length; i++)
                {
                    if (items[i].TypeName.Equals("PowerBIReport"))
                    {//Report   Kpi
                        PowerBiModel pbi = new PowerBiModel();
                        pbi.Name = items[i].Name;
                        board.PowerBiModelList.Add(pbi);
                        pcnt++;
                    }
                }
                board.PowerBiCount = pcnt;


                board.ReportModelList = new List<ReportModel>();
                pcnt = 0;
                for (var i = 0; i < items.Length; i++)
                {
                    if (items[i].TypeName.Equals("Report"))
                    {//Report   Kpi
                        ReportModel pbi = new ReportModel();
                        pbi.Name = items[i].Name;
                        board.ReportModelList.Add(pbi);
                        pcnt++;
                    }
                }
                board.ReportCount = pcnt;

                ViewBag.current_page = "index";
                
                return View(board);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult ReportView(string cpg="",string ctp= "",string cfd="")
        {
            if (CheckUserSession())
            {
                this.InitialFunc();

                ViewBag.folders = _folders;
                ViewBag.current_folder = cfd;
                if (cfd.Equals("") && _folders.Count > 0) ViewBag.current_folder = _folders[0];

                _dbService = new DashboardService();
                Dashboard board = new Dashboard();
                board = _dbService.KpiDetails(board, (Models.User)Session["user"]);

                //Get PowerBiReports
                //board = _dbService.PowerBIDetails(board, (Models.User)Session["user"]);
                //Get Reports
                //board = _dbService.SSRSReportDetails(board, (Models.User)Session["user"]);

                ReportingService2010 rs = new ReportingService2010();
                Models.User user = (Models.User)Session["user"];
                rs.Credentials = new System.Net.NetworkCredential(user.Username, user.Password, _url);
                var items = rs.ListChildren("/" + ViewBag.current_folder, true); //Hoxworth Name Path
                board.PowerBiModelList = new List<PowerBiModel>();
                int pcnt = 0;
                for (var i = 0; i < items.Length; i++)
                {
                    if (items[i].TypeName.Equals("PowerBIReport"))
                    {//Report   Kpi
                        PowerBiModel pbi = new PowerBiModel();
                        pbi.Name = items[i].Name;
                        board.PowerBiModelList.Add(pbi);
                        pcnt++;
                    }
                }
                board.PowerBiCount = pcnt;


                board.ReportModelList = new List<ReportModel>();
                pcnt = 0;
                for (var i = 0; i < items.Length; i++)
                {
                    if (items[i].TypeName.Equals("Report"))
                    {//Report   Kpi
                        ReportModel pbi = new ReportModel();
                        pbi.Name = items[i].Name;
                        board.ReportModelList.Add(pbi);
                        pcnt++;
                    }
                }
                board.ReportCount = pcnt;

                ViewBag.current_page = cpg;//http://52.191.118.216/reports/powerbi/Hoxworth/AABB%20Analysis
                ViewBag.current_url = "http://52.191.118.216/reports/"+ctp+"/"+cfd+"/" + cpg + "?rs:Embed=true";
                //"http://52.191.118.216/reports/report/Hoxworth/"+cpg+"?rs:Embed=true";
                return View(board);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }


        public ActionResult Guide(string cfd = "",int rid = 0, string sch = "", string returnUrl = null)
        {
            if (CheckUserSession())
            {
                if (sch == null) sch = "";
                ViewData["ReturnUrl"] = returnUrl;
                ViewData["ReturnMsg"] = "";
                ViewData["ReturnCode"] = 0;
                ViewBag.rid = rid;
                ViewBag.sch = "";
                ViewBag.cid = 0;
                ViewBag.screenUrl = "";

                string json = string.Empty;
                //string ur = @"http://52.191.118.216:801/Guide/GetReports";
                string ur = @"http://localhost:8801/Guide/GetReports";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ur);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                }
                var model = JsonConvert.DeserializeObject<List<Reports>>(json);

                ViewBag.reportList = model;
                if (ViewBag.reportList.Count > 0 && rid == 0) rid = ViewBag.reportList[0].Id;
                for (int i = 0; i < ViewBag.reportList.Count; i++)
                {
                    if (ViewBag.reportList[i].Id == rid)
                    {
                        ViewBag.cid = i;
                        ViewBag.screenUrl = "imgGuide/" + rid + ".jpg";
                    }
                }

                json = string.Empty;
                //ur = @"http://52.191.118.216:801/Guide/GetReport?rid=" + rid;
                ur = @"http://localhost:8801/Guide/GetReport?rid=" + rid;
                request = (HttpWebRequest)WebRequest.Create(ur);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                }
                var modelreport = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

                ViewBag.userList = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["userList"].ToString());
                ViewBag.freqList = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["freqList"].ToString());
                ViewBag.filterList = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["filterList"].ToString());
                ViewBag.summaryList = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["summaryList"].ToString());
                ViewBag.columnList = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["columnList"].ToString());
                ViewBag.drill1List = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["drill1List"].ToString());
                ViewBag.drill2List = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["drill2List"].ToString());

                this.InitialFunc();
                ViewBag.folders = _folders;
                ViewBag.current_folder = cfd;
                if (cfd.Equals("") && _folders.Count > 0) ViewBag.current_folder = _folders[0];

                _dbService = new DashboardService();
                Dashboard board = new Dashboard();
                board = _dbService.KpiDetails(board, (Models.User)Session["user"]);

                //Get PowerBiReports
                //board = _dbService.PowerBIDetails(board, (Models.User)Session["user"]);
                //Get Reports
                //board = _dbService.SSRSReportDetails(board, (Models.User)Session["user"]);

                ReportingService2010 rs = new ReportingService2010();
                Models.User user = (Models.User)Session["user"];
                rs.Credentials = new System.Net.NetworkCredential(user.Username, user.Password, _url);
                var items = rs.ListChildren("/" + ViewBag.current_folder, true); //Hoxworth Name Path
                board.PowerBiModelList = new List<PowerBiModel>();
                int pcnt = 0;
                for (var i = 0; i < items.Length; i++)
                {
                    if (items[i].TypeName.Equals("PowerBIReport"))
                    {//Report   Kpi
                        PowerBiModel pbi = new PowerBiModel();
                        pbi.Name = items[i].Name;
                        board.PowerBiModelList.Add(pbi);
                        pcnt++;
                    }
                }
                board.PowerBiCount = pcnt;


                board.ReportModelList = new List<ReportModel>();
                pcnt = 0;
                for (var i = 0; i < items.Length; i++)
                {
                    if (items[i].TypeName.Equals("Report"))
                    {//Report   Kpi
                        ReportModel pbi = new ReportModel();
                        pbi.Name = items[i].Name;
                        board.ReportModelList.Add(pbi);
                        pcnt++;
                    }
                }
                board.ReportCount = pcnt;

                ViewBag.current_page = "guide";
                ViewBag.current_rid = rid;

                return View(board);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult Platelet()
        {
            if (CheckUserSession())
            {
                //ReportViewer reportViewer = new ReportViewer();
                //reportViewer.ProcessingMode = ProcessingMode.Remote;
                //reportViewer.ServerReport.ReportServerCredentials = new BiologRSrCredentials();
                //reportViewer.ServerReport.ReportPath = "/Hoxworth/Hoxworth Platelet Study";
                //reportViewer.ServerReport.ReportServerUrl = new Uri(WebConfigurationManager.AppSettings["ReportingServerURL"]);
                ////reportViewer.SizeToReportContent = true;
                ////reportViewer.Width = Unit.Percentage(100);
                ////reportViewer.Height = Unit.Percentage(100);
                //ViewBag.ReportViewer = reportViewer;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult PlateletProfile()
        {
            if (CheckUserSession())
            {
                //ReportViewer reportViewer = new ReportViewer();
                //reportViewer.ProcessingMode = ProcessingMode.Remote;
                //reportViewer.ServerReport.ReportServerCredentials = new BiologRSrCredentials();
                //reportViewer.ServerReport.ReportPath = "/Hoxworth/Hoxworth Platelet Study";
                //reportViewer.ServerReport.ReportServerUrl = new Uri(WebConfigurationManager.AppSettings["ReportingServerURL"]);
                ////reportViewer.SizeToReportContent = true;
                ////reportViewer.Width = Unit.Percentage(100);
                ////reportViewer.Height = Unit.Percentage(100);
                //ViewBag.ReportViewer = reportViewer;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult Bloodunit()
        {
            if (CheckUserSession())
            {

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }


        public ActionResult RFID()
        {
            if (CheckUserSession())
            {

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult DataSummary()
        {
            if (CheckUserSession())
            {
                //ReportViewer reportViewer = new ReportViewer();
                //reportViewer.ProcessingMode = ProcessingMode.Remote;
                //reportViewer.ServerReport.ReportServerCredentials = new BiologRSrCredentials();
                //reportViewer.ServerReport.ReportPath = "/Hoxworth/Blood Unit Tracking";
                //reportViewer.ServerReport.ReportServerUrl = new Uri(WebConfigurationManager.AppSettings["ReportingServerURL"]);
                ////reportViewer.SizeToReportContent = true;
                ////reportViewer.Width = Unit.Percentage(100);
                ////reportViewer.Height = Unit.Percentage(100);
                //ViewBag.ReportViewer = reportViewer;

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ExpiringUnit()
        {
            if (CheckUserSession())
            {

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        private bool CheckUserSession()
        {
            if (Session["user"] != null)
            {

                var user = (Models.User)Session["user"];
                if (user.IsLoggedIn)
                {
                    Session["user"] = user;
                    ViewBag.username = user.Username;
                    return true;
                }

            }
            return false;
        }
    }
}