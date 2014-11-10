using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    class InlineChatDesignerController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/inlinechatdesigner read all
        * @apiName get
        * @apiGroup Settings > /inline chat designer
        * @apiDescription Read all the inline chat designs for a site.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}          Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/inlinechatdesigner  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                                                          Your site's account number.
        *
        * @apiSuccess       {Object[]}      InlineChatDesignerViewModel                                                     the inlinechatdesignerviewmodel object
        * @apiSuccess       {Number}        InlineChatDesignerViewModel.GroupID                                             The group id of the inline chat design.
        * @apiSuccess       {Number}        InlineChatDesignerViewModel.InlineWindowPicturePreference                       The picture preference of the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowChatRatingEnabled                       Is the chat rating button enabled in the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowChatRatingText                          The text of the rating button in the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDeisgnerViewModel.InlineWindowPrintEnabled                            Is the print button enabled for the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowPrintText                               The text for the print button for the linline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowEmailEnabled                            Is the email button enabled for the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowEmailText                               The text of the email button for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowEndChatText                             The text of the end chat button for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowOperatorText                            The text displayed for the agents' messages for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowVisitorText                             The text displayed for the visitors' messages for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowWelcomeMessage                          The welcome message that is displayed for the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowLineRatingEnabled                       Is the line rating button enabled for the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowUploadEnabled                           Is the upload button enabled for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowUploadText                              The text for the upload buttonfor the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowTypingIndicatorEnabled                  Is the typing indicator enabled for the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowTypingIndicatorText                     The text to display when the agent is typing if it is enabled for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowCSSFile                                 The name of the inline window css file for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.IntroductionText                                    The introduction text for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesingerViewModel.InlineWindowExternalCSSFile                         The url of an external css file to be used with the inline chat design.
        * @apiSuccess       {String[]}      InlineChatDesignerViewModel.InlineWindowExternalJSFile                          An array of urls of external js files to be used with the inline chat design.
        * @apiSuccess       {Number}        InlineChatDesignerViewModel.InLineChatAvatarType                                The type of avatar to display in the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InLineChatFacebookVisible                           Is the facebook link visible in the inline chat design?
        * @apiSuccess       {Boolean}       InlineChatDesingerViewModel.InLineChatTwitterVisible                            Is the twitter link visible in the inline chat design?
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InLineChatGooglePlusVisible                         Is the google plus link visible in the inline chat design?
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InLineChatLinkedInVisible                           Is the linked in link visible in the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.TitleAvailableText                                  The text in the title bar when an agent is available in the inline chat design.
        * @apiSuccess       {String}        InlinechatDesignerViewModel.TitleUnavailableText                                The text in the title bar when an agent is not available in the inline chat design.
        *    
        * @apiSuccessExample    {json}      Success-Response:
        *     HTTP/1.1 200 OK
        *     { 
        *          [{"GroupID":1,
        *          "InlineWindowPicturePreference":1,
        *          "InlineWindowChatRatingEnabled":true,
        *          "InlineWindowChatRatingText":"rate us",
        *          "IinlineWindowPrintEnabled":true,
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
        *          "InlineWindowExternalCSSFile":"www.mydomain.com/inlinewindowexternalcssfile.css",
        *          "InlineWindowExternalJSFile":"www.mydomain.com/inlinewindowexternaljsfile.js",
        *          "InlineChatAvartarType":1,
        *          "InlineChatFacebookVisible":true,
        *          "InlineChatTwitterVisible":true,
        *          "InlineChatGooglePlusVisible":true,
        *          "InlineChatLinkedInVisible":true, 
        *          "TitleAvailableText":"available text",
        *          "TitleUnavailableText": "unavailable text"
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
        * @api {get} /{siteID}/inlinechatdesigner/:groupID read
        * @apiName get:groupID
        * @apiGroup Settings > /inline chat designer
        * @apiDescription Read the inline chat designs for a group.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/inlinechatdesigner:groupID  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                                                          Your site's account number.
        * @apiParam         {Number}        groupID                                                                         The id of the group to use to read the inline chat designer esettings.
        *
        * @apiSuccess       {Object}        InlineChatDesignerViewModel                                                     the inlinechatdesignerviewmodel object
        * @apiSuccess       {Number}        InlineChatDesignerViewModel.GroupID                                             The group id of the inline chat design.
        * @apiSuccess       {Number}        InlineChatDesignerViewModel.InlineWindowPicturePreference                       The picture preference of the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowChatRatingEnabled                       Is the chat rating button enabled in the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowChatRatingText                          The text of the rating button in the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDeisgnerViewModel.InlineWindowPrintEnabled                            Is the print button enabled for the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowPrintText                               The text for the print button for the linline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowEmailEnabled                            Is the email button enabled for the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowEmailText                               The text of the email button for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowEndChatText                             The text of the end chat button for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowOperatorText                            The text displayed for the agents' messages for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowVisitorText                             The text displayed for the visitors' messages for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowWelcomeMessage                          The welcome message that is displayed for the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowLineRatingEnabled                       Is the line rating button enabled for the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowUploadEnabled                           Is the upload button enabled for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowUploadText                              The text for the upload buttonfor the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowTypingIndicatorEnabled                  Is the typing indicator enabled for the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowTypingIndicatorText                     The text to display when the agent is typing if it is enabled for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowCSSFile                                 The name of the inline window css file for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.IntroductionText                                    The introduction text for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesingerViewModel.InlineWindowExternalCSSFile                         The url of an external css file to be used with the inline chat design.
        * @apiSuccess       {String[]}      InlineChatDesignerViewModel.InlineWindowExternalJSFile                          An array of urls of external js files to be used with the inline chat design.
        * @apiSuccess       {Number}        InlineChatDesignerViewModel.InLineChatAvatarType                                The type of avatar to display in the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InLineChatFacebookVisible                           Is the facebook link visible in the inline chat design?
        * @apiSuccess       {Boolean}       InlineChatDesingerViewModel.InLineChatTwitterVisible                            Is the twitter link visible in the inline chat design?
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InLineChatGooglePlusVisible                         Is the google plus link visible in the inline chat design?
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InLineChatLinkedInVisible                           Is the linked in link visible in the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.TitleAvailableText                                  The text in the title bar when an agent is available in the inline chat design.
        * @apiSuccess       {String}        InlinechatDesignerViewModel.TitleUnavailableText                                The text in the title bar when an agent is not available in the inline chat design.
        *    
        * @apiSuccessExample    {json}      Success-Response:
        *     HTTP/1.1 200 OK
        *     { 
        *          "GroupID":1,
        *          "InlineWindowPicturePreference":1,
        *          "InlineWindowChatRatingEnabled":true,
        *          "InlineWindowChatRatingText":"rate us",
        *          "IinlineWindowPrintEnabled":true,
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
        *          "InlineWindowExternalCSSFile":"www.mydomain.com/inlinewindowexternalcssfile.css",
        *          "InlineWindowExternalJSFile":"www.mydomain.com/inlinewindowexternaljsfile.js",
        *          "InlineChatAvartarType":1,
        *          "InlineChatFacebookVisible":true,
        *          "InlineChatTwitterVisible":true,
        *          "InlineChatGooglePlusVisible":true,
        *          "InlineChatLinkedInVisible":true, 
        *          "TitleAvailableText":"available text",
        *          "TitleUnavailableText": "unavailable text"
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
        public void Get(int groupID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/inlinechatdesigner update
        * @apiName put
        * @apiGroup Settings > /inline chat designer
        * @apiDescription Update the inline chat design for a group.
        * @apiPermission siteManager
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/cannedresponse  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d {"GroupID":1,"InlineWindowPicturePreference":1,"InlineWindowChatRatingEnabled":true,"InlineWindowChatRatingText":"rate us","IinlineWindowPrintEnabled":true,"InlineWindowPrintText":"print","InlineWindowEmailEnabled":true,"InlineWindowEmailText":"email","InlineWindowEndChatText":"end chat","InlineWindowOperatorText":"operator","InlineWindowVisitorText":"you","InlineWindowWelcomeMessage":"Hello, How can I help you today?","InlineWindowLineRatingEnabled":true,"InlineWindowUploadEnabled":true,"InlineWindowUploadText":"uplaod file","InlineWindowTypingIndicatorEnabled":true,"InlineWindowTypingIndicatorText":"is typing","InlineWindowCSSFile":"www.mydomain.com/inlinewindowcssfile.css","IntroductionText":"Please send us a message to begin chatting.","InlineWindowExternalCSSFile":"www.mydomain.com/inlinewindowexternalcssfile.css","InlineWindowExternalJSFile":"www.mydomain.com/inlinewindowexternaljsfile.js","InlineChatAvartarType":1,"InlineChatFacebookVisible":true,"InlineChatTwitterVisible":true,"InlineChatGooglePlusVisible":true,"InlineChatLinkedInVisible":true,"TitleAvailableText":"available text","TitleUnavailableText": "unavailable text"
        * 
        * @apiParam         {Number}        siteID                                                                          Your site's account number.
        * @apiParam         {Object}        InlineChatDesignerViewModel                                                     the inlinechatdesignerviewmodel object
        * @apiParam         {Number}        InlineChatDesignerViewModel.GroupID                                             The group id of the inline chat design.
        * @apiParam         {Number}        InlineChatDesignerViewModel.InlineWindowPicturePreference                       The picture preference of the inline chat design.
        * @apiParam         {Boolean}       InlineChatDesignerViewModel.InlineWindowChatRatingEnabled                       Is the chat rating button enabled in the inline chat design?
        * @apiParam         {String}        InlineChatDesignerViewModel.InlineWindowChatRatingText                          The text of the rating button in the inline chat design.
        * @apiParam         {Boolean}       InlineChatDeisgnerViewModel.InlineWindowPrintEnabled                            Is the print button enabled for the inline chat design?
        * @apiParam         {String}        InlineChatDesignerViewModel.InlineWindowPrintText                               The text for the print button for the linline chat design.
        * @apiParam         {Boolean}       InlineChatDesignerViewModel.InlineWindowEmailEnabled                            Is the email button enabled for the inline chat design?
        * @apiParam         {String}        InlineChatDesignerViewModel.InlineWindowEmailText                               The text of the email button for the inline chat design.
        * @apiParam         {String}        InlineChatDesignerViewModel.InlineWindowEndChatText                             The text of the end chat button for the inline chat design.
        * @apiParam         {String}        InlineChatDesignerViewModel.InlineWindowOperatorText                            The text displayed for the agents' messages for the inline chat design.
        * @apiParam         {String}        InlineChatDesignerViewModel.InlineWindowVisitorText                             The text displayed for the visitors' messages for the inline chat design.
        * @apiParam         {String}        InlineChatDesignerViewModel.InlineWindowWelcomeMessage                          The welcome message that is displayed for the inline chat design.
        * @apiParam         {Boolean}       InlineChatDesignerViewModel.InlineWindowLineRatingEnabled                       Is the line rating button enabled for the inline chat design.
        * @apiParam         {Boolean}       InlineChatDesignerViewModel.InlineWindowUploadEnabled                           Is the upload button enabled for the inline chat design.
        * @apiParam         {String}        InlineChatDesignerViewModel.InlineWindowUploadText                              The text for the upload buttonfor the inline chat design.
        * @apiParam         {Boolean}       InlineChatDesignerViewModel.InlineWindowTypingIndicatorEnabled                  Is the typing indicator enabled for the inline chat design?
        * @apiParam         {String}        InlineChatDesignerViewModel.InlineWindowTypingIndicatorText                     The text to display when the agent is typing if it is enabled for the inline chat design.
        * @apiParam         {String}        InlineChatDesignerViewModel.InlineWindowCSSFile                                 The name of the inline window css file for the inline chat design.
        * @apiParam         {String}        InlineChatDesignerViewModel.IntroductionText                                    The introduction text for the inline chat design.
        * @apiParam         {String}        InlineChatDesingerViewModel.InlineWindowExternalCSSFile                         The url of an external css file to be used with the inline chat design.
        * @apiParam         {String[]}      InlineChatDesignerViewModel.InlineWindowExternalJSFile                          An array of urls of external js files to be used with the inline chat design.
        * @apiParam         {Number}        InlineChatDesignerViewModel.InLineChatAvatarType                                The type of avatar to display in the inline chat design.
        * @apiParam         {Boolean}       InlineChatDesignerViewModel.InLineChatFacebookVisible                           Is the facebook link visible in the inline chat design?
        * @apiParam         {Boolean}       InlineChatDesingerViewModel.InLineChatTwitterVisible                            Is the twitter link visible in the inline chat design?
        * @apiParam         {Boolean}       InlineChatDesignerViewModel.InLineChatGooglePlusVisible                         Is the google plus link visible in the inline chat design?
        * @apiParam         {Boolean}       InlineChatDesignerViewModel.InLineChatLinkedInVisible                           Is the linked in link visible in the inline chat design?
        * @apiParam         {String}        InlineChatDesignerViewModel.TitleAvailableText                                  The text in the title bar when an agent is available in the inline chat design.
        * @apiParam         {String}        InlinechatDesignerViewModel.TitleUnavailableText                                The text in the title bar when an agent is not available in the inline chat design.
        *
        * @apiSuccess       {Object}        InlineChatDesignerViewModel                                                     the inlinechatdesignerviewmodel object
        * @apiSuccess       {Number}        InlineChatDesignerViewModel.GroupID                                             The group id of the inline chat design.
        * @apiSuccess       {Number}        InlineChatDesignerViewModel.InlineWindowPicturePreference                       The picture preference of the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowChatRatingEnabled                       Is the chat rating button enabled in the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowChatRatingText                          The text of the rating button in the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDeisgnerViewModel.InlineWindowPrintEnabled                            Is the print button enabled for the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowPrintText                               The text for the print button for the linline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowEmailEnabled                            Is the email button enabled for the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowEmailText                               The text of the email button for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowEndChatText                             The text of the end chat button for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowOperatorText                            The text displayed for the agents' messages for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowVisitorText                             The text displayed for the visitors' messages for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowWelcomeMessage                          The welcome message that is displayed for the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowLineRatingEnabled                       Is the line rating button enabled for the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowUploadEnabled                           Is the upload button enabled for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowUploadText                              The text for the upload buttonfor the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowTypingIndicatorEnabled                  Is the typing indicator enabled for the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowTypingIndicatorText                     The text to display when the agent is typing if it is enabled for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowCSSFile                                 The name of the inline window css file for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.IntroductionText                                    The introduction text for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesingerViewModel.InlineWindowExternalCSSFile                         The url of an external css file to be used with the inline chat design.
        * @apiSuccess       {String[]}      InlineChatDesignerViewModel.InlineWindowExternalJSFile                          An array of urls of external js files to be used with the inline chat design.
        * @apiSuccess       {Number}        InlineChatDesignerViewModel.InLineChatAvatarType                                The type of avatar to display in the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InLineChatFacebookVisible                           Is the facebook link visible in the inline chat design?
        * @apiSuccess       {Boolean}       InlineChatDesingerViewModel.InLineChatTwitterVisible                            Is the twitter link visible in the inline chat design?
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InLineChatGooglePlusVisible                         Is the google plus link visible in the inline chat design?
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InLineChatLinkedInVisible                           Is the linked in link visible in the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.TitleAvailableText                                  The text in the title bar when an agent is available in the inline chat design.
        * @apiSuccess       {String}        InlinechatDesignerViewModel.TitleUnavailableText                                The text in the title bar when an agent is not available in the inline chat design.
        *    
        * @apiSuccessExample    {json}      Success-Response:
        *     HTTP/1.1 200 OK
        *     { 
        *          "GroupID":1,
        *          "InlineWindowPicturePreference":1,
        *          "InlineWindowChatRatingEnabled":true,
        *          "InlineWindowChatRatingText":"rate us",
        *          "IinlineWindowPrintEnabled":true,
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
        *          "InlineWindowExternalCSSFile":"www.mydomain.com/inlinewindowexternalcssfile.css",
        *          "InlineWindowExternalJSFile":"www.mydomain.com/inlinewindowexternaljsfile.js",
        *          "InlineChatAvartarType":1,
        *          "InlineChatFacebookVisible":true,
        *          "InlineChatTwitterVisible":true,
        *          "InlineChatGooglePlusVisible":true,
        *          "InlineChatLinkedInVisible":true, 
        *          "TitleAvailableText":"available text",
        *          "TitleUnavailableText": "unavailable text"
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
        public void Put(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/inlinechatdesigner/restoredefaults/:groupID restore defaults
        * @apiName restoredefaults:groupID
        * @apiGroup Settings > /inline chat designer
        * @apiDescription Restore the group's inline chat design to default settings
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/inlinechatdesigner/restoredefaults/:groupID \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                                                          Your site's account number.
        * @apiParam         {Number}        groupID                                                                         The id of the group to use to restore default setting for the inline chat.
        *
        * @apiSuccess       {Object}        InlineChatDesignerViewModel                                                     the inlinechatdesignerviewmodel object
        * @apiSuccess       {Number}        InlineChatDesignerViewModel.GroupID                                             The group id of the inline chat design.
        * @apiSuccess       {Number}        InlineChatDesignerViewModel.InlineWindowPicturePreference                       The picture preference of the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowChatRatingEnabled                       Is the chat rating button enabled in the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowChatRatingText                          The text of the rating button in the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDeisgnerViewModel.InlineWindowPrintEnabled                            Is the print button enabled for the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowPrintText                               The text for the print button for the linline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowEmailEnabled                            Is the email button enabled for the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowEmailText                               The text of the email button for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowEndChatText                             The text of the end chat button for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowOperatorText                            The text displayed for the agents' messages for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowVisitorText                             The text displayed for the visitors' messages for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowWelcomeMessage                          The welcome message that is displayed for the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowLineRatingEnabled                       Is the line rating button enabled for the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowUploadEnabled                           Is the upload button enabled for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowUploadText                              The text for the upload buttonfor the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InlineWindowTypingIndicatorEnabled                  Is the typing indicator enabled for the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowTypingIndicatorText                     The text to display when the agent is typing if it is enabled for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.InlineWindowCSSFile                                 The name of the inline window css file for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesignerViewModel.IntroductionText                                    The introduction text for the inline chat design.
        * @apiSuccess       {String}        InlineChatDesingerViewModel.InlineWindowExternalCSSFile                         The url of an external css file to be used with the inline chat design.
        * @apiSuccess       {String[]}      InlineChatDesignerViewModel.InlineWindowExternalJSFile                          An array of urls of external js files to be used with the inline chat design.
        * @apiSuccess       {Number}        InlineChatDesignerViewModel.InLineChatAvatarType                                The type of avatar to display in the inline chat design.
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InLineChatFacebookVisible                           Is the facebook link visible in the inline chat design?
        * @apiSuccess       {Boolean}       InlineChatDesingerViewModel.InLineChatTwitterVisible                            Is the twitter link visible in the inline chat design?
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InLineChatGooglePlusVisible                         Is the google plus link visible in the inline chat design?
        * @apiSuccess       {Boolean}       InlineChatDesignerViewModel.InLineChatLinkedInVisible                           Is the linked in link visible in the inline chat design?
        * @apiSuccess       {String}        InlineChatDesignerViewModel.TitleAvailableText                                  The text in the title bar when an agent is available in the inline chat design.
        * @apiSuccess       {String}        InlinechatDesignerViewModel.TitleUnavailableText                                The text in the title bar when an agent is not available in the inline chat design.
        *    
        * @apiSuccessExample    {json}      Success-Response:
        *     HTTP/1.1 200 OK
        *     { 
        *          "GroupID":1,
        *          "InlineWindowPicturePreference":1,
        *          "InlineWindowChatRatingEnabled":true,
        *          "InlineWindowChatRatingText":"rate us",
        *          "IinlineWindowPrintEnabled":true,
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
        *          "InlineWindowExternalCSSFile":"www.mydomain.com/inlinewindowexternalcssfile.css",
        *          "InlineWindowExternalJSFile":"www.mydomain.com/inlinewindowexternaljsfile.js",
        *          "InlineChatAvartarType":1,
        *          "InlineChatFacebookVisible":true,
        *          "InlineChatTwitterVisible":true,
        *          "InlineChatGooglePlusVisible":true,
        *          "InlineChatLinkedInVisible":true, 
        *          "TitleAvailableText":"available text",
        *          "TitleUnavailableText": "unavailable text"
        *     }
        * 
        * @apiSuccessExample    {json}      Success-Response:
        *     HTTP/1.1 200 OK
        *     { "groupID": 1, "inlineWindowPicturePreference": 1, "inlineWindowChatRatingEnabled": true, "inlineWindowChatRatingText": "rate us", "inlineWindowPrintEnabled": true, "inlineWindowPrintText": "print", "inlineWindowEmailEnabled": true, "inlineWindowEmailText": "email", "inlineWindowEndChatText": "end chat", "inlineWindowOperatorText": "operator", "inlineWindowVisitorText", "you", "inlineWindowWelcomeMessage": "Hello, How can I help you today?", "inlineWindowLineRatingEnabled": true, "inlineWindowUploadEnabled": true, "inlineWindowUploadText": "uplaod file", "inlineWindowTypingIndicatorEnabled": true, "inlineWindowTypingIndicatorText", "is typing", "inlineWindowCSSFile": "www.mydomain.com/inlinewindowcssfile.css", "introductionText": "Please send us a message to begin chatting.", "inlineWindowExternalCSSFile": "www.mydomain.com/inlinewindowexternalcssfile.css", "inlineWindowExternalJSFile": "www.mydomain.com/inlinewindowexternaljsfile.js", "inlineChatAvartarType": 1, "inlineChatFacebookVisible": true, "inlineChatTwitterVisible": true, "inlineChatGooglePlusVisible": true, "inlineChatLinkedInVisible": true, "titleAvailableText": "available text", "titleUnavailableText": "unavailable text"}"
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
        public void RestoreDefaults(int groupID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/inlinechatdesigner/inlinechatcss read all inline chat css files
        * @apiName getallinlinechatcssfiles
        * @apiGroup Settings > /inline chat designer
        * @apiDescription Read the inline chat css files for a site.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/inlinechatdesigner/inlinechatcss  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        *
        * @apiSuccess       {String[]}      inlineChatCSSFile                                    An array of inline chat css files for this site.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     { "data": ["www.mydomain.com/inlinechatdesigner.css", "www.mydomain.com/inlinechatdesigner_extra.css"]}
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
        public void GetInlineChatCSS()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/inlinechatdesigner/inlinechatcss/:groupID read inline chat css file
        * @apiName getinlinechatcssfile
        * @apiGroup Settings > /inline chat designer
        * @apiDescription Read the inline chat css file for a group.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/inlinechatdesigner/inlinechatcss/:groupID  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        groupID                                             The id of the group to use to read the inline chat desinger css files.
        *
        * @apiSuccess       {String[]}      inlineChatCSSFile                                   An array of inline chat css files for this site.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     { "data": ["www.mydomain.com/inlinechatdesigner.css", "www.mydomain.com/inlinechatdesigner_extra.css"]}
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
        public void GetInlineChatCSS(int groupID)
        {
        }


        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/inlinechatdesigner/inlinechatcss update inline chat css file
        * @apiName putinlinechatcssfile
        * @apiGroup Settings > /inline chat designer
        * @apiDescription Update he inline chat css file for a group.
        * @apiPermission siteManager
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/inlinechatdesigner/inlinechatcss  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d { "data": ["www.mydomain.com/inlinechatdesigner.css", "www.mydomain.com/inlinechatdesigner_extra.css"] }
        * 
        * @apiParam         {Number}        siteID                                              The site's unique ID.
        * @apiParam         {Number}        groupID                                             The id of the group to use to read the inline chat desinger css files.
        * @apiParam         {String}        formData                                            The inline chat css file for this group.
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
        public void PutInlineChatCSS(int groupID, string value)
        {
        }
    }
}