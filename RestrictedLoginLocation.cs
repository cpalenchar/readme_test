using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class RestrictedLoginLocation
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/restrictedloginlocation list
        * @apiName get
        * @apiGroup Settings > /restricted login location
        * @apiDescription list the restricted logins for this site.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/restrictedloginlocation  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                                  The site's unique ID.
        *
        * @apiSuccess       {Object[]}      RestrictedLoginLocation                                 RestrictedLoginLocation  
        * @apiSuccess       {Number}        RestrictedLoginLocation.RestrictedLoginLocationID       The id of the restricted login
        * @apiSuccess       {Number}        RestrictedLoginLocation.SteID                           Your site's account number.
        * @apiSuccess       {String}        RestrictedLoginLocation.FromIPAddress                   The starting ip address range of the restricted login
        * @apiSuccess       {String}        RestrictedLoginLocation.ToIPAddress                     The ending ipAddress range of the restricted login.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"RestictedLoginLocationID":1,
        *          "SiteID" 1,
        *          "FromIPAddress":"123.123.123.123",
        *          "ToIPAddress": "123.123.123.125"
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
        * @api {post} /{siteID}/restrictedloginlocation create
        * @apiName post
        * @apiGroup Settings > /restricted login location
        * @apiDescription Create a new restricted login.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/restrictedloginlocation  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID":1,"FromIPAddress":"123.123.123.123","ToIPAddress" "123.123.123.125"}" 
        * 
        * @apiParam         {Number}        siteID                                                  Your site's account number.
        * @apiParam         {Object}        RestrictedLoginLocation                                 the restrictedloginlocation  object
        * @apiParam         {Number}        RestrictedLoginLocaton.SiteID                           Your site's account number.
        * @apiParam         {String}        RestrictedLoginLocation.FromIPAddress                   The starting ip address range of the restricted login
        * @apiParam         {String}        RestrictedLoginLocation.ToIPAddress                     The ending ipAddress range of the restricted login.
        *
        * @apiSuccess       {Object}        RestrictedLoginLocation                                 the restrictedloginglocation object
        * @apiSuccess       {Number}        RestrictedLoginLocation.RestrictedLoginLocationID       The id of the restricted login
        * @apiSuccess       {Number}        RestrictedLoginLocation.SteID                           Your site's account number.
        * @apiSuccess       {String}        RestrictedLoginLocation.FromIPAddress                   The starting ip address range of the restricted login
        * @apiSuccess       {String}        RestrictedLoginLocation.ToIPAddress                     The ending ipAddress range of the restricted login.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"RestictedLoginLocationID":1,
        *          "SiteID" 1,
        *          "FromIPAddress":"123.123.123.123",
        *          "ToIPAddress": "123.123.123.125"
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
        public void Post(string loginLocation)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/restrictedloginlocation update
        * @apiName put
        * @apiGroup Settings > /restricted login location
        * @apiDescription Create a new restricted login.
        * @apiPermission siteAdministrator
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/restrictedloginlocation  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"RestrictedLoginLocationID":1,"SiteID":1,"FromIPAddress":"123.123.123.123","ToIPAddress": "123.123.123.125"}" 
        * 
        * @apiParam         {Number}        siteID                                                Your site's account number.
        * @apiParam         {Object}        RestrictedLoginLocation                               the restrictedloginlocation  object
        * @apiParam         {Number}        RestrictedLoginLocaton.SiteID                         Your site's account number.
        * @apiParam         {String}        RestrictedLoginLocation.FromIPAddress                 The starting ip address range of the restricted login
        * @apiParam         {String}        RestrictedLoginLocation.ToIPAddress                   The ending ipAddress range of the restricted login.
        *
        * @apiSuccess       {Object}        RestrictedLoginLocation                               the restrictedloginglocation object
        * @apiSuccess       {Number}        RestrictedLoginLocation.RestrictedLoginLocationID       The id of the restricted login
        * @apiSuccess       {Number}        RestrictedLoginLocation.SteID                           Your site's account number.
        * @apiSuccess       {String}        RestrictedLoginLocation.FromIPAddress                   The starting ip address range of the restricted login
        * @apiSuccess       {String}        RestrictedLoginLocation.ToIPAddress                     The ending ipAddress range of the restricted login.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"RestictedLoginLocationID":1,
        *          "SiteID" 1,
        *          "FromIPAddress":"123.123.123.123",
        *          "ToIPAddress": "123.123.123.125"
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
        public void Put(string loginLocation)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delte} /{siteID}/restrictedloginlocation/:id delete
        * @apiName delete
        * @apiGroup Settings > /restricted Login Location
        * @apiDescription Create a new restricted login.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/restrictedloginlocation/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                                Your site's account number.
        * @apiParam         {Object}        id                                                    The id of the restricted login location to delete.
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
    }
}
