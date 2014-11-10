using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class ActivityFeedController
    {
        /// <summary>
        /// Returns all activities in the past 8 hours for a site
        /// </summary>
        /// <returns></returns>
        #region apiComments
        /**
         * @apiVersion 0.1.0
         * @api {get} /{siteID}/activityfeed read all
         * @apiDescription Returns all activities in the past 8 hours for a site
         * @apiPermission siteAdmin
         * @apiGroup Reporting > /activity feed
         * @apiGroupDescription This provides all the different methods used to populate the different kinds of activity feeds throughout the application.
         * @apiName List
         * 
         * @apiSuccess  {Object[]}  Activity                List of ActivityViewModel
         * @apiSuccess  {String}    Activity.Date           Date and Time
         * @apiSuccess  {String}    Activity.Event          The event.
         * @apiSuccess  {String}    Activity.TimeAgo        Time Ago?
         * @apiSuccess  {Number}    Activity.Type           The Activity Type (ActivityType enum).
         *                                                  Possible ActivityTypes:
         *                                                      (0) AgentLoggedIn,
         *                                                      (1) AgentLoggedOut,
         *                                                      (2) AgentAcceptedEngagement,
         *                                                      (3) AgentExitedEngagement,
         *                                                      (4) AgentCreatedCrmRecord,
         *                                                      (5) AgentChangedStatus,
         *                                                      (6) VisitorRequestedChat,
         *                                                      (7) VisitorExitedQueue,
         *                                                      (8) NoAgentsAvailable,
         *                                                      (9) AgentAcceptedInvite  *when an agent accepts invite to join site and created a login.
         * @apiSuccess  {String}    Activity.HeadshotUrl    The URL where the agent's headshot is hosted.
         * 
         * @apiSuccessExample    {json}      Success-Response:
         *     HTTP/1.1 200 OK
         *     {[{"Date": "1/1/2014 12:00 am", "Event": "Admin  logged in.", "TimeAgo": "8 hours 18 seconds", "Type": 0, "HeadshotUrl": "~\headshots\10\3048\Agent1.png"},{"Date": "1/1/2014 8:00 am", "Event": "Admin  logged out.", "TimeAgo": "18 seconds", "Type": 1, "HeadshotUrl": "~\headshots\10\3048\Agent1.png"}]}
         *    
         * @apiExample {curl} curl
         *      curl -X GET https:/reporting.api.livefluence.com/{siteID}/ActivityFeed \
         *      -H "Authorization: Basic {authorizationToken}"
         *      
         */
        //* @apiExample {js} JavaScript / jQuery
        //*       $.ajax({ 
        //*          type: "GET",
        //*          url: "https://reporting.api.livefluence.com/{siteID}/ActivityFeed", 
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
        //*      var request = new RestRequest("/{siteID}/ActivityFeed", Method.GET);
        //*      var data = JsonConvert.DeserializeObject<ActivityViewModel>(client.Execute(request).Content); 
        //*      
        //*/
        #endregion apiComments
        public void List()
        {
        }

        #region apiComments
        /**
         * @apiVersion 0.1.0
         * @api {get} /{siteID}/activityfeed/getbydate/:range read by date
         * @apiDescription Returns all activities within the provided date range
         * @apiPermission siteAdmin
         * @apiGroup Reporting > /activity feed
         * @apiName ListByDate
         * 
         * @apiParam    {Object}    DateRange               DateRangeViewModel object
         * @apiParam    {String}    DateRange.StartDate     The start date and time.
         * @apiParam    {String}    DateRange.EndDate       The end date and time.
         * 
         * @apiSuccess  {Object[]}  Activity                List of ActivityViewModel
         * @apiSuccess  {Date}      Activity.Date           Date and Time
         * @apiSuccess  {String}    Activity.Event          The event.
         * @apiSuccess  {String}    Activity.TimeAgo        Time Ago?
         * @apiSuccess  {Number}    Activity.Type           The Activity Type (ActivityType enum).
         *                                                  Possible ActivityTypes:
         *                                                      (0) AgentLoggedIn,
         *                                                      (1) AgentLoggedOut,
         *                                                      (2) AgentAcceptedEngagement,
         *                                                      (3) AgentExitedEngagement,
         *                                                      (4) AgentCreatedCrmRecord,
         *                                                      (5) AgentChangedStatus,
         *                                                      (6) VisitorRequestedChat,
         *                                                      (7) VisitorExitedQueue,
         *                                                      (8) NoAgentsAvailable,
         *                                                      (9) AgentAcceptedInvite  *when an agent accepts invite to join site and created a login.
         * @apiSuccess  {String}    Activity.HeadshotUrl    The URL where the agent's headshot is hosted.
         * 
         * @apiSuccessExample    {json}      Success-Response:
         *     HTTP/1.1 200 OK
         *     {[{"Date": "1/1/2014 12:00 am", "Event": "Admin  logged in.", "TimeAgo": "8 hours 18 seconds", "Type": 0, "HeadshotUrl": "~\headshots\10\3048\Agent1.png"},{"Date": "1/1/2014 8:00 am", "Event": "Admin  logged out.", "TimeAgo": "18 seconds", "Type": 1, "HeadshotUrl": "~\headshots\10\3048\Agent1.png"}]}
         * 
         * @apiExample {curl} curl
         *      curl -X GET https:/reporting.api.livefluence.com/{siteID}/ActivityFeed/GetByDate/ \
         *      -H "Authorization: Basic {authorizationToken}" \
         *      -H "Content-Type: application/json" \
         *      -d '{"StartDate": "2014/07/01 12:00:00",  "EndDate": "2014/07/31 23:59:59"}'
         *      
         */
        //* @apiExample {js} JavaScript / jQuery
        //*       $.ajax({ 
        //*          type: "GET",
        //*          url: "https://reporting.api.livefluence.com/{siteID}/ActivityFeed/GetByDate/", 
        //*          data: {
        //*              "StartDate": "2014/07/01 12:00:00",
        //*              "EndDate": "2014/07/31 23:59:59"
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
        //*      var request = new RestRequest("/{siteID}/ActivityFeed/GetByDate/", Method.GET);
        //*      request.AddParameter("range", {"StartDate": "2014/07/01 12:00:00",
        //*              "EndDate": "2014/07/31 23:59:59"});
        //*      });
        //*      var data = JsonConvert.DeserializeObject<ActivityViewModel>(client.Execute(request).Content); 
        //*      
        //*/
        #endregion apiComments
        public void ListByDate(string range)
        {
        }

        /// <summary>
        /// Returns all activities in the past 8 hours for a user
        /// </summary>
        /// <returns></returns>
        #region apiComments
        /**
         * @apiVersion 0.1.0
         * @api {get} /{siteID}/activityfeed/user/:userID read by user
         * @apiDescription Returns all activities for the provided user id
         * @apiPermission agent
         * @apiGroup Reporting > /activity feed
         * @apiName ListByUser
         * 
         * @apiParam    {Number}    userID                  User's unique ID.
         * 
         * @apiSuccess  {Object[]}  Activity                List of ActivityViewModel
         * @apiSuccess  {Date}      Activity.Date           Date and Time
         * @apiSuccess  {String}    Activity.Event          The event.
         * @apiSuccess  {String}    Activity.TimeAgo        Time Ago?
         * @apiSuccess  {Number}    Activity.Type           The Activity Type (ActivityType enum).
         *                                                  Possible ActivityTypes:
         *                                                      (0) AgentLoggedIn,
         *                                                      (1) AgentLoggedOut,
         *                                                      (2) AgentAcceptedEngagement,
         *                                                      (3) AgentExitedEngagement,
         *                                                      (4) AgentCreatedCrmRecord,
         *                                                      (5) AgentChangedStatus,
         *                                                      (6) VisitorRequestedChat,
         *                                                      (7) VisitorExitedQueue,
         *                                                      (8) NoAgentsAvailable,
         *                                                      (9) AgentAcceptedInvite  *when an agent accepts invite to join site and created a login.
         * @apiSuccess  {String}    Activity.HeadshotUrl    The URL where the agent's headshot is hosted.
         * 
         * @apiSuccessExample    {json}      Success-Response:
         *     HTTP/1.1 200 OK
         *     {[{"Date": "1/1/2014 12:00 am", "Event": "Admin  logged in.", "TimeAgo": "8 hours 18 seconds", "Type": 0, "HeadshotUrl": "~\headshots\10\3048\Agent1.png"},{"Date": "1/1/2014 8:00 am", "Event": "Admin  logged out.", "TimeAgo": "18 seconds", "Type": 1, "HeadshotUrl": "~\headshots\10\3048\Agent1.png"}]}
         * 
         * @apiErrorStructure   NotAuthorizedError
         * 
         * @apiExample {curl} curl
         *      curl -X GET https:/reporting.api.livefluence.com/{siteID}/ActivityFeed/User/{userID} \
         *      -H "Authorization: Basic {authorizationToken}"
         */
        //* @apiExample {js} JavaScript / jQuery
        //*       $.ajax({ 
        //*          type: "GET",
        //*          url: "https://reporting.api.livefluence.com/{siteID}/ActivityFeed/User/", 
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
        //*      var request = new RestRequest("/{siteID}/ActivityFeed/User/", Method.GET);
        //*      request.AddParameter("userID", 47);
        //*      var data = JsonConvert.DeserializeObject<ActivityViewModel>(client.Execute(request).Content); 
        //*      
        //*/
        #endregion apiComments
        public void ListByUser(int userID)
        {
        }

        /// <summary>
        /// Returns all activities in the past 8 hours for a user
        /// </summary>
        /// <returns></returns>
        #region apiComments
        /**
         * @apiVersion 0.1.0
         * @api {get} /{siteID}/activityfeed/group/:groupID read by group
         * @apiDescription Returns all activities for the provided group id
         * @apiPermission siteAdmin
         * @apiGroup Reporting > /activity feed
         * @apiName ListByGroup
         * 
         * @apiParam    {Number}    groupID                 Group's unique ID.
         * 
         * @apiSuccess  {Object[]}  Activity                List of ActivityViewModel
         * @apiSuccess  {Date}      Activity.Date           Date and Time
         * @apiSuccess  {String}    Activity.Event          The event.
         * @apiSuccess  {String}    Activity.TimeAgo        Time Ago?
         * @apiSuccess  {Number}    Activity.Type           The Activity Type (ActivityType enum).
         *                                                  Possible ActivityTypes:
         *                                                      (0) AgentLoggedIn,
         *                                                      (1) AgentLoggedOut,
         *                                                      (2) AgentAcceptedEngagement,
         *                                                      (3) AgentExitedEngagement,
         *                                                      (4) AgentCreatedCrmRecord,
         *                                                      (5) AgentChangedStatus,
         *                                                      (6) VisitorRequestedChat,
         *                                                      (7) VisitorExitedQueue,
         *                                                      (8) NoAgentsAvailable,
         *                                                      (9) AgentAcceptedInvite  *when an agent accepts invite to join site and created a login.
         * @apiSuccess  {String}    Activity.HeadshotUrl    The URL where the agent's headshot is hosted.
         * 
         * @apiSuccessExample    {json}      Success-Response:
         *     HTTP/1.1 200 OK
         *     {[{"Date": "1/1/2014 12:00 am", "Event": "Admin  logged in.", "TimeAgo": "8 hours 18 seconds", "Type": 0, "HeadshotUrl": "~\headshots\10\3048\Agent1.png"},{"Date": "1/1/2014 8:00 am", "Event": "Admin  logged out.", "TimeAgo": "18 seconds", "Type": 1, "HeadshotUrl": "~\headshots\10\3048\Agent1.png"}]}
         * 
         * @apiErrorStructure   NotAuthorizedError
         * 
         * @apiExample {curl} curl
         *      curl -X GET https:/reporting.api.livefluence.com/{siteID}/ActivityFeed/Group/{groupID} \
         *      -H "Authorization: Basic {authorizationToken}" 
         */
        //* @apiExample {js} JavaScript / jQuery
        //*       $.ajax({ 
        //*          type: "GET",
        //*          url: "https://reporting.api.livefluence.com/{siteID}/ActivityFeed/Group/", 
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
        //*      var request = new RestRequest("/{siteID}/ActivityFeed/Group/", Method.GET);
        //*      request.AddParameter("groupID", 13);
        //*      var data = JsonConvert.DeserializeObject<ActivityViewModel>(client.Execute(request).Content); 
        //*      
        //*/
        #endregion apiComments
        public void ListByGroup(int groupID)
        {
        }

        #region apiComments
        /**
         * @apiVersion 0.1.0
         * @api {get} /{siteID}/activityfeed/user/:userID/getbydate/:range read by user by date
         * @apiDescription Returns all activities within the provided date range for the specified user id.
         * @apiPermission agent
         * @apiGroup Reporting > /activity feed
         * @apiName ListByUserByDate
         * 
         * @apiParam    {Number}    userID                  User's unique ID.
         * @apiParam    {Object}    DateRange               DateRangeViewModel object
         * @apiParam    {String}    DateRange.StartDate     The start date and time.
         * @apiParam    {String}    DateRange.EndDate       The end date and time.
         * 
         * @apiSuccess  {Object[]}  Activity                List of ActivityViewModel
         * @apiSuccess  {Date}      Activity.Date           Date and Time
         * @apiSuccess  {String}    Activity.Event          The event.
         * @apiSuccess  {String}    Activity.TimeAgo        Time Ago?
         * @apiSuccess  {Number}    Activity.Type           The Activity Type (ActivityType enum).
         *                                                  Possible ActivityTypes:
         *                                                      (0) AgentLoggedIn,
         *                                                      (1) AgentLoggedOut,
         *                                                      (2) AgentAcceptedEngagement,
         *                                                      (3) AgentExitedEngagement,
         *                                                      (4) AgentCreatedCrmRecord,
         *                                                      (5) AgentChangedStatus,
         *                                                      (6) VisitorRequestedChat,
         *                                                      (7) VisitorExitedQueue,
         *                                                      (8) NoAgentsAvailable,
         *                                                      (9) AgentAcceptedInvite  *when an agent accepts invite to join site and created a login.
         * @apiSuccess  {String}    Activity.HeadshotUrl    The URL where the agent's headshot is hosted.
         * 
         * @apiSuccessExample    {json}      Success-Response:
         *     HTTP/1.1 200 OK
         *     {[{"Date": "1/1/2014 12:00 am", "Event": "Admin  logged in.", "TimeAgo": "8 hours 18 seconds", "Type": 0, "HeadshotUrl": "~\headshots\10\3048\Agent1.png"},{"Date": "1/1/2014 8:00 am", "Event": "Admin  logged out.", "TimeAgo": "18 seconds", "Type": 1, "HeadshotUrl": "~\headshots\10\3048\Agent1.png"}]}
         * 
         * @apiErrorStructure   NotAuthorizedError
         * 
         * @apiExample {curl} curl
         *      curl -X GET https:/reporting.api.livefluence.com/{siteID}/ActivityFeed/User/{userID}/GetByDate/ \
         *      -H "Authorization: Basic {authorizationToken}" \
         *      -H "Content-Type: application/json" \
         *      -d '{"StartDate": "2014/07/01 12:00:00",  "EndDate": "2014/07/31 23:59:59"}'
         *      
         */
        //* @apiExample {js} JavaScript / jQuery
        //*       $.ajax({ 
        //*          type: "GET",
        //*          url: "https://reporting.api.livefluence.com/{siteID}/ActivityFeed/User/47/GetByDate/", 
        //*          data: {
        //*              "StartDate": "2014/07/01 12:00:00",
        //*              "EndDate": "2014/07/31 23:59:59"
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
        //*      var request = new RestRequest("/{siteID}/ActivityFeed/User/47/GetByDate/", Method.GET);
        //*      request.RequestFormat = DataFormat.JSON;
        //*      request.AddParameter("range", {"StartDate": "2014/07/01 12:00:00",
        //*              "EndDate": "2014/07/31 23:59:59"});
        //*      var data = JsonConvert.DeserializeObject<ActivityViewModel>(client.Execute(request).Content); 
        //*      
        //*/
        #endregion apiComments
        public void ListByUserByDate(int userID, string range)
        {
        }

        #region apiComments
        /**
         * @apiVersion 0.1.0
         * @api {get} /{SiteID}/ActivityFeed/Group/:groupID/GetByDate/:range read by group by date
         * @apiDescription Returns all activities within the provided date range for the specified group id.
         * @apiPermission agent
         * @apiGroup Reporting > /activity feed
         * @apiName ListByGroupByDate
         * 
         * @apiParam    {Number}    groupID                 Group's unique ID.
         * @apiParam    {Object}    DateRange               DateRangeViewModel object
         * @apiParam    {String}    DateRange.StartDate     The start date and time.
         * @apiParam    {String}    DateRange.EndDate       The end date and time.
         * 
         * @apiSuccess  {Object[]}  Activity                List of ActivityViewModel
         * @apiSuccess  {Date}      Activity.Date           Date and Time
         * @apiSuccess  {String}    Activity.Event          The event.
         * @apiSuccess  {String}    Activity.TimeAgo        Time Ago?
         * @apiSuccess  {Number}    Activity.Type           The Activity Type (ActivityType enum).
         *                                                  Possible ActivityTypes:
         *                                                      (0) AgentLoggedIn,
         *                                                      (1) AgentLoggedOut,
         *                                                      (2) AgentAcceptedEngagement,
         *                                                      (3) AgentExitedEngagement,
         *                                                      (4) AgentCreatedCrmRecord,
         *                                                      (5) AgentChangedStatus,
         *                                                      (6) VisitorRequestedChat,
         *                                                      (7) VisitorExitedQueue,
         *                                                      (8) NoAgentsAvailable,
         *                                                      (9) AgentAcceptedInvite  *when an agent accepts invite to join site and created a login.
         * @apiSuccess  {String}    Activity.HeadshotUrl    The URL where the agent's headshot is hosted.
         * 
         * @apiSuccessExample    {json}      Success-Response:
         *     HTTP/1.1 200 OK
         *     {[{"Date": "1/1/2014 12:00 am", "Event": "Admin  logged in.", "TimeAgo": "8 hours 18 seconds", "Type": 0, "HeadshotUrl": "~\headshots\10\3048\Agent1.png"},{"Date": "1/1/2014 8:00 am", "Event": "Admin  logged out.", "TimeAgo": "18 seconds", "Type": 1, "HeadshotUrl": "~\headshots\10\3048\Agent1.png"}]}
         * 
         * @apiErrorStructure   NotAuthorizedError
         * 
         * @apiExample {curl} curl
         *      curl -X GET https:/reporting.api.livefluence.com/{siteID}/ActivityFeed/Group/{groupID}/GetByDate/ \
         *      -H "Authorization: Basic {authorizationToken}" \
         *      -H "Content-Type: application/json" \
         *      -d '{"StartDate": "2014/07/01 12:00:00",  "EndDate": "2014/07/31 23:59:59"}'
         */
        //* @apiExample {js} JavaScript / jQuery
        //*       $.ajax({ 
        //*          type: "GET",
        //*          url: "https://reporting.api.livefluence.com/{siteID}/ActivityFeed/Group/13/GetByDate/", 
        //*          data: {
        //*              "StartDate": "2014/07/01 12:00:00",
        //*              "EndDate": "2014/07/31 23:59:59"
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
        //*      var request = new RestRequest("/{siteID}/ActivityFeed/Group/13/GetByDate/", Method.GET);
        //*      request.AddParameter("range", {"StartDate": "2014/07/01 12:00:00",
        //*              "EndDate": "2014/07/31 23:59:59"});
        //*      var data = JsonConvert.DeserializeObject<ActivityViewModel>(client.Execute(request).Content); 
        //*      
        //*/
        #endregion apiComments
        public void ListByGroupByDate(int groupID, string range)
        {
        }
    }
}