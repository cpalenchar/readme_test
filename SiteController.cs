using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class SiteController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/site/getall read all
        * @apiName getall
        * @apiGroup SETTINGS > /site
        * @apiDescription Read all the sites for this user.
        * @apiPermission siteAdministrator
        * 
        * @apiExample       {curl}              Example usage:
        *       curl http:/main.api.livefluence.com/{siteID}/site
        *       -H "Authorization: Basic {authorizationToken}" 
        *       
        *
        * @apiParam         {Number}            siteID                                                Your site's account number.
        *
        * @apiSuccess       {Object[]}          SiteViewModel                                         the siteviewmodel object
        * @apiSuccess       {Number}            SiteViewModel.SiteID                                  Your site's account number.
        * @apiSuccess       {String}            SiteViewModel.CompanyURL                              The url of the site.
        * @apiSuccess       {String}            SiteViewModel.CompanyName                             The name of the site.
        * @apiSuccess       {String}            SiteViewModel.CompanyAddress1                         The first line of the site's address.
        * @apiSuccess       {String}            SiteViewModel.CompanyAdsress2                         The second line of the site's address.
        * @apiSuccess       {Number}            SiteViewModel.CompanyCountryID                        The id code of the country of the site.
        * @apiSuccess       {String}            SiteViewModel.CompanyPostalCode                       The postal code of the site.
        * @apiSuccess       {String}            SiteViewModel.Region                                  The geographic region of the site.
        * @apiSuccess       {String}            SiteViewModel.Language                                The default language of the site.
        * @apiSuccess       {String}            SiteViewModel.Facebook                                The Facebook link of the site.
        * @apiSuccess       {String}            SiteViewModel.Twitter                                 The Twitter link of the site.
        * @apiSuccess       {String}            SiteViewModel.Google                                  The Google Plus link of the company.
        * @apiSuccess       {String}            SiteViewModel.LinkedIn                                The LinkedIn link of the site.
        * @apiSuccess       {String}            SiteViewModel.LogoUrl                                 The url of the sites's logo.
        * @apiSuccess       {Number}            SiteViewModel.CreatedByUserID                         The user id of the user that created the site.
        * @apiSuccess       {String}            SiteViewModel.CreatedBy                               The username of the user that created the site.
        * @apiSuccess       {String}            SiteViewModel.CreatedTimeAgo                          A user friendly description of when the site was created.  
        * @apiSuccess       {String}            SiteViewModel.Comments                                Comments of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.ShowWizard                              Show the startup wizard be displayed of the site.
        * @apiSuccess       {String}            SiteViewModel.Timezone                                The timezone of the site.
        * @apiSuccess       {String}            SiteViewModel.CName                                   The Cname alias the account utilizes of engagements.  
        * @apiSuccess       {String}            SiteViewModel.TwitterScreenName;                      The Twitter screen name of the site.
        * @apiSuccess       {String}            SiteViewModel.TwitterAccessTokenSecret                The Twitter secret token linked to the site's Twitter account when logging in.
        * @apiSuccess       {String}            SiteViewModel.TwitterAccessToken                      The Twitter access token to the site's Twitter account.
        * @apiSuccess       {String}            SiteViewModel.FacebookAppID                           The app id of the site's Facebook account.
        * @apiSuccess       {String}            SiteViewModel.FacebookAppName                         The app name of the site's Facebook account.
        * @apiSuccess       {String}            SiteViewModel.FacebookAppSecret                       The Facebook secret token linked to the site's account when logging in.                        
        * @apiSuccess       {Number}            SiteViewModel.ApplicationID                           The site's application id.
        * @apiSuccess       {Date}              SiteViewModel.DateCreated                             The date and time the site was created.
        * @apiSuccess       {String}            SiteViewModel.GoogleAnalyticsID                       The Google Analytics id of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.TransferUnansweredChats                 Does the site allow transfer of unaswered engagements?
        * @apiSuccess       {Boolean}           SiteViewModel.EnablePrechatSurvey                     Does the site have a prechat survey of the visitor?
        * @apiSuccess       {String}            SiteViewModel.EmailPrechatSubmissionsTo               The email to send the prechat surveys of the site.
        * @apiSuccess       {String}            SiteViewModel.PrechatSubmitText                       The text of the prechat survey if it is enabled of the site.
        * @apiSuccess       {String}            SiteViewModel.PrechatHeaderText                       The header text of the prechat survey of the site if it is enabled.
        * @apiSuccess       {String}            SiteViewModel.DefaultVisitorName                      The default name to use of a visitor of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.QueueIncomingRequests                   Do incoming engagement request get queued of the site?
        * @apiSuccess       {Number}            SiteViewModel.QueueTimeoutSeconds                     If queueing is used of the site, the is the timeout value of the queue.
        * @apiSuccess       {Boolean}           SiteViewModel.QueueWhenAllAgentsBusy                  If queueing is not used of the site, should a queue be used if all agents are busy?
        * @apiSuccess       {Boolean}           SiteViewModel.HigherTiersGetQueueAlert                If queueing is used to higher tiers get queue alerts of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.EnablePostchatSurvey                    Does the site have a postchat survey of the visitor?
        * @apiSuccess       {String}            SiteViewModel.PostchatSubmitText                      The text of the post chat survey if it enabled of the site.
        * @apiSuccess       {String}            SiteViewModel.EmailPostchatSubmissionsTo              The email address to send postchat surveys to if postchat surveys are enabled of the site. 
        * @apiSuccess       {String}            SiteViewModel.PostchatHeaderText                      The header text of the postchat survey if it is enabled. 
        * @apiSuccess       {Boolean}           SiteViewModel.EnablePostchatAgentSurvey               Does the site have a postchat survey of the agent?
        * @apiSuccess       {Number}            SiteViewModel.RoutingAlgorithm                        Routing algorithm to route engagements of the site (1: No logic, 2: Custom Rules, 3: External Provider).
        * @apiSuccess       {Number}            SiteViewModel.UnavailableAction                       What action to do if there are not agents in the site available of the engagement (1: Offer a survey, 2: Display custom text, 3: Redirect to page, 4: Hide live help).
        * @apiSuccess       {String}            SiteViewModel.UnavailableText                         The unavailable text to display of the unavailable action is set to display custom text.
        * @apiSuccess       {String}            SiteViewModel.UnavailableRedirectUrl                  The url to use as a redirect if the unavailable action is set to redirect to page.
        * @apiSuccess       {String}            SiteViewModel.EmailUnavailableSubmissionsTo           The email address to send unavailable surveys to if the unavailable action is set to offer survey of the site.
        * @apiSuccess       {String}            SiteViewModel.UnavailableRedirectUrl                  The url to use as a redirect if the unavailable action is set to redirect to page of the site.
        * @apiSuccess       {String}            SiteViewModel.UnavailableSubmitText                   The text of the unavailable survey if it is enabled of the site.
        * @apiSuccess       {String}            SiteViewModel.UnavailableHeaderText                   The header text of the unavailable survey if the unavailable action is set of offer survey of the site.
        * @apiSuccess       {Number}            SiteViewModel.InlineWindowPicturePreference           The option to set the inline window picture of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.InlineWindowChatRatingEnabled           Is the engagement rating button enabled of the inline window of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowChatRatingText              The text of the engagement rating button of the Inline window if it is enabled of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.InlineWindowPrintEnabled                Is the print button enabled of the inline window of the site?
        * @apiSuccess       {String}            SiteViewModel.InlineWindowPrintText                   The text of the print button of the inline window if it is enabled of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.InlineWindowEmailEnabled                Is the email button enabled of the inline window of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowEmailText                   The text of the email button of the inline window if it is enabled of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowEndChatText                 The text of the end chat button of the inline window engagemnet of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowOperatorText                The text displayed of the agents' messages of the inline window of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowVisitorText                 The text displayed of the visitors' messages of the inline window of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowWelcomeMessage              The welcome message that is displayed in the inline window of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.InlineWindowLineRatingEnabled           Is the line rating button enabled of the inline window of the site?
        * @apiSuccess       {Boolean}           SiteViewModel.InlineWindowUploadEnabled               Is the upload button enabled of the inline window of the site?
        * @apiSuccess       {String}            SiteViewModel.InlineWindowUploadText                  The text of the upload button of the linline window if it is enabled of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.InlineWindowTypingIndicatorEnabled      Is the typing indicator enabled of the inline window of the site?
        * @apiSuccess       {String}            SiteViewModel.InlineWindowTypingIndicatorText         The text to display when the agent is typing if it is enaabled of the inline window of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowCSSFile                     The name of the inline window css file of the site.
        * @apiSuccess       {String}            SiteViewModel.IntroductionText                        The introduction text of thos site.
        * @apiSuccess       {Number}            SiteViewModel.ChatCloseEvent                          The action that causes the engagement to close of the site.  
        * @apiSuccess       {Number}            SiteViewModel.AutoExitVisitorTime                     The number of seconds that have to elapse beofe a visitor is automatically exited from the engagement of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.AttemptRouteSameAgent                   Should the routing engine attempt to route the engagement to the same agent of the site?
        * @apiSuccess       {Number}            SiteViewModel.RequestPreroutingAction                 The prerouting action of the site, (1: No Logic, 2: Custom Rules, 3: External Provider).
        * @apiSuccess       {Number}            SiteViewModel.RequestRoutingAction                    The routing action of the site, {1: No Logic, 2: Custom Rules, 3: External Provider).
        * @apiSuccess       {String}            SiteViewModel.ExternalPreroutingUrl                   The prerouting url of the site when the prerouting action is set of external provider.
        * @apiSuccess       {String}            SiteViewModel.ExternalRoutingUrl                      The routing url of the site when the routing action is set of external provider.
        * @apiSuccess       {Boolean}           SiteViewModel.EnableInterGroupTransfer                Does the site support transferring engagements inside of groups?
        * @apiSuccess       {Boolean}           SiteViewModel.EnableAllAgentsofTransfer              Are all agents in the site available to receive a transferred engagement, regardless of utilization?
        * @apiSuccess       {String}            SiteViewModel.EngagementApiUrl                        The engagement api url of the site.  All the urls of a site are configurable.
        * @apiSuccess       {String}            SiteViewModel.visitorApiUrl                           The visitor api url of the site.  All the urls of a site are configurable.
        * @apiSuccess       {String}            SiteViewModel.MainApiUrl                              The main api url fot the site. All the urls of a site are configurable.
        * @apiSuccess       {String}            SiteViewModel.RoutingApiUrl                           The routing api url of the site.  All the urls of a site are configurable.
        * @apiSuccess       {String}            SiteViewModel.ReportingApiUrl                         The reporting api url of the site.  All the urls of a site are configurable.
        * @apiSuccess       {String}            SiteViewModel.EngagementSignalRUrl                    The signalR url of the site. All the urls of a site are configurable.
        * @apiSuccess       {String}            SiteViewModel.ContentDeliveryUrl                      The url used to deliver content and scripts of the site.
        * @apiSuccess       {String}            SiteViewModel.StaticFilesUrl                          The url used to deliver static content of the site.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"SiteID":1,
        *          "CompanyURL":"www.mydomain.com", 
        *          "CompanyName":"mycompany",
        *          "CompanyAddress1":"1 East Main Street",
        *          "CompayAddress2":"Suite 102",
        *          "CompanyCountryID":237,
        *          "CompanyPostalCode":"11111",
        *          "Region":"region",
        *          "Language":"en",
        *          "Facebook":"mycompanyFacebook",
        *          "Twitter":"mycompanyTwitter",
        *          "Google":"mycompanyGoogle","LinkedIn":"mycompanyLinkedIn",
        *          "LogoUrl":"www.mydomain.com/logo.jpg",
        *          "CreatedByUserID":1,
        *          "CreatedBy":"Bob",
        *          "CreatedTimeAgo":"a week ago",
        *          "Comments":"signed up online",
        *          "Timezone":"Eastern Standard Time",
        *          "CName":"chat.mydomain.com",
        *          "TwitterScreeName":"twitter.mydomain",
        *          "TwitterAccessTokenSecret:"",
        *          "TwitterAccessToken":"",
        *          "FacebookAppID":"",
        *          "FacebookAppSecret":"",
        *          "ApplicationID":1,
        *          "DateCreate":"1/1/2014 12:00 am",
        *          "GoogleAnalyticsID":"",
        *          "TransferUnansweredChats":true,
        *          "EnablePrechatSurvey":true,
        *          "EmailPrechatSubmissionsTo":"myemail@domain.com",
        *          "PrechatSurveyID":100,
        *          "PrechatSubmitText":"prechat survey text",
        *          "PrechatHeaderText":"welcom visitor",
        *          "DefaultVisitorName":"visitor",
        *          "QueueIncomingRequests":true,
        *          "QueueTimeoutSeconds":300,
        *          "QueueWhenAllAgentsBusy":true,
        *          "HigherTiersGetQueueAlert":true,
        *          "EnablePostchatSurvey":true,
        *          "PostchatSubmitText":"submit survey",
        *          "PostchatSurveyID":101,
        *          "EmailPostchatSubmissionsTo":"myemail@domain.com",
        *          "PostchatHeaderText":"Thank your for completing the survey",
        *          "EnablePostchatAgentSurvey":true,
        *          "PostchatAgentSurveyID":102,
        *          "RoutingAlgorithm":1,
        *          "UnavailableAction":2,
        *          "UnavailableSurveyID":105,
        *          "UnavailableText":"All agents are currently busy!",
        *          "UnavailableRedirectUrl":"www.mydomain.com/redirecturl",
        *          "EmailUnavailableSubmissionsTo":"myemail@domain.com",
        *          "UnavailableSubmitText":"All agents busy survey.",
        *          "UnavailableHeaderText","All agents are busy.",
        *          "InlineWindowPicturePreference":1,
        *          "InlineWindowChatRatingEnabled":true,
        *          "InlineWindowChatRatingText":"rate us",
        *          "InlineWindowPrintEnabled":true,
        *          "InlineWindowPrintText":"print",
        *          "InlineWindowEmailEnabled":true,
        *          "InlineWindowEmailText":"email",
        *          "InlineWindowEndChatText":"end chat",
        *          "InlineWindowOperatorText":"operator",
        *          "InlineWindowVisitorText":"you",
        *          "InlineWindowWelcomeMessage":"Hello, How can I help you today?",
        *          "InlineWindowLineRatingEnabled":true,
        *          "InlineWindowUploadEnabled":true,
        *          "InlineWindowUploadText":"uplaod file",
        *          "InlineWindowTypingIndicatorEnabled":true,
        *          "InlineWindowTypingIndicatorText":"is typing",
        *          "InlineWindowCSSFile":"www.mydomain.com/inlinewindowcssfile.css",
        *          "IntroductionText":"Please send us a message to begin chatting.",
        *          "ChatCloseEvent":1,
        *          "AutoExitVisitorTime":60,
        *          "AttemptRouteSameAgent":true,
        *          "RequestPreroutingAction":1,
        *          "RequestRoutingAction":1,
        *          "ExternalPreroutingURL":"",
        *          "ExternalReoutingURL":"",
        *          "EnableInterGroupTransfer":true,
        *          "EnableAllAgentsFroTransfer":true,
        *          "EngagmentApiURL":"engagement.api.livefluence.com",
        *          "VisitorApiURL": visitor.api.livefluence.com",
        *          "MainApiURL":"main.api.livefluence.com",
        *          "RoutingApiURL":"routing.api.livefluence.com",
        *          "ReportingApiURL":"reporting.api.livefluence.com",
        *          "EngagmentSignalRURL":"signalR.api.livefluence.com",
        *          "ContentDeliverURL":"azure.cdn.content",
        *          "StaticFilesURL":"azure.cdn.staticFiles"
        *          }]
        *     }
        *     
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void GetAll()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/site read
        * @apiName get
        * @apiGroup SETTINGS > /site
        * @apiDescription Read the site for this user.
        * @apiPermission siteAdministrator
        * 
        * @apiExample       {curl}              Example usage:
        *       curl  http:/main.api.livefluence.com/{siteID}/site \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       
        *
        * @apiParam         {Number}            siteID                                                  The site's unique ID.
        *
        * @apiSuccess       {Object}            SiteViewModel                                         the siteviewmodel object
        * @apiSuccess       {Number}            SiteViewModel.SiteID                                  Your site's account number.
        * @apiSuccess       {String}            SiteViewModel.CompanyURL                              The url of the site.
        * @apiSuccess       {String}            SiteViewModel.CompanyName                             The name of the site.
        * @apiSuccess       {String}            SiteViewModel.CompanyAddress1                         The first line of the site's address.
        * @apiSuccess       {String}            SiteViewModel.CompanyAdsress2                         The second line of the site's address.
        * @apiSuccess       {Number}            SiteViewModel.CompanyCountryID                        The id code of the country of the site.
        * @apiSuccess       {String}            SiteViewModel.CompanyPostalCode                       The postal code of the site.
        * @apiSuccess       {String}            SiteViewModel.Region                                  The geographic region of the site.
        * @apiSuccess       {String}            SiteViewModel.Language                                The default language of the site.
        * @apiSuccess       {String}            SiteViewModel.Facebook                                The Facebook link of the site.
        * @apiSuccess       {String}            SiteViewModel.Twitter                                 The Twitter link of the site.
        * @apiSuccess       {String}            SiteViewModel.Google                                  The Google Plus link of the company.
        * @apiSuccess       {String}            SiteViewModel.LinkedIn                                The LinkedIn link of the site.
        * @apiSuccess       {String}            SiteViewModel.LogoUrl                                 The url of the sites's logo.
        * @apiSuccess       {Number}            SiteViewModel.CreatedByUserID                         The user id of the user that created the site.
        * @apiSuccess       {String}            SiteViewModel.CreatedBy                               The username of the user that created the site.
        * @apiSuccess       {String}            SiteViewModel.CreatedTimeAgo                          A user friendly description of when the site was created.  
        * @apiSuccess       {String}            SiteViewModel.Comments                                Comments of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.ShowWizard                              Show the startup wizard be displayed of the site.
        * @apiSuccess       {String}            SiteViewModel.Timezone                                The timezone of the site.
        * @apiSuccess       {String}            SiteViewModel.CName                                   The Cname alias the account utilizes of engagements.  
        * @apiSuccess       {String}            SiteViewModel.TwitterScreenName;                      The Twitter screen name of the site.
        * @apiSuccess       {String}            SiteViewModel.TwitterAccessTokenSecret                The Twitter secret token linked to the site's Twitter account when logging in.
        * @apiSuccess       {String}            SiteViewModel.TwitterAccessToken                      The Twitter access token to the site's Twitter account.
        * @apiSuccess       {String}            SiteViewModel.FacebookAppID                           The app id of the site's Facebook account.
        * @apiSuccess       {String}            SiteViewModel.FacebookAppName                         The app name of the site's Facebook account.
        * @apiSuccess       {String}            SiteViewModel.FacebookAppSecret                       The Facebook secret token linked to the site's account when logging in.                        
        * @apiSuccess       {Number}            SiteViewModel.ApplicationID                           The site's application id.
        * @apiSuccess       {Date}              SiteViewModel.DateCreated                             The date and time the site was created.
        * @apiSuccess       {String}            SiteViewModel.GoogleAnalyticsID                       The Google Analytics id of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.TransferUnansweredChats                 Does the site allow transfer of unaswered engagements?
        * @apiSuccess       {Boolean}           SiteViewModel.EnablePrechatSurvey                     Does the site have a prechat survey of the visitor?
        * @apiSuccess       {String}            SiteViewModel.EmailPrechatSubmissionsTo               The email to send the prechat surveys of the site.
        * @apiSuccess       {String}            SiteViewModel.PrechatSubmitText                       The text of the prechat survey if it is enabled of the site.
        * @apiSuccess       {String}            SiteViewModel.PrechatHeaderText                       The header text of the prechat survey of the site if it is enabled.
        * @apiSuccess       {String}            SiteViewModel.DefaultVisitorName                      The default name to use of a visitor of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.QueueIncomingRequests                   Do incoming engagement request get queued of the site?
        * @apiSuccess       {Number}            SiteViewModel.QueueTimeoutSeconds                     If queueing is used of the site, the is the timeout value of the queue.
        * @apiSuccess       {Boolean}           SiteViewModel.QueueWhenAllAgentsBusy                  If queueing is not used of the site, should a queue be used if all agents are busy?
        * @apiSuccess       {Boolean}           SiteViewModel.HigherTiersGetQueueAlert                If queueing is used to higher tiers get queue alerts of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.EnablePostchatSurvey                    Does the site have a postchat survey of the visitor?
        * @apiSuccess       {String}            SiteViewModel.PostchatSubmitText                      The text of the post chat survey if it enabled of the site.
        * @apiSuccess       {String}            SiteViewModel.EmailPostchatSubmissionsTo              The email address to send postchat surveys to if postchat surveys are enabled of the site. 
        * @apiSuccess       {String}            SiteViewModel.PostchatHeaderText                      The header text of the postchat survey if it is enabled. 
        * @apiSuccess       {Boolean}           SiteViewModel.EnablePostchatAgentSurvey               Does the site have a postchat survey of the agent?
        * @apiSuccess       {Number}            SiteViewModel.RoutingAlgorithm                        Routing algorithm to route engagements of the site (1: No logic, 2: Custom Rules, 3: External Provider).
        * @apiSuccess       {Number}            SiteViewModel.UnavailableAction                       What action to do if there are not agents in the site available of the engagement (1: Offer a survey, 2: Display custom text, 3: Redirect to page, 4: Hide live help).
        * @apiSuccess       {String}            SiteViewModel.UnavailableText                         The unavailable text to display of the unavailable action is set to display custom text.
        * @apiSuccess       {String}            SiteViewModel.UnavailableRedirectUrl                  The url to use as a redirect if the unavailable action is set to redirect to page.
        * @apiSuccess       {String}            SiteViewModel.EmailUnavailableSubmissionsTo           The email address to send unavailable surveys to if the unavailable action is set to offer survey of the site.
        * @apiSuccess       {String}            SiteViewModel.UnavailableRedirectUrl                  The url to use as a redirect if the unavailable action is set to redirect to page of the site.
        * @apiSuccess       {String}            SiteViewModel.UnavailableSubmitText                   The text of the unavailable survey if it is enabled of the site.
        * @apiSuccess       {String}            SiteViewModel.UnavailableHeaderText                   The header text of the unavailable survey if the unavailable action is set of offer survey of the site.
        * @apiSuccess       {Number}            SiteViewModel.InlineWindowPicturePreference           The option to set the inline window picture of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.InlineWindowChatRatingEnabled           Is the engagement rating button enabled of the inline window of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowChatRatingText              The text of the engagement rating button of the Inline window if it is enabled of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.InlineWindowPrintEnabled                Is the print button enabled of the inline window of the site?
        * @apiSuccess       {String}            SiteViewModel.InlineWindowPrintText                   The text of the print button of the inline window if it is enabled of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.InlineWindowEmailEnabled                Is the email button enabled of the inline window of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowEmailText                   The text of the email button of the inline window if it is enabled of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowEndChatText                 The text of the end chat button of the inline window engagemnet of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowOperatorText                The text displayed of the agents' messages of the inline window of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowVisitorText                 The text displayed of the visitors' messages of the inline window of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowWelcomeMessage              The welcome message that is displayed in the inline window of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.InlineWindowLineRatingEnabled           Is the line rating button enabled of the inline window of the site?
        * @apiSuccess       {Boolean}           SiteViewModel.InlineWindowUploadEnabled               Is the upload button enabled of the inline window of the site?
        * @apiSuccess       {String}            SiteViewModel.InlineWindowUploadText                  The text of the upload button of the linline window if it is enabled of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.InlineWindowTypingIndicatorEnabled      Is the typing indicator enabled of the inline window of the site?
        * @apiSuccess       {String}            SiteViewModel.InlineWindowTypingIndicatorText         The text to display when the agent is typing if it is enaabled of the inline window of the site.
        * @apiSuccess       {String}            SiteViewModel.InlineWindowCSSFile                     The name of the inline window css file of the site.
        * @apiSuccess       {String}            SiteViewModel.IntroductionText                        The introduction text of thos site.
        * @apiSuccess       {Number}            SiteViewModel.ChatCloseEvent                          The action that causes the engagement to close of the site.  
        * @apiSuccess       {Number}            SiteViewModel.AutoExitVisitorTime                     The number of seconds that have to elapse beofe a visitor is automatically exited from the engagement of the site.
        * @apiSuccess       {Boolean}           SiteViewModel.AttemptRouteSameAgent                   Should the routing engine attempt to route the engagement to the same agent of the site?
        * @apiSuccess       {Number}            SiteViewModel.RequestPreroutingAction                 The prerouting action of the site, (1: No Logic, 2: Custom Rules, 3: External Provider).
        * @apiSuccess       {Number}            SiteViewModel.RequestRoutingAction                    The routing action of the site, {1: No Logic, 2: Custom Rules, 3: External Provider).
        * @apiSuccess       {String}            SiteViewModel.ExternalPreroutingUrl                   The prerouting url of the site when the prerouting action is set of external provider.
        * @apiSuccess       {String}            SiteViewModel.ExternalRoutingUrl                      The routing url of the site when the routing action is set of external provider.
        * @apiSuccess       {Boolean}           SiteViewModel.EnableInterGroupTransfer                Does the site support transferring engagements inside of groups?
        * @apiSuccess       {Boolean}           SiteViewModel.EnableAllAgentsofTransfer              Are all agents in the site available to receive a transferred engagement, regardless of utilization?
        * @apiSuccess       {String}            SiteViewModel.EngagementApiUrl                        The engagement api url of the site.  All the urls of a site are configurable.
        * @apiSuccess       {String}            SiteViewModel.visitorApiUrl                           The visitor api url of the site.  All the urls of a site are configurable.
        * @apiSuccess       {String}            SiteViewModel.MainApiUrl                              The main api url fot the site. All the urls of a site are configurable.
        * @apiSuccess       {String}            SiteViewModel.RoutingApiUrl                           The routing api url of the site.  All the urls of a site are configurable.
        * @apiSuccess       {String}            SiteViewModel.ReportingApiUrl                         The reporting api url of the site.  All the urls of a site are configurable.
        * @apiSuccess       {String}            SiteViewModel.EngagementSignalRUrl                    The signalR url of the site. All the urls of a site are configurable.
        * @apiSuccess       {String}            SiteViewModel.ContentDeliveryUrl                      The url used to deliver content and scripts of the site.
        * @apiSuccess       {String}            SiteViewModel.StaticFilesUrl                          The url used to deliver static content of the site.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "SiteID":1,
        *          "CompanyURL":"www.mydomain.com", 
        *          "CompanyName":"mycompany",
        *          "CompanyAddress1":"1 East Main Street",
        *          "CompayAddress2":"Suite 102",
        *          "CompanyCountryID":237,
        *          "CompanyPostalCode":"11111",
        *          "Region":"region",
        *          "Language":"en",
        *          "Facebook":"mycompanyFacebook",
        *          "Twitter":"mycompanyTwitter",
        *          "Google":"mycompanyGoogle","LinkedIn":"mycompanyLinkedIn",
        *          "LogoUrl":"www.mydomain.com/logo.jpg",
        *          "CreatedByUserID":1,
        *          "CreatedBy":"Bob",
        *          "CreatedTimeAgo":"a week ago",
        *          "Comments":"signed up online",
        *          "Timezone":"Eastern Standard Time",
        *          "CName":"chat.mydomain.com",
        *          "TwitterScreeName":"twitter.mydomain",
        *          "TwitterAccessTokenSecret:"",
        *          "TwitterAccessToken":"",
        *          "FacebookAppID":"",
        *          "FacebookAppSecret":"",
        *          "ApplicationID":1,
        *          "DateCreate":"1/1/2014 12:00 am",
        *          "GoogleAnalyticsID":"",
        *          "TransferUnansweredChats":true,
        *          "EnablePrechatSurvey":true,
        *          "EmailPrechatSubmissionsTo":"myemail@domain.com",
        *          "PrechatSurveyID":100,
        *          "PrechatSubmitText":"prechat survey text",
        *          "PrechatHeaderText":"welcom visitor",
        *          "DefaultVisitorName":"visitor",
        *          "QueueIncomingRequests":true,
        *          "QueueTimeoutSeconds":300,
        *          "QueueWhenAllAgentsBusy":true,
        *          "HigherTiersGetQueueAlert":true,
        *          "EnablePostchatSurvey":true,
        *          "PostchatSubmitText":"submit survey",
        *          "PostchatSurveyID":101,
        *          "EmailPostchatSubmissionsTo":"myemail@domain.com",
        *          "PostchatHeaderText":"Thank your for completing the survey",
        *          "EnablePostchatAgentSurvey":true,
        *          "PostchatAgentSurveyID":102,
        *          "RoutingAlgorithm":1,
        *          "UnavailableAction":2,
        *          "UnavailableSurveyID":105,
        *          "UnavailableText":"All agents are currently busy!",
        *          "UnavailableRedirectUrl":"www.mydomain.com/redirecturl",
        *          "EmailUnavailableSubmissionsTo":"myemail@domain.com",
        *          "UnavailableSubmitText":"All agents busy survey.",
        *          "UnavailableHeaderText","All agents are busy.",
        *          "InlineWindowPicturePreference":1,
        *          "InlineWindowChatRatingEnabled":true,
        *          "InlineWindowChatRatingText":"rate us",
        *          "InlineWindowPrintEnabled":true,
        *          "InlineWindowPrintText":"print",
        *          "InlineWindowEmailEnabled":true,
        *          "InlineWindowEmailText":"email",
        *          "InlineWindowEndChatText":"end chat",
        *          "InlineWindowOperatorText":"operator",
        *          "InlineWindowVisitorText":"you",
        *          "InlineWindowWelcomeMessage":"Hello, How can I help you today?",
        *          "InlineWindowLineRatingEnabled":true,
        *          "InlineWindowUploadEnabled":true,
        *          "InlineWindowUploadText":"uplaod file",
        *          "InlineWindowTypingIndicatorEnabled":true,
        *          "InlineWindowTypingIndicatorText":"is typing",
        *          "InlineWindowCSSFile":"www.mydomain.com/inlinewindowcssfile.css",
        *          "IntroductionText":"Please send us a message to begin chatting.",
        *          "ChatCloseEvent":1,
        *          "AutoExitVisitorTime":60,
        *          "AttemptRouteSameAgent":true,
        *          "RequestPreroutingAction":1,
        *          "RequestRoutingAction":1,
        *          "ExternalPreroutingURL":"",
        *          "ExternalReoutingURL":"",
        *          "EnableInterGroupTransfer":true,
        *          "EnableAllAgentsFroTransfer":true,
        *          "EngagmentApiURL":"engagement.api.livefluence.com",
        *          "VisitorApiURL": visitor.api.livefluence.com",
        *          "MainApiURL":"main.api.livefluence.com",
        *          "RoutingApiURL":"routing.api.livefluence.com",
        *          "ReportingApiURL":"reporting.api.livefluence.com",
        *          "EngagmentSignalRURL":"signalR.api.livefluence.com",
        *          "ContentDeliverURL":"azure.cdn.content",
        *          "StaticFilesURL":"azure.cdn.staticFiles"
        *     }
        *     
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void Get()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/site create
        * @apiName post
        * @apiGroup SETTINGS > /site
        * @apiDescription Create a new site.
        * @apiPermission super
        * 
        * @apiExample       {curl}              Example usage:
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/site  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"companyURL": "www.mydomain.com", "companyName": "mycompany", "companyAddress1": "1 East Main Street", "compayAddress2": "Suite 102", "CompanyCountryID": 237, "companyPostalCode": "11111", "region": "region", "language": "en", "facebook": "mycompanyFacebook", "twitter": "mycompanyTwitter", "google": "mycompanyGoogle", "linkedIn": "mycompanyLinkedIn", "loglURL": "www.mydomain.com/logo.jpg", "createdByUserID": 1, "createdBy": "Bob", "createdTimeAgo": "a week ago", "comments": "signed up online", "timezone": "Eastern Standard Time", "cname": "chat.mydomain.com", "twitterScreeName": "twitter.mydomain", "twotterAccessTokenSecret: "", "twitterAccessToken": "", facebookAppID": "", "facebookAppSecret": "", "applicationID": 1, "dateCreate": "1/1/2014 12:00 am", "googleAnalyticsID": "", "transferUnansweredChats": true, "enablePrechatSurvey": true, "emailPrechatSubmissionsTo": "myemail@domain.com", "prechatSurveyID": 100, "prechatSubmitText": "prechat survey text", "prechatHeaderText": "welcom visitor", "defaultVisitorName": "visitor", "queueIncomingRequests": true, "queueTimeoutSeconds": 300, "queueWhenAllAgentsBusy": true, "higherTiersGetQueueAlert": true, "enablePostchatSurvey": true, "postchatSubmitText": "submit survey", "postchatSurveyID": 101, "emailPostchatSubmissionsTo": "myemail@domain.com", "postchatHeaderText": "Thank your for completing the survey", "enablePostchatAgentSurvey": true, "postchatAgentSurveyID": 102, "routingAlgorithm": 1, "unavailableAction": 2, "unavailableSurveyID": 105, "unavailableText": "All agents are currently busy!", "unavailableRedirectUrl": "www.mydomain.com/redirecturl", "emailUnavailableSubmissionsTo", "myemail@domain.com", "unavailableSubmitText", "All agents busy survey.", "unavailableHeaderText", "All agents are busy.", "inlineWindowPicturePreference": 1, "inlineWindowChatRatingEnabled": true, "inlineWindowChatRatingText": "rate us", "inlineWindowPrintEnabled": true, "inlineWindowPrintText": "print", "inlineWindowEmailEnabled": true, "inlineWindowEmailText": "email", "inlineWindowEndChatText": "end chat", "inlineWindowOperatorText": "operator", "inlineWindowVisitorText", "you", "inlineWindowWelcomeMessage": "Hello, How can I help you today?", "inlineWindowLineRatingEnabled": true, "inlineWindowUploadEnabled": true, "inlineWindowUploadText": "uplaod file", "inlineWindowTypingIndicatorEnabled": true, "inlineWindowTypingIndicatorText", "is typing", "inlineWindowCSSFile": "www.mydomain.com/inlinewindowcssfile.css", "introductionText": "Please send us a message to begin chatting.", "chatCloseEvent": 1, "autoExitVisitorTime": 60, "attemptRouteSameAgent": true, "requestPreroutingAction": 1, "requestRoutingAction": 1, "externalPreroutingURL": "", "externalReoutingURL": "", "enableInterGroupTransfer": true, "enableAllAgentsFroTransfer": true, "engagmentApiURL": "engagement.api.livefluence.com", "visitorApiURL": "visitor.api.livefluence.com", "mainApiURL": "main.api.livefluence.com", "routingApiURL": "routing.api.livefluence.com", "reportingApiURL": "reporting.api.livefluence.com", "engagmentSignalRURL": "signalR.api.livefluence.com", "contentDeliverURL": "azure.cdn.content", "staticFilesURL": "azure.cdn.staticFiles"}" 
        *   
        * @apiParam         {Number}            siteID                                                Your site's account number.  
        * @apiParam         {Object}            SiteViewModel                                         the siteviewmodel object
        * @apiParam         {String}            SiteViewModel.CompanyURL                              The url of the site.
        * @apiParam         {String}            SiteViewModel.CompanyName                             The name of the site.
        * @apiParam         {String}            SiteViewModel.CompanyAddress1                         The first line of the site's address.
        * @apiParam         {String}            SiteViewModel.CompanyAdsress2                         The second line of the site's address.
        * @apiParam         {Number}            SiteViewModel.CompanyCountryID                        The id code of the country of the site.
        * @apiParam         {String}            SiteViewModel.CompanyPostalCode                       The postal code of the site.
        * @apiParam         {String}            SiteViewModel.Region                                  The geographic region of the site.
        * @apiParam         {String}            SiteViewModel.Language                                The default language of the site.
        * @apiParam         {String}            SiteViewModel.Facebook                                The Facebook link of the site.
        * @apiParam         {String}            SiteViewModel.Twitter                                 The Twitter link of the site.
        * @apiParam         {String}            SiteViewModel.Google                                  The Google Plus link of the company.
        * @apiParam         {String}            SiteViewModel.LinkedIn                                The LinkedIn link of the site.
        * @apiParam         {String}            SiteViewModel.LogoUrl                                 The url of the sites's logo.
        * @apiParam         {Number}            SiteViewModel.CreatedByUserID                         The user id of the user that created the site.
        * @apiParam         {String}            SiteViewModel.CreatedBy                               The username of the user that created the site.
        * @apiParam         {String}            SiteViewModel.CreatedTimeAgo                          A user friendly description of when the site was created.  
        * @apiParam         {String}            SiteViewModel.Comments                                Comments of the site.
        * @apiParam         {Boolean}           SiteViewModel.ShowWizard                              Show the startup wizard be displayed of the site.
        * @apiParam         {String}            SiteViewModel.Timezone                                The timezone of the site.
        * @apiParam         {String}            SiteViewModel.CName                                   The Cname alias the account utilizes of engagements.  
        * @apiParam         {String}            SiteViewModel.TwitterScreenName;                      The Twitter screen name of the site.
        * @apiParam         {String}            SiteViewModel.TwitterAccessTokenSecret                The Twitter secret token linked to the site's Twitter account when logging in.
        * @apiParam         {String}            SiteViewModel.TwitterAccessToken                      The Twitter access token to the site's Twitter account.
        * @apiParam         {String}            SiteViewModel.FacebookAppID                           The app id of the site's Facebook account.
        * @apiParam         {String}            SiteViewModel.FacebookAppName                         The app name of the site's Facebook account.
        * @apiParam         {String}            SiteViewModel.FacebookAppSecret                       The Facebook secret token linked to the site's account when logging in.                        
        * @apiParam         {Number}            SiteViewModel.ApplicationID                           The site's application id.
        * @apiParam         {Date}              SiteViewModel.DateCreated                             The date and time the site was created.
        * @apiParam         {String}            SiteViewModel.GoogleAnalyticsID                       The Google Analytics id of the site.
        * @apiParam         {Boolean}           SiteViewModel.TransferUnansweredChats                 Does the site allow transfer of unaswered engagements?
        * @apiParam         {Boolean}           SiteViewModel.EnablePrechatSurvey                     Does the site have a prechat survey of the visitor?
        * @apiParam         {String}            SiteViewModel.EmailPrechatSubmissionsTo               The email to send the prechat surveys of the site.
        * @apiParam         {String}            SiteViewModel.PrechatSubmitText                       The text of the prechat survey if it is enabled of the site.
        * @apiParam         {String}            SiteViewModel.PrechatHeaderText                       The header text of the prechat survey of the site if it is enabled.
        * @apiParam         {String}            SiteViewModel.DefaultVisitorName                      The default name to use of a visitor of the site.
        * @apiParam         {Boolean}           SiteViewModel.QueueIncomingRequests                   Do incoming engagement request get queued of the site?
        * @apiParam         {Number}            SiteViewModel.QueueTimeoutSeconds                     If queueing is used of the site, the is the timeout value of the queue.
        * @apiParam         {Boolean}           SiteViewModel.QueueWhenAllAgentsBusy                  If queueing is not used of the site, should a queue be used if all agents are busy?
        * @apiParam         {Boolean}           SiteViewModel.HigherTiersGetQueueAlert                If queueing is used to higher tiers get queue alerts of the site.
        * @apiParam         {Boolean}           SiteViewModel.EnablePostchatSurvey                    Does the site have a postchat survey of the visitor?
        * @apiParam         {String}            SiteViewModel.PostchatSubmitText                      The text of the post chat survey if it enabled of the site.
        * @apiParam         {String}            SiteViewModel.EmailPostchatSubmissionsTo              The email address to send postchat surveys to if postchat surveys are enabled of the site. 
        * @apiParam         {String}            SiteViewModel.PostchatHeaderText                      The header text of the postchat survey if it is enabled. 
        * @apiParam         {Boolean}           SiteViewModel.EnablePostchatAgentSurvey               Does the site have a postchat survey of the agent?
        * @apiParam         {Number}            SiteViewModel.RoutingAlgorithm                        Routing algorithm to route engagements of the site (1: No logic, 2: Custom Rules, 3: External Provider).
        * @apiParam         {Number}            SiteViewModel.UnavailableAction                       What action to do if there are not agents in the site available of the engagement (1: Offer a survey, 2: Display custom text, 3: Redirect to page, 4: Hide live help).
        * @apiParam         {String}            SiteViewModel.UnavailableText                         The unavailable text to display of the unavailable action is set to display custom text.
        * @apiParam         {String}            SiteViewModel.UnavailableRedirectUrl                  The url to use as a redirect if the unavailable action is set to redirect to page.
        * @apiParam         {String}            SiteViewModel.EmailUnavailableSubmissionsTo           The email address to send unavailable surveys to if the unavailable action is set to offer survey of the site.
        * @apiParam         {String}            SiteViewModel.UnavailableRedirectUrl                  The url to use as a redirect if the unavailable action is set to redirect to page of the site.
        * @apiParam         {String}            SiteViewModel.UnavailableSubmitText                   The text of the unavailable survey if it is enabled of the site.
        * @apiParam         {String}            SiteViewModel.UnavailableHeaderText                   The header text of the unavailable survey if the unavailable action is set of offer survey of the site.
        * @apiParam         {Number}            SiteViewModel.InlineWindowPicturePreference           The option to set the inline window picture of the site.
        * @apiParam         {Boolean}           SiteViewModel.InlineWindowChatRatingEnabled           Is the engagement rating button enabled of the inline window of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowChatRatingText              The text of the engagement rating button of the Inline window if it is enabled of the site.
        * @apiParam         {Boolean}           SiteViewModel.InlineWindowPrintEnabled                Is the print button enabled of the inline window of the site?
        * @apiParam         {String}            SiteViewModel.InlineWindowPrintText                   The text of the print button of the inline window if it is enabled of the site.
        * @apiParam         {Boolean}           SiteViewModel.InlineWindowEmailEnabled                Is the email button enabled of the inline window of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowEmailText                   The text of the email button of the inline window if it is enabled of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowEndChatText                 The text of the end chat button of the inline window engagemnet of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowOperatorText                The text displayed of the agents' messages of the inline window of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowVisitorText                 The text displayed of the visitors' messages of the inline window of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowWelcomeMessage              The welcome message that is displayed in the inline window of the site.
        * @apiParam         {Boolean}           SiteViewModel.InlineWindowLineRatingEnabled           Is the line rating button enabled of the inline window of the site?
        * @apiParam         {Boolean}           SiteViewModel.InlineWindowUploadEnabled               Is the upload button enabled of the inline window of the site?
        * @apiParam         {String}            SiteViewModel.InlineWindowUploadText                  The text of the upload button of the linline window if it is enabled of the site.
        * @apiParam         {Boolean}           SiteViewModel.InlineWindowTypingIndicatorEnabled      Is the typing indicator enabled of the inline window of the site?
        * @apiParam         {String}            SiteViewModel.InlineWindowTypingIndicatorText         The text to display when the agent is typing if it is enaabled of the inline window of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowCSSFile                     The name of the inline window css file of the site.
        * @apiParam         {String}            SiteViewModel.IntroductionText                        The introduction text of thos site.
        * @apiParam         {Number}            SiteViewModel.ChatCloseEvent                          The action that causes the engagement to close of the site.  
        * @apiParam         {Number}            SiteViewModel.AutoExitVisitorTime                     The number of seconds that have to elapse beofe a visitor is automatically exited from the engagement of the site.
        * @apiParam         {Boolean}           SiteViewModel.AttemptRouteSameAgent                   Should the routing engine attempt to route the engagement to the same agent of the site?
        * @apiParam         {Number}            SiteViewModel.RequestPreroutingAction                 The prerouting action of the site, (1: No Logic, 2: Custom Rules, 3: External Provider).
        * @apiParam         {Number}            SiteViewModel.RequestRoutingAction                    The routing action of the site, {1: No Logic, 2: Custom Rules, 3: External Provider).
        * @apiParam         {String}            SiteViewModel.ExternalPreroutingUrl                   The prerouting url of the site when the prerouting action is set of external provider.
        * @apiParam         {String}            SiteViewModel.ExternalRoutingUrl                      The routing url of the site when the routing action is set of external provider.
        * @apiParam         {Boolean}           SiteViewModel.EnableInterGroupTransfer                Does the site support transferring engagements inside of groups?
        * @apiParam         {Boolean}           SiteViewModel.EnableAllAgentsofTransfer              Are all agents in the site available to receive a transferred engagement, regardless of utilization?
        * @apiParam         {String}            SiteViewModel.EngagementApiUrl                        The engagement api url of the site.  All the urls of a site are configurable.
        * @apiParam         {String}            SiteViewModel.visitorApiUrl                           The visitor api url of the site.  All the urls of a site are configurable.
        * @apiParam         {String}            SiteViewModel.MainApiUrl                              The main api url fot the site. All the urls of a site are configurable.
        * @apiParam         {String}            SiteViewModel.RoutingApiUrl                           The routing api url of the site.  All the urls of a site are configurable.
        * @apiParam         {String}            SiteViewModel.ReportingApiUrl                         The reporting api url of the site.  All the urls of a site are configurable.
        * @apiParam         {String}            SiteViewModel.EngagementSignalRUrl                    The signalR url of the site. All the urls of a site are configurable.
        * @apiParam         {String}            SiteViewModel.ContentDeliveryUrl                      The url used to deliver content and scripts of the site.
        * @apiParam         {String}            SiteViewModel.StaticFilesUrl                          The url used to deliver static content of the site.
        *
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void Post(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/site update
        * @apiName Put
        * @apiGroup SETTINGS > /site
        * @apiDescription Update this site.
        * @apiPermission super
        * 
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/site  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"siteID": 1, "companyURL": "www.mydomain.com", "companyName": "mycompany", "companyAddress1": "1 East Main Street", "compayAddress2": "Suite 102", "CompanyCountryID": 237, "companyPostalCode": "11111", "region": "region", "language": "en", "facebook": "mycompanyFacebook", "twitter": "mycompanyTwitter", "google": "mycompanyGoogle", "linkedIn": "mycompanyLinkedIn", "loglURL": "www.mydomain.com/logo.jpg", "createdByUserID": 1, "createdBy": "Bob", "createdTimeAgo": "a week ago", "comments": "signed up online", "timezone": "Eastern Standard Time", "cname": "chat.mydomain.com", "twitterScreeName": "twitter.mydomain", "twotterAccessTokenSecret: "", "twitterAccessToken": "", facebookAppID": "", "facebookAppSecret": "", "applicationID": 1, "dateCreate": "1/1/2014 12:00 am", "googleAnalyticsID": "", "transferUnansweredChats": true, "enablePrechatSurvey": true, "emailPrechatSubmissionsTo": "myemail@domain.com", "prechatSurveyID": 100, "prechatSubmitText": "prechat survey text", "prechatHeaderText": "welcom visitor", "defaultVisitorName": "visitor", "queueIncomingRequests": true, "queueTimeoutSeconds": 300, "queueWhenAllAgentsBusy": true, "higherTiersGetQueueAlert": true, "enablePostchatSurvey": true, "postchatSubmitText": "submit survey", "postchatSurveyID": 101, "emailPostchatSubmissionsTo": "myemail@domain.com", "postchatHeaderText": "Thank your for completing the survey", "enablePostchatAgentSurvey": true, "postchatAgentSurveyID": 102, "routingAlgorithm": 1, "unavailableAction": 2, "unavailableSurveyID": 105, "unavailableText": "All agents are currently busy!", "unavailableRedirectUrl": "www.mydomain.com/redirecturl", "emailUnavailableSubmissionsTo", "myemail@domain.com", "unavailableSubmitText", "All agents busy survey.", "unavailableHeaderText", "All agents are busy.", "inlineWindowPicturePreference": 1, "inlineWindowChatRatingEnabled": true, "inlineWindowChatRatingText": "rate us", "inlineWindowPrintEnabled": true, "inlineWindowPrintText": "print", "inlineWindowEmailEnabled": true, "inlineWindowEmailText": "email", "inlineWindowEndChatText": "end chat", "inlineWindowOperatorText": "operator", "inlineWindowVisitorText", "you", "inlineWindowWelcomeMessage": "Hello, How can I help you today?", "inlineWindowLineRatingEnabled": true, "inlineWindowUploadEnabled": true, "inlineWindowUploadText": "uplaod file", "inlineWindowTypingIndicatorEnabled": true, "inlineWindowTypingIndicatorText", "is typing", "inlineWindowCSSFile": "www.mydomain.com/inlinewindowcssfile.css", "introductionText": "Please send us a message to begin chatting.", "chatCloseEvent": 1, "autoExitVisitorTime": 60, "attemptRouteSameAgent": true, "requestPreroutingAction": 1, "requestRoutingAction": 1, "externalPreroutingURL": "", "externalReoutingURL": "", "enableInterGroupTransfer": true, "enableAllAgentsFroTransfer": true, "engagmentApiURL": "engagement.api.livefluence.com", "visitorApiURL": "visitor.api.livefluence.com", "mainApiURL": "main.api.livefluence.com", "routingApiURL": "routing.api.livefluence.com", "reportingApiURL": "reporting.api.livefluence.com", "engagmentSignalRURL": "signalR.api.livefluence.com", "contentDeliverURL": "azure.cdn.content", "staticFilesURL": "azure.cdn.staticFiles"}" 
        *
        * @apiParam         {Number}            siteID                                                Your site's account number.  
        * @apiParam         {Object}            SiteViewModel                                         the siteviewmodel object
        * @apiParam         {Number}            SiteViewModel.SiteID                                  Your sites' account number.
        * @apiParam         {String}            SiteViewModel.CompanyURL                              The url of the site.
        * @apiParam         {String}            SiteViewModel.CompanyName                             The name of the site.
        * @apiParam         {String}            SiteViewModel.CompanyAddress1                         The first line of the site's address.
        * @apiParam         {String}            SiteViewModel.CompanyAdsress2                         The second line of the site's address.
        * @apiParam         {Number}            SiteViewModel.CompanyCountryID                        The id code of the country of the site.
        * @apiParam         {String}            SiteViewModel.CompanyPostalCode                       The postal code of the site.
        * @apiParam         {String}            SiteViewModel.Region                                  The geographic region of the site.
        * @apiParam         {String}            SiteViewModel.Language                                The default language of the site.
        * @apiParam         {String}            SiteViewModel.Facebook                                The Facebook link of the site.
        * @apiParam         {String}            SiteViewModel.Twitter                                 The Twitter link of the site.
        * @apiParam         {String}            SiteViewModel.Google                                  The Google Plus link of the company.
        * @apiParam         {String}            SiteViewModel.LinkedIn                                The LinkedIn link of the site.
        * @apiParam         {String}            SiteViewModel.LogoUrl                                 The url of the sites's logo.
        * @apiParam         {Number}            SiteViewModel.CreatedByUserID                         The user id of the user that created the site.
        * @apiParam         {String}            SiteViewModel.CreatedBy                               The username of the user that created the site.
        * @apiParam         {String}            SiteViewModel.CreatedTimeAgo                          A user friendly description of when the site was created.  
        * @apiParam         {String}            SiteViewModel.Comments                                Comments of the site.
        * @apiParam         {Boolean}           SiteViewModel.ShowWizard                              Show the startup wizard be displayed of the site.
        * @apiParam         {String}            SiteViewModel.Timezone                                The timezone of the site.
        * @apiParam         {String}            SiteViewModel.CName                                   The Cname alias the account utilizes of engagements.  
        * @apiParam         {String}            SiteViewModel.TwitterScreenName;                      The Twitter screen name of the site.
        * @apiParam         {String}            SiteViewModel.TwitterAccessTokenSecret                The Twitter secret token linked to the site's Twitter account when logging in.
        * @apiParam         {String}            SiteViewModel.TwitterAccessToken                      The Twitter access token to the site's Twitter account.
        * @apiParam         {String}            SiteViewModel.FacebookAppID                           The app id of the site's Facebook account.
        * @apiParam         {String}            SiteViewModel.FacebookAppName                         The app name of the site's Facebook account.
        * @apiParam         {String}            SiteViewModel.FacebookAppSecret                       The Facebook secret token linked to the site's account when logging in.                        
        * @apiParam         {Number}            SiteViewModel.ApplicationID                           The site's application id.
        * @apiParam         {Date}              SiteViewModel.DateCreated                             The date and time the site was created.
        * @apiParam         {String}            SiteViewModel.GoogleAnalyticsID                       The Google Analytics id of the site.
        * @apiParam         {Boolean}           SiteViewModel.TransferUnansweredChats                 Does the site allow transfer of unaswered engagements?
        * @apiParam         {Boolean}           SiteViewModel.EnablePrechatSurvey                     Does the site have a prechat survey of the visitor?
        * @apiParam         {String}            SiteViewModel.EmailPrechatSubmissionsTo               The email to send the prechat surveys of the site.
        * @apiParam         {String}            SiteViewModel.PrechatSubmitText                       The text of the prechat survey if it is enabled of the site.
        * @apiParam         {String}            SiteViewModel.PrechatHeaderText                       The header text of the prechat survey of the site if it is enabled.
        * @apiParam         {String}            SiteViewModel.DefaultVisitorName                      The default name to use of a visitor of the site.
        * @apiParam         {Boolean}           SiteViewModel.QueueIncomingRequests                   Do incoming engagement request get queued of the site?
        * @apiParam         {Number}            SiteViewModel.QueueTimeoutSeconds                     If queueing is used of the site, the is the timeout value of the queue.
        * @apiParam         {Boolean}           SiteViewModel.QueueWhenAllAgentsBusy                  If queueing is not used of the site, should a queue be used if all agents are busy?
        * @apiParam         {Boolean}           SiteViewModel.HigherTiersGetQueueAlert                If queueing is used to higher tiers get queue alerts of the site.
        * @apiParam         {Boolean}           SiteViewModel.EnablePostchatSurvey                    Does the site have a postchat survey of the visitor?
        * @apiParam         {String}            SiteViewModel.PostchatSubmitText                      The text of the post chat survey if it enabled of the site.
        * @apiParam         {String}            SiteViewModel.EmailPostchatSubmissionsTo              The email address to send postchat surveys to if postchat surveys are enabled of the site. 
        * @apiParam         {String}            SiteViewModel.PostchatHeaderText                      The header text of the postchat survey if it is enabled. 
        * @apiParam         {Boolean}           SiteViewModel.EnablePostchatAgentSurvey               Does the site have a postchat survey of the agent?
        * @apiParam         {Number}            SiteViewModel.RoutingAlgorithm                        Routing algorithm to route engagements of the site (1: No logic, 2: Custom Rules, 3: External Provider).
        * @apiParam         {Number}            SiteViewModel.UnavailableAction                       What action to do if there are not agents in the site available of the engagement (1: Offer a survey, 2: Display custom text, 3: Redirect to page, 4: Hide live help).
        * @apiParam         {String}            SiteViewModel.UnavailableText                         The unavailable text to display of the unavailable action is set to display custom text.
        * @apiParam         {String}            SiteViewModel.UnavailableRedirectUrl                  The url to use as a redirect if the unavailable action is set to redirect to page.
        * @apiParam         {String}            SiteViewModel.EmailUnavailableSubmissionsTo           The email address to send unavailable surveys to if the unavailable action is set to offer survey of the site.
        * @apiParam         {String}            SiteViewModel.UnavailableRedirectUrl                  The url to use as a redirect if the unavailable action is set to redirect to page of the site.
        * @apiParam         {String}            SiteViewModel.UnavailableSubmitText                   The text of the unavailable survey if it is enabled of the site.
        * @apiParam         {String}            SiteViewModel.UnavailableHeaderText                   The header text of the unavailable survey if the unavailable action is set of offer survey of the site.
        * @apiParam         {Number}            SiteViewModel.InlineWindowPicturePreference           The option to set the inline window picture of the site.
        * @apiParam         {Boolean}           SiteViewModel.InlineWindowChatRatingEnabled           Is the engagement rating button enabled of the inline window of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowChatRatingText              The text of the engagement rating button of the Inline window if it is enabled of the site.
        * @apiParam         {Boolean}           SiteViewModel.InlineWindowPrintEnabled                Is the print button enabled of the inline window of the site?
        * @apiParam         {String}            SiteViewModel.InlineWindowPrintText                   The text of the print button of the inline window if it is enabled of the site.
        * @apiParam         {Boolean}           SiteViewModel.InlineWindowEmailEnabled                Is the email button enabled of the inline window of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowEmailText                   The text of the email button of the inline window if it is enabled of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowEndChatText                 The text of the end chat button of the inline window engagemnet of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowOperatorText                The text displayed of the agents' messages of the inline window of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowVisitorText                 The text displayed of the visitors' messages of the inline window of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowWelcomeMessage              The welcome message that is displayed in the inline window of the site.
        * @apiParam         {Boolean}           SiteViewModel.InlineWindowLineRatingEnabled           Is the line rating button enabled of the inline window of the site?
        * @apiParam         {Boolean}           SiteViewModel.InlineWindowUploadEnabled               Is the upload button enabled of the inline window of the site?
        * @apiParam         {String}            SiteViewModel.InlineWindowUploadText                  The text of the upload button of the linline window if it is enabled of the site.
        * @apiParam         {Boolean}           SiteViewModel.InlineWindowTypingIndicatorEnabled      Is the typing indicator enabled of the inline window of the site?
        * @apiParam         {String}            SiteViewModel.InlineWindowTypingIndicatorText         The text to display when the agent is typing if it is enaabled of the inline window of the site.
        * @apiParam         {String}            SiteViewModel.InlineWindowCSSFile                     The name of the inline window css file of the site.
        * @apiParam         {String}            SiteViewModel.IntroductionText                        The introduction text of thos site.
        * @apiParam         {Number}            SiteViewModel.ChatCloseEvent                          The action that causes the engagement to close of the site.  
        * @apiParam         {Number}            SiteViewModel.AutoExitVisitorTime                     The number of seconds that have to elapse beofe a visitor is automatically exited from the engagement of the site.
        * @apiParam         {Boolean}           SiteViewModel.AttemptRouteSameAgent                   Should the routing engine attempt to route the engagement to the same agent of the site?
        * @apiParam         {Number}            SiteViewModel.RequestPreroutingAction                 The prerouting action of the site, (1: No Logic, 2: Custom Rules, 3: External Provider).
        * @apiParam         {Number}            SiteViewModel.RequestRoutingAction                    The routing action of the site, {1: No Logic, 2: Custom Rules, 3: External Provider).
        * @apiParam         {String}            SiteViewModel.ExternalPreroutingUrl                   The prerouting url of the site when the prerouting action is set of external provider.
        * @apiParam         {String}            SiteViewModel.ExternalRoutingUrl                      The routing url of the site when the routing action is set of external provider.
        * @apiParam         {Boolean}           SiteViewModel.EnableInterGroupTransfer                Does the site support transferring engagements inside of groups?
        * @apiParam         {Boolean}           SiteViewModel.EnableAllAgentsofTransfer              Are all agents in the site available to receive a transferred engagement, regardless of utilization?
        * @apiParam         {String}            SiteViewModel.EngagementApiUrl                        The engagement api url of the site.  All the urls of a site are configurable.
        * @apiParam         {String}            SiteViewModel.visitorApiUrl                           The visitor api url of the site.  All the urls of a site are configurable.
        * @apiParam         {String}            SiteViewModel.MainApiUrl                              The main api url fot the site. All the urls of a site are configurable.
        * @apiParam         {String}            SiteViewModel.RoutingApiUrl                           The routing api url of the site.  All the urls of a site are configurable.
        * @apiParam         {String}            SiteViewModel.ReportingApiUrl                         The reporting api url of the site.  All the urls of a site are configurable.
        * @apiParam         {String}            SiteViewModel.EngagementSignalRUrl                    The signalR url of the site. All the urls of a site are configurable.
        * @apiParam         {String}            SiteViewModel.ContentDeliveryUrl                      The url used to deliver content and scripts of the site.
        * @apiParam         {String}            SiteViewModel.StaticFilesUrl                          The url used to deliver static content of the site.
        *
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void Put(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/site/logo create logo
        * @apiName postlogo
        * @apiGroup SETTINGS > /site
        * @apiDescription Create a logo for this site.
        * @apiPermission super
        * 
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/site/logo  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d {formData}   
        *
        * @apiParam         {Number}            siteID                                                  Your site's account number.
        * @apiParam         {String}            logo                                                    The logo for the site.
        *
        *
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void Logo()
        {
        }

        #region invitation requests
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/site/getnewuserrequest/:id get new user reqeuest
        * @apiName getnewuserrequest:id
        * @apiGroup SETTINGS > /site
        * @apiDescription Read the new user request for this unique id.
        * @apiPermission anonymous
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/site/getnewuserrequest/:id  \
        *       -H "Authorization: Basic {authorizationToken}"
        *
        * @apiParam         {Number}            siteID                                                  Your site's account number.
        * @apiParam         {String}            id                                                      The id of the new user request.
        *
        * @apiSuccess       {Object}            NewUserRequestViewModel                                 the newuserrequestviewmodel object
        * @apiSuccess       {Date}              NewUserRequestViewModel.DateCreated                     The date and time the new user request was created.
        * @apiSuccess       {String}            NewUserRequestViewModel.EmailAddress                    The email address of the new user.
        * @apiSuccess       {Number}            NewUserRequestViewModel.Group                           The id of the group the user is being asked to join.
        * @apiSuccess       {String}            NewUserRequestViewModel.InviteID                        The invitation id that was created for the new user.
        * @apiSuccess       {Boolean}           NewUserRequestViewModel.IsAdmin                         Is the new user an admin?
        * @apiSuccess       {Boolean}           NewUserRequestViewModel.IsAgent                         Is the new user and agent?
        * @apiSuccess       {Boolean}           NewUserRequestViewModel.IsManager                       Is the new user a manager?
        * @apiSuccess       {String}            NewUserRequestViewModel.RoleSelected                    The role the new user is being invited to join.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "DateCreated":"1/1/2014 12:00 am",
        *          "EmailAddress":"email@mydomain.com",
        *          "Group":1,
        *          "InviteID":"guid",
        *          "IsAdmin":false,
        *          "IsAgent":true,
        *          "IsManager":false",
        *          "RoleSelected": "agent"
        *     }
        * 
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void GetNewUserRequest(string id)
        {
        }

        //Get all NewUserRequest for site
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/site/getnewuserrequests read all new user requests
        * @apiName getnewuserrequests
        * @apiGroup SETTINGS > /site
        * @apiDescription Read the new user requests for this site.
        * @apiPermission siteManager
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/site/getnewuserrequests  \
        *       -H "Authorization: Basic {authorizationToken}"
        *
        * @apiParam         {Number}            siteID                                                  The site's unique ID.
        *
        * @apiSuccess       {Object[]}            NewUserRequestViewModel                                 the newuserrequestviewmodel object
        * @apiSuccess       {Date}              NewUserRequestViewModel.DateCreated                     The date and time the new user request was created.
        * @apiSuccess       {String}            NewUserRequestViewModel.EmailAddress                    The email address of the new user.
        * @apiSuccess       {Number}            NewUserRequestViewModel.Group                           The id of the group the user is being asked to join.
        * @apiSuccess       {String}            NewUserRequestViewModel.InviteID                        The invitation id that was created for the new user.
        * @apiSuccess       {Boolean}           NewUserRequestViewModel.IsAdmin                         Is the new user an admin?
        * @apiSuccess       {Boolean}           NewUserRequestViewModel.IsAgent                         Is the new user and agent?
        * @apiSuccess       {Boolean}           NewUserRequestViewModel.IsManager                       Is the new user a manager?
        * @apiSuccess       {String}            NewUserRequestViewModel.RoleSelected                    The role the new user is being invited to join.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"DateCreated":"1/1/2014 12:00 am",
        *          "EmailAddress":"email@mydomain.com",
        *          "Group":1,
        *          "InviteID":"guid",
        *          "IsAdmin":false,
        *          "IsAgent":true,
        *          "IsManager":false",
        *          "RoleSelected": "agent"
        *          }] 
        *     }
        *
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void GetNewUserRequests()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/site/createnewuserrequests create new user requests
        * @apiName postnewuserrequests
        * @apiGroup SETTINGS > /site
        * @apiDescription Create new user requests for this site.
        * @apiPermission siteAdministrator
        * 
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/site/createnewuserrequests  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{[{"DateCreated":"1/1/2014 12:00 am","EmailAddress":"email@mydomain.com","Group":1,"InviteID":"guid","IsAdmin":false,"IsAgent":true,"IsManager":false","RoleSelected":"agent"}]}"   
        *       
        * @apiParam         {Number}            siteID                                                  The site's unique ID.
        * @apiParam         {Object[]}          NewUserRequestViewModel                                 the newuserrequestviewmodel object
        * @apiParam         {Date}              NewUserRequestViewModel.DateCreated                     The date and time the new user request was created.
        * @apiParam         {String}            NewUserRequestViewModel.EmailAddress                    The email address of the new user.
        * @apiParam         {Number}            NewUserRequestViewModel.Group                           The id of the group the user is being asked to join.
        * @apiParam         {String}            NewUserRequestViewModel.InviteID                        The invitation id that was created for the new user.
        * @apiParam         {Boolean}           NewUserRequestViewModel.IsAdmin                         Is the new user an admin?
        * @apiParam         {Boolean}           NewUserRequestViewModel.IsAgent                         Is the new user and agent?
        * @apiParam         {Boolean}           NewUserRequestViewModel.IsManager                       Is the new user a manager?
        * @apiParam         {String}            NewUserRequestViewModel.RoleSelected                    The role the new user is being invited to join.
        *
        * @apiSucces        {Object[]}          NewUserRequestViewModel                                 the newuserrequestviewmodel object
        * @apiSucces        {Date}              NewUserRequestViewModel.DateCreated                     The date and time the new user request was created.
        * @apiSucces        {String}            NewUserRequestViewModel.EmailAddress                    The email address of the new user.
        * @apiSucces        {Number}            NewUserRequestViewModel.Group                           The id of the group the user is being asked to join.
        * @apiSucces        {String}            NewUserRequestViewModel.InviteID                        The invitation id that was created for the new user.
        * @apiSucces        {Boolean}           NewUserRequestViewModel.IsAdmin                         Is the new user an admin?
        * @apiSucces        {Boolean}           NewUserRequestViewModel.IsAgent                         Is the new user and agent?
        * @apiSucces        {Boolean}           NewUserRequestViewModel.IsManager                       Is the new user a manager?
        * @apiSucces        {String}            NewUserRequestViewModel.RoleSelected                    The role the new user is being invited to join.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"DateCreated":"1/1/2014 12:00 am",
        *          "EmailAddress":"email@mydomain.com",
        *          "Group":1,
        *          "InviteID":"guid",
        *          "IsAdmin":false,
        *          "IsAgent":true,
        *          "IsManager":false",
        *          "RoleSelected": "agent"
        *          }] 
        *     }
        * 
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void Post(string newUserRequests)
        {
        }

        // Create new user request.
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/site/createnewuserrequest create new user request
        * @apiName postnewuserrequest
        * @apiGroup SETTINGS > /site
        * @apiDescription Create new user request for this site.
        * @apiPermission siteAdministrator
        * 
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/site/createnewuserrequest  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"DateCreated":"1/1/2014 12:00 am","EmailAddress":"email@mydomain.com","Group":1,"InviteID":"guid","IsAdmin":false,"IsAgent":true,"IsManager":false","RoleSelected": "agent"}"
        *       
        * @apiParam         {Number}            siteID                                                  The site's unique ID.
        * @apiParam         {Object}            NewUserRequestViewModel                                 the newuserrequestviewmodel object
        * @apiParam         {Date}              NewUserRequestViewModel.DateCreated                     The date and time the new user request was created.
        * @apiParam         {String}            NewUserRequestViewModel.EmailAddress                    The email address of the new user.
        * @apiParam         {Number}            NewUserRequestViewModel.Group                           The id of the group the user is being asked to join.
        * @apiParam         {String}            NewUserRequestViewModel.InviteID                        The invitation id that was created for the new user.
        * @apiParam         {Boolean}           NewUserRequestViewModel.IsAdmin                         Is the new user an admin?
        * @apiParam         {Boolean}           NewUserRequestViewModel.IsAgent                         Is the new user and agent?
        * @apiParam         {Boolean}           NewUserRequestViewModel.IsManager                       Is the new user a manager?
        * @apiParam         {String}            NewUserRequestViewModel.RoleSelected                    The role the new user is being invited to join.
        *
        * @apiSucces        {Object}            NewUserRequestViewModel                                 the newuserrequestviewmodel object
        * @apiSucces        {Date}              NewUserRequestViewModel.DateCreated                     The date and time the new user request was created.
        * @apiSucces        {String}            NewUserRequestViewModel.EmailAddress                    The email address of the new user.
        * @apiSucces        {Number}            NewUserRequestViewModel.Group                           The id of the group the user is being asked to join.
        * @apiSucces        {String}            NewUserRequestViewModel.InviteID                        The invitation id that was created for the new user.
        * @apiSucces        {Boolean}           NewUserRequestViewModel.IsAdmin                         Is the new user an admin?
        * @apiSucces        {Boolean}           NewUserRequestViewModel.IsAgent                         Is the new user and agent?
        * @apiSucces        {Boolean}           NewUserRequestViewModel.IsManager                       Is the new user a manager?
        * @apiSucces        {String}            NewUserRequestViewModel.RoleSelected                    The role the new user is being invited to join.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"DateCreated":"1/1/2014 12:00 am",
        *          "EmailAddress":"email@mydomain.com",
        *          "Group":1,
        *          "InviteID":"guid",
        *          "IsAdmin":false,
        *          "IsAgent":true,
        *          "IsManager":false",
        *          "RoleSelected": "agent"
        *          }] 
        *     }
        *     
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void Post(string newUserRequest)
        {
        }
        // Delete new user request.
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/site/deletenewuserrequest/:id delete new user request
        * @apiName deletenewuserrequest:ID
        * @apiGroup SETTINGS > /site
        * @apiDescription Delete new user request for this site.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/site/deletenewuserrequest/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        *
        * @apiParam         {Number}            siteID                                                  Your site's account number.
        * @apiParam         {Number}            id                                                      The new user request to delete.
        *
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void Delete(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/site/acceptnewuserrequest accept new user request
        * @apiName postnewuserrequest
        * @apiGroup SETTINGS > /site
        * @apiDescription A user has received an invitation and is accepting the request to join.
        * @apiPermission anonymous
        * 
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/site/acceptnewuserrequest  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"DisplayName":"bob","HeadshotUrl":"www.mydomain.com/headshot.jpg","Newuserrequestid":"","Password":"mypassword","SiteID":1}" 
        * 
        * @apiParam         {Number}            siteID                                                  Your site's account number.
        * @apiParam         {Object}            AcceptNewUserRequestViewModel                           AcceptNewUserRequestViewModel
        * @apiParam         {String}            AcceptNewUserRequestViewModel.DisplayName               The display name this user has choosen.
        * @apiParam         {String}            AcceptNewUserRequestViewModel.HeadshotUrl               The url of the headshot for this user.
        * @apiParam         {String}            AcceptNewUserRequestViewModel.NewUserRequestId          The unique id of the request.
        * @apiParam         {String}            AcceptNewUserRequestViewModel.Password                  The password this user has choosen.
        * @apiParam         {Number}            AcceptNewUserRequestViewModel.SiteID                    Your site's account number.  This is found in the invitation.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {}
        * 
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void AcceptNewUserRequest(string acceptNewUserRequest)
        {
        }
        #endregion

        #region site users
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/site/removeuser delete user
        * @apiName deleteuser
        * @apiGroup SETTINGS > /site
        * @apiDescription Deletes a user from a site.
        * @apiPermission siteAdministrator
        * 
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/site/removeuser \
        *       -H "Authorization: Basic {authorizationToken}" 
        *       -d "{"SiteID":1,"UserName":"myemail@mydomain.com"}
        *       
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        UserProfileViewModel                                the usereprofileviewmodel object
        * @apiParam         {String}        UserProfileViewModel.userName                       The username of the user.
        *
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void RemoveUser(string userProfile)
        {
        }
        #endregion

        #region site configuration properties
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/site/getsiteconfiguration read site configuration
        * @apiName getsiteconfiguration
        * @apiGroup SETTINGS > /site
        * @apiDescription Read the configuration for this site.
        * @apiPermission siteAdministrator
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/site/getsiteconfiguration  \
        *       -H "Authorization: Basic {authorizationToken}"   
        *       
        * @apiParam         {Number}            siteID                                                                  Your site's account number.
        *
        * @apiSuccess       {Object}            SiteConfigurationViewModel                                              the siteconfigurationviewmodel object
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.DisableStorageChatArchival                   Does the site archive engagements?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.DisableStorageVisitorEmailAndName            Does the site store the visitor name and email?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableAgentsToCopyTranscriptsToClipboard     Does the site allow agents to copy engagement transcripts to the local computer's clipboard?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableAgentsToEmailTranscripts               Does the site allow agents to email engagement transcripts?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableAgentsToPushPagesDuringChat            Does the site allow agents to push pages to visitors during engagements?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableAgentsToRejectQueuedChats              Does the site allow agents to reject queued engagements?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableAgentToAgentChats                      Does the site allow agent to agent chats?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableCreditCardMaskDuringChat               Does the site mask credit card numbers during the engagement?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableCreditCardMaskWhenArchivingChats       Does the site mask credit card numbers in archived engagements?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnablePasswordExpireDays                     Does the site allow passwords to expire?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnablePasswordHistoryDays                    Does the site enforce reuse of passwords?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnablePasswordMinimumLength                  Does the site enforce a minimum password length?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnablePasswordRegularExpression              Does the site enforce a reqular expression validator for passwords?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableVisitorsToCopyTranscriptsToClipboard   Does the site allow visitors to copy engagement transcripts to the local computer's clipboard?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableVisitorsToEmailTranscripts             Does the site allow visitors to email engagement transcripts?
        * @apiSuccess       {Number}            SiteConfigurationViewModel.PasswordExpireDays                           If the site allows expiration of passwords, the number of days users must change their password.
        * @apiSuccess       {Number}            SiteConfigurationViewModel.PasswordHistoryDays                          If the site doesn't allow reuse of passwords, the number of days a password can't be reused.
        * @apiSuccess       {Number}            SiteConfigurationViewModel.PasswordMinimumLength                        If the site enforces a minimum password length, the minimum password length.
        * @apiSuccess       {String}            SiteConfigurationViewModel.PasswordRegularExpression                    If the site enforces a reqular expression vailidate for passwords, the reqular expression to use when validating a new password.
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.RequireLowerCase                             Does the site require a lower case letter in an new password? 
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.RequireNumericDigit                          Does the site require a numeric digit in a new password?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.RequireSpecialCharacter                      Does the site require a special character in a new password?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.RequireUpperCase                             Does the site require an upper case character in a new password?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "DisableStorageChatArchival":true,
        *          "DisableStorageVisitorEmailAndName":true,
        *          "EnableAgentsToCopyTranscriptsToClipboard":true",
        *          "EnableAgentsToEmailTranscripts":true,
        *          "EnableAgentesToPushPagesDuringChat":true,
        *          "EnableAgentesToRejectQueuedChats":true,
        *          "EnableAgentToAgentChats":true,
        *          "EnableCreditCardMaskDuringChat":true,
        *          "EnableCreditCardMaskWhenArchivingChats":true,
        *          "EnablePasswordExpireDays":true,
        *          "EnablePasswordHistoryDays":true,
        *          "EnablePasswordMinimumLength":true,
        *          "EnablePasswordRegularExpression":true,
        *          "EnableVisitorsToCopyTranscriptsToClipboard":true,
        *          "EnableVisitorsToEmailTranscripts":true,
        *          "PasswordExpireDays":90,
        *          "PasswordHistoryDays":365,
        *          "PasswordMinimumLength":8,
        *          "PasswordRegularExpression":"[abc]",
        *          "RequireLowerCase":true,
        *          "RequireNumericDigit":true,
        *          "ReguireSpecialCharacter":true,
        *          "RequireUpperCase": true 
        *     }
        * 
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void GetSiteConfiguration()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/site/configurationproperty update configuration property
        * @apiName putconfigurationproperty
        * @apiGroup SETTINGS > /site
        * @apiDescription Update this site.
        * @apiPermission super
        * 
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/site/configurationproperty  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"Property":"DisableStorageChatArchival","Value":"true"}
        *       
        * @apiParam         {Number}            siteID                                                  Your site's account number.
        * @apiParam         {Object}            SiteConfigurationPropertyUpdateModel                    the siteconfigurationpropertyupdatemodel object
        * @apiParam         {String}            SiteConfigurationPropertyUpdateModel.Property           The configuration property to update.
        * @apiParam         {String}            SiteConfigurationPropertyUpdateModel.Value              The value of the property.
        * 
        * @apiParam         {Object}            SiteConfigurationPropertyUpdateModel                    SiteConfigurationPropertyUpdateModel
        * @apiParam         {String}            SiteConfigurationPropertyUpdateModel.Property           The configuration property to update.
        * @apiParam         {String}            SiteConfigurationPropertyUpdateModel.Value              The value of the property.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "Property":"DisableStorageChatArchival",
        *          "Dalue": "true"
        *     }
       * 
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void UpdateConfigurationProperty(string siteConfigurationUpdateProperty)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/site/updateSiteadministratorconfiguration update site administrator configuration
        * @apiName putsiteadministratorconfiguration
        * @apiGroup SETTINGS > /site
        * @apiDescription Update the administration configuration for this site.
        * @apiPermission siteAdministrator
        * 
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/site/updateSiteadministratorconfiguration  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"DisableStorageChatArchival":true,"DisableStorageVisitorEmailAndName":true,"EnableAgentsToCopyTranscriptsToClipboard":true","EnableAgentsToEmailTranscripts":true,"EnableAgentesToPushPagesDuringChat":true,"EnableAgentesToRejectQueuedChats":true,"EnableAgentToAgentChats":true,"EnableCreditCardMaskDuringChat":true,"EnableCreditCardMaskWhenArchivingChats":true,"EnablePasswordExpireDays":true,"EnablePasswordHistoryDays":true,"EnablePasswordMinimumLength":true,"EnablePasswordRegularExpression":true,"EnableVisitorsToCopyTranscriptsToClipboard":true,"EnableVisitorsToEmailTranscripts":true,"PasswordExpireDays":90,"PasswordHistoryDays":365,"PasswordMinimumLength":8,"PasswordRegularExpression":"[abc]","RequireLowerCase":true,"RequireNumericDigit":true,"ReguireSpecialCharacter":true,"RequireUpperCase":true}"
        *       
        * @apiParam         {Number}            siteID                                                                  The site's unique ID.
        * @apiParam         {Object}            SiteConfigurationViewModel                                              the siteconfigurationviewmodel object
        * @apiParam         {Boolean}           SiteConfigurationViewModel.DisableStorageChatArchival                   Does the site archive engagements?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.DisableStorageVisitorEmailAndName            Does the site store the visitor name and email?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.EnableAgentsToCopyTranscriptsToClipboard     Does the site allow agents to copy engagement transcripts to the local computer's clipboard?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.EnableAgentsToEmailTranscripts               Does the site allow agents to email engagement transcripts?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.EnableAgentsToPushPagesDuringChat            Does the site allow agents to push pages to visitors during engagements?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.EnableAgentsToRejectQueuedChats              Does the site allow agents to reject queued engagements?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.EnableAgentToAgentChats                      Does the site allow agent to agent chats?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.EnableCreditCardMaskDuringChat               Does the site mask credit card numbers during the engagement?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.EnableCreditCardMaskWhenArchivingChats       Does the site mask credit card numbers in archived engagements?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.EnablePasswordExpireDays                     Does the site allow passwords to expire?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.EnablePasswordHistoryDays                    Does the site enforce reuse of passwords?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.EnablePasswordMinimumLength                  Does the site enforce a minimum password length?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.EnablePasswordRegularExpression              Does the site enforce a reqular expression validator for passwords?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.EnableVisitorsToCopyTranscriptsToClipboard   Does the site allow visitors to copy engagement transcripts to the local computer's clipboard?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.EnableVisitorsToEmailTranscripts             Does the site allow visitors to email engagement transcripts?
        * @apiParam         {Number}            SiteConfigurationViewModel.PasswordExpireDays                           If the site allows expiration of passwords, the number of days users must change their password.
        * @apiParam         {Number}            SiteConfigurationViewModel.PasswordHistoryDays                          If the site doesn't allow reuse of passwords, the number of days a password can't be reused.
        * @apiParam         {Number}            SiteConfigurationViewModel.PasswordMinimumLength                        If the site enforces a minimum password length, the minimum password length.
        * @apiParam         {String}            SiteConfigurationViewModel.PasswordRegularExpression                    If the site enforces a reqular expression vailidate for passwords, the reqular expression to use when validating a new password.
        * @apiParam         {Boolean}           SiteConfigurationViewModel.RequireLowerCase                             Does the site require a lower case letter in an new password? 
        * @apiParam         {Boolean}           SiteConfigurationViewModel.RequireNumericDigit                          Does the site require a numeric digit in a new password?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.RequireSpecialCharacter                      Does the site require a special character in a new password?
        * @apiParam         {Boolean}           SiteConfigurationViewModel.RequireUpperCase                             Does the site require an upper case character in a new password?
        *
        * @apiSuccess       {Object}            SiteConfigurationViewModel                                              the siteconfigurationviewmodel object
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.DisableStorageChatArchival                   Does the site archive engagements?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.DisableStorageVisitorEmailAndName            Does the site store the visitor name and email?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableAgentsToCopyTranscriptsToClipboard     Does the site allow agents to copy engagement transcripts to the local computer's clipboard?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableAgentsToEmailTranscripts               Does the site allow agents to email engagement transcripts?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableAgentsToPushPagesDuringChat            Does the site allow agents to push pages to visitors during engagements?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableAgentsToRejectQueuedChats              Does the site allow agents to reject queued engagements?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableAgentToAgentChats                      Does the site allow agent to agent chats?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableCreditCardMaskDuringChat               Does the site mask credit card numbers during the engagement?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableCreditCardMaskWhenArchivingChats       Does the site mask credit card numbers in archived engagements?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnablePasswordExpireDays                     Does the site allow passwords to expire?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnablePasswordHistoryDays                    Does the site enforce reuse of passwords?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnablePasswordMinimumLength                  Does the site enforce a minimum password length?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnablePasswordRegularExpression              Does the site enforce a reqular expression validator for passwords?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableVisitorsToCopyTranscriptsToClipboard   Does the site allow visitors to copy engagement transcripts to the local computer's clipboard?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.EnableVisitorsToEmailTranscripts             Does the site allow visitors to email engagement transcripts?
        * @apiSuccess       {Number}            SiteConfigurationViewModel.PasswordExpireDays                           If the site allows expiration of passwords, the number of days users must change their password.
        * @apiSuccess       {Number}            SiteConfigurationViewModel.PasswordHistoryDays                          If the site doesn't allow reuse of passwords, the number of days a password can't be reused.
        * @apiSuccess       {Number}            SiteConfigurationViewModel.PasswordMinimumLength                        If the site enforces a minimum password length, the minimum password length.
        * @apiSuccess       {String}            SiteConfigurationViewModel.PasswordRegularExpression                    If the site enforces a reqular expression vailidate for passwords, the reqular expression to use when validating a new password.
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.RequireLowerCase                             Does the site require a lower case letter in an new password? 
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.RequireNumericDigit                          Does the site require a numeric digit in a new password?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.RequireSpecialCharacter                      Does the site require a special character in a new password?
        * @apiSuccess       {Boolean}           SiteConfigurationViewModel.RequireUpperCase                             Does the site require an upper case character in a new password?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "DisableStorageChatArchival":true,
        *          "DisableStorageVisitorEmailAndName":true,
        *          "EnableAgentsToCopyTranscriptsToClipboard":true",
        *          "EnableAgentsToEmailTranscripts":true,
        *          "EnableAgentesToPushPagesDuringChat":true,
        *          "EnableAgentesToRejectQueuedChats":true,
        *          "EnableAgentToAgentChats":true,
        *          "EnableCreditCardMaskDuringChat":true,
        *          "EnableCreditCardMaskWhenArchivingChats":true,
        *          "EnablePasswordExpireDays":true,
        *          "EnablePasswordHistoryDays":true,
        *          "EnablePasswordMinimumLength":true,
        *          "EnablePasswordRegularExpression":true,
        *          "EnableVisitorsToCopyTranscriptsToClipboard":true,
        *          "EnableVisitorsToEmailTranscripts":true,
        *          "PasswordExpireDays":90,
        *          "PasswordHistoryDays":365,
        *          "PasswordMinimumLength":8,
        *          "PasswordRegularExpression":"[abc]",
        *          "RequireLowerCase":true,
        *          "RequireNumericDigit":true,
        *          "ReguireSpecialCharacter":true,
        *          "RequireUpperCase": true 
        *     }
        *
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void UpdateSiteAdministrationConfiguration(string updatedSiteConfiguration)
        {
        }
        #endregion

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/site/getsiteurls read site urls
        * @apiName getsiteURLs
        * @apiGroup SETTINGS > /site
        * @apiDescription Read the urls for this site.
        * @apiPermission siteAdministrator
        * 
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/site/getsiteurls  \
        *       -H "Authorization: Basic {authorizationToken}"  
        *       
        * @apiParam         {Number}            siteID                                                  Your site's account number.
        *
        * @apiSuccess       {Object[]}          SiteUrlsViewModel                                       SiteUrlsViewModel
        * @apiSuccess       {String}            SiteUrlsViewModel.ContentDeliveryUrl                    The url of content and scripts of the site.
        * @apiSuccess       {String}            SiteUrlsViewModel.EngagementApiUrl                      The url of the engagement api of the site.
        * @apiSuccess       {String}            SiteUrlsViewModel.EngagementSignalRUrl                  The url of the signalR server of the site.
        * @apiSuccess       {String}            SiteUrlsViewModel.MainApiUrl                            The url of the main api of the site.
        * @apiSuccess       {String}            SiteUrlsViewModel.ReportingApiUrl                       The url of the reporting api of the site.
        * @apiSuccess       {String}            SiteUrlsViewModel.RoutingApiUrl                         The url of the routing api of the site.
        * @apiSuccess       {Number}            SiteUrlsViewModel.SiteID                                Your site's account number.
        * @apiSuccess       {Number}            SiteUrlsViewModel.SiteName                              The name of the site.
        * @apiSuccess       {String}            SiteUrlsViewModel.StaticFilesUrl                        The url the site uses to server static files.
        * @apiSuccess       {String}            SiteUrlsViewModel.VisitorApiUrl                         The visitor api url of the site.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "ContentDeliverUrl":"azure.cdn.content",
        *          "EngagmentApiUrl":"engagement.api.livefluence.com",
        *          "VisitorApiUrl":"visitor.api.livefluence.com",
        *          "MainApiUrl":"main.api.livefluence.com",
        *          "RoutingApiUrl":"routing.api.livefluence.com",
        *          "ReportingApiUrl":"reporting.api.livefluence.com",
        *          "RngagmentSignalRUrl":"signalR.api.livefluence.com",
        *          "RtaticFilesURL": "azure.cdn.staticFiles"
        *     }
        *     
        * @apiDefineErrorStructure NotAuthorizedError
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void GetSiteUrls()
        {
            
        }
    }
}
