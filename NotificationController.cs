using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class NotificationController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/notification/:id read
        * @apiName get
        * @apiGroup SETTINGS > /notification
        * @apiDescription Read a notification.
        * @apiPermission agent
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/notification/:id  \
        *       -H "Authorization: Basic {authorizationToken}"
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {String}        id                                                  The id of the notification to read.
        *
        * @apiSuccess       {Object}        AgentNotification                                   the agentnotification object
        * @apiSuccess       {String}        AgentNotification.ID                                The id of the notification.
        * @apiSuccess       {Number}        AgentNotification.Type                              The type of the notification.  NewVisitor: 1, NewQueueItem: 2, NewEngagement: 3, NewEngagementLine: 4
        * @apiSuccess       {Number}        AgentNotification.RecipientID                       The user id of the object who should receive the notification based on the recipient type.
        * @apiSuccess       {Number}        AgentNotification.RecipientType                     The type of recipient. 1: site, 2: group, 3: agent
        * @apiSuccess       {String}        AgentNotification.ReferenceID                       The unique id of the action that casued the notification, for example an engagement id.
        * @apiSuccess       {String}        AgentNotification.Content                           The content of the notification to display in browser popup notifiction.
        * @apiSuccess       {String}        AgentNotification.GritterContent                    The content of the notification to display in the gritter alert inside the browser.
        * @apiSuccess       {String}        AgentNotification.GritterTitle                      The title of the gritter style alert.  The gritter content can include html.
        * @apiSuccess       {Number}        AgentNotificatoin.GritterTime                       The time to display the gritter notification.
        * @apiSuccess       {Boolean}       AgentNotificatoin.GritterSticky                     Is the gritter notification sticky?
        * @apiSuccess       {String}        AgentNotification.Description                       The general description of the notifiction.
        * @apiSuccess       {Date}          AgentNotification.DateCreated                       The date and time the notification was created.
        * @apiSuccess       {Number}        AgentNotification.TimeToLive                        The number of seconds the notification is valid.
        *    

        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "ID":1,
        *          "Type":1,
        *          "RecipientID":1,
        *          "RecipientType":3,
        *          "ReferenceID":"guid",
        *          "Content":"You have a new visitor",
        *          "GritterContent":"You have a new visitor",
        *          "GritterTitle":"New Visitor",
        *          "GritterTime":120,
        *          "GritterSticky":false,
        *          "Description":"You have a new visitor",
        *          "DateCreated":"1/1/2014 12:00 am",
        *          "TimeToLive":0 
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
        public void Get(string ID)
        {
        }
    }
}