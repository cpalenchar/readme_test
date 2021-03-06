﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class ExportAccountUtiliztionController
    {
        #region apiComments
        /**
         * @apiVersion 0.1.0
         * @api {get} /{SiteID}/ExportAccountUtilization/Download/:reportFormat download
         * @apiDescription Generates the Account Utilization report in the file format selected by user and saves it for the user to retrieve.
         * @apiPermission siteAdmin
         * @apiGroup Reporting > /export account utilization
         * @apiName Download
         *
         * @apiParam    {String}    reportFormat    Report format requested (pdf, html, xls).
         * 
         * @apiSuccess  {String}    URL             URL Link to the report's export generated file.
         * 
         * @apiExample {curl} curl
         *      curl -X GET -H "Authorization: Basic {authorizationToken}" 
         *      -d '{"reportFormat": "pdf"}'
         *      https:/reporting.api.livefluence.com/{siteID}/ExportAccountUtilization/Download/
         */
        //* @apiExample {js} JavaScript / jQuery
        //*       $.ajax({ 
        //*          type: "GET",
        //*          url: "https://reporting.api.livefluence.com/{siteID}/ExportAccountUtilization/Download/", 
        //*          data: {
        //*              "reportFormat": "pdf"
        //*          },
        //*          dataType: 'json',  
        //*          beforeSend: function (xhr){ 
        //*              xhr.setRequestHeader('Authorization', 'Basic ' + {authorizationToken}); 
        //*          },    
        //*          success: function (data) { //process json result }
        //*      });
        //*      
        //* @apiExample {c#} C# / RestSharp
        //*      var client = new RestClient("https://reporting.api.livefluence.com");
        //*      client.AddDefaultHeader("Authorization", {authorizationToken});
        //*      var request = new RestRequest("/{siteID}/ExportAccountUtilization/Download/", Method.GET);
        //*      request.AddParameter("reportFormat", "pdf");
        //*      var data = client.Execute(request).Content; 
        //*      
        //*/
        #endregion apiComments
        public void Download(String reportFormat)
        {
        }

        #region apiComments
        /**
         * @apiVersion 0.1.0
         * @api {get} /{SiteID}/ExportAccountUtilization/Email/:reportFormat/:emailAddress email
         * @apiDescription Generates the Account Utilization report in the file format selected by user and emails it to the email address provided.
         * @apiPermission siteAdmin
         * @apiGroup Reporting > /export account utilization
         * @apiName Email
         *
         * @apiParam    {String}    reportFormat    Report format requested (pdf, html, xls).
         * @apiParam    {String}    emailAddress    Email address to send the report to.
         * 
         * @apiSuccess  {String}    URL             URL Link to the report's export generated file.
         * 
         * @apiExample {curl} curl
         *      curl -X GET -H "Authorization: Basic {authorizationToken}" 
         *      -d '{"reportFormat": "pdf",
         *           "emailAddress": "mail@domain.com"}'
         *      https:/reporting.api.livefluence.com/{siteID}/ExportAccountUtilization/Email/
         */
        //* @apiExample {js} JavaScript / jQuery
        //*       $.ajax({ 
        //*          type: "GET",
        //*          url: "https://reporting.api.livefluence.com/{siteID}/ExportAccountUtilization/Email/", 
        //*          data: {
        //*              "reportFormat": "pdf",
        //*              "emailAddress": "mail@domain.com"
        //*          },
        //*          dataType: 'json',  
        //*          beforeSend: function (xhr){ 
        //*              xhr.setRequestHeader('Authorization', 'Basic ' + {authorizationToken}); 
        //*          },    
        //*          success: function (data) { //process json result }
        //*      });
        //*      
        //* @apiExample {c#} C# / RestSharp
        //*      var client = new RestClient("https://reporting.api.livefluence.com");
        //*      client.AddDefaultHeader("Authorization", {authorizationToken});
        //*      var request = new RestRequest("/{siteID}/ExportAccountUtilization/Email/", Method.GET);
        //*      request.AddParameter("reportFormat", "pdf");
        //*      request.AddParameter("emailAddress", "mail@domain.com");
        //*      var data = client.Execute(request).Content; 
        //*      
        //*/
        #endregion apiComments
        public void Email(String reportFormat, String emailAddress)
        {
        }
    }
}
