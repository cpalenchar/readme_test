using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class AlertController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/alert/getbysite get by site
        * @apiName GetBySite
        * @apiGroup Settings > /alert
        * @apiDescription Read all alerts for this site.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/alert/getbysite/:id  \
        *       -H "Authorization: Basic {authorizationToken}" 
        *       
        * @apiParam         {Number}        siteID                                      Your site's account number.
        *
        * @apiSuccess       {Object[]}      Alert                                       Alert
        * @apiSuccess       {Number}        Alert.AlertID                               The id for the alert.
        * @apiSuccess       {Number}        Alert.SiteID                                Your site's account number.
        * @apiSuccess       {String}        Alert.Name                                  The name for the alert.
        * @apiSuccess       {String}        Alert.Description                           The description for the alert.
        * @apiSuccess       {String}        Alert.Expression                            The expression to be used for the alert.
        * @apiSuccess       {String}        Alert.Content                               The content to be used for the alert.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *       [{"AlertID": 1,  
        *       "SiteID": 1,
        *       "Name": "local visitor",
        *       "Description": "A local visitor has visited the page",
        *       "Expression": "({IPAddress}='127.0.0.1')",
        *       "Content": "A new local visitor has visited the page"
        *       }]
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
        * @api {get} /{siteID}/alert/:id read
        * @apiName get
        * @apiGroup Settings > /alert
        * @apiDescription Read the alert for this id.
        * @apiPermission agent
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/alert/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        *       
        * @apiParam         {Number}        siteID                                      Your site's account number.
        * @apiParam         {Number}        id                                          The alert's id.
        *
        * @apiSuccess       {Object}        Alert                                       the alert object.
        * @apiSuccess       {Number}        Alert.AlertID                               The id for the alert.
        * @apiSuccess       {Number}        Alert.SiteID                                The id for the site.
        * @apiSuccess       {String}        Alert.Name                                  The name of the alert.
        * @apiSuccess       {String}        Alert.Description                           The description of the alert.
        * @apiSuccess       {String}        Alert.Expression                            The expression to be used for the alert.
        * @apiSuccess       {String}        Alert.Content                               The content to be used for the alert.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
         *      "AlertID": 1,  
        *       "SiteID": 1,
        *       "Name": "local visitor",
        *       "Description": "A local visitor has visited the page",
        *       "Expression": "({IPAddress}='127.0.0.1')",
        *       "Content": "A new local visitor has visited the page"
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
        * @api {post} /{siteID}/alert create
        * @apiName post
        * @apiGroup Settings > /alert
        * @apiDescription Create a new alert.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/alert  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{ "SiteID": 1, "Name": "local visitor", "Description": "A localhost visitor is on the page.", "Exression": "({IPAddress} = '127.0.0.1')", "Content": "A local host visitor visited the page." }" 
        *       
        * @apiParam         {Number}        siteID                                      Your site's account number.
        * @apiParam         {Object}        Alert                                       The alert object.
        * @apiParam         {Number}        Alert.SiteID                                Your site's account number.
        * @apiParam         {String}        Alert.Name                                  The name of the alert.
        * @apiParam         {String}        Alert.Description                           The description of the alert.
        * @apiParam         {String}        Alert.Expression                            The expression to be used for the alert.
        * @apiParam         {String}        Alert.Content                               The content to be used for the alert.
        *
        * @apiSuccess       {Object}        Alert                                       The alert object.
        * @apiSuccess       {Number}        Alert.AlertID                               The id for the alert.
        * @apiSuccess       {Number}        Alert.SiteID                                Your site's account number.
        * @apiSuccess       {String}        Alert.Name                                  The name of the alert.
        * @apiSuccess       {String}        Alert.Description                           The description of the alert.
        * @apiSuccess       {String}        Alert.Expression                            The expression to be used for the alert.
        * @apiSuccess       {String}        Alert.Content                               The content to be used for the alert.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *       "AlertID": 1,  
        *       "SiteID": 1,
        *       "Name": "local visitor",
        *       "Description": "A local visitor has visited the page",
        *       "Expression": "({IPAddress}='127.0.0.1')",
        *       "Content": "A new local visitor has visited the page"
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
        public void Post(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/alert update
        * @apiName Put
        * @apiGroup Settings > /alert
        * @apiDescription Update an alert.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/alert  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{ "SiteID": 1, "Name": "local visitor", "Description": "A localhost visitor is on the page.", "Exression": "({IPAddress} = '127.0.0.1')", "Content": "A local host visitor visited the page." }" 
        *       
        * @apiParam         {Number}        siteID                                      Your site's account number.
        * @apiParam         {Object}        Alert                                       The alert object.
        * @apiSuccess       {Number}        Alert.AlertID                               The id for the alert.
        * @apiParam         {Number}        Alert.SiteID                                Your site's account number.
        * @apiParam         {String}        Alert.Name                                  The name of the alert.
        * @apiParam         {String}        Alert.Description                           The description of the alert.
        * @apiParam         {String}        Alert.Expression                            The expression to be used for the alert.
        * @apiParam         {String}        Alert.Content                               The content to be used for the alert.
        *
        * @apiSuccess       {Object}        Alert                                       The alert object.
        * @apiSuccess       {Number}        Alert.AlertID                               The id for the alert.
        * @apiSuccess       {Number}        Alert.SiteID                                Your site's account number.
        * @apiSuccess       {String}        Alert.Name                                  The name of the alert.
        * @apiSuccess       {String}        Alert.Description                           The description of the alert.
        * @apiSuccess       {String}        Alert.Expression                            The expression to be used for the alert.
        * @apiSuccess       {String}        Alert.Content                               The content to be used for the alert.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *       "AlertID": 1,  
        *       "SiteID": 1,
        *       "Name": "local visitor",
        *       "Description": "A local visitor has visited the page",
        *       "Expression": "({IPAddress}='127.0.0.1')",
        *       "Content": "A new local visitor has visited the page"
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
        public void Put(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/alert/:id delete
        * @apiName delete
        * @apiGroup Settings >  /alert
        * @apiDescription Delete an alert.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/alert/{id} \
        *       -H "Authorization: Basic {authorizationToken}" 
        *       
        * @apiParam         {Number}        siteID                                      Your site's account number.
        * @apiParam         {Number}        id                                          The id of the alert.
        *
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
        *     
        * @apiError NotFound The alert was not found.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 404 NotFound
        *     {
        *       "error": "Alert {ID} does not exist."
        *     }* 
        */
        #endregion
        public void Delete(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/alert/addrecipient add recipient
        * @apiName postrecipient
        * @apiGroup Settings > /alert
        * @apiDescription Add a recipient to this alert.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/alert/addrecipient  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"UserID": 1, "AlertID": 1, "SendSMS": true, "SendEmail": true, "SendToLogin": true}" 
        *       
        * @apiParam         {Number}        siteID                                      Your site's account number.
        * @apiParam         {Object}        AlertRecipient                              The alertrecipient object.
        * @apiParam         {Number}        AlertRecipient.UserID                       The id for the user to add to the alert.
        * @apiParam         {Number}        AlertRecipient.AlertID                      The id for the alert to add to the user.
        * @apiParam         {Boolean}       AlertRecipient.SendSMS                      Does the alert get sent as an sms to the user?
        * @apiParam         {Boolean}       AlertRecipient.SendEmail                    Does the alert get sent as an email to the user?
        * @apiParam         {Boolean}       AlertRecipeint.SendToLogin                  Does the alert get sent to the login for the user?
        *
        * @apiSuccess       {Object}        AlertRecipient                              The alert recipient object.
        * @apiSuccess       {Number}        AlertRecipient.AlertRecipientID             The id for the alert recipient.
        * @apiSuccess       {Number}        AlertRecipient.UserID                       The id of the user to add to the alert.
        * @apiSuccess       {Number}        AlertRecipient.AlertID                      The id of the alert to add to the user.
        * @apiSuccess       {Boolean}       AlertRecipient.SendSMS                      Does the alert get sent as an sms to the user?
        * @apiSuccess       {Boolean}       AlertRecipient.SendEmail                    Does the alert get sent as an email to the user?
        * @apiSuccess       {Boolean}       AlertRecipeint.SendToLogin                  Does the alert get sent to the login for the user?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *       "AlertRecipientID": 1,
        *       "UserID": 1,  
        *       "AlertID": 1,
        *       "SendSMS": true,
        *       "SendEmail": false
        *       "SendToLogin": false
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
        public void PostAlertRecipient(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/Alert/deleterecipient delete recipient
        * @apiName deleterecipient
        * @apiGroup Settings > /alert
        * @apiDescription Delete a recipient from this alert.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/alert/deleterecipient  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"alertRecipientID": 1, "userID": 1, "alertID": 1}" 
        *       
        * @apiParam         {Number}        siteID                                      Your site's account number.
        * @apiParam         {Object}        AlertRecipient                              The alertrecipient object.
        * @apiParam         {Number}        AlertRecipient.alertRecipientID             The id of this alert recipient.
        * @apiParam         {Number}        AlertRecipient.userID                       The id of the user to delete from this alert.
        * @apiParam         {Number}        AlertRecipient.alertID                      The id of the alert to delte from this user.
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
        public void DeleteAlertRecipient(string value)
        {

        }
    }
}