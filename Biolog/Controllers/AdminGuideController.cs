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
using Microsoft.AspNetCore.Http;
using System.Security.AccessControl;
namespace Biolog.Controllers
{
    public class AdminGuideController : Controller
    {
        private List<Reports> _reports;
        private Dictionary<string, object> _reportinfo;
        public ActionResult Index(int rid = 0, string sch = "", string returnUrl = null, int tid=0)
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
                ViewBag.tid = tid>0?tid:2; 
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
                _reports = model;

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
                _reportinfo = modelreport;

                ViewBag.userList = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["userList"].ToString());
                ViewBag.freqList = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["freqList"].ToString());
                ViewBag.filterList = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["filterList"].ToString());
                ViewBag.summaryList = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["summaryList"].ToString());
                ViewBag.columnList = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["columnList"].ToString());
                ViewBag.drill1List = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["drill1List"].ToString());
                ViewBag.drill2List = JsonConvert.DeserializeObject<List<ReportInfo>>(modelreport["drill2List"].ToString());
                ViewBag.crid = rid;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult GuideEdit(int rid = 0, string sch = "", int eRid = 0, int eRkind = 0, string eRfolder = "", string eRname = "")
        {
            if (CheckUserSession())
            {
                //string ur = @"http://52.191.118.216:801/Guide/aEditReport?rid=" + eRid+"&kind="+eRkind+"&folder="+eRfolder+"&name="+eRname;
                string ur = @"http://localhost:8801/Guide/aEditReport?rid=" + eRid + "&kind=" + eRkind + "&folder=" + eRfolder + "&name=" + eRname;
                string res = getAPIrequest(ur);
                return RedirectToAction(actionName: "Index", controllerName: "AdminGuide",
                routeValues: new { rid = rid, sch = sch });
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult GuideRemove(int rid = 0, string sch = "", int rRid = 0)
        {
            if (CheckUserSession())
            {
                //string ur = @"http://52.191.118.216:801/Guide/aRemoveReport?rid=" + eRid;
                string ur = @"http://localhost:8801/Guide/aRemoveReport?rid=" + rRid;
                string res = getAPIrequest(ur);
                try {
                    string fileName = Server.MapPath("~\\imgGuide\\") + rRid + ".jpg";
                    if ((System.IO.File.Exists(fileName)))
                    {
                        System.IO.File.Delete(fileName);
                    }
                }
                catch (Exception) { }
                return RedirectToAction(actionName: "Index", controllerName: "AdminGuide",
                routeValues: new { rid = 0, sch = sch });
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        
        public ActionResult GuideTUserEdit(int rid = 0, string sch = "", string eRtuser = "")
        {
            int iid = -1;
            if (CheckUserSession())
            {
                //string ur = @"http://52.191.118.216:801/Guide/aEditReportInfo?rid=" + iid + "&rrid="+rid+"&name=" + eRtuser+"&type=0";
                string ur = @"http://localhost:8801/Guide/aEditReportInfo?rid=" + iid + "&rrid=" + rid + "&name=" + eRtuser + "&type=0";
                string res = getAPIrequest(ur);
                return RedirectToAction(actionName: "Index", controllerName: "AdminGuide",
                routeValues: new { rid = rid, sch = sch });
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult GuideFreqEdit(int rid = 0, string sch = "", string eRfreq = "")
        {
            int iid = -1;
            if (CheckUserSession())
            {
                //string ur = @"http://52.191.118.216:801/Guide/aEditReportInfo?rid=" + iid + "&rrid="+rid+"&name=" + eRtuser+"&type=0";
                string ur = @"http://localhost:8801/Guide/aEditReportInfo?rid=" + iid + "&rrid=" + rid + "&name=" + eRfreq + "&type=1";
                string res = getAPIrequest(ur);
                return RedirectToAction(actionName: "Index", controllerName: "AdminGuide",
                routeValues: new { rid = rid, sch = sch });
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult GuideAttrEdit(int rid = 0, string sch = "", string eRdescription = "", string eRpurpose = "", string eLegend="")
        {
            if (CheckUserSession())
            {
                //string ur = @"http://52.191.118.216:801/Guide/aEditReport?rid=" + eRid+"&kind="+eRkind+"&folder="+eRfolder+"&name="+eRname;
                string ur = @"http://localhost:8801/Guide/aEditReportAttr?rid=" + rid + "&description=" + eRdescription + "&purpose=" + eRpurpose + "&legend=" + eLegend;
                string res = getAPIrequest(ur);
                return RedirectToAction(actionName: "Index", controllerName: "AdminGuide",
                routeValues: new { rid = rid, sch = sch });
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult EditReportInfoRow(int rid = 0, string sch = "", string eIname = "", string eIdesc = "", string eIuses = "", int eIid = 0, int tid = 0)
        {
            if (CheckUserSession())
            {
                //string ur = @"http://52.191.118.216:801/Guide/aEditReportInfo?rid=" + iid + "&rrid="+rid+"&name=" + eRtuser+"&type=0";
                string ur = @"http://localhost:8801/Guide/aEditReportInfo?rid=" + eIid + "&rrid=" + rid + "&name=" + eIname + "&description=" + eIdesc + "&uses=" + eIuses + "&type=" + tid;
                string res = getAPIrequest(ur);
                return RedirectToAction(actionName: "Index", controllerName: "AdminGuide",
                routeValues: new { rid = rid, sch = sch, tid = tid });
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        
        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> GuideFileEdit(int rid = 0, string sch = "", IFormFile eRfile =null) {
            if (CheckUserSession())
            {
                string ext = ".jpg";
                var filePath = Server.MapPath("~\\imgGuide\\");//"D:/imgGuide/";
                // DirectorySecurity securityRules = new DirectorySecurity();
                // securityRules.AddAccessRule(new FileSystemAccessRule(filePath, FileSystemRights.FullControl, AccessControlType.Allow));
                // DirectoryInfo di = Directory.CreateDirectory(filePath, securityRules);
                // if (!Directory.Exists(filePath)) { Directory.CreateDirectory(filePath); }
                foreach (string file in Request.Files)
                {
                    HttpPostedFileBase hpf = Request.Files[file] as HttpPostedFileBase;
                    if (hpf.ContentLength > 0)
                    {
                        if (hpf.FileName.EndsWith(ext))
                        {
                            filePath += rid + ext;
                            Stream s = hpf.InputStream;
                            byte[] appData = new byte[hpf.ContentLength + 1];
                            s.Read(appData, 0, hpf.ContentLength);
                            using (var stream = new FileStream(filePath, FileMode.OpenOrCreate))
                            {
                                stream.Write(appData,0, hpf.ContentLength);
                                //await hpf. .CopyToAsync(stream);
                            }
                        }
                    }
                }
                return RedirectToAction(actionName: "Index", controllerName: "AdminGuide", routeValues: new { rid = rid, sch = sch });
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult GuideReportInfoRemove(int rid = 0, string sch = "", int uid = 0, int tid=0)
        {
            if (CheckUserSession())
            {
                //string ur = @"http://52.191.118.216:801/Guide/GuideInfoRemove?rid=" + uid;
                string ur = @"http://localhost:8801/Guide/GuideInfoRemove?rid=" + uid;
                string res = getAPIrequest(ur);
                return RedirectToAction(actionName: "Index", controllerName: "AdminGuide",
                routeValues: new { rid = rid, sch = sch , tid=tid});
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        private Reports getReportById(int rid) {
            for (int i = 0; rid > -1 && i < _reports.Count; i++) if (rid == _reports[i].Id) return _reports[i];
            Reports r = new Reports();
            r.Id = -1;
            r.CreatedDate = DateTime.Now;
            r.CreatedBy = "admin";
            return r;
        }

        private string getAPIrequest(string ur) {
            string json = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ur);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }
            return json;
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