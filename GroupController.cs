using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    class GroupController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/group read all 
        * @apiName get
        * @apiGroup Settings > /group
        * @apiDescription Read all groups for a site.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/group  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                          Your site's account number.
        *
        * @apiSuccess       {Object[]}      Group                                           the group object
        * @apiSuccess       {Number}        Group.GroupID                                   The id of the group
        * @apiSuccess       {String}        Group.Name                                      The friendly name of the group.
        * @apiSuccess       {String}        Group.GoogleAnalyticsID                         The Google Analytics ID associated with the group.
        * @apiSuccess       {String}        Group.VisitorLanguage                           The visitor's language for the group to be used with google translate.
        * @apiSuccess       {String}        Group.Timezone                                  The default time zone for the group.
        * @apiSuccess       {Boolean}       Group.OverrideSiteSettings                      Are the site default settings being used for the group?
        * @apiSuccess       {Number}        Group.TotalUsers                                The total number of users in the group.
        * @apiSuccess       {Number}        Group.OnlineUsers                               The total number of users that are online in the group.
        * @apiSuccess       {Number}        Group.CurrentChats                              The total number of active engagements for the group.
        * @apiSuccess       {Number}        Group.TotalEngagements                          The total number of engagements the group has had.
        * @apiSuccess       {Number}        Group.ApprovalRating                            The approval rating of the group based on the approvate rating on the group's engagements.
        * @apiSuccess       {Number}        Group.PercentChats                              The amount of hours the group has been available in the system.
        * @apiSuccess       {Boolean}       Group.EnablePrechatSurvey                       Does the group have a prechat survey for the visitor?
        * @apiSuccess       {String}        Group.EmailPrechatSubmissionsTo                 The email to send the prechat surveys for the group.
        * @apiSuccess       {Number}        Group.PrechatSurveyID                           The unique id of the prechat survey for the visitor if prechat survey is enabled for the group.
        * @apiSuccess       {String}        Group.PrechatSubmitText                         The text for the prechat survey if it is enabled for the group.
        * @apiSuccess       {String}        Group.PrechatHeaderText                         The header text for the prechat survey for the group if it is enabled.
        * @apiSuccess       {String}        Group.DefaultVisitorName                        The default name to use for a visitor for the group.
        * @apiSuccess       {Boolean}       Group.QueueIncomingRequests                     Does incoming engagement request get queued for the group?
        * @apiSuccess       {Number}        Group.QueueTimeoutSeconds                       If queueing is used for the group, the is the timeout value for the queue.
        * @apiSuccess       {Boolean}       Group.QueueWhenAllAgentsBusy                    If queueing is not used for the group, should a queue be used if all agents are busy?
        * @apiSuccess       {Boolean}       Group.HigherTiersGetQueueAlert                  If queueing is used to higher tiers get queue alerts for the group.
        * @apiSuccess       {Boolean}       Group.EnablePostchatSurvey                      Does the group have a postchat survey for the visitor?
        * @apiSuccess       {String}        Group.PostchatSubmitText                        The text for the post chat survey if it enabled for the group.
        * @apiSuccess       {Number}        Group.PostchatSurveyID                          The unique id of the postchat survey for the visitor if the postchat survey for the visitor is enabled for the group. 
        * @apiSuccess       {String}        Group.EmailPostchatSubmissionsTo                The email address to send postchat surveys to if postchat surveys are enabled for the group. 
        * @apiSuccess       {String}        Group.PostchatHeaderText                        The header text for the postchat survey if it is enabled. 
        * @apiSuccess       {Boolean}       Group.EnablePostchatAgentSurvey                 Does the group have a postchat survey for the agent?
        * @apiSuccess       {Number}        Group.PostchatAgentSurveyID                     The unique id of the postchat survey for the agent if the postchat survey for the agent is enabled for the group.
        * @apiSuccess       {Number}        Group.RoutingAlgorithm                          Routing algorithm to route engagements for the group (1: No logic, 2: Custom Rules, 3: External Provider).
        * @apiSuccess       {Number}        Group.UnavailableAction                         What action to do if there are not agents in the group available for the engagement (1: Offer a survey, 2: Display custom text, 3: Redirect to page, 4: Hide live help).
        * @apiSuccess       {Number}        Group.UnavailableSurveyID                       The unique id of the unavailable survey if the unavailable action for the group is 1.
        * @apiSuccess       {String}        Group.UnavailableText                           The unavailable text to display of the unavailable action is set to display custom text.
        * @apiSuccess       {String}        Group.UnavailableRedirectUrl                    The url to use as a redirect if the unavailable action is set to redirect to page.
        * @apiSuccess       {String}        Group.EmailUnavailableSubmissionsTo             The email address to send unavailable surveys to if the unavailable action is set to offer survey for the group.
        * @apiSuccess       {String}        Group.UnavailableSubmitText                     The text for the unavailable survey if it is enabled for the group.
        * @apiSuccess       {String}        Group.UnavailableHeaderText                     The header text for the unavailable survey if the unavailable action is set for offer survey for the group.
        * @apiSuccess       {Number}        Group.InlineWindowPicturePreference             The option to set the inline window picture for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowChatRatingEnabled             Is the engagement rating button enabled for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowChatRatingText                The text for the engagement rating button for the Inline window if it is enabled for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowPrintEnabled                  Is the print button enabled for the inline window for the group?
        * @apiSuccess       {String}        Group.InlineWindowPrintText                     The text for the print button for the inline window if it is enabled for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowEmailEnabled                  Is the email button enabled for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowEmailText                     The text for the email button for the inline window if it is enabled for the group.
        * @apiSuccess       {String}        Group.nlineWindowEndChatText                   The text for the end chat button for the inline window engagemnet for the group.
        * @apiSuccess       {String}        Group.IinlineWindowOperatorText                  The text displayed for the agents' messages for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowVisitorText                   The text displayed for the visitors' messages for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowWelcomeMessage                The welcome message that is displayed in the inline window for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowLineRatingEnabled             Is the line rating button enabled for the inline window for the group?
        * @apiSuccess       {Boolean}       Group.nlineWindowUploadEnabled                 Is the upload button enabled for the inline window for the group?
        * @apiSuccess       {String}        Group.InlineWindowUploadText                    The text for the upload button for the linline window if it is enabled for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowTypingIndicatorEnabled        Is the typing indicator enabled for the inline window for the group?
        * @apiSuccess       {String}        Group.InlineWindowTypingIndicatorText           The text to display when the agent is typing if it is enaabled for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowCSSFile                       The name of the inline window css file for the group.
        * @apiSuccess       {String}        Group.IntroductionText                          The introduction text for thos group.
        * @apiSuccess       {Number}        Group.ChatCloseEvent                            The action that causes the engagement to close for the group.  
        * @apiSuccess       {Number}        Group.AutoExitVisitorTime                       The number of seconds that have to elapse before a visitor is automatically exited from the engagement for the group.
        * @apiSuccess       {Boolean}       Group.AttemptRouteSameAgent                     Should the routing engine attempt to route the engagement to the same agent for the group?
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"Name":"sales",
        *          "GoogleAnalyticsID":"[key]",
        *          "VisitorLanguage":"en",
        *          "Timezone":"Eastern Standard Time",
        *          "OverrideSiteSettings":true,
        *          "EnablePrechatSurvey":true,
        *          "EmailPrechatSubmissionsTo":"myemail@domain.com",
        *          "PrechatSurveyID":100,
        *          "PrechatSubmitText":"prechat survey text",
        *          "PrechatHeaderText":"welcom visitor",
        *          "DefaultVisitorName":"Visitor",
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
        *          "RoutingAlgorithm": 1,
        *          "UnavailableAction":2,
        *          "UnavailableSurveyID":105,
        *          "UnavailableText":"All agents are currently busy!",
        *          "UnavailableRedirectUrl":"www.mydomain.com/redirecturl",
        *          "EmailUnavailableSubmissionsTo","myemail@domain.com",
        *          "UnavailableSubmitText","All agents busy survey.",
        *          "UnavailableHeaderText":"All agents are busy.",
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
        *          "ChatCloseEvent": 1,
        *          "AutoExitVisitorTime":60,
        *          "AttemptRouteSameAgent":true
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
        public void Get()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/group/:id read
        * @apiName get:id
        * @apiGroup Settings > /group
        * @apiDescription Read all the details of the group by id.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/group/:id  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                          Your site's account number.
        * @apiParam         {Number}        id                                              The id of the group to read.
        *
        * @apiSuccess       {Object}        Group                                           the group object
        * @apiSuccess       {Number}        Group.GroupID                                   The id of the group
        * @apiSuccess       {String}        Group.Name                                      The friendly name of the group.
        * @apiSuccess       {String}        Group.GoogleAnalyticsID                         The Google Analytics ID associated with the group.
        * @apiSuccess       {String}        Group.VisitorLanguage                           The visitor's language for the group to be used with google translate.
        * @apiSuccess       {String}        Group.Timezone                                  The default time zone for the group.
        * @apiSuccess       {Boolean}       Group.OverrideSiteSettings                      Are the site default settings being used for the group?
        * @apiSuccess       {Number}        Group.TotalUsers                                The total number of users in the group.
        * @apiSuccess       {Number}        Group.OnlineUsers                               The total number of users that are online in the group.
        * @apiSuccess       {Number}        Group.CurrentChats                              The total number of active engagements for the group.
        * @apiSuccess       {Number}        Group.TotalEngagements                          The total number of engagements the group has had.
        * @apiSuccess       {Number}        Group.ApprovalRating                            The approval rating of the group based on the approvate rating on the group's engagements.
        * @apiSuccess       {Number}        Group.PercentChats                              The amount of hours the group has been available in the system.
        * @apiSuccess       {Boolean}       Group.EnablePrechatSurvey                       Does the group have a prechat survey for the visitor?
        * @apiSuccess       {String}        Group.EmailPrechatSubmissionsTo                 The email to send the prechat surveys for the group.
        * @apiSuccess       {Number}        Group.PrechatSurveyID                           The unique id of the prechat survey for the visitor if prechat survey is enabled for the group.
        * @apiSuccess       {String}        Group.PrechatSubmitText                         The text for the prechat survey if it is enabled for the group.
        * @apiSuccess       {String}        Group.PrechatHeaderText                         The header text for the prechat survey for the group if it is enabled.
        * @apiSuccess       {String}        Group.DefaultVisitorName                        The default name to use for a visitor for the group.
        * @apiSuccess       {Boolean}       Group.QueueIncomingRequests                     Does incoming engagement request get queued for the group?
        * @apiSuccess       {Number}        Group.QueueTimeoutSeconds                       If queueing is used for the group, the is the timeout value for the queue.
        * @apiSuccess       {Boolean}       Group.QueueWhenAllAgentsBusy                    If queueing is not used for the group, should a queue be used if all agents are busy?
        * @apiSuccess       {Boolean}       Group.HigherTiersGetQueueAlert                  If queueing is used to higher tiers get queue alerts for the group.
        * @apiSuccess       {Boolean}       Group.EnablePostchatSurvey                      Does the group have a postchat survey for the visitor?
        * @apiSuccess       {String}        Group.PostchatSubmitText                        The text for the post chat survey if it enabled for the group.
        * @apiSuccess       {Number}        Group.PostchatSurveyID                          The unique id of the postchat survey for the visitor if the postchat survey for the visitor is enabled for the group. 
        * @apiSuccess       {String}        Group.EmailPostchatSubmissionsTo                The email address to send postchat surveys to if postchat surveys are enabled for the group. 
        * @apiSuccess       {String}        Group.PostchatHeaderText                        The header text for the postchat survey if it is enabled. 
        * @apiSuccess       {Boolean}       Group.EnablePostchatAgentSurvey                 Does the group have a postchat survey for the agent?
        * @apiSuccess       {Number}        Group.PostchatAgentSurveyID                     The unique id of the postchat survey for the agent if the postchat survey for the agent is enabled for the group.
        * @apiSuccess       {Number}        Group.RoutingAlgorithm                          Routing algorithm to route engagements for the group (1: No logic, 2: Custom Rules, 3: External Provider).
        * @apiSuccess       {Number}        Group.UnavailableAction                         What action to do if there are not agents in the group available for the engagement (1: Offer a survey, 2: Display custom text, 3: Redirect to page, 4: Hide live help).
        * @apiSuccess       {Number}        Group.UnavailableSurveyID                       The unique id of the unavailable survey if the unavailable action for the group is 1.
        * @apiSuccess       {String}        Group.UnavailableText                           The unavailable text to display of the unavailable action is set to display custom text.
        * @apiSuccess       {String}        Group.UnavailableRedirectUrl                    The url to use as a redirect if the unavailable action is set to redirect to page.
        * @apiSuccess       {String}        Group.EmailUnavailableSubmissionsTo             The email address to send unavailable surveys to if the unavailable action is set to offer survey for the group.
        * @apiSuccess       {String}        Group.UnavailableSubmitText                     The text for the unavailable survey if it is enabled for the group.
        * @apiSuccess       {String}        Group.UnavailableHeaderText                     The header text for the unavailable survey if the unavailable action is set for offer survey for the group.
        * @apiSuccess       {Number}        Group.InlineWindowPicturePreference             The option to set the inline window picture for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowChatRatingEnabled             Is the engagement rating button enabled for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowChatRatingText                The text for the engagement rating button for the Inline window if it is enabled for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowPrintEnabled                  Is the print button enabled for the inline window for the group?
        * @apiSuccess       {String}        Group.InlineWindowPrintText                     The text for the print button for the inline window if it is enabled for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowEmailEnabled                  Is the email button enabled for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowEmailText                     The text for the email button for the inline window if it is enabled for the group.
        * @apiSuccess       {String}        Group.nlineWindowEndChatText                   The text for the end chat button for the inline window engagemnet for the group.
        * @apiSuccess       {String}        Group.IinlineWindowOperatorText                  The text displayed for the agents' messages for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowVisitorText                   The text displayed for the visitors' messages for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowWelcomeMessage                The welcome message that is displayed in the inline window for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowLineRatingEnabled             Is the line rating button enabled for the inline window for the group?
        * @apiSuccess       {Boolean}       Group.nlineWindowUploadEnabled                 Is the upload button enabled for the inline window for the group?
        * @apiSuccess       {String}        Group.InlineWindowUploadText                    The text for the upload button for the linline window if it is enabled for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowTypingIndicatorEnabled        Is the typing indicator enabled for the inline window for the group?
        * @apiSuccess       {String}        Group.InlineWindowTypingIndicatorText           The text to display when the agent is typing if it is enaabled for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowCSSFile                       The name of the inline window css file for the group.
        * @apiSuccess       {String}        Group.IntroductionText                          The introduction text for thos group.
        * @apiSuccess       {Number}        Group.ChatCloseEvent                            The action that causes the engagement to close for the group.  
        * @apiSuccess       {Number}        Group.AutoExitVisitorTime                       The number of seconds that have to elapse before a visitor is automatically exited from the engagement for the group.
        * @apiSuccess       {Boolean}       Group.AttemptRouteSameAgent                     Should the routing engine attempt to route the engagement to the same agent for the group?
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"GroupID":1
        *           "Name":"sales",
        *           "GoogleAnalyticsID":"[key]",
        *           "VisitorLanguage":"en",
        *           "Timezone":"Eastern Standard Time",
        *           "OverrideSiteSettings":true,
        *           "EnablePrechatSurvey":true,
        *           "EmailPrechatSubmissionsTo":"myemail@domain.com",
        *           "PrechatSurveyID":100,
        *           "PrechatSubmitText":"prechat survey text",
        *           "PrechatHeaderText":"welcom visitor",
        *           "DefaultVisitorName":"Visitor",
        *           "QueueIncomingRequests":true,
        *           "QueueTimeoutSeconds":300,
        *           "QueueWhenAllAgentsBusy":true,
        *           "HigherTiersGetQueueAlert":true,
        *           "EnablePostchatSurvey":true,
        *           "PostchatSubmitText":"submit survey",
        *           "PostchatSurveyID":101,
        *           "EmailPostchatSubmissionsTo":"myemail@domain.com",
        *           "PostchatHeaderText":"Thank your for completing the survey",
        *           "EnablePostchatAgentSurvey":true,
        *           "PostchatAgentSurveyID":102,
        *           "RoutingAlgorithm": 1,
        *           "UnavailableAction":2,
        *           "UnavailableSurveyID":105,
        *           "UnavailableText":"All agents are currently busy!",
        *           "UnavailableRedirectUrl":"www.mydomain.com/redirecturl",
        *           "EmailUnavailableSubmissionsTo","myemail@domain.com",
        *           "UnavailableSubmitText","All agents busy survey.",
        *           "UnavailableHeaderText":"All agents are busy.",
        *           "InlineWindowPicturePreference":1,
        *           "InlineWindowChatRatingEnabled":true,
        *           "InlineWindowChatRatingText":"rate us",
        *           "InlineWindowPrintEnabled":true,
        *           "InlineWindowPrintText":"print",
        *           "InlineWindowEmailEnabled":true,
        *           "InlineWindowEmailText":"email",
        *           "InlineWindowEndChatText":"end chat",
        *           "InlineWindowOperatorText":"operator",
        *           "InlineWindowVisitorText":"you",
        *           "InlineWindowWelcomeMessage":"Hello, How can I help you today?",
        *           "InlineWindowLineRatingEnabled":true,
        *           "InlineWindowUploadEnabled":true,
        *           "InlineWindowUploadText":"uplaod file",
        *           "InlineWindowTypingIndicatorEnabled":true,
        *           "InlineWindowTypingIndicatorText":"is typing",
        *           "InlineWindowCSSFile":"www.mydomain.com/inlinewindowcssfile.css",
        *           "IntroductionText":"Please send us a message to begin chatting.",
        *           "ChatCloseEvent": 1,
        *           "AutoExitVisitorTime":60,
        *           "AttemptRouteSameAgent":true
        *           }]
        *     }
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
        public void Get(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/group create
        * @apiName Post
        * @apiGroup Settings > /group
        * @apiDescription Create a new group.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/group  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"Name":"sales","GoogleAnalyticsID":"[key]","VisitorLanguage":"en","Timezone":"Eastern Standard Time","OverrideSiteSettings":true,"EnablePrechatSurvey":true,"EmailPrechatSubmissionsTo":"myemail@domain.com","PrechatSurveyID":100,"PrechatSubmitText":"prechat survey text","PrechatHeaderText":"welcom visitor","DefaultVisitorName":"Visitor","QueueIncomingRequests":true,"QueueTimeoutSeconds":300,"QueueWhenAllAgentsBusy":true,"HigherTiersGetQueueAlert":true,"EnablePostchatSurvey":true,"PostchatSubmitText":"submit survey","PostchatSurveyID":101,"EmailPostchatSubmissionsTo":"myemail@domain.com","PostchatHeaderText":"Thank your for completing the survey","EnablePostchatAgentSurvey":true,"PostchatAgentSurveyID":102,"RoutingAlgorithm": 1,"UnavailableAction": 2,"UnavailableSurveyID":105,"UnavailableText":"All agents are currently busy!","UnavailableRedirectUrl":"www.mydomain.com/redirecturl","EmailUnavailableSubmissionsTo","myemail@domain.com","UnavailableSubmitText","All agents busy survey.","UnavailableHeaderText":"All agents are busy.","InlineWindowPicturePreference":1,"InlineWindowChatRatingEnabled":true,"InlineWindowChatRatingText":"rate us","InlineWindowPrintEnabled":true,"InlineWindowPrintText":"print","InlineWindowEmailEnabled":true,"InlineWindowEmailText":"email","InlineWindowEndChatText":"end chat","InlineWindowOperatorText":"operator","InlineWindowVisitorText":"you","InlineWindowWelcomeMessage":"Hello, How can I help you today?","InlineWindowLineRatingEnabled":true,"InlineWindowUploadEnabled":true,"InlineWindowUploadText":"uplaod file","InlineWindowTypingIndicatorEnabled":true,"InlineWindowTypingIndicatorText":"is typing","InlineWindowCSSFile":"www.mydomain.com/inlinewindowcssfile.css","IntroductionText":"Please send us a message to begin chatting.","ChatCloseEvent": 1,"AutoExitVisitorTime":60,"AttemptRouteSameAgent":true}"
        * 
        * @apiParam         {Number}        siteID                                          Your site's account number.
        * @apiParam         {Object}        Group                                           the group object
        * @apiParam         {String}        Group.Name                                      The friendly name of the group.
        * @apiParam         {String}        Group.GoogleAnalyticsID                         The Google Analytics ID associated with the group.
        * @apiParam         {String}        Group.VisitorLanguage                           The visitor's language for the group to be used with google translate.
        * @apiParam         {String}        Group.Timezone                                  The default time zone for the group.
        * @apiParam         {Boolean}       Group.OverrideSiteSettings                      Are the site default settings being used for the group?
        * @apiParam         {Number}        Group.TotalUsers                                The total number of users in the group.
        * @apiParam         {Number}        Group.OnlineUsers                               The total number of users that are online in the group.
        * @apiParam         {Number}        Group.CurrentChats                              The total number of active engagements for the group.
        * @apiParam         {Number}        Group.TotalEngagements                          The total number of engagements the group has had.
        * @apiParam         {Number}        Group.ApprovalRating                            The approval rating of the group based on the approvate rating on the group's engagements.
        * @apiParam         {Number}        Group.PercentChats                              The amount of hours the group has been available in the system.
        * @apiParam         {Boolean}       Group.EnablePrechatSurvey                       Does the group have a prechat survey for the visitor?
        * @apiParam         {String}        Group.EmailPrechatSubmissionsTo                 The email to send the prechat surveys for the group.
        * @apiParam         {Number}        Group.PrechatSurveyID                           The unique id of the prechat survey for the visitor if prechat survey is enabled for the group.
        * @apiParam         {String}        Group.PrechatSubmitText                         The text for the prechat survey if it is enabled for the group.
        * @apiParam         {String}        Group.PrechatHeaderText                         The header text for the prechat survey for the group if it is enabled.
        * @apiParam         {String}        Group.DefaultVisitorName                        The default name to use for a visitor for the group.
        * @apiParam         {Boolean}       Group.QueueIncomingRequests                     Does incoming engagement request get queued for the group?
        * @apiParam         {Number}        Group.QueueTimeoutSeconds                       If queueing is used for the group, the is the timeout value for the queue.
        * @apiParam         {Boolean}       Group.QueueWhenAllAgentsBusy                    If queueing is not used for the group, should a queue be used if all agents are busy?
        * @apiParam         {Boolean}       Group.HigherTiersGetQueueAlert                  If queueing is used to higher tiers get queue alerts for the group.
        * @apiParam         {Boolean}       Group.EnablePostchatSurvey                      Does the group have a postchat survey for the visitor?
        * @apiParam         {String}        Group.PostchatSubmitText                        The text for the post chat survey if it enabled for the group.
        * @apiParam         {Number}        Group.PostchatSurveyID                          The unique id of the postchat survey for the visitor if the postchat survey for the visitor is enabled for the group. 
        * @apiParam         {String}        Group.EmailPostchatSubmissionsTo                The email address to send postchat surveys to if postchat surveys are enabled for the group. 
        * @apiParam         {String}        Group.PostchatHeaderText                        The header text for the postchat survey if it is enabled. 
        * @apiParam         {Boolean}       Group.EnablePostchatAgentSurvey                 Does the group have a postchat survey for the agent?
        * @apiParam         {Number}        Group.PostchatAgentSurveyID                     The unique id of the postchat survey for the agent if the postchat survey for the agent is enabled for the group.
        * @apiParam         {Number}        Group.RoutingAlgorithm                          Routing algorithm to route engagements for the group (1: No logic, 2: Custom Rules, 3: External Provider).
        * @apiParam         {Number}        Group.UnavailableAction                         What action to do if there are not agents in the group available for the engagement (1: Offer a survey, 2: Display custom text, 3: Redirect to page, 4: Hide live help).
        * @apiParam         {Number}        Group.UnavailableSurveyID                       The unique id of the unavailable survey if the unavailable action for the group is 1.
        * @apiParam         {String}        Group.UnavailableText                           The unavailable text to display of the unavailable action is set to display custom text.
        * @apiParam         {String}        Group.UnavailableRedirectUrl                    The url to use as a redirect if the unavailable action is set to redirect to page.
        * @apiParam         {String}        Group.EmailUnavailableSubmissionsTo             The email address to send unavailable surveys to if the unavailable action is set to offer survey for the group.
        * @apiParam         {String}        Group.UnavailableSubmitText                     The text for the unavailable survey if it is enabled for the group.
        * @apiParam         {String}        Group.UnavailableHeaderText                     The header text for the unavailable survey if the unavailable action is set for offer survey for the group.
        * @apiParam         {Number}        Group.InlineWindowPicturePreference             The option to set the inline window picture for the group.
        * @apiParam         {Boolean}       Group.InlineWindowChatRatingEnabled             Is the engagement rating button enabled for the inline window for the group.
        * @apiParam         {String}        Group.InlineWindowChatRatingText                The text for the engagement rating button for the Inline window if it is enabled for the group.
        * @apiParam         {Boolean}       Group.InlineWindowPrintEnabled                  Is the print button enabled for the inline window for the group?
        * @apiParam         {String}        Group.InlineWindowPrintText                     The text for the print button for the inline window if it is enabled for the group.
        * @apiParam         {Boolean}       Group.InlineWindowEmailEnabled                  Is the email button enabled for the inline window for the group.
        * @apiParam         {String}        Group.InlineWindowEmailText                     The text for the email button for the inline window if it is enabled for the group.
        * @apiParam         {String}        Group.nlineWindowEndChatText                   The text for the end chat button for the inline window engagemnet for the group.
        * @apiParam         {String}        Group.IinlineWindowOperatorText                  The text displayed for the agents' messages for the inline window for the group.
        * @apiParam         {String}        Group.InlineWindowVisitorText                   The text displayed for the visitors' messages for the inline window for the group.
        * @apiParam         {String}        Group.InlineWindowWelcomeMessage                The welcome message that is displayed in the inline window for the group.
        * @apiParam         {Boolean}       Group.InlineWindowLineRatingEnabled             Is the line rating button enabled for the inline window for the group?
        * @apiParam         {Boolean}       Group.nlineWindowUploadEnabled                 Is the upload button enabled for the inline window for the group?
        * @apiParam         {String}        Group.InlineWindowUploadText                    The text for the upload button for the linline window if it is enabled for the group.
        * @apiParam         {Boolean}       Group.InlineWindowTypingIndicatorEnabled        Is the typing indicator enabled for the inline window for the group?
        * @apiParam         {String}        Group.InlineWindowTypingIndicatorText           The text to display when the agent is typing if it is enaabled for the inline window for the group.
        * @apiParam         {String}        Group.InlineWindowCSSFile                       The name of the inline window css file for the group.
        * @apiParam         {String}        Group.IntroductionText                          The introduction text for thos group.
        * @apiParam         {Number}        Group.ChatCloseEvent                            The action that causes the engagement to close for the group.  
        * @apiParam         {Number}        Group.AutoExitVisitorTime                       The number of seconds that have to elapse before a visitor is automatically exited from the engagement for the group.
        * @apiParam         {Boolean}       Group.AttemptRouteSameAgent                     Should the routing engine attempt to route the engagement to the same agent for the group?
        *          
        * @apiSuccess       {Object}        Group                                           the group object
        * @apiSuccess       {Number}        Group.GroupID                                   The id of the group
        * @apiSuccess       {String}        Group.Name                                      The friendly name of the group.
        * @apiSuccess       {String}        Group.GoogleAnalyticsID                         The Google Analytics ID associated with the group.
        * @apiSuccess       {String}        Group.VisitorLanguage                           The visitor's language for the group to be used with google translate.
        * @apiSuccess       {String}        Group.Timezone                                  The default time zone for the group.
        * @apiSuccess       {Boolean}       Group.OverrideSiteSettings                      Are the site default settings being used for the group?
        * @apiSuccess       {Number}        Group.TotalUsers                                The total number of users in the group.
        * @apiSuccess       {Number}        Group.OnlineUsers                               The total number of users that are online in the group.
        * @apiSuccess       {Number}        Group.CurrentChats                              The total number of active engagements for the group.
        * @apiSuccess       {Number}        Group.TotalEngagements                          The total number of engagements the group has had.
        * @apiSuccess       {Number}        Group.ApprovalRating                            The approval rating of the group based on the approvate rating on the group's engagements.
        * @apiSuccess       {Number}        Group.PercentChats                              The amount of hours the group has been available in the system.
        * @apiSuccess       {Boolean}       Group.EnablePrechatSurvey                       Does the group have a prechat survey for the visitor?
        * @apiSuccess       {String}        Group.EmailPrechatSubmissionsTo                 The email to send the prechat surveys for the group.
        * @apiSuccess       {Number}        Group.PrechatSurveyID                           The unique id of the prechat survey for the visitor if prechat survey is enabled for the group.
        * @apiSuccess       {String}        Group.PrechatSubmitText                         The text for the prechat survey if it is enabled for the group.
        * @apiSuccess       {String}        Group.PrechatHeaderText                         The header text for the prechat survey for the group if it is enabled.
        * @apiSuccess       {String}        Group.DefaultVisitorName                        The default name to use for a visitor for the group.
        * @apiSuccess       {Boolean}       Group.QueueIncomingRequests                     Does incoming engagement request get queued for the group?
        * @apiSuccess       {Number}        Group.QueueTimeoutSeconds                       If queueing is used for the group, the is the timeout value for the queue.
        * @apiSuccess       {Boolean}       Group.QueueWhenAllAgentsBusy                    If queueing is not used for the group, should a queue be used if all agents are busy?
        * @apiSuccess       {Boolean}       Group.HigherTiersGetQueueAlert                  If queueing is used to higher tiers get queue alerts for the group.
        * @apiSuccess       {Boolean}       Group.EnablePostchatSurvey                      Does the group have a postchat survey for the visitor?
        * @apiSuccess       {String}        Group.PostchatSubmitText                        The text for the post chat survey if it enabled for the group.
        * @apiSuccess       {Number}        Group.PostchatSurveyID                          The unique id of the postchat survey for the visitor if the postchat survey for the visitor is enabled for the group. 
        * @apiSuccess       {String}        Group.EmailPostchatSubmissionsTo                The email address to send postchat surveys to if postchat surveys are enabled for the group. 
        * @apiSuccess       {String}        Group.PostchatHeaderText                        The header text for the postchat survey if it is enabled. 
        * @apiSuccess       {Boolean}       Group.EnablePostchatAgentSurvey                 Does the group have a postchat survey for the agent?
        * @apiSuccess       {Number}        Group.PostchatAgentSurveyID                     The unique id of the postchat survey for the agent if the postchat survey for the agent is enabled for the group.
        * @apiSuccess       {Number}        Group.RoutingAlgorithm                          Routing algorithm to route engagements for the group (1: No logic, 2: Custom Rules, 3: External Provider).
        * @apiSuccess       {Number}        Group.UnavailableAction                         What action to do if there are not agents in the group available for the engagement (1: Offer a survey, 2: Display custom text, 3: Redirect to page, 4: Hide live help).
        * @apiSuccess       {Number}        Group.UnavailableSurveyID                       The unique id of the unavailable survey if the unavailable action for the group is 1.
        * @apiSuccess       {String}        Group.UnavailableText                           The unavailable text to display of the unavailable action is set to display custom text.
        * @apiSuccess       {String}        Group.UnavailableRedirectUrl                    The url to use as a redirect if the unavailable action is set to redirect to page.
        * @apiSuccess       {String}        Group.EmailUnavailableSubmissionsTo             The email address to send unavailable surveys to if the unavailable action is set to offer survey for the group.
        * @apiSuccess       {String}        Group.UnavailableSubmitText                     The text for the unavailable survey if it is enabled for the group.
        * @apiSuccess       {String}        Group.UnavailableHeaderText                     The header text for the unavailable survey if the unavailable action is set for offer survey for the group.
        * @apiSuccess       {Number}        Group.InlineWindowPicturePreference             The option to set the inline window picture for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowChatRatingEnabled             Is the engagement rating button enabled for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowChatRatingText                The text for the engagement rating button for the Inline window if it is enabled for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowPrintEnabled                  Is the print button enabled for the inline window for the group?
        * @apiSuccess       {String}        Group.InlineWindowPrintText                     The text for the print button for the inline window if it is enabled for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowEmailEnabled                  Is the email button enabled for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowEmailText                     The text for the email button for the inline window if it is enabled for the group.
        * @apiSuccess       {String}        Group.nlineWindowEndChatText                   The text for the end chat button for the inline window engagemnet for the group.
        * @apiSuccess       {String}        Group.IinlineWindowOperatorText                  The text displayed for the agents' messages for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowVisitorText                   The text displayed for the visitors' messages for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowWelcomeMessage                The welcome message that is displayed in the inline window for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowLineRatingEnabled             Is the line rating button enabled for the inline window for the group?
        * @apiSuccess       {Boolean}       Group.nlineWindowUploadEnabled                 Is the upload button enabled for the inline window for the group?
        * @apiSuccess       {String}        Group.InlineWindowUploadText                    The text for the upload button for the linline window if it is enabled for the group.
        * @apiSuccess       {Boolean}       Group.InlineWindowTypingIndicatorEnabled        Is the typing indicator enabled for the inline window for the group?
        * @apiSuccess       {String}        Group.InlineWindowTypingIndicatorText           The text to display when the agent is typing if it is enaabled for the inline window for the group.
        * @apiSuccess       {String}        Group.InlineWindowCSSFile                       The name of the inline window css file for the group.
        * @apiSuccess       {String}        Group.IntroductionText                          The introduction text for thos group.
        * @apiSuccess       {Number}        Group.ChatCloseEvent                            The action that causes the engagement to close for the group.  
        * @apiSuccess       {Number}        Group.AutoExitVisitorTime                       The number of seconds that have to elapse before a visitor is automatically exited from the engagement for the group.
        * @apiSuccess       {Boolean}       Group.AttemptRouteSameAgent                     Should the routing engine attempt to route the engagement to the same agent for the group?
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "GroupID":1
        *          "Name":"sales",
        *          "GoogleAnalyticsID":"[key]",
        *          "VisitorLanguage":"en",
        *          "Timezone":"Eastern Standard Time",
        *          "OverrideSiteSettings":true,
        *          "EnablePrechatSurvey":true,
        *          "EmailPrechatSubmissionsTo":"myemail@domain.com",
        *          "PrechatSurveyID":100,
        *          "PrechatSubmitText":"prechat survey text",
        *          "PrechatHeaderText":"welcom visitor",
        *          "DefaultVisitorName":"Visitor",
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
        *          "RoutingAlgorithm": 1,
        *          "UnavailableAction":2,
        *          "UnavailableSurveyID":105,
        *          "UnavailableText":"All agents are currently busy!",
        *          "UnavailableRedirectUrl":"www.mydomain.com/redirecturl",
        *          "EmailUnavailableSubmissionsTo","myemail@domain.com",
        *          "UnavailableSubmitText","All agents busy survey.",
        *          "UnavailableHeaderText":"All agents are busy.",
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
        *          "ChatCloseEvent": 1,
        *          "AutoExitVisitorTime":60,
        *          "AttemptRouteSameAgent":true
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
        public void Post(string group, int siteID = 0)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/group update
        * @apiName put
        * @apiGroup Settings > /group
        * @apiDescription Update a group.
        * @apiPermission siteAdministrator
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/group  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"GroupID":1,"Name":"sales","GoogleAnalyticsID":"[key]","VisitorLanguage":"en","Timezone":"Eastern Standard Time","OverrideSiteSettings":true,"EnablePrechatSurvey":true,"EmailPrechatSubmissionsTo":"myemail@domain.com","PrechatSurveyID":100,"PrechatSubmitText":"prechat survey text","PrechatHeaderText":"welcom visitor","DefaultVisitorName":"Visitor","QueueIncomingRequests":true,"QueueTimeoutSeconds":300,"QueueWhenAllAgentsBusy":true,"HigherTiersGetQueueAlert":true,"EnablePostchatSurvey":true,"PostchatSubmitText":"submit survey","PostchatSurveyID":101,"EmailPostchatSubmissionsTo":"myemail@domain.com","PostchatHeaderText":"Thank your for completing the survey","EnablePostchatAgentSurvey":true,"PostchatAgentSurveyID":102,"RoutingAlgorithm": 1,"UnavailableAction": 2,"UnavailableSurveyID":105,"UnavailableText":"All agents are currently busy!","UnavailableRedirectUrl":"www.mydomain.com/redirecturl","EmailUnavailableSubmissionsTo","myemail@domain.com","UnavailableSubmitText","All agents busy survey.","UnavailableHeaderText":"All agents are busy.","InlineWindowPicturePreference":1,"InlineWindowChatRatingEnabled":true,"InlineWindowChatRatingText":"rate us","InlineWindowPrintEnabled":true,"InlineWindowPrintText":"print","InlineWindowEmailEnabled":true,"InlineWindowEmailText":"email","InlineWindowEndChatText":"end chat","InlineWindowOperatorText":"operator","InlineWindowVisitorText":"you","InlineWindowWelcomeMessage":"Hello, How can I help you today?","InlineWindowLineRatingEnabled":true,"InlineWindowUploadEnabled":true,"InlineWindowUploadText":"uplaod file","InlineWindowTypingIndicatorEnabled":true,"InlineWindowTypingIndicatorText":"is typing","InlineWindowCSSFile":"www.mydomain.com/inlinewindowcssfile.css","IntroductionText":"Please send us a message to begin chatting.","ChatCloseEvent": 1,"AutoExitVisitorTime":60,"AttemptRouteSameAgent":true}"
        * 
        * @apiParam         {Number}        siteID                                          Your site's account number.
        * @apiParam         {Object}        Group                                           the group object
        * @apiParam         {Number}        Group.groupID                                   The id of the group
        * @apiParam         {String}        Group.name                                      The friendly name of the group.
        * @apiParam         {String}        Group.googleAnalyticsID                         The Google Analytics ID associated with the group.
        * @apiParam         {String}        Group.visitorLanguage                           The visitor's language for the group to be used with google translate.
        * @apiParam         {String}        Group.timezone                                  The default time zone for the group.
        * @apiParam         {Boolean}       Group.overrideSiteSettings                      Are the site default settings being used for the group?
        * @apiParam         {Boolean}       Group.enablePrechatSurvey                       Does the group have a prechat survey for the visitor?
        * @apiParam         {String}        Group.emailPrechatSubmissionsTo                 The email to send the prechat surveys for the group.
        * @apiParam         {Number}        Group.prechatSurveyID                           The unique id of the prechat survey for the visitor if prechat survey is enabled for the group.
        * @apiParam         {String}        Group.prechatSubmitText                         The text for the prechat survey if it is enabled for the group.
        * @apiParam         {String}        Group.prechatHeaderText                         The header text for the prechat survey for the group if it is enabled.
        * @apiParam         {String}        Group.defaultVisitorName                        The default name to use for a visitor for the group.
        * @apiParam         {Boolean}       Group.queueIncomingRequests                     Does incoming engagement request get queued for the group?
        * @apiParam         {Number}        Group.queueTimeoutSeconds                       If queueing is used for the group, the is the timeout value for the queue.
        * @apiParam         {Boolean}       Group.queueWhenAllAgentsBusy                    If queueing is not used for the group, should a queue be used if all agents are busy?
        * @apiParam         {Boolean}       Group.higherTiersGetQueueAlert                  If queueing is used to higher tiers get queue alerts for the group.
        * @apiParam         {Boolean}       Group.enablePostchatSurvey                      Does the group have a postchat survey for the visitor?
        * @apiParam         {String}        Group.postchatSubmitText                        The text for the post chat survey if it enabled for the group.
        * @apiParam         {Number}        Group.postchatSurveyID                          The unique id of the postchat survey for the visitor if the postchat survey for the visitor is enabled for the group. 
        * @apiParam         {String}        Group.emailPostchatSubmissionsTo                The email address to send postchat surveys to if postchat surveys are enabled for the group. 
        * @apiParam         {String}        Group.postchatHeaderText                        The header text for the postchat survey if it is enabled. 
        * @apiParam         {Boolean}       Group.enablePostchatAgentSurvey                 Does the group have a postchat survey for the agent?
        * @apiParam         {Number}        Group.postchatAgentSurveyID                     The unique id of the postchat survey for the agent if the postchat survey for the agent is enabled for the group.
        * @apiParam         {Number}        Group.routingAlgorithm                          Routing algorithm to route engagements for the group (1: No logic, 2: Custom Rules, 3: External Provider).
        * @apiParam         {Number}        Group.unavailableAction                         What action to do if there are not agents in the group available for the engagement (1: Offer a survey, 2: Display custom text, 3: Redirect to page, 4: Hide live help).
        * @apiParam         {Number}        Group.unavailableSurveyID                       The unique id of the unavailable survey if the unavailable action for the group is 1.
        * @apiParam         {String}        Group.unavailableText                           The unavailable text to display of the unavailable action is set to display custom text.
        * @apiParam         {String}        Group.unavailableRedirectUrl                    The url to use as a redirect if the unavailable action is set to redirect to page.
        * @apiParam         {String}        Group.emailUnavailableSubmissionsTo             The email address to send unavailable surveys to if the unavailable action is set to offer survey for the group.
        * @apiParam         {String}        Group.unavailableSubmitText                     The text for the unavailable survey if it is enabled for the group.
        * @apiParam         {String}        Group.unavailableHeaderText                     The header text for the unavailable survey if the unavailable action is set for offer survey for the group.
        * @apiParam         {Number}        Group.inlineWindowPicturePreference             The option to set the inline window picture for the group.
        * @apiParam         {Boolean}       Group.inlineWindowChatRatingEnabled             Is the engagement rating button enabled for the inline window for the group.
        * @apiParam         {String}        Group.inlineWindowChatRatingText                The text for the engagement rating button for the Inline window if it is enabled for the group.
        * @apiParam         {Boolean}       Group.inlineWindowPrintEnabled                  Is the print button enabled for the inline window for the group?
        * @apiParam         {String}        Group.inlineWindowPrintText                     The text for the print button for the inline window if it is enabled for the group.
        * @apiParam         {Boolean}       Group.inlineWindowEmailEnabled                  Is the email button enabled for the inline window for the group.
        * @apiParam         {String}        Group.inlineWindowEmailText                     The text for the email button for the inline window if it is enabled for the group.
        * @apiParam         {String}        Group.inlineWindowEndChatText                   The text for the end chat button for the inline window engagemnet for the group.
        * @apiParam         {String}        Group.inlineWindowOperatorText                  The text displayed for the agents' messages for the inline window for the group.
        * @apiParam         {String}        Group.inlineWindowVisitorText                   The text displayed for the visitors' messages for the inline window for the group.
        * @apiParam         {String}        Group.inlineWindowWelcomeMessage                The welcome message that is displayed in the inline window for the group.
        * @apiParam         {Boolean}       Group.inlineWindowLineRatingEnabled             Is the line rating button enabled for the inline window for the group?
        * @apiParam         {Boolean}       Group.inlineWindowUploadEnabled                 Is the upload button enabled for the inline window for the group?
        * @apiParam         {String}        Group.inlineWindowUploadText                    The text for the upload button for the linline window if it is enabled for the group.
        * @apiParam         {Boolean}       Group.inlineWindowTypingIndicatorEnabled        Is the typing indicator enabled for the inline window for the group?
        * @apiParam         {String}        Group.inlineWindowTypingIndicatorText           The text to display when the agent is typing if it is enaabled for the inline window for the group.
        * @apiParam         {String}        Group.inlineWindowCSSFile                       The name of the inline window css file for the group.
        * @apiParam         {String}        Group.introductionText                          The introduction text for thos group.
        * @apiParam         {Number}        Group.chatCloseEvent                            The action that causes the engagement to close for the group.  
        * @apiParam         {Number}        Group.autoExitVisitorTime                       The number of seconds that have to elapse before a visitor is automatically exited from the engagement for the group.
        * @apiParam         {Boolean}       Group.attemptRouteSameAgent                     Should the routing engine attempt to route the engagement to the same agent for the group?
        *          
        * @apiSuccess       {Object}        Group                                           the group object
        * @apiSuccess       {Number}        Group.groupID                                   The id of the group
        * @apiSuccess       {String}        Group.name                                      The friendly name of the group.
        * @apiSuccess       {String}        Group.googleAnalyticsID                         The Google Analytics ID associated with the group.
        * @apiSuccess       {String}        Group.visitorLanguage                           The visitor's language for the group to be used with google translate.
        * @apiSuccess       {String}        Group.timezone                                  The default time zone for the group.
        * @apiSuccess       {Boolean}       Group.overrideSiteSettings                      Are the site default settings being used for the group?
        * @apiSuccess       {Number}        Group.totalUsers                                The total number of users in the group.
        * @apiSuccess       {Number}        Group.onlineUsers                               The total number of users that are online in the group.
        * @apiSuccess       {Number}        Group.currentChats                              The total number of active engagements for the group.
        * @apiSuccess       {Number}        Group.totalEngagements                          The total number of engagements the group has had.
        * @apiSuccess       {Number}        Group.approvalRating                            The approval rating of the group based on the approvate rating on the group's engagements.
        * @apiSuccess       {Number}        Group.percentChats                              The amount of hours the group has been available in the system.
        * @apiSuccess       {Boolean}       Group.enablePrechatSurvey                       Does the group have a prechat survey for the visitor?
        * @apiSuccess       {String}        Group.emailPrechatSubmissionsTo                 The email to send the prechat surveys for the group.
        * @apiSuccess       {Number}        Group.prechatSurveyID                           The unique id of the prechat survey for the visitor if prechat survey is enabled for the group.
        * @apiSuccess       {String}        Group.prechatSubmitText                         The text for the prechat survey if it is enabled for the group.
        * @apiSuccess       {String}        Group.prechatHeaderText                         The header text for the prechat survey for the group if it is enabled.
        * @apiSuccess       {String}        Group.defaultVisitorName                        The default name to use for a visitor for the group.
        * @apiSuccess       {Boolean}       Group.queueIncomingRequests                     Does incoming engagement request get queued for the group?
        * @apiSuccess       {Number}        Group.queueTimeoutSeconds                       If queueing is used for the group, the is the timeout value for the queue.
        * @apiSuccess       {Boolean}       Group.queueWhenAllAgentsBusy                    If queueing is not used for the group, should a queue be used if all agents are busy?
        * @apiSuccess       {Boolean}       Group.higherTiersGetQueueAlert                  If queueing is used to higher tiers get queue alerts for the group.
        * @apiSuccess       {Boolean}       Group.enablePostchatSurvey                      Does the group have a postchat survey for the visitor?
        * @apiSuccess       {String}        Group.postchatSubmitText                        The text for the post chat survey if it enabled for the group.
        * @apiSuccess       {Number}        Group.postchatSurveyID                          The unique id of the postchat survey for the visitor if the postchat survey for the visitor is enabled for the group. 
        * @apiSuccess       {String}        Group.emailPostchatSubmissionsTo                The email address to send postchat surveys to if postchat surveys are enabled for the group. 
        * @apiSuccess       {String}        Group.postchatHeaderText                        The header text for the postchat survey if it is enabled. 
        * @apiSuccess       {Boolean}       Group.enablePostchatAgentSurvey                 Does the group have a postchat survey for the agent?
        * @apiSuccess       {Number}        Group.postchatAgentSurveyID                     The unique id of the postchat survey for the agent if the postchat survey for the agent is enabled for the group.
        * @apiSuccess       {Number}        Group.routingAlgorithm                          Routing algorithm to route engagements for the group (1: No logic, 2: Custom Rules, 3: External Provider).
        * @apiSuccess       {Number}        Group.unavailableAction                         What action to do if there are not agents in the group available for the engagement (1: Offer a survey, 2: Display custom text, 3: Redirect to page, 4: Hide live help).
        * @apiSuccess       {Number}        Group.unavailableSurveyID                       The unique id of the unavailable survey if the unavailable action for the group is 1.
        * @apiSuccess       {String}        Group.unavailableText                           The unavailable text to display of the unavailable action is set to display custom text.
        * @apiSuccess       {String}        Group.unavailableRedirectUrl                    The url to use as a redirect if the unavailable action is set to redirect to page.
        * @apiSuccess       {String}        Group.emailUnavailableSubmissionsTo             The email address to send unavailable surveys to if the unavailable action is set to offer survey for the group.
        * @apiSuccess       {String}        Group.unavailableSubmitText                     The text for the unavailable survey if it is enabled for the group.
        * @apiSuccess       {String}        Group.unavailableHeaderText                     The header text for the unavailable survey if the unavailable action is set for offer survey for the group.
        * @apiSuccess       {Number}        Group.inlineWindowPicturePreference             The option to set the inline window picture for the group.
        * @apiSuccess       {Boolean}       Group.inlineWindowChatRatingEnabled             Is the engagement rating button enabled for the inline window for the group.
        * @apiSuccess       {String}        Group.inlineWindowChatRatingText                The text for the engagement rating button for the Inline window if it is enabled for the group.
        * @apiSuccess       {Boolean}       Group.inlineWindowPrintEnabled                  Is the print button enabled for the inline window for the group?
        * @apiSuccess       {String}        Group.inlineWindowPrintText                     The text for the print button for the inline window if it is enabled for the group.
        * @apiSuccess       {Boolean}       Group.inlineWindowEmailEnabled                  Is the email button enabled for the inline window for the group.
        * @apiSuccess       {String}        Group.inlineWindowEmailText                     The text for the email button for the inline window if it is enabled for the group.
        * @apiSuccess       {String}        Group.inlineWindowEndChatText                   The text for the end chat button for the inline window engagemnet for the group.
        * @apiSuccess       {String}        Group.inlineWindowOperatorText                  The text displayed for the agents' messages for the inline window for the group.
        * @apiSuccess       {String}        Group.inlineWindowVisitorText                   The text displayed for the visitors' messages for the inline window for the group.
        * @apiSuccess       {String}        Group.inlineWindowWelcomeMessage                The welcome message that is displayed in the inline window for the group.
        * @apiSuccess       {Boolean}       Group.inlineWindowLineRatingEnabled             Is the line rating button enabled for the inline window for the group?
        * @apiSuccess       {Boolean}       Group.inlineWindowUploadEnabled                 Is the upload button enabled for the inline window for the group?
        * @apiSuccess       {String}        Group.inlineWindowUploadText                    The text for the upload button for the linline window if it is enabled for the group.
        * @apiSuccess       {Boolean}       Group.inlineWindowTypingIndicatorEnabled        Is the typing indicator enabled for the inline window for the group?
        * @apiSuccess       {String}        Group.inlineWindowTypingIndicatorText           The text to display when the agent is typing if it is enaabled for the inline window for the group.
        * @apiSuccess       {String}        Group.inlineWindowCSSFile                       The name of the inline window css file for the group.
        * @apiSuccess       {String}        Group.introductionText                          The introduction text for thos group.
        * @apiSuccess       {Number}        Group.chatCloseEvent                            The action that causes the engagement to close for the group.  
        * @apiSuccess       {Number}        Group.autoExitVisitorTime                       The number of seconds that have to elapse before a visitor is automatically exited from the engagement for the group.
        * @apiSuccess       {Boolean}       Group.attemptRouteSameAgent                     Should the routing engine attempt to route the engagement to the same agent for the group?
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "GroupID":1
        *          "Name":"sales",
        *          "GoogleAnalyticsID":"[key]",
        *          "VisitorLanguage":"en",
        *          "Timezone":"Eastern Standard Time",
        *          "OverrideSiteSettings":true,
        *          "EnablePrechatSurvey":true,
        *          "EmailPrechatSubmissionsTo":"myemail@domain.com",
        *          "PrechatSurveyID":100,
        *          "PrechatSubmitText":"prechat survey text",
        *          "PrechatHeaderText":"welcom visitor",
        *          "DefaultVisitorName":"Visitor",
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
        *          "RoutingAlgorithm": 1,
        *          "UnavailableAction":2,
        *          "UnavailableSurveyID":105,
        *          "UnavailableText":"All agents are currently busy!",
        *          "UnavailableRedirectUrl":"www.mydomain.com/redirecturl",
        *          "EmailUnavailableSubmissionsTo","myemail@domain.com",
        *          "UnavailableSubmitText","All agents busy survey.",
        *          "UnavailableHeaderText":"All agents are busy.",
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
        *          "ChatCloseEvent": 1,
        *          "AutoExitVisitorTime":60,
        *          "AttemptRouteSameAgent":true
        *     }
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
        public void Put(string group, int siteID = 0)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/group/:id delete 
        * @apiName delete
        * @apiGroup Settings > /group
        * @apiDescription Delete a group by it's id.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/group/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id of the group to delete. 
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
        * @api {get} /{siteID}/group/getusers/:id read users
        * @apiName getusers:id
        * @apiGroup Settings > /group
        * @apiDescription Read all users for a group.
        * @apiPermission agent
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/group/getusers/:id  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id of the group to read.
        *
        * @apiSuccess       {Object[]}      UserProfileViewModel                                UserProfileViewModel
        * @apiSuccess       {Number}        UserProfileViewModel.SiteID                         Your site's account number.
        * @apiSuccess       {Number}        UserProfileViewModel.UserID                         The of the user.
        * @apiSuccess       {String}        UserProfileViewModel.FirstName                      The first name of the user.
        * @apiSuccess       {String}        UserProfileViewModel.LastName                       The last name of the user.
        * @apiSuccess       {String}        UserProfileViewModel.Phone                          The phone number of the user.
        * @apiSuccess       {String}        UserProfileViewModel.Fax                            The fax number of the user.
        * @apiSuccess       {String}        UserProfileViewModel.AlternateEmail                 The alternate email for the user.
        * @apiSuccess       {String}        UserProfileViewModel.HeadshotUrl                    The url where the agent's headshot is hosted.
        * @apiSuccess       {String}        UserProfileViewModel.TimeZone                       The timezone offset for the user.
        * @apiSuccess       {String}        UserProfileViewModel.Language                       The language of the user to be used with google translate.
        * @apiSuccess       {Date}          UserProfileViewModel.LastSystemNotice               The last date and time of the system notice.
        * @apiSuccess       {Date}          UserProfileViewModel.LastLoginFailure               The last date and time of the last login failure.
        * @apiSuccess       {Date}          UserProfileViewModel.LastCheck                      The last date and time of the last check.
        * @apiSuccess       {Date}          UserProfileViewModel.LastSuccessfulLogin            The last date and time of the last successful login.
        * @apiSuccess       {Number}        UserProfileViewModel.ConsecutiveLoginFailures       The number of connesecutive login failures.
        * @apiSuccess       {Boolean}       UserProfileViewModel.VisualAlertsWhenUnavailable    Are viusal alerts displayed when the user is unavailable but logged in?
        * @apiSuccess       {Boolean}       UserProfileViewModel.ShadowNotifications            Are alerts displayed for engagements the user is shadowing?
        * @apiSuccess       {Boolean}       UserProfileViewModel.SoundsWhenUnavailable          Are sounds for alerts played when the user is unavailable but logged in?
        * @apiSuccess       {String}        UserProfileViewModel.SoundsNewEngagement            The sound that is played when the user receives a new engagement.
        * @apiSuccess       {String}        UserProfileViewModel.SoundsNewVisitor               The sound that is played when a new visitor is detected by the visitor monitoring.
        * @apiSuccess       {String}        UserProfileViewModel.SoundsError                    The sound that is played when an error occurs in the agent software.
        * @apiSuccess       {String}        UserProfileViewModel.EngagementFontSize             The font size in pixels for the engagement text as it is displayed in the agent sofware.
        * @apiSuccess       {String}        UserProfileViewModel.ColorsMyText                   The color of agent's text as it is displayed in the agent sofware.
        * @apiSuccess       {String}        UserProfileViewModel.ColorsVisitorText              The color of the visitor's text as it is displayed in the agent software.
        * @apiSuccess       {String}        UserProfileViewModel.ColorsOtherAgentText           The color of other agnet's text as it displayed in the agent software.
        * @apiSuccess       {String}        UserProfileViewModel.ColorsSystemText               The color of the system text as it is displayed in the agent software.
        * @apiSuccess       {Boolean}       UserProfileViewModel.NewEngagementPopupAlert        Is a popup displayed when the user receives a new engagement?
        * @apiSuccess       {String}        UserProfileViewModel.UserName                       The username of the user.
        * @apiSuccess       {String}        UserProfileViewModel.DisplayName                    The display name of the user.
        * @apiSuccess       {Boolean}       UserProfileViewModel.AvailableAtLogin               Is the user available for engagements immediately when they login?
        * @apiSuccess       {Boolean}       UserProfileViewModel.VisitorMonitoringEnabled       Is the user able to monitor visitors in real time, the also requres visitor monitoring code to be deployed?
        * @apiSuccess       {Boolean}       UserProfileViewModel.EnableSystemTrayAlerts         Are system tray alerts allowed by the user?
        * @apiSuccess       {Boolean}       UserProfileViewModel.RepeatSoundAlerts              Are sounds for alerts repeated for the user in the agent software?
        * @apiSuccess       {String}        UserProfileViewModel.LoggedInSinceTimeSpanVerbose   The timespan since the user has been logged in.
        * @apiSuccess       {String}        UserProfileViewModel.LastLoggedInTimeSpanVerbose    The timespane since the user last logged off.
        * @apiSuccess       {Boolean}       UserProfileViewModel.IsAdministrator                Is the user in an administrator role?
        * @apiSuccess       {Boolean}       UserProfileViewModel.IsManager                      Is the user in a manager role?
        * @apiSuccess       {Boolean}       UserProfileViewModel.IsAgent                        Is the user in an agent role?
        * @apiSuccess       {Number}        UserProfileViewModel.Tier                           The tier of the user.
        * @apiSuccess       {String}        UserProfileViewModel.AppVersion                     The version of the application the user is using to log in.
        * @apiSuccess       {Date}          UserProfileViewModel.LoginTime                      The date and time the user last logged in using the agent software.
        * @apiSuccess       {Boolean}       UserProfileViewModel.IsSignalRConnected             Is the user connected to signalR?
        * @apiSuccess       {Boolean}       UserProfileViewModel.IsLoggedIn                     Is the user currently logged into the agent software?  If the user is logged in and not connected to signalR the user is polling for updates.
        * @apiSuccess       {Boolean}       UserProfileViewModel.Available                      Is the user available to receive engagements?
        * @apiSuccess       {Boolean}       UserProfileViewModel.IsBootRequested                Has the user recieved a forced log off?
        * @apiSuccess       {Date}          UserProfileViewModel.LastChatTime                   The date and time of the users' last chat.
        * @apiSuccess       {Boolean}       UserProfileViewModel.IsPending                      Is the users' invitation pending?
        * @apiSuccess       {Date}          UserProfileViewModel.PendingSince                   The date and time of the users' invitation.
        * @apiSuccess       {String}        UserProfileViewModel.PendingSinceVerbose            The verbose date and time of the users' invitation.
        * @apiSuccess       {Number}        UserProfileViewModel.CurrentChats                   The total number of engagements the user currently has.
        * @apiSuccess       Number}         UserProfileViewModel.TotalChats                     The total number of engagements the user has taken.
        * @apiSuccess       {Number}        UserProfileViewModel.ApprovalRating                 The current approval rating of the user, determined by the engagement ratings.
        * @apiSuccess       {Number}        UserProfileViewModel.HoursAvailable                 The total number of hours the user has been available.
        * @apiSuccess       {Number}        UserProfileViewModel.MaxChats                       The total number of concurrent engagements the user is allowed to have.
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
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        */
        #endregion
        public void GetUsers(int groupId, int siteID = 0)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/group/adduser create group user
        * @apiName postgroupuser
        * @apiGroup Settings > /group
        * @apiDescription Add a user to this group.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/group/adduser  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"GroupID":1,"UserName":"bob","AvailableAtLogin":true,"IsAdministrator":false,"IsManager":false,"IsAgent":true,"Tier":2}"
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        UserGroup                                           the usergroup object
        * @apiParam         {Number}        UserGroup.GroupID                                   The id of the group.
        * @apiParam         {String}        UserGroup.UserName                                  The user name of the user to add to the group. 
        * @apiParam         {Boolean}       UserGroup.AvailableAtLogin                          Is the user available at login for the group?
        * @apiParam         {Boolean}       UserGroup.IsAdministrator                           Is user in the administrator role for the group?
        * @apiParam         {Boolean}       UserGroup.IsManager                                 Is the user in the manager role for the group?
        * @apiParam         {Boolean}       UserGroup.IsAgent                                   Is the user in the agent role for the group?
        * @apiParam         {Number}        UserGroup.Tier                                      Sets the tier the user is in for the group.
        *
        * @apiSuccess       {Object[]}      UserGroup                                           the usergroup object
        * @apiSuccess       {Number}        UserGroup.GroupID                                   The id of the group.
        * @apiSuccess       {String}        UserGroup.GroupName                                 The user friendly name of the group.
        * @apiSuccess       {String}        UserGroup.UserName                                  The user name of the user to add to the group.
        * @apiSuccess       {Boolean}       UserGroup.AvailableAtLogin                          Is the user available at login for the group?
        * @apiSuccess       {Boolean}       UserGroup.IsAdministrator                           Is the user in the administrator role for the group?
        * @apiSuccess       {Boolean}       UserGroup.IsManager                                 Is the user in the manager role for the group?
        * @apiSuccess       {Boolean}       UserGroup.IsAgent                                   Is the user in the agent role for the group?
        * @apiSuccess       {Number}        UserGroup.Tier                                      The tier the user is in for the group.
        * @apiSuccess       {Date}          UserGroup.LastEngagementTime                        The date and time of the last engagement the user has for the group.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"GroupID":1,
        *           "GroupName":"Sales",
        *           "UserName":"bob",
        *           "AvailableAtLogin":true,
        *           "IsAdministrator":false,
        *           "IsManager":false,
        *           "IsAgent":true,
        *           "Tier":2,
        *           "LastEngagementTime":"1/1/2014 12:00 am"
        *           }]
        *     }
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * @apiError NotAuthorized The site the user is a member of doesn't match the site being requested.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        * @apiError NotFound The user was not found.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 404 Not Found
        *     {
        *       "error": "User {UserName} not found."
        *     }              
        */
        #endregion
        public void AddUser(string userGroup)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/group/updateuser update group user
        * @apiName putgroupuser
        * @apiGroup Settings > /group
        * @apiDescription Update a user that is already a memeber of this group.
        * @apiPermission siteAdministrator
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/group/adduser  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"GroupID":1,"UserName":"bob","AvailableAtLogin":true,"IsAdministrator":false,"IsManager":false,"IsAgent":true,"Tier":2}"
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        UserGroup                                           the usergroup object
        * @apiParam         {Number}        UserGroup.GroupID                                   The id of the group.
        * @apiParam         {String}        UserGroup.UserName                                  The user name of the user to add to the group. 
        * @apiParam         {Boolean}       UserGroup.AvailableAtLogin                          Is the user available at login for the group?
        * @apiParam         {Boolean}       UserGroup.IsAdministrator                           Is user in the administrator role for the group?
        * @apiParam         {Boolean}       UserGroup.IsManager                                 Is the user in the manager role for the group?
        * @apiParam         {Boolean}       UserGroup.IsAgent                                   Is the user in the agent role for the group?
        * @apiParam         {Number}        UserGroup.Tier                                      Sets the tier the user is in for the group.
        *
        * @apiSuccess       {Object[]}      UserGroup                                           the usergroup object
        * @apiSuccess       {Number}        UserGroup.GroupID                                   The id of the group.
        * @apiSuccess       {String}        UserGroup.GroupName                                 The user friendly name of the group.
        * @apiSuccess       {String}        UserGroup.UserName                                  The user name of the user to add to the group.
        * @apiSuccess       {Boolean}       UserGroup.AvailableAtLogin                          Is the user available at login for the group?
        * @apiSuccess       {Boolean}       UserGroup.IsAdministrator                           Is the user in the administrator role for the group?
        * @apiSuccess       {Boolean}       UserGroup.IsManager                                 Is the user in the manager role for the group?
        * @apiSuccess       {Boolean}       UserGroup.IsAgent                                   Is the user in the agent role for the group?
        * @apiSuccess       {Number}        UserGroup.Tier                                      The tier the user is in for the group.
        * @apiSuccess       {Date}          UserGroup.LastEngagementTime                        The date and time of the last engagement the user has for the group.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"GroupID":1,
        *           "GroupName":"Sales",
        *           "UserName":"bob",
        *           "AvailableAtLogin":true,
        *           "IsAdministrator":false,
        *           "IsManager":false,
        *           "IsAgent":true,
        *           "Tier":2,
        *           "LastEngagementTime":"1/1/2014 12:00 am"
        *           }]
        *     } 
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * @apiError NotAuthorized The site the user is a member of doesn't match the site being requested.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        *
        * @apiError NotFoundGroup The user was not found in this group.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 404 Not Found
        *     {
        *       "error": "User {UserName} not found in this group."
        *     }                        
        * 
        * @apiError NotFound The user was not found.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 404 Not Found
        *     {
        *       "error": "User {UserName} not found."
        *     }              
        */
        #endregion
        public void UpdateUser(string userGroup)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/Group/removeuser delete user group
        * @apiName deleteusergroup
        * @apiGroup Settings > /group
        * @apiDescription Remove a user from this group.
        * @apiPermission siteAdministrator
        *
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/group/removeuser  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"GroupID":1,"UserName":"bob","AvailableAtLogin":true,"IsAdministrator":false,"IsManager":false,"IsAgent":true,"Tier":2}"
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        UserGroup                                           the usergroup object
        * @apiParam         {Number}        UserGroup.GroupID                                   The id of the group.
        * @apiParam         {String}        UserGroup.UserName                                  The user name of the user to add to the group. 
        * @apiParam         {Boolean}       UserGroup.AvailableAtLogin                          Is the user available at login for the group?
        * @apiParam         {Boolean}       UserGroup.IsAdministrator                           Is user in the administrator role for the group?
        * @apiParam         {Boolean}       UserGroup.IsManager                                 Is the user in the manager role for the group?
        * @apiParam         {Boolean}       UserGroup.IsAgent                                   Is the user in the agent role for the group?
        * @apiParam         {Number}        UserGroup.Tier                                      Sets the tier the user is in for the group.
        *
        *
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * @apiError NotAuthorized The site the user is a member of doesn't match the site being requested.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        *
        * @apiError NotFoundGroup The user was not found in this group.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 404 Not Found
        *     {
        *       "error": "User {UserName} not found in this group."
        *     }                        
        * 
        * @apiError NotFound The user was not found.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 404 Not Found
        *     {
        *       "error": "User {UserName} not found."
        *     }              
        */
        #endregion
        public void RemoveUser(string userGroup)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/group/configurationproperty update configuration property
        * @apiName updateconfigurationproperty
        * @apiGroup Settings > /group
        * @apiDescription Update a configuration property for this group.
        * @apiPermission siteAdministrator
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/group/configurationproperty  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"GroupID":1,"Property":"InlineWindowUploadText","Value":"upload file"} 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        ConfigProperty                                      the configurationproperty object
        * @apiParam         {Number}        ConfigProperty.GroupID                              The group id of the property.
        * @apiParam         {String}        ConfigProperty.Property                             The name of the property to update.
        * @apiParam         {String}        ConfigProperty.Value                                The value of the property.
        *
        * @apiSuccess       {Object}        ConfigProperty                                      the configurationproperty object
        * @apiSuccess       {Number}        ConfigProperty.GroupID                              The group id of the property.
        * @apiSuccess       {String}        ConfigProperty.Property                             The name of the property.
        * @apiSuccess       {String}        ConfigProperty.Value                                The value of the property.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "GroupID":1,
        *           "Property":"InlineWindowUploadText",
        *           "Value":"upload file"
        *     }
        * 
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        *
        */
        #endregion
        public void UpdateConfigurationProperty(string groupConfigurationUpdateProperty)
        {
        }
    }
}