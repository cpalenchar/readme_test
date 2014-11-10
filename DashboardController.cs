using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class DashboardController
    {
        #region apiComments
        /**
         * @apiVersion 0.1.0
         * @api {get} /{SiteID}/DashboardController/GetDashboardPanelsInfo/:groupID rea dashboard panels info
         * @apiDescription Retrieves all the information needed to populate all the panels in the dashboard based
         *                  on the passed in group id and the current user's rights
         * @apiPermission authenticated
         * @apiGroup Reporting > /dashboard
         * @apiName GetDashboardPanelsInfo
         * @apiGroupDescription This provides all the different methods used to populate the Dashboard panels.
         *
         * @apiParam    {Number}    groupID                                                         Group's unique ID.
         * 
         * @apiSuccess  {Object}    ViewModel                                                       DashboardPanelsViewModel.
         * @apiSuccess  {Object[]}  ViewModel.OnlineAgents                                          List of OnlineAgentsViewModel.
         * @apiSuccess  {Number}    ViewModel.OnlineAgents.SiteID                                   The site's ID.
         * @apiSuccess  {Number}    ViewModel.OnlineAgents.GroupID                                  The group's ID.
         * @apiSuccess  {Number}    ViewModel.OnlineAgents.TierID                                   The tier's ID.
         * @apiSuccess  {String}    ViewModel.OnlineAgents.HeadshotUrl                              The URL where the agent's headshot is hosted.
         * @apiSuccess  {Number}    ViewModel.OnlineAgents.AgentID                                  The agent's ID.
         * @apiSuccess  {String}    ViewModel.OnlineAgents.AgentName                                The agent's display name.
         * @apiSuccess  {Number}    ViewModel.OnlineAgents.CurrentChats                             The current number of chats the user has.
         * @apiSuccess  {Number}    ViewModel.OnlineAgents.MaxChats                                 The maximum number of chats the user can have going on concurrently.
         * @apiSuccess  {Boolean}   ViewModel.OnlineAgents.Available                                Is the agent available for chats?
         * @apiSuccess  {Object[]}  ViewModel.EngagementRequests                                    List of EngagementRequestViewModel.
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.ID                                 The engagement's ID.
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.SiteID                             The site ID of the account.
         * @apiSuccess  {Object[]}  ViewModel.EngagementRequests.AgentIDs                           List of EngagementAgentViewModel (The IDs of the agents in the engagement).
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.AgentIDs.AgentID                   The engagement agent's ID.
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.AgentIDs.Status                    The engagement agent's status.
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.TierID                             The tier ID within the engagement.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorID                          The ID of the visitor within the engagement.
         * @apiSuccess  {Boolean}   ViewModel.EngagementRequests.IsAgentToAgent                     Reflects if the chat is between agents, or agent(s) and a visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.DateCreated                        The date and time the engagement was created.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.Answered                           The date and time the engagement was answered.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.Rejected                           The date and time the engagement was rejected.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.Queued                             The date and time the engagement was queued.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.Charset                            The engagement's charset.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.RemoteDesktopUrl                   The URL linked to a remote desktop session, initiated from the engagement.
         * @apiSuccess  {Boolean}   ViewModel.EngagementRequests.HasConverted                       Has this engagement converted?
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.EngagementType                     The type of engagement.
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.Stage                              The stage if the engagement.
         * @apiSuccess  {Object}    ViewModel.EngagementRequests.VisitorInfo                        EngagementVisitorInfoViewModel (The visitor's info).
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.VisitorInfo.ID                     The ID of the visitor.
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.VisitorInfo.AreaCode               The area cdode of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.BrowserType            The browser of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.City                   The city of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.Country                The country of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.DNS                    The DNS of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.EmailAddress           The email address of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.IPAddress              The IP address of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.ISP                    The ISP of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.Keywords               The keywords attached to the visitor from a search engine.
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.VisitorInfo.Latitude               The latitude of the visitor.
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.VisitorInfo.Longitude              The longitude of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.Location               The location(country) of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.PostalCode             The postal code, if applicable, of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.ReferredBy             The reffering source of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.URLReferrer            The referring URL of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.DisplayName            The name of the visitor.
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.HeadshotUrl            The headshot for the visitor
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.FirstVisit             The date & time of the visitor's first visit
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.LastChat               The date & time of the visitor's last chat
         * @apiSuccess  {Object[]}  ViewModel.EngagementRequests.VisitorInfo.VisitorPersonas                    List of VisitorPersona
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.VisitorInfo.VisitorPersonas.VisitorPersonaID   VisitorPersona's ID (Primary Key)
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.VisitorInfo.VisitorPersonas.VisitorPersonaID   Persona's ID
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.VisitorPersonas.VisitorID          Visitor's ID
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.VisitorPersonas.Name               Persona's name
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.VisitorInfo.VisitorPersonas.Value              Persona's value
         * @apiSuccess  {Object[]}  ViewModel.EngagementRequests.VisitorInfo.SurveyResults                      List of EngagementSurveyResponseViewModel
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.VisitorInfo.SurveyResults.SurveyResponseID     Survey Response's ID (Primary Key)
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.SurveyResults.EngagementID         Engagement's ID
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.VisitorInfo.SurveyResults.SurveyID             Survey's ID
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.VisitorInfo.SurveyResults.SiteID               Site's ID
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.VisitorInfo.SurveyResults.SurveyType           Survey's Type
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.SurveyResults.Question             Survey's question
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.SurveyResults.Answer               Visitor's answer to the survey's question
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.SurveyResults.VisitorID            Visitor's ID
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.SurveyResults.DateCreated          Date survey was created
         * @apiSuccess  {Number}    ViewModel.EngagementRequests.VisitorInfo.SurveyResults.GroupID              Group's ID
         * @apiSuccess  {String}    ViewModel.EngagementRequests.VisitorInfo.SurveyResults.Choices              Survey question's choices
         * 
         * @apiExample {curl} curl
         *      curl -X GET -H "Authorization: Basic {authorizationToken}" 
         *      -d '{"groupID": 13}'
         *      https:/reporting.api.livefluence.com/{siteID}/DashboardController/GetDashboardPanelsInfo/
         */
        //* @apiExample {js} JavaScript / jQuery
        //*       $.ajax({ 
        //*          type: "GET",
        //*          url: "https://reporting.api.livefluence.com/{siteID}/DashboardController/GetDashboardPanelsInfo/", 
        //*          data: {
        //*              "groupID": 13
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
        //*      var request = new RestRequest("/{siteID}/DashboardController/GetDashboardPanelsInfo/", Method.GET);
        //*      request.AddParameter("groupID", 13);
        //*      var data = JsonConvert.DeserializeObject<DashboardPanelsViewModel>(client.Execute(request).Content); 
        //*      
        //*/
        #endregion apiComments
        public void GetDashboardPanelsInfo(int groupID)
        {
        }

        #region apiComments
        /**
         * @apiVersion 0.1.0
         * @api {get} /{SiteID}/DashboardController/GetDashboardKPIsInfo/:groupID read dashboard kpis info
         * @apiDescription Retrieves all the information needed to populate all the KPIs in the dashboard 
         *                  based on passed in group id and current user's rights
         * @apiPermission authenticated
         * @apiGroup Reporting > /dashboard
         * @apiName GetDashboardKPIsInfo
         *
         * @apiParam    {Number}    groupID                                         Group's unique ID.
         * 
         * @apiSuccess  {Object}    ViewModel                                       DashboardKPIsViewModel.
         * @apiSuccess  {Number}    ViewModel.SiteID                                The site's ID.
         * @apiSuccess  {Number}    ViewModel.GroupID                               The group's ID.
         * @apiSuccess  {Number}    ViewModel.TierID                                The tier's ID.
         * @apiSuccess  {Number}    ViewModel.VisitorsCount                         The count of visitors on the site.
         * @apiSuccess  {Number}    ViewModel.QueuesCount                           The count of visitors in queues.
         * @apiSuccess  {Number}    ViewModel.ChatsCount                            The count of visitors in chats.
         * @apiSuccess  {Number}    ViewModel.TotalConversionsCount                 The count of all conversions.
         * @apiSuccess  {Number}    ViewModel.TotalConversionsAmount                The total amount of all conversions.
         * @apiSuccess  {Number}    ViewModel.TotalChatConversionsCount             The count of all chat conversions.
         * @apiSuccess  {Number}    ViewModel.TotalChatConversionsAmount            The total amount of all chat conversions.
         * 
         * @apiExample {curl} curl
         *      curl -X GET -H "Authorization: Basic {authorizationToken}" 
         *      -d '{"groupID": 13}'
         *      https:/reporting.api.livefluence.com/{siteID}/DashboardController/GetDashboardKPIsInfo/
         */
        //* @apiExample {js} JavaScript / jQuery
        //*       $.ajax({ 
        //*          type: "GET",
        //*          url: "https://reporting.api.livefluence.com/{siteID}/DashboardController/GetDashboardKPIsInfo/", 
        //*          data: {
        //*              "groupID": 13
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
        //*      var request = new RestRequest("/{siteID}/DashboardController/GetDashboardKPIsInfo/", Method.GET);
        //*      request.AddParameter("groupID", 13);
        //*      var data = JsonConvert.DeserializeObject<DashboardKPIsViewModel>(client.Execute(request).Content); 
        //*      
        //*/
        #endregion apiComments
        public void GetDashboardKPIsInfo(int groupID)
        {
        }

        #region apiComments
        /**
         * @apiVersion 0.1.0
         * @api {get} /{SiteID}/DashboardController/ForceLogoff/:userID force logoff
         * @apiDescription Tries to log off the selected agent out of the system.
         * @apiPermission authenticated
         * @apiGroup Reporting > /dashboard
         * @apiName ForceLogoff
         *
         * @apiParam    {Number}    userID      User's unique ID.
         * 
         * @apiSuccess  {Boolean}   Success     Indicator to show if the call was successful.
         * 
         * @apiExample {curl} curl
         *      curl -X GET -H "Authorization: Basic {authorizationToken}" 
         *      -d '{"userID": 47
         *      https:/reporting.api.livefluence.com/{siteID}/DashboardController/ForceLogoff/
         */
        //* @apiExample {js} JavaScript / jQuery
        //*       $.ajax({ 
        //*          type: "GET",
        //*          url: "https://reporting.api.livefluence.com/{siteID}/DashboardController/ForceLogoff/", 
        //*          data: {
        //*              "userID": 47
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
        //*      var request = new RestRequest("/{siteID}/DashboardController/ForceLogoff/", Method.GET);
        //*      request.AddParameter("userID", 47);
        //*      client.Execute(request); 
        //*      
        //*/
        #endregion apiComments
        public void ForceLogoff(int userID)
        {
        }

        #region apiComments
        /**
         * @apiVersion 0.1.0
         * @api {get} /{SiteID}/DashboardController/ForceEndEngagement/:engagementID force end engagement
         * @apiDescription Tries to end the selected engagement.
         * @apiPermission authenticated
         * @apiGroup Reporting > /dashboard
         * @apiName ForceEndEngagement
         *
         * @apiParam    {String}    engagementID    Engagement's unique ID.
         * 
         * @apiSuccess  {Boolean}   Success         Indicator to show if the call was successful.
         * 
         * @apiExample {curl} curl
         *      curl -X GET -H "Authorization: Basic {authorizationToken}" 
         *      -d '{"engagementID": "4H9ixqrw6UWxfeNG93a-Ug"
         *      https:/reporting.api.livefluence.com/{siteID}/DashboardController/ForceEndEngagement/
         */
        //* @apiExample {js} JavaScript / jQuery
        //*       $.ajax({ 
        //*          type: "GET",
        //*          url: "https://reporting.api.livefluence.com/{siteID}/DashboardController/ForceEndEngagement/", 
        //*          data: {
        //*              "engagementID": "4H9ixqrw6UWxfeNG93a-Ug"
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
        //*      var request = new RestRequest("/{siteID}/DashboardController/ForceEndEngagement/", Method.GET);
        //*      request.AddParameter("engagementID", "4H9ixqrw6UWxfeNG93a-Ug");
        //*      client.Execute(request); 
        //*      
        //*/
        #endregion apiComments
        public void ForceEndEngagement(string engagementID)
        {
        }
    }
}