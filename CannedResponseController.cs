using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class CannedResponseController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/cannedresponse/gettagsforagentchat/:groupID read tags for agent
        * @apiName gettagsforagentchat
        * @apiGroup SETTINGS > /canned response
        * @apiDescription Read the tag utilizations for the authenticated user in this group.
        * @apiPermission agent
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/cannedresponse/gettagsforagentchat/{groupID}  \
        *       -H "Authorization: Basic {authorizationToken}" 
        *
        * @apiParam         {Number}        SiteID                                                                  Your site's account number.
        * @apiParam         {Number}        GroupID                                                                 The id for the group.
        * 
        * @apiSuccess       {Object[]}      TagUtilizationViewModel                                                 the TagUtlizationViewModel
        * @apiSuccess       {String}        TagUtilizationViewModel.Label                                           The label for the tag.
        * @apiSuccess       {Number}        TagUtilizationViewModel.Utilization                                     The utilization for the tag.
        * @apiSuccess       {Number}        TagUtilizationViewModel.SiteID                                          Your site's account number.
        * @apiSuccess       {Number}        TagUtilizationViewModel.GroupID                                         The id for the group.
        * @apiSuccess       {Number}        TagUtilizationViewModel.UserID                                          The id for the user.
        * @apiSuccess       {Object[]}      TagUtilizationViewModel.CannedResponseViewModel                         the CannedResponseViewModel
        * @apiSuccess       {Number}        TagUtilizationViewModel.CannedResponseViewModel.PremadeMessageID        The id of the premade message.
        * @apiSuccess       {Number}        TagUtilizationViewModel.CannedResponseViewModel.SiteID                  Your site's account number.
        * @apiSuccess       {Number}        TagUtilizationViewModel.CannedResponseViewModel.GroupID                 The id for the group of the canned response.
        * @apiSuccess       {Number}        TagUtilizationViewModel.CannedResponseViewModel.UserID                  The id for the user of the canned response.
        * @apiSuccess       {String}        TagUtilizationViewModel.CannedResponseViewModel.Message                 The body of the canned response.
        * @apiSuccess       {Number}        TagUtilizationViewModel.CannedResponseViewModel.SortOrder               The sort order of the canned response
        * @apiSuccess       {String[]}      TagUtilizationViewModel.CannedResponseViewModel.TagList                 The list of tags assoicated with the canned response.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "Label":"canned response label",
        *          "Utilization":56,
        *          "SiteID":1,
        *          "GroupID":1,
        *          "UserID":1,
        *          "PremadeMessages":[
        *              {"PremadeMessageID":1,
        *              "SiteID":1,
        *              "GroupID":1,
        *              "UserID",
        *              "Message":"Premade message",
        *              "SortOrder":1,
        *              "TagList":["Sales","Service"]
        *          }]
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
        public void GetTagsForAgentChat(int siteID, int groupID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/cannedresponse/gettagutilizationbygroup/:groupID read tag utilization by group
        * @apiName gettagutilizationBygroup
        * @apiGroup SETTINGS > /canned response
        * @apiDescription Read the tag utilizations for a group.
        * @apiPermission agent
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{SiteID}/cannedresponse/gettagutilizationbygroup/{groupID}  \
        *       -H "Authorization: Basic {authorizationToken}" 
        *
        * @apiParam         {Number}        siteID                                                                  Your site's account number.
        * @apiParam         {Number}        groupID                                                                 The id for the group.
        * 
        * @apiSuccess       {Object[]}      TagUtilizationViewModel                                                 the tagutilizationviewmodel
        * @apiSuccess       {String}        TagUtilizationViewModel.Label                                           The label for the tag.
        * @apiSuccess       {Number}        TagUtilizationViewModel.Utilization                                     The utilization for the tag.
        * @apiSuccess       {Number}        TagUtilizationViewModel.SiteID                                          Your site's account number.
        * @apiSuccess       {Number}        TagUtilizationViewModel.GroupID                                         The id of the group.
        * @apiSuccess       {Number}        TagUtilizationViewModel.UserID                                          The id of the user.
        * @apiSuccess       {Object[]}      TagUtilizationViewModel.CannedResponseViewModel                         the cannedresponseviewmodel
        * @apiSuccess       {Number}        TagUtilizationViewModel.CannedResponseViewModel.PremadeMessageID        The id of the premade message.
        * @apiSuccess       {Number}        TagUtilizationViewModel.CannedResponseViewModel.SiteID                  Your site's account number.
        * @apiSuccess       {Number}        TagUtilizationViewModel.CannedResponseViewModel.GroupID                 The id for the group of the canned response.
        * @apiSuccess       {Number}        TagUtilizationViewModel.CannedResponseViewModel.UserID                  The id for the user of the canned response.
        * @apiSuccess       {String}        TagUtilizationViewModel.CannedResponseViewModel.Message                 The body of the canned response.
        * @apiSuccess       {Number}        TagUtilizationViewModel.CannedResponseViewModel.SortOrder               The sort order of the canned response
        * @apiSuccess       {String[]}      TagUtilizationViewModel.CannedResponseViewModel.TagList                 The list of tags assoicated with the canned response.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{
        *               "Label":"canned response label",
        *               "Utilization":56,
        *               "SiteID":1,
        *               "GroupID":1,
        *               "UserID":1,
        *               "PremadeMessages":[{
        *                   "PremadeMessageID":1,
        *                   "SiteID":1,
        *                   "GroupID":1,
        *                   "UserID",
        *                   "Message":"Premade message",
        *                   "SortOrder":1,
        *                   "TagList":["Sales","Service"]
        *               }]
         *         }]
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
        public void GetTagUtilizationByGroup(int siteID, int groupID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/cannedresponse/:id read
        * @apiName getcannedresponse
        * @apiGroup SETTINGS > /canned response
        * @apiDescription Read the canned response for this id.
        * @apiPermission agent
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/cannedresponse/:id  \
        *       -H "Authorization: Basic {authorizationToken}" 
        *
        * @apiParam         {Number}        siteID                                      Your site's account number.
        * @apiParam         {Number}        id                                          The id of the canned response to read.
        * 
        * @apiSuccess       {Object}        CannedResponseViewModel                     the cannedresponseviewmodel
        * @apiSuccess       {Number}        CannedResponseViewModel.PremadeMessageID    The id of the premade message.
        * @apiSuccess       {Number}        CannedResponseViewModel.SiteID              Your site's account number.
        * @apiSuccess       {Number}        CannedResponseViewModel.GroupID             The id for the group of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.UserID              The id for the user of the canned response.
        * @apiSuccess       {String}        CannedResponseViewModel.Message             The body of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.SortOrder           The sort order of the canned response
        * @apiSuccess       {String[]}      CannedResponseViewModel.TagList             The list of tags assoicated with the canned response.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "PremadeMessageID": 1,
        *          "SiteID":1,
        *          "GroupID":1,
        *          "UserID":1,
        *          "Message":"Premade message",
        *          "SortOrder":1,
        *          "TagList":["Sales","Service"]
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
        //Get a single premade message
        public void Get(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/cannedresponse/getbysite read all
        * @apiName getbysite
        * @apiGroup SETTINGS > /canned response
        * @apiDescription Read all the canned responses for a site.
        * @apiPermission agent
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/cannedresponse/getbysite  \
        *       -H "Authorization: Basic {authorizationToken}" 
        *       
        * @apiParam         {Number}        siteID                                          Your site's account number.
        * 
        * @apiSuccess       {Object[]}      CannedResponseViewModel                         CannedResponseViewModel
        * @apiSuccess       {Number}        CannedResponseViewModel.PremadeMessageID        The id of the premade message.
        * @apiSuccess       {Number}        CannedResponseViewModel.SiteID                  Your site's account number.
        * @apiSuccess       {Number}        CannedResponseViewModel.GroupID                 The id for the group of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.UserID                  The id for the user of the canned response.
        * @apiSuccess       {String}        CannedResponseViewModel.Message                 The body of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.SortOrder               The sort order of the canned response
        * @apiSuccess       {String[]}      CannedResponseViewModel.TagList                 The list of tags assoicated with the canned response.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{
        *          "PremadeMessageID": 1,
        *          "SiteID":1,
        *          "GroupID":1,
        *          "UserID":1,
        *          "Message":"Premade message",
        *          "SortOrder":1,
        *          "TagList":["Sales","Service"]
        *          }]
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
        public void GetBySite(int siteID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/cannedresponse/getbygroup/:groupID read by group
        * @apiName getbygroup
        * @apiGroup SETTINGS > /canned response
        * @apiDescription Read all the canned respones for this group.
        * @apiPermission agent
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{SiteID}/cannedresponse/getbygroup/:GroupID \
        *       -H "Authorization: Basic {authorizationToken}" 
        *
        * @apiParam         {Number}        SiteID                                          Your site's account number.
        * @apiParam         {Number}        GroupID                                         The id for the group.
        * 
        * @apiSuccess       {Object[]}      CannedResponseViewModel                         the cannedresponseviewmodel
        * @apiSuccess       {Number}        CannedResponseViewModel.PremadeMessageID        The id of the premade message.
        * @apiSuccess       {Number}        CannedResponseViewModel.SiteID                  Your site's account number.
        * @apiSuccess       {Number}        CannedResponseViewModel.GroupID                 The id for the group of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.UserID                  The id for the user of the canned response.
        * @apiSuccess       {String}        CannedResponseViewModel.Message                 The body of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.SortOrder               The sort order of the canned response
        * @apiSuccess       {String[]}      CannedResponseViewModel.TagList                 The list of tags assoicated with the canned response.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"PremadeMessageID": 1,
        *          "SiteID":1,
        *          "GroupID":1,
        *          "UserID":1,
        *          "Message":"Premade message",
        *          "SortOrder":1,
        *          "TagList":["Sales","Service"]
        *          }]
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
        public void GetByGroup(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/cannedresponse/getbyuser/:userID read by user
        * @apiName getbyuser
        * @apiGroup SETTINGS > /canned response
        * @apiDescription Read all the canned responses for this user.
        * @apiPermission agent
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{SiteID}/cannedresponse/gettagutilizationbygroup/:UserID  \
        *       -H "Authorization: Basic {authorizationToken}" 
        *
        * @apiParam         {Number}        SiteID                                                      Your site's account number.
        * @apiParam         {Number}        UserID                                                      The id for ths user.
        * 
        * @apiSuccess       {Object[]}      CannedResponseViewModel                                     the cannedresponseviewmodel
        * @apiSuccess       {Number}        CannedResponseViewModel.PremadeMessageID                    The id of the premade message.
        * @apiSuccess       {Number}        CannedResponseViewModel.SiteID                              Your site's account number.
        * @apiSuccess       {Number}        CannedResponseViewModel.GroupID                             The id for the group of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.UserID                              The id for the user of the canned response.
        * @apiSuccess       {String}        CannedResponseViewModel.Message                             The body of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.SortOrder                           The sort order of the canned response
        * @apiSuccess       {String[]}      CannedResponseViewModel.TagList                             The list of tags assoicated with the canned response.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"PremadeMessageID": 1,
        *          "SiteID":1,
        *          "GroupID":1,
        *          "UserID":1,
        *          "Message":"Premade message",
        *          "SortOrder":1,
        *          "TagList":["Sales","Service"]
        *          }]
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
        public void GetByUser(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/cannedresponse/getbytag/:tag read by tag
        * @apiName getbytag
        * @apiGroup SETTINGS > /canned response
        * @apiDescription Read all the canned respones for this tag
        * @apiPermission agent
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{SiteID}/cannedresponse/gettagutilizationbygroup/:tag  \
        *       -H "Authorization: Basic {authorizationToken}" 
        *
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {String}        tag                                                 The name of the tag.
        * 
        * @apiSuccess       {Object[]}      CannedResponseViewModel                             the cannedresponseviewmodel
        * @apiSuccess       {Number}        CannedResponseViewModel.PremadeMessageID            The id of the premade message.
        * @apiSuccess       {Number}        CannedResponseViewModel.SiteID                      Your site's account number.
        * @apiSuccess       {Number}        CannedResponseViewModel.GroupID                     The id for the group of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.UserID                      The id for the user of the canned response.
        * @apiSuccess       {String}        CannedResponseViewModel.Message                     The body of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.SortOrder                   The sort order of the canned response
        * @apiSuccess       {String[]}      CannedResponseViewModel.TagList                     The list of tags assoicated with the canned response.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"PremadeMessageID": 1,
        *          "SiteID":1,
        *          "GroupID":1,
        *          "UserID":1,
        *          "Message":"Premade message",
        *          "SortOrder":1,
        *          "TagList":["Sales","Service"]
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
        public void GetByTag(int siteID, string tag)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/cannedresponse create
        * @apiName post
        * @apiGroup SETTINGS > /canned response
        * @apiDescription Create a new canned response.
        * @apiPermission agent
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/cannedresponse  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID": 1,"GroupID": 1,"UserID": 1,"Message": "Hello, how may I help you?","SortOrder": 1,"TagList": ["sales, service"]}
        *       
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        groupID                                             The id for the group.
        * @apiParam         {Object}        CannedResponseViewModel                             the cannedresponseviewmodel
        * @apiParam         {Number}        CannedResponseViewModel.SiteID                      The id for the site of the canned response.
        * @apiParam         {Number}        CannedResponseViewModel.GroupID                     The id for the group of the canned response.
        * @apiParam         {Number}        CannedResponseViewModel.UserID                      The id for the user of the canned response.
        * @apiParam         {String}        CannedResponseViewModel.Message                     The body of the canned response.
        * @apiParam         {Number}        CannedResponseViewModel.SortOrder                   The sort order of the canned response
        * @apiParam         {String[]}      CannedResponseViewModel.TagList                     The list of tags assoicated with the canned response.          
        * 
        * @apiSuccess       {Object}        CannedResponseViewModel                             the cannedresponseviewmodel
        * @apiSuccess       {Number}        CannedResponseViewModel.PremadeMessageID            The id of the premade message.
        * @apiSuccess       {Number}        CannedResponseViewModel.SiteID                      The id for the site of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.GroupID                     The id for the group of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.UserID                      The id for the user of the canned response.
        * @apiSuccess       {String}        CannedResponseViewModel.Message                     The body of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.SortOrder                   The sort order of the canned response
        * @apiSuccess       {String[]}      CannedResponseViewModel.TagList                     The list of tags assoicated with the canned response.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "PremadeMessageID": 1,
        *          "SiteID":1,
        *          "GroupID":1,
        *          "UserID":1,
        *          "Message":"Premade message",
        *          "SortOrder":1,
        *          "TagList":["Sales","Service"]
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
        //Add a premade message
        public void Post(int siteID, string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/cannedresponse update
        * @apiName put
        * @apiGroup SETTINGS > /canned response
        * @apiDescription Update a canned response.
        * @apiPermission agent
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/cannedresponse  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID": 1,"GroupID": 1,"UserID": 1,"Message": "Hello, how may I help you?","SortOrder": 1,"TagList": ["sales, service"]}
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        groupID                                             The id for the group.
        * @apiParam         {Object}        CannedResponseViewModel                             the cannedresponseviewmodel
        * @apiParam         {Number}        CannedResponseViewModel.PremadeMessageID            The id for the canned response.
        * @apiParam         {Number}        CannedResponseViewModel.SiteID                      The id for the site of the canned response.
        * @apiParam         {Number}        CannedResponseViewModel.GroupID                     The id for the group of the canned response.
        * @apiParam         {Number}        CannedResponseViewModel.UserID                      The id for the user of the canned response.
        * @apiParam         {String}        CannedResponseViewModel.Message                     The body of the canned response.
        * @apiParam         {Number}        CannedResponseViewModel.SortOrder                   The sort order of the canned response
        * @apiParam         {String[]}      CannedResponseViewModel.TagList                     The list of tags assoicated with the canned response.          
        * 
        * @apiSuccess       {Object}        CannedResponseViewModel                             the cannedresponseviewmodel
        * @apiSuccess       {Number}        CannedResponseViewModel.PremadeMessageID            The id of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.SiteID                      Your site's account number.
        * @apiSuccess       {Number}        CannedResponseViewModel.GroupID                     The id for the group of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.UserID                      The id for the user of the canned response.
        * @apiSuccess       {String}        CannedResponseViewModel.Message                     The body of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.SortOrder                   The sort order of the canned response
        * @apiSuccess       {String[]}      CannedResponseViewModel.TagList                     The list of tags assoicated with the canned response.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "PremadeMessageID": 1,
        *          "SiteID":1,
        *          "GroupID":1,
        *          "UserID":1,
        *          "Message":"Premade message",
        *          "SortOrder":1,
        *          "TagList":["Sales","Service"]
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
        //Update a premade message
        public void Put(int siteID, string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/cannedresponse/:id delete
        * @apiName delete
        * @apiGroup SETTINGS > /canned response
        * @apiDescription Delete a canned response.
        * @apiPermission agent
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{SiteID}/cannedresponse/{id} \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        iD                                                  The id of the canned response to delete.
        *
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        *     
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 404 NotFound
        *     {
        *       "error": "Canned Response {ID} does not exist."
        *     }* 
        */
        #endregion
        //Delete a premade message
        public void Delete(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/cannedresponse/updateall  updateall
        * @apiName putall
        * @apiGroup SETTINGS > /canned response
        * @apiDescription Update an array of canned responses.
        * @apiPermission agent
        *
        *       curl -X PUT https:/main.api.livefluence.com/{SiteID}/cannedresponse/updateall  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{ [{"PremadeMessageID": 1, "SiteID": 1, "GroupID": 1, "UserID": 1, "Message": "Hello, how may I help you?", "SortOrder": 1, "TagList":["sales, service"]},{"PremadeMessageID": 2,"SiteID": 1,"GroupID":1,"UserID":1,"Message":"Thank you, have a nice day.","SortOrder":2,"TagList":["sales, service"]}]"
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object[]}      CannedResponseViewModel                             The cannedresponseviewmodel
        * @apiParam         {Number}        CannedResponseViewModel.PremadeMessageID            The id of the canned response.
        * @apiParam         {Number}        CannedResponseViewModel.SiteID                      Your site's account number.
        * @apiParam         {Number}        CannedResponseViewModel.GroupID                     The id for the group of the canned response.
        * @apiParam         {Number}        CannedResponseViewModel.UserID                      The id for the user of the canned response.
        * @apiParam         {String}        CannedResponseViewModel.Message                     The body of the canned response.
        * @apiParam         {Number}        CannedResponseViewModel.SortOrder                   The sort order of the canned response
        * @apiParam         {String[]}      CannedResponseViewModel.TagList                     The list of tags assoicated with the canned response.          
        * 
        * @apiSuccess       {Object[]}      CannedResponseViewModel                            the cannedresponseviewmodel
        * @apiSuccess       {Number}        CannedResponseViewModel.PremadeMessageID            The id of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.SiteID                      Your site's account number.
        * @apiSuccess       {Number}        CannedResponseViewModel.GroupID                     The id for the group of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.UserID                      The id for the user of the canned response.
        * @apiSuccess       {String}        CannedResponseViewModel.Message                     The body of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.SortOrder                   The sort order of the canned response
        * @apiSuccess       {String[]}      CannedResponseViewModel.TagList                     The list of tags assoicated with the canned response.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     { 
        *          [{
        *              "PremadeMessageID": 1, 
        *              "SiteID": 1, 
        *              "GroupID": 1, 
        *              "UserID": 1, 
        *              "Message": "Hello, how may I help you?", 
        *              "SortOrder": 1, "TagList":["sales, service"]
        *          },
        *          {
        *              "PremadeMessageID":2,
        *              "SiteID":1,
        *              "GroupID":1,
        *              "UserID":1,
        *              "Message":"Thank you, have a nice day.",
        *              "SortOrder":2,
        *              "TagList":["sales, service"]
        *          }]
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
        public void UpdateAll(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/cannedresponse/updatesortorder updatesortorder
        * @apiName putsortorder
        * @apiGroup SETTINGS >  /canned response
        * @apiDescription Update an array of canned responses sort order.
        * @apiPermission agent
        *
        *       curl -X PUT https:/main.api.livefluence.com/{SiteID}/cannedresponse/updatesortorder  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{ [{"PremadeMessgeID": 1, "SortOrder": 1}, {"PremadeMessageID": 2, "SortOrder": 2}]}"
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object[]}      CannedResponseViewModel                             the cannedresponseviewmodel
        * @apiParam         {Number}        CannedResponseViewModel.PremadeMessageID            The id of the canned response.
        * @apiParam         {Number}        CannedResponseViewModel.SortOrder                   The sort order of the canned response
        * 
        * @apiSuccess       {Object[]}        CannedResponseViewModel                             the cannedresponseviewmodel
        * @apiSuccess       {Number}        CannedResponseViewModel.PremadeMessageID            The id of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.SiteID                      Your site's account number.
        * @apiSuccess       {Number}        CannedResponseViewModel.GroupID                     The id for the group of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.UserID                      The id for the user of the canned response.
        * @apiSuccess       {String}        CannedResponseViewModel.Message                     The body of the canned response.
        * @apiSuccess       {Number}        CannedResponseViewModel.SortOrder                   The sort order of the canned response
        * @apiSuccess       {String[]}      CannedResponseViewModel.TagList                     The list of tags assoicated with the canned response.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          {[
        *              "PremadeMessageID":1,
        *               "SiteID":1,
        *               "GroupID":1,
        *               "UserID":1,
        *               "Message":"Hello, how may I help you?",
        *               "SortOrder":1,
        *               "TagList":["sales, service"]
        *          },
        *          {
        *              "PremadeMessageID":2,
        *              "SiteID":1,
        *              "GroupID":1,
        *              "UserID":1,
        *              "Message":"Thank you, have a nice day.",
        *              "SortOrder":2,
        *              "TagList":["sales, service"]
        *          }]
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
        //UpdateSortOrder
        public void UpdateSortOrder(string value)
        {
        }
    }
}