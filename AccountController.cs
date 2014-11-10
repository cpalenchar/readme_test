using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class AccountController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/account/login/ login
        * @apiName Login
        * @apiGroup Settings > /account
        * @apiDescription Login to the api.
        * @apiPermission anonymous
        * 
        * @apiExample       {curl}              Example usage:
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/account/login \ 
        *       -H "Content-Type: application/json" \
        *       -d '{"userName": "email@domain.com, "password": "mypassword"}'
        *       
        * @apiParam         {Number}        siteID                          Your site's account number.
        * @apiParam         {Object}        LoginViewModel                  LoginVeiwModel
        * @apiParam         {String}        LoginViewModel.UserName         The username used to login.
        * @apiParam         {String}        LoginVewModel.Password          The password used to login.
        * 
        * @apiSuccess       {Object}        AccessToken                     Token used in the authorization header for subsequent api calls.
        * @apiSuccess       {Number}        AccessToken.UserID              The id of the user.
        * @apiSuccess       {String}        AccessToken.UserName            The username of the user.
        * @apiSuccess       {String}        AccessToken.Token               The token used to login.
        * @apiSuccess       {Date}          AccessToken.IssuedUTC           The date and time the token was issued.
        * @apiSuccess       {Date}          AccessToken.ExpiresUTC          The data and time the token expires.
        * @apiSuccess       {Number}        AccessToken.ActiveSiteID        The id of the site the user of which the user is logged in.
        * @apiSuccess       {Number[]}      AccessToken.Sites               The list of sites of which the user is a member. 
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *       "UserID":1,
        *       "UserName":"myemail@mydomain.com",
        *       "Token":"cJ4Kx0Br0kackchZhXQIIQ",
        *       "IssuedUTC":"1/1/2014 12:00 am",
        *       "ExpiresUTC":"1/1/2014 12:00 am",
        *       "ActiveSiteID":1,
        *       "Sites":[1]
        *     }
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 401 Not Authorized
        *     {
        *       "error": "Invalid username/password"
        *     }
        */
        #endregion
        public void LogIn(String logInViewModel)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/account/logout/logout
        * @apiName Logout
        * @apiGroup Settings > /account
        * @apiDescription Logout of the api.
        * @apiPermission anonymous
        * 
        * @apiExample       {curl}              Example usage:
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/account/logout \ 
        *       -H "Content-Type: application/json" \
        *       -d '{"Session": "session key", "SiteID": 1}'
        *       
        * @apiParam         {Number}        SiteId                                      Your site's account number.
        * @apiParam         {Object}        LogoutViewModel                             LogoutVeiwModel
        * @apiParam         {String}        LogoutViewModel.Session                     The token received when the user logged in.
        * @apiParam         {String}        LogoutVewModel.SiteId                       Your site's account number.
        * 
        * @apiError Conflict The user is not logged in.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 409 Conflict
        *     {
        *       "error": "Agent is not logged in."
        *     }
        */
        #endregion
        public void Logout(String logoutViewModel)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/account/get/:id read
        * @apiName Get:id
        * @apiGroup Settings > /account
        * @apiDescription Read the profile for this user.
        * @apiPermission agent
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/account/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        *       
        * @apiParam         {Number}        siteID                                  Your site's account number.
        * @apiParam         {Number}        id                                      The id of the user profile.
        *
        * @apiSuccess       {Object}        User   User
        * @apiSuccess       {Number}        User.UserID                             The id for the user.
        * @apiSuccess       {Number}        User.SiteID                             Your site's account number.
        * @apiSuccess       {String}        User.FirstName                          The first name of the user.
        * @apiSuccess       {String}        User.LastName                           The last name of the user.
        * @apiSuccess       {String}        User.Phone                              The phone number of the user.
        * @apiSuccess       {String}        User.Fax                                The fax number of the user.
        * @apiSuccess       {String}        User.AlternateEmail                     The alternate email of the user.
        * @apiSuccess       {String}        User.HeadshotUrl                        The url where the agent's headshot is hosted.
        * @apiSuccess       {String}        User.TimeZone                           The timezone offset for the user.
        * @apiSuccess       {String}        User.Language                           The language of the user to be used with google translate.
        * @apiSuccess       {Date}          User.LastSystemNotice                   The date and time of the last system notice.
        * @apiSuccess       {Date}          User.LastLoginFailure                   The date and time of the last login failure.
        * @apiSuccess       {Date}          User.LastCheck                          The date and time of the last check.
        * @apiSuccess       {Date}          User.LastSuccessfulLogin                The date and time of the last successful login.
        * @apiSuccess       {Number}        User.ConsecutiveLoginFailures           The number of connesecutive login failures.
        * @apiSuccess       {Boolean}       User.VisualAlertsWhenUnavailable        Are visual alerts displayed when the user is unavailable but logged in?
        * @apiSuccess       {Boolean}       User.ShadowNotifications                Are alerts displayed for engagements the user is shadowing?
        * @apiSuccess       {Boolean}       User.SoundsWhenUnavailable              Are sounds for alerts played when the user is unavailable but logged in?
        * @apiSuccess       {String}        User.SoundsNewEngagement                The sound that is played when the user receives a new engagement.
        * @apiSuccess       {String}        User.SoundsNewVisitor                   The sound that is played when a new visitor is detected by the visitor monitoring.
        * @apiSuccess       {String}        User.SoundsError                        The sound that is played when an error occurs in the agent software.
        * @apiSuccess       {String}        User.EngagementFontSize                 The font size in pixels for the engagement text as it is displayed in the agent sofware.
        * @apiSuccess       {String}        User.ColorsMyText                       The color of agent's text as it is displayed in the agent sofware.
        * @apiSuccess       {String}        User.ColorsVisitorText                  The color of the visitor's text as it is displayed in the agent software.
        * @apiSuccess       {String}        User.ColorsOtherAgentText               The color of other agent's text as it displayed in the agent software.
        * @apiSuccess       {String}        User.ColorsSystemText                   The color of the system text as it is displayed in the agent software.
        * @apiSuccess       {Boolean}       User.NewEngagementPopupAlert            Is a popup displayed when the user receives a new engagement?
        * @apiSuccess       {String}        User.UserName                           The username of the user.
        * @apiSuccess       {String}        User.DisplayName                        The display name of the user.
        * @apiSuccess       {Boolean}       User.AvailableAtLogin                   Is the user available for engagements immediately when they login?
        * @apiSuccess       {Boolean}       User.VisitorMonitoringEnabled           Is the user able to monitor visitors in real time, this also requres visitor monitoring code to be deployed?
        * @apiSuccess       {Boolean}       User.EnableSystemTrayAlerts             Are system tray alerts allowed by this user?
        * @apiSuccess       {Boolean}       User.RepeatSoundAlerts                  Are sounds for alerts repeated for this user in the agent software?
        * @apiSuccess       {String}        User.LoggedInSinceTimeSpanVerbose       The timespan since the user has been logged in.
        * @apiSuccess       {String}        User.LastLoggedInTimeSpanVerbose        The timespane since the user last logged off.
        * @apiSuccess       {Boolean}       User.IsAdministrator                    Is the user in an administrator role?
        * @apiSuccess       {Boolean}       User.IsManager                          Is the user in a manager role?
        * @apiSuccess       {Boolean}       User.IsAgent                            Is the user in an agent role?
        * @apiSuccess       {Number}        User.Tier                               The tier of the user.
        * @apiSuccess       {String}        User.AppVersion                         The version of the application the user is using to log in.
        * @apiSuccess       {Date}          User.LoginTime                          The date and time the user last logged in using the agent software.
        * @apiSuccess       {Boolean}       User.IsSignalRConnected                 Is the user connected to signalR?
        * @apiSuccess       {Boolean}       User.IsLoggedIn                         Is the user currently logged into the agent software?  If the user is logged in and not connected to signalR the user is polling for updates.
        * @apiSuccess       {Boolean}       User.Available                          Is the user available to receive engagements?
        * @apiSuccess       {Boolean}       User.IsBootRequested                    Has the user recieved a forced log off?
        * @apiSuccess       {Date}          User.LastChatTime                       The date and time of the users' last chat.
        * @apiSuccess       {Boolean}       User.IsPending                          Is the users' invitation pending?
        * @apiSuccess       {Date}          User.PendingSince                       The date and time of the users' invitation.
        * @apiSuccess       {String}        User.PendingSinceVerbose                The verbose date and time of the users' invitation.
        * @apiSuccess       {Number}        User.CurrentChats                       The total number of engagements the user currently has.
        * @apiSuccess       {Number}        User.TotalChats                         The total number of engagements the user has taken.
        * @apiSuccess       {Number}        User.ApprovalRating                     The current approval rating of the user, determined by the engagement ratings.
        * @apiSuccess       {Number}        User.HoursAvailable                     The total number of hours the user has been available.
        * @apiSuccess       {Number}        User.MaxChats                           The total number of concurrent engagements the user is allowed to have.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *      {
        *           "userId":1046,  
        *           "FirstName":"bob",
        *           "LastName":"smith",
        *           "Phone":"1111111111",
        *           "Fax":null,
        *           "AlternateEmail":null,
        *           "HeadshotUrl":"http://mydomain.com/avatars/avatar2.png",
        *           "TimeZone":"Dateline Standard Time",
        *           "Language":"en",
        *           "LastSystemNotice":"1980-01-01T00:00:00Z",
        *           "LastLoginFailure":"1980-01-01T00:00:00Z",
        *           "LastCheck":"1980-01-01T00:00:00Z",
        *           "LastSuccessfulLogin":"2014-11-08T05:04:10.587Z",
        *           "ConsecutiveLoginFailures":0,
        *           "VisualAlertsWhenUnavailable":true,
        *           "ShadowNotifications":true,
        *           "SoundsWhenUnavailable":true,
        *           "SoundsNewChat":"url2",
        *           "SoundsNewEngagement":"url1",
        *           "SoundsNewVisitor":"url1",
        *           "SoundsError":"url2",
        *           "EngagementFontSize":"18",
        *           "ColorsMyText":"#555",
        *           "ColorsVisitorText":"#4986e7",
        *           "ColorsOtherAgentText":"#ac725e",
        *           "ColorsSystemText":"#f83a22",
        *           "NewEngagementPopupAlert":true,
        *           "UserName":"myemail@mydomain.com",
        *           "DisplayName":"Administrator",
        *           "AvailableAtLogin":false,
        *           "VisitorMonitoringEnabled":true,
        *           "EnableSystemTrayAlerts":true,
        *           "RepeatSoundAlerts":false,
        *           "LoggedInSinceTimeSpanVerbose":"4 minutes ago",
        *           "LastLoggedInTimeSpanVerbose":"4 minutes ago",
        *           "SiteID":33,
        *           "IsAdministrator":true,
        *           "IsManager":true,
        *           "IsAgent":true,
        *           "Tier":1,
        *           "AppVersion":"10.0.0.b",
        *           "LoginTime":"2014-11-08T05:04:11.003Z",
        *           "IsSignalRConnected":false,
        *           "IsLoggedIn":true,
        *           "Available":true,
        *           "IsBootRequested":false,
        *           "LastChatTime":"1980-01-01T00:00:00Z",
        *           "IsPending":false,
        *           "PendingSince":"0001-01-01T00:00:00Z",
        *           "PendingSinceVerbose":"not yet",
        *           "CurrentChats":32,
        *           "TotalChats":0,
        *           "ApprovalRating":0.0,
        *           "HoursAvailable":0.0,
        *           "MaxChats":4,"
        *           Groups":[]
        *       }
        *      
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 401 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void Get(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/account/getallusers/ read all
        * @apiName Get All
        * @apiGroup Settings > /account
        * @apiDescription Read all the user profiles for this site.
        * @apiPermission siteManager
        * 
        * @apiExample       {curl}              Example usage:
        *       curl  https:/main.api.livefluence.com/{siteID}/account/getallusers  \
         *      -H "Authorization: Basic {authorizationToken}"
        *       
        *
        * @apiParam         {Number}        siteID                                  Your site's account number.
        *
        * @apiSuccess       {Object[]}      User                                    User
        * @apiSuccess       {Number}        User.SiteID                             Your site's account number.
        * @apiSuccess       {Number}        User.UserID                             The id for the user.
        * @apiSuccess       {String}        User.FirstName                          The first name of the user.
        * @apiSuccess       {String}        User.FastName                           The last name of the user.
        * @apiSuccess       {String}        User.Phone                              The phone number of the user.
        * @apiSuccess       {String}        User.Fax                                The fax number of the user.
        * @apiSuccess       {String}        User.AlternateEmail                     The alternate email for the user.
        * @apiSuccess       {String}        User.HeadshotUrl                        The url where the agent's headshot is hosted.
        * @apiSuccess       {String}        User.TimeZone                           The timezone offset for the user.
        * @apiSuccess       {String}        User.Language                           The language of the user to be used with google translate.
        * @apiSuccess       {Date}          User.LastSystemNotice                   The date and time of the last system notice.
        * @apiSuccess       {Date}          User.LastLoginFailure                   The date and time of the last login failure.
        * @apiSuccess       {Date}          User.LastCheck                          The last date and time of the last check.
        * @apiSuccess       {Date}          User.LastSuccessfulLogin                The last date and time of the last successful login.
        * @apiSuccess       {Number}        User.ConsecutiveLoginFailures           The number of connesecutive login failures.
        * @apiSuccess       {Boolean}       User.VisualAlertsWhenUnavailable        Are viusal alerts displayed when the user is unavailable but logged in?
        * @apiSuccess       {Boolean}       User.ShadowNotifications                Are alerts displayed for engagements the user is shadowing?
        * @apiSuccess       {Boolean}       User.SoundsWhenUnavailable              Are sounds for alerts played when the user is unavailable but logged in?
        * @apiSuccess       {String}        User.SoundsNewEngagement                The sound that is played when the user receives a new engagement.
        * @apiSuccess       {String}        User.SoundsNewVisitor                   The sound that is played when a new visitor is detected by the visitor monitoring.
        * @apiSuccess       {String}        User.SoundsError                        The sound that is played when an error occurs in the agent software.
        * @apiSuccess       {String}        User.EngagementFontSize                 The font size in pixels for the engagement text as it is displayed in the agent sofware.
        * @apiSuccess       {String}        User.ColorsMyText                       The color of agent's text as it is displayed in the agent sofware.
        * @apiSuccess       {String}        User.ColorsVisitorText                  The color of the visitor's text as it is displayed in the agent software.
        * @apiSuccess       {String}        User.ColorsOtherAgentText               The color of other agent's text as it displayed in the agent software.
        * @apiSuccess       {String}        User.ColorsSystemText                   The color of the system text as it is displayed in the agent software.
        * @apiSuccess       {Boolean}       User.NewEngagementPopupAlert            Is a popup displayed when the user receives a new engagement?
        * @apiSuccess       {String}        User.UserName                           The username of the user.
        * @apiSuccess       {String}        User.DisplayName                        The display name of the user.
        * @apiSuccess       {Boolean}       User.AvailableAtLogin                   Is the user available for engagements immediately when they login?
        * @apiSuccess       {Boolean}       User.VisitorMonitoringEnabled           Is the user able to monitor visitors in real time, the also requres visitor monitoring code to be deployed?
        * @apiSuccess       {Boolean}       User.EnableSystemTrayAlerts             Are system tray alerts allowed by the user?
        * @apiSuccess       {Boolean}       User.RepeatSoundAlerts                  Are sounds for alerts repeated for the user in the agent software?
        * @apiSuccess       {String}        User.LoggedInSinceTimeSpanVerbose       The timespan since the user has been logged in.
        * @apiSuccess       {String}        User.LastLoggedInTimeSpanVerbose        The timespane since the user last logged off.
        * @apiSuccess       {Boolean}       User.IsAdministrator                    Is the user in an administrator role?
        * @apiSuccess       {Boolean}       User.IsManager                          Is the user in a manager role?
        * @apiSuccess       {Boolean}       User.IsAgent                            Is the user in an agent role?
        * @apiSuccess       {Number}        User.Tier                               The tier the user is in.
        * @apiSuccess       {String}        User.AppVersion                         The version of the application the user is using to log in.
        * @apiSuccess       {Date}          User.LoginTime                          The date and time the user last logged in using the agent software.
        * @apiSuccess       {Boolean}       User.IsSignalRConnected                 Is the user connected to signalR?
        * @apiSuccess       {Boolean}       User.IsLoggedIn                         Is the user currently logged into the agent software?  If the user is logged in and not connected to signalR the user is polling for updates.
        * @apiSuccess       {Boolean}       User.Available                          Is the user available to receive engagements?
        * @apiSuccess       {Boolean}       User.IsBootRequested                    Has the user recieved a forced log off?
        * @apiSuccess       {Date}          User.LastChatTime                       The date and time of the users' last chat.
        * @apiSuccess       {Boolean}       User.IsPending                          Is the users' invitation pending?
        * @apiSuccess       {Date}          User.PendingSince                       The date and time of the users' invitation.
        * @apiSuccess       {String}        User.PendingSinceVerbose                The verbose date and time of the users' invitation.
        * @apiSuccess       {Number}        User.CurrentChats                       The total number of engagements the user currently has.
        * @apiSuccess       {Number}        User.TotalChats                         The total number of engagements the user has been taken part in.
        * @apiSuccess       {Number}        User.ApprovalRating                     The current approval rating of the user, determined by the engagement ratings.
        * @apiSuccess       {Number}        User.HoursAvailable                     The total number of hours the user has been available.
        * @apiSuccess       {Number}        User.MaxChats                           The total number of concurrent engagements the user is allowed to have.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *      {
        *           [{"userId":1046,  
        *           "FirstName":"bob",
        *           "LastName":"smith",
        *           "Phone":"1111111111",
        *           "Fax":null,
        *           "AlternateEmail":null,
        *           "HeadshotUrl":"http://mydomain.com/avatars/avatar2.png",
        *           "TimeZone":"Dateline Standard Time",
        *           "Language":"en",
        *           "LastSystemNotice":"1980-01-01T00:00:00Z",
        *           "LastLoginFailure":"1980-01-01T00:00:00Z",
        *           "LastCheck":"1980-01-01T00:00:00Z",
        *           "LastSuccessfulLogin":"2014-11-08T05:04:10.587Z",
        *           "ConsecutiveLoginFailures":0,
        *           "VisualAlertsWhenUnavailable":true,
        *           "ShadowNotifications":true,
        *           "SoundsWhenUnavailable":true,
        *           "SoundsNewChat":"url2",
        *           "SoundsNewEngagement":"url1",
        *           "SoundsNewVisitor":"url1",
        *           "SoundsError":"url2",
        *           "EngagementFontSize":"18",
        *           "ColorsMyText":"#555",
        *           "ColorsVisitorText":"#4986e7",
        *           "ColorsOtherAgentText":"#ac725e",
        *           "ColorsSystemText":"#f83a22",
        *           "NewEngagementPopupAlert":true,
        *           "UserName":"myemail@mydomain.com",
        *           "DisplayName":"Administrator",
        *           "AvailableAtLogin":false,
        *           "VisitorMonitoringEnabled":true,
        *           "EnableSystemTrayAlerts":true,
        *           "RepeatSoundAlerts":false,
        *           "LoggedInSinceTimeSpanVerbose":"4 minutes ago",
        *           "LastLoggedInTimeSpanVerbose":"4 minutes ago",
        *           "SiteID":33,
        *           "IsAdministrator":true,
        *           "IsManager":true,
        *           "IsAgent":true,
        *           "Tier":1,
        *           "AppVersion":"10.0.0.b",
        *           "LoginTime":"2014-11-08T05:04:11.003Z",
        *           "IsSignalRConnected":false,
        *           "IsLoggedIn":true,
        *           "Available":true,
        *           "IsBootRequested":false,
        *           "LastChatTime":"1980-01-01T00:00:00Z",
        *           "IsPending":false,
        *           "PendingSince":"0001-01-01T00:00:00Z",
        *           "PendingSinceVerbose":"not yet",
        *           "CurrentChats":32,
        *           "TotalChats":0,
        *           "ApprovalRating":0.0,
        *           "HoursAvailable":0.0,
        *           "MaxChats":4,"
        *           Groups":[]}]
        *       }
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 401 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void GetAllUsers()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/account/post/ update profile
        * @apiName Post
        *  @apiGroup Settings > /account
        * @apiDescription Update the profile for this user.
        * @apiPermission agent
        * 
        * @apiExample       {curl}              Example usage:
        *       curl -X POST  https:/main.api.livefluence.com/{siteID}/account
        *       -H "Authorization: Basic {authorizationToken}" /
        *       -H "Content-Type: application/json" 
        *       -d "{ "SiteID": 1, "UserID": 1, "FirstName": "John", "LastName": "Smith",  "Phone": "111.111.1111", "Fax": "111.111.1111", "AlternateEmail": "email@domain.com", "HeadshotUrl": "mydomain.com/headshoturl.jpg", "TimeZone": "GMT Standard Time", "Language": "en", "LastSystemNotice": "1/1/2014 12:00 am", "LastLoginFailure": "1/1/2014 12:00 am", "LastSuccessfulLogin", "1/1/2014 12:00 am", "ConsecutiveLoginFailures": 0, "VisualAlertsWhenUnavailable": true, "ShadowNotifications": true, "SoundsWhenUnavailable" : true, "SoundsNewEngagement": "newengagement sound", "SoundsNewVisitor": "newvisitor sound, "SoundsError": "errorsound", "EngagementFontSize": "12", "ColorsMyText": "#ffffff", "ColorsVisitorText": "#ffffff", "ColorsOtherAgentText": "#ffffff", "ColorsSystemText": "#ffffff", "NewEngagementPopupAlert": true, "UserName": "myemail@mydomain.com", "DisplayName": "screen name", "AvailableAtLogin": true, "VisitorMonitoringEnabled": true, "EnableSystemTrayAlerts": true, "RepeatSoundAlerts": true, "IsAdministrator": true, "IsManager": true, "IsAgent": true, "Tier": 1 }"
        *       
        * @apiParam         {Number}        siteID                                  Your site's account number.
        * @apiParam         {Object}        User                                    User
        * @apiParam         {Number}        User.SiteID                             Your site's account number.
        * @apiParam         {Number}        User.UserID                             The id for the user.
        * @apiParam         {String}        User.FirstName                          The first name of the user.
        * @apiParam         {String}        User.LastName                           The last name of the user.
        * @apiParam         {String}        User.Phone                              The phone number of the user.
        * @apiParam         {String}        User.Fax                                The fax number of the user.
        * @apiParam         {String}        User.AlternateEmail                     The alternate email for the user.
        * @apiParam         {String}        User.HeadshotUrl                        The url where the agent's headshot is hosted.
        * @apiParam         {String}        User.TimeZone                           The timezone offset for the user.
        * @apiParam         {String}        User.Language                           The language of the user to be used with google translate.
        * @apiParam         {Date}          User.LastSystemNotice                   The date and time of the last system notice.
        * @apiParam         {Date}          User.LastLoginFailure                   The date and time of the last login failure.
        * @apiParam         {Date}          User.LastCheck                          The last date and time of the last check.
        * @apiParam         {Date}          User.LastSuccessfulLogin                The last date and time of the last successful login.
        * @apiParam         {Number}        User.ConsecutiveLoginFailures           The number of connesecutive login failures.
        * @apiParam         {Boolean}       User.VisualAlertsWhenUnavailable        Are viusal alerts displayed when the user is unavailable but logged in?
        * @apiParam         {Boolean}       User.ShadowNotifications                Are alerts displayed for engagements the user is shadowing?
        * @apiParam         {Boolean}       User.SoundsWhenUnavailable              Are sounds for alerts played when the user is unavailable but logged in?
        * @apiParam         {String}        User.SoundsNewEngagement                The sound that is played when the user receives a new engagement.
        * @apiParam         {String}        User.SoundsNewVisitor                   The sound that is played when a new visitor is detected by the visitor monitoring.
        * @apiParam         {String}        User.SoundsError                        The sound that is played when an error occurs in the agent software.
        * @apiParam         {String}        User.EngagementFontSize                 The font size in pixels for the engagement text as it is displayed in the agent sofware.
        * @apiParam         {String}        User.ColorsMyText                       The color of agent's text as it is displayed in the agent sofware.
        * @apiParam         {String}        User.ColorsVisitorText                  The color of the visitor's text as it is displayed in the agent software.
        * @apiParam         {String}        User.ColorsOtherAgentText               The color of other agent's text as it displayed in the agent software.
        * @apiParam         {String}        User.ColorsSystemText                   The color of the system text as it is displayed in the agent software.
        * @apiParam         {Boolean}       User.NewEngagementPopupAlert            Is a popup displayed when the user receives a new engagement?
        * @apiParam         {String}        User.UserName                           The username of the user.
        * @apiParam         {String}        User.DisplayName                        The display name of the user.
        * @apiParam         {Boolean}       User.AvailableAtLogin                   Is the user available for engagements immediately when they login?
        * @apiParam         {Boolean}       User.VisitorMonitoringEnabled           Is the user able to monitor visitors in real time, the also requres visitor monitoring code to be deployed?
        * @apiParam         {Boolean}       User.EnableSystemTrayAlerts             Are system tray alerts allowed by the user?
        * @apiParam         {Boolean}       User.RepeatSoundAlerts                  Are sounds for alerts repeated for the user in the agent software?
        * @apiParam         {String}        User.LoggedInSinceTimeSpanVerbose       The timespan since the user has been logged in.
        * @apiParam         {String}        User.LastLoggedInTimeSpanVerbose        The timespane since the user last logged off.
        * @apiParam         {Boolean}       User.IsAdministrator                    Is the user in an administrator role?
        * @apiParam         {Boolean}       User.IsManager                          Is the user in a manager role?
        * @apiParam         {Boolean}       User.IsAgent                            Is the user in an agent role?
        * @apiParam         {Number}        User.Tier                               The tier the user is in.
        * @apiParam         {Boolean}       User.Available                          Is the user available to receive engagements?
        *
        * @apiSuccess       {Object[]}      User                                    User
        * @apiSuccess       {Number}        User.SiteID                             Your site's account number.
        * @apiSuccess       {Number}        User.UserID                             The id for the user.
        * @apiSuccess       {String}        User.FirstName                          The first name of the user.
        * @apiSuccess       {String}        User.LastName                           The last name of the user.
        * @apiSuccess       {String}        User.Phone                              The phone number of the user.
        * @apiSuccess       {String}        User.Fax                                The fax number of the user.
        * @apiSuccess       {String}        User.AlternateEmail                     The alternate email for the user.
        * @apiSuccess       {String}        User.HeadshotUrl                        The url where the agent's headshot is hosted.
        * @apiSuccess       {String}        User.TimeZone                           The timezone offset for the user.
        * @apiSuccess       {String}        User.Language                           The language of the user to be used with google translate.
        * @apiSuccess       {Date}          User.LastSystemNotice                   The date and time of the last system notice.
        * @apiSuccess       {Date}          User.LastLoginFailure                   The date and time of the last login failure.
        * @apiSuccess       {Date}          User.LastCheck                          The last date and time of the last check.
        * @apiSuccess       {Date}          User.LastSuccessfulLogin                The last date and time of the last successful login.
        * @apiSuccess       {Number}        User.ConsecutiveLoginFailures           The number of connesecutive login failures.
        * @apiSuccess       {Boolean}       User.VisualAlertsWhenUnavailable        Are viusal alerts displayed when the user is unavailable but logged in?
        * @apiSuccess       {Boolean}       User.ShadowNotifications                Are alerts displayed for engagements the user is shadowing?
        * @apiSuccess       {Boolean}       User.SoundsWhenUnavailable              Are sounds for alerts played when the user is unavailable but logged in?
        * @apiSuccess       {String}        User.SoundsNewEngagement                The sound that is played when the user receives a new engagement.
        * @apiSuccess       {String}        User.SoundsNewVisitor                   The sound that is played when a new visitor is detected by the visitor monitoring.
        * @apiSuccess       {String}        User.SoundsError                        The sound that is played when an error occurs in the agent software.
        * @apiSuccess       {String}        User.EngagementFontSize                 The font size in pixels for the engagement text as it is displayed in the agent sofware.
        * @apiSuccess       {String}        User.ColorsMyText                       The color of agent's text as it is displayed in the agent sofware.
        * @apiSuccess       {String}        User.ColorsVisitorText                  The color of the visitor's text as it is displayed in the agent software.
        * @apiSuccess       {String}        User.ColorsOtherAgentText               The color of other agent's text as it displayed in the agent software.
        * @apiSuccess       {String}        User.ColorsSystemText                   The color of the system text as it is displayed in the agent software.
        * @apiSuccess       {Boolean}       User.NewEngagementPopupAlert            Is a popup displayed when the user receives a new engagement?
        * @apiSuccess       {String}        User.UserName                           The username of the user.
        * @apiSuccess       {String}        User.DisplayName                        The display name of the user.
        * @apiSuccess       {Boolean}       User.AvailableAtLogin                   Is the user available for engagements immediately when they login?
        * @apiSuccess       {Boolean}       User.VisitorMonitoringEnabled           Is the user able to monitor visitors in real time, the also requres visitor monitoring code to be deployed?
        * @apiSuccess       {Boolean}       User.EnableSystemTrayAlerts             Are system tray alerts allowed by the user?
        * @apiSuccess       {Boolean}       User.RepeatSoundAlerts                  Are sounds for alerts repeated for the user in the agent software?
        * @apiSuccess       {String}        User.LoggedInSinceTimeSpanVerbose       The timespan since the user has been logged in.
        * @apiSuccess       {String}        User.LastLoggedInTimeSpanVerbose        The timespane since the user last logged off.
        * @apiSuccess       {Boolean}       User.IsAdministrator                    Is the user in an administrator role?
        * @apiSuccess       {Boolean}       User.IsManager                          Is the user in a manager role?
        * @apiSuccess       {Boolean}       User.IsAgent                            Is the user in an agent role?
        * @apiSuccess       {Number}        User.Tier                               The tier the user is in.
        * @apiSuccess       {Boolean}       User.available                          Is the user available to receive engagements?
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *      {
        *           "userId":1046,  
        *           "FirstName":"bob",
        *           "LastName":"smith",
        *           "Phone":"1111111111",
        *           "Fax":null,
        *           "AlternateEmail":null,
        *           "HeadshotUrl":"http://mydomain.com/avatars/avatar2.png",
        *           "TimeZone":"Dateline Standard Time",
        *           "Language":"en",
        *           "LastSystemNotice":"1980-01-01T00:00:00Z",
        *           "LastLoginFailure":"1980-01-01T00:00:00Z",
        *           "LastCheck":"1980-01-01T00:00:00Z",
        *           "LastSuccessfulLogin":"2014-11-08T05:04:10.587Z",
        *           "ConsecutiveLoginFailures":0,
        *           "VisualAlertsWhenUnavailable":true,
        *           "ShadowNotifications":true,
        *           "SoundsWhenUnavailable":true,
        *           "SoundsNewChat":"url2",
        *           "SoundsNewEngagement":"url1",
        *           "SoundsNewVisitor":"url1",
        *           "SoundsError":"url2",
        *           "EngagementFontSize":"18",
        *           "ColorsMyText":"#555",
        *           "ColorsVisitorText":"#4986e7",
        *           "ColorsOtherAgentText":"#ac725e",
        *           "ColorsSystemText":"#f83a22",
        *           "NewEngagementPopupAlert":true,
        *           "UserName":"myemail@mydomain.com",
        *           "DisplayName":"Administrator",
        *           "AvailableAtLogin":false,
        *           "VisitorMonitoringEnabled":true,
        *           "EnableSystemTrayAlerts":true,
        *           "RepeatSoundAlerts":false,
        *           "LoggedInSinceTimeSpanVerbose":"4 minutes ago",
        *           "LastLoggedInTimeSpanVerbose":"4 minutes ago",
        *           "SiteID":33,
        *           "IsAdministrator":true,
        *           "IsManager":true,
        *           "IsAgent":true,
        *           "Tier":1,
        *       }
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 401 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void Post(string profile)
        {
            
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/account/changepassword/ update password
        * @apiName Put Password
        * @apiGroup Settings > /account
        * @apiDescription Update the password for the user that is logged in.
        * @apiPermission agent
        * 
        * @apiExample       {curl}              Example usage:
        *       curl -X PUT  https:/main.api.livefluence.com/{siteID}/account
        *       -H "Authorization: Basic {authorizationToken}" /
        *       -H "Content-Type: application/json" 
        *       -d "{ "NewPassword": "mypassword", "CurrentPassword": "myoldpassword" }"
        *
        * @apiParam         {Number}        siteId                                      Your site's account number.
        * @apiParam         {Object}        PasswordChangeViewModel                     PasswordChangeViewModel
        * @apiParam         {String}        PasswordChangeViewModel.NewPassword         The new password.
        * @apiParam         {String}        PasswordChangeViewModel.CurrentPassword     The current password.
        * 
        * @apiSuccess       {Object}        PassowrdChangeViewModel                     PasswordChangeViewModel
        * @apiSuccess       {String}        PasswordChangeViewModel.NewPassword         The new password.
        * @apiSuccess       {String}        PasswordChangeViewModel.CurrentPassword     The current password.
        * @apiSuccess       {Boolean}       PasswordChangeViewModel.Succeeded           Did the password get updated?
        * @apiSuccess       {String[]}      PasswordChangeViewModel.Errors              An array of password validation errors.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "NewPassword":"mynewpassword",
        *          "CurrentPassword":"mycurrentpassword",
        *          "Succeeded":true,
        *          "Errors";[]}
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 401 Not Authorized
        *     {
        *       "error": "Not Authorized"
        *     }
        */
        #endregion
        public void UpdatePassword(string passwordChangeViewModel)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/account/updatetier/ update tier
        * @apiName Put Tier
        * @apiGroup Settings > /account
        * @apiDescription Update the tier for this user in this group.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X PUT  https:/main.api.livefluence.com/{siteID}/account
        *       -H "Authorization: Basic {authorizationToken}" /
        *       -H "Content-Type: application/json" 
        *       -d "{ "UserId": 1, "GroupId": 1, "Tier": 1}"
        *       
        * @apiParam         {Number}        SiteID                                      Your site's account number.
        * @apiParam         {Object}        UpdateTierViewModel                         UpdateTierViewModel
        * @apiParam         {Number}        UpdateTierViewModel.UserID                  The id for the user.
        * @apiParam         {Number}        UpdateTierViewModel.GroupID                 The id for the group.
        * @apiParam         {Number}        UpdateTierViewModel.Tier                    The new tier for the user in the group.
        * 
        * @apiSuccess       {Object}        UpdateTierViewModel                         UpdateTierViewModel
        * @apiSuccess       {Number}        UpdateTierViewModel.UserID                  The id for the user.
        * @apiSuccess       {Number}        UpdateTierViewModel.GroupID                 The id for the group.
        * @apiSuccess       {Number}        UpdateTierViewModel.Tier                    The new tier for the user in the group.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "UserID":1,
        *          "GroupID":1,
        *          "Tier":1"
        *     }
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 401 Not Authorized
        *     {
        *       "error": "Not Authorized"
        *     }
        */
        #endregion
        public void UpdateTier(string newTier)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/Account/Headshot/:id headshot
        * @apiName Headshot
        * @apiGroup SETTTINGS > /account
        * @apiDescription Update the headshot for this user.
        * @apiPermission agent
        * 
        * @apiExample       {curl}              Example usage:
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/account/headshot/:id /
        *       -H "Authorization: Basic {authorizationToken}" /
        *       -H "Content-Type: application/json" /
        *       -d "{formdata}" 
        *       
        * @apiParam         {Number}        siteId                                      Your site's account number.
        * @apiParam         {Number}        id                                          The user's id.
        * 
        * @apiSuccess       {String}        HeadshotUrl                                 The location of the saved headshot.
        *
        * @apiSuccessExample {text} Success-Response:
        *     HTTP/1.1 200 OK
        *     {www.mydomain.com/headshot.jpg}
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 401 Not Authorized
        *     {
        *       "error": "Not Authorized"
        *     }
        */
        #endregion
        public void Headshot(int id)
        {
        }
    }
}
