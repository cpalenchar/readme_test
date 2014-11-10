using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class PopoutChatDesignerController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/popoutchatdesigner list
        * @apiName get
        * @apiGroup Settings > /popout chat designer
        * @apiDescription list the poput chats for this site.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/popoutchatdesigner  \
        *       -H "Authorization: Basic {authorizationToken}"
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        *
        * @apiSuccess       {Object[]}      PopoutChatDesignerViewModel                       the popoutchatdesignerviewmodel
        * @apiSuccess       {Number}        PopoutChatDesignerViewModel.GroupID               The group id of the poput chat design.
        * @apiSuccess       {Number}        PopoutChatDesignerViewModel.SkinGalleryItemID     The id of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.SkinTitle             The title of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.SkinDescription       The description of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.PopOutChatJSFile      The javascript file to be used with the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.PopOutChatCSSFile     The css file to be used with the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.ImagePreviewURL       The image preview url for the skin.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"GroupID":1,
        *          "SkinGalleryItemID":1,
        *          "SkinTitle":"sales skin",
        *          "SkinDescription":"New sales skin",
        *          "PopoutChatJSFile":"www.mydomain.com/popoutchatfile.js",
        *          "PopoutchatCSSFile":"www.mydomain.com/popoutchatfile.css",
        *          "ImagePreviewURL":"www.mydomain.com/popoutchatimagepreview.jpg"
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
        * @api {get} /{siteID}/popoutchatcesigner/:groupID read 
        * @apiName get:groupID
        * @apiGroup Settings > /popout chat designer
        * @apiDescription Read the poput chat for this group.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/popoutchatdesigner/:groupID  \
        *       -H "Authorization: Basic {authorizationToken}"
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiParam         {Number}        groupID                                           The id of the group to use to read the popout chat designs. 
        *
        * @apiSuccess       {Object}        PopoutChatDesignerViewModel                       the popoutchatdesignerviewmodel object
        * @apiSuccess       {Number}        PopoutChatDesignerViewModel.GroupID               The group id of the poput chat design.
        * @apiSuccess       {Number}        PopoutChatDesignerViewModel.SkinGalleryItemID     The id of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.SkinTitle             The title of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.SkinDescription       The description of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.PopOutChatJSFile      The javascript file to be used with the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.PopOutChatCSSFile     The css file to be used with the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.ImagePreviewURL       The image preview url for the skin.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "GroupID":1,
        *          "SkinGalleryItemID":1,
        *          "SkinTitle":"sales skin",
        *          "SkinDescription":"New sales skin",
        *          "PopoutChatJSFile":"www.mydomain.com/popoutchatfile.js",
        *          "PopoutchatCSSFile":"www.mydomain.com/popoutchatfile.css",
        *          "ImagePreviewURL":"www.mydomain.com/popoutchatimagepreview.jpg"
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
        * @api {put} /{siteID}/popoutchatdesigner update
        * @apiName put
        * @apiGroupM Settings > /popout chat designer
        * @apiDescription Update the popout chat design
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/popoutchatdesigner/:groupID  \
        *       -H "Authorization: Basic {authorizationToken}"
        *       -H "Content-Type: application/json" \
        *       -d "{"GroupID":1,"SkinGalleryItemID":1,"SkinTitle":"sales skin","SkinDescription":"New sales skin","PopoutChatJSFile":"www.mydomain.com/popoutchatfile.js","popoutchatCSSFile":"www.mydomain.com/popoutchatfile.css","ImagePreviewURL":"www.mydomain.com/popoutchatimagepreview.jpg"}"
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiSuccess       {Object}        PopoutChatDesignerViewModel                       the popoutchatdesignerviewmodel object
        * @apiSuccess       {Number}        PopoutChatDesignerViewModel.GroupID               The group id of the poput chat design.
        * @apiSuccess       {Number}        PopoutChatDesignerViewModel.SkinGalleryItemID     The id of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.SkinTitle             The title of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.SkinDescription       The description of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.PopOutChatJSFile      The javascript file to be used with the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.PopOutChatCSSFile     The css file to be used with the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.ImagePreviewURL       The image preview url for the skin.
        *
        * @apiSuccess       {Object}        PopoutChatDesignerViewModel                       the popoutchatdesignerviewmodel object
        * @apiSuccess       {Number}        PopoutChatDesignerViewModel.GroupID               The group id of the poput chat design.
        * @apiSuccess       {Number}        PopoutChatDesignerViewModel.SkinGalleryItemID     The id of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.SkinTitle             The title of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.SkinDescription       The description of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.PopOutChatJSFile      The javascript file to be used with the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.PopOutChatCSSFile     The css file to be used with the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.ImagePreviewURL       The image preview url for the skin.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "GroupID":1,
        *          "SkinGalleryItemID":1,
        *          "SkinTitle":"sales skin",
        *          "SkinDescription":"New sales skin",
        *          "PopoutChatJSFile":"www.mydomain.com/popoutchatfile.js",
        *          "PopoutchatCSSFile":"www.mydomain.com/popoutchatfile.css",
        *          "ImagePreviewURL":"www.mydomain.com/popoutchatimagepreview.jpg"
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
        * @api {get} /{siteID}/popoutchatdesigner/restoredefaults/:groupID restore defaults
        * @apiName getrestoredefaults
        * @apiGroup Settings > /popout chat designer
        * @apiDescription Update the popout chat design
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/popoutchatdesigner/restoredefaults/:groupID  \
        *       -H "Authorization: Basic {authorizationToken} 
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiParam         {Number}        groupID                                           The group's unique ID.
        *
        * @apiSuccess       {Object}        PopoutChatDesignerViewModel                       the popoutchatdesignerviewmodel object
        * @apiSuccess       {Number}        PopoutChatDesignerViewModel.GroupID               The group id of the poput chat design.
        * @apiSuccess       {Number}        PopoutChatDesignerViewModel.SkinGalleryItemID     The id of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.SkinTitle             The title of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.SkinDescription       The description of the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.PopOutChatJSFile      The javascript file to be used with the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.PopOutChatCSSFile     The css file to be used with the skin.
        * @apiSuccess       {String}        PopoutChatDesignerViewModel.ImagePreviewURL       The image preview url for the skin.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "GroupID":1,
        *          "SkinGalleryItemID":1,
        *          "SkinTitle":"sales skin",
        *          "SkinDescription":"New sales skin",
        *          "PopoutChatJSFile":"www.mydomain.com/popoutchatfile.js",
        *          "PopoutchatCSSFile":"www.mydomain.com/popoutchatfile.css",
        *          "ImagePreviewURL":"www.mydomain.com/popoutchatimagepreview.jpg"
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
        public void RestoreDefaults(int groupID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/popoutchatdesigner/getpopoutchatcss list css files
        * @apiName getcssfiles
        * @apiGroup Settings > /popout chat designer
        * @apiDescription list the CSS files for this site's popout chat designs
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/popoutchatdesigner/getpopoutchatcss \
        *       -H "Authorization: Basic {authorizationToken}"
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        *
        * @apiSuccess       {String[]}      cssFile                                           An array of css files.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     { "data": ["www.mydomain.com/popoutchatdesigner.css", "www.mydomain.com/popoutchatdesigner_extra.css"]}
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
        public void GetPopOutChatCSS()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/popoutchatdesigner/getpopoutchatcss/:groupID read css file
        * @apiName getcssfile
        * @apiGroup Settings > /popout chat designer
        * @apiDescription Read the CSS files for this group's popout chat designs
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/popoutchatdesigner/getpopoutchatcss/:groupID \
        *       -H "Authorization: Basic {authorizationToken}"
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiParam         {Number}        groupID                                           The id of the group to use to read the css files.
        *
        * @apiSuccess       {String}        cssFile                                           A css files.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     { "data": "www.mydomain.com/popoutchatdesigner.css"}
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
        public void GetPopOutChatCSS(int groupID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/popoutchatdesigner/getpopoutchatjs list javascript files
        * @apiName getjsfiles
        * @apiGroup Settings > /popout chat designer
        * @apiDescription list the javascript files for this site's popout chat designs
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/popoutchatdesigner/getpopoutchatjs \
        *       -H "Authorization: Basic {authorizationToken}"
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        *
        * @apiSuccess       {String[]}      jsFile                                            An array of js files.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     { "data": ["www.mydomain.com/popoutchatdesigner.js", "www.mydomain.com/popoutchatdesigner_extra.js"]}
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
        public void GetPopOutChatJS()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/popoutchatdesigner/getpopoutchatjs/:groupID read javascript file
        * @apiName getjsfile
        * @apiGroup Settings > /popout chat designer
        * @apiDescription Read the CSS files for this group's popout chat designs
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/popoutchatdesigner/getpopoutchatjs/:groupID \
        *       -H "Authorization: Basic {authorizationToken}"
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiParam         {Number}        groupID                                           The id of the group used to read the poput chat desinger javascript file. 
        *
        * @apiSuccess       {String}        jsFile                                            A javascript file.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     { "data": "www.mydomain.com/popoutchatdesigner.js"}
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
        public void GetPopOutChatJS(int groupID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/popoutchatdesigner/popoutchatcss/:groupID update css file
        * @apiName putcssfile
        * @apiGroup Settings > /popout chat designer
        * @apiDescription Read the CSS files for this group's popout chat designs
        * @apiPermission siteAdministrator
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/popoutchatdesigner/popoutchatcss/:groupID  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{ "data": "www.mydomain.com/popoutchatdesigner.css"}"
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {String}        cssfile                                             The css file for this group's popout chat design.
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
        public void PutPopOutChatCSS(int groupID, string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/popoutchatdesigner/popoutchatjs/:groupID Update CSS File
        * @apiName putjsfile
        * @apiGroup Settings > /popout chat designer
        * @apiDescription Read the CSS files for this group's popout chat designs
        * @apiPermission siteAdministrator
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/popoutchatdesigner/popoutchatjs/:groupID  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{ "data": "www.mydomain.com/popoutchatdesigner.js}"
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {String}        jsfile                                              The javascript file for this group's popout chat design.
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
        public void PutPopOutChatJS(int groupID, string value)
        {
        }
    }
}