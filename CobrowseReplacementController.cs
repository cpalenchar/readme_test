using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class CobrowseReplacementController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/cobrowsereplacement read all
        * @apiName get
        * @apiGroup SETTINGS > /cobrowse replacement
        * @apiDescription Read all the cobrowse replacements for this site.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/cobrowsereplacement  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam          {Number}       siteID                                              Your site's account number.
        * 
        * @apiSuccess       {Object[]}      CobrowseReplacement                                 the corbrowsereplacement object
        * @apiSuccess       {Number}        CobrowseReplacement.CobrowseDomainID                The id of the cobrowse domain.
        * @apiSuccess       {Number}        CobrowseReplacement.SiteID                          Your site's account number.
        * @apiSuccess       {String}        CobrowseReplacement.RegEx                           The regular expression to use when replacing the domain.
        * @apiSuccess       {String}        CobrowseReplacement.Replace                         The new value.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"CobrowseDomainID":1,  
        *           "SiteID":1,
        *           "RegEx":"[abc]",
        *           "Replace":"mysite"
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
        public void GetBySite(int siteID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/cobrowsereplacement/:id read
        * @apiName get:id
        * @apiGroup SETTINGS > /cobrowse replacement
        * @apiDescription Read the cobrowse replacement for this id.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/cobrowsereplacement\:id  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id of the cobrowse replacement.
        * 
        * @apiSuccess       {Object}        CobrowseReplacement                                 the corbrowsereplacement object
        * @apiSuccess       {Number}        CobrowseReplacement.CobrowseDomainID                The id of the cobrowse domain.
        * @apiSuccess       {Number}        CobrowseReplacement.SiteID                          Your site's account number.
        * @apiSuccess       {String}        CobrowseReplacement.RegEx                           The regular expression to use when replacing the domain.
        * @apiSuccess       {String}        CobrowseReplacement.Replace                         The new value.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "CobrowseDomainID":1,  
        *           "SiteID":1,
        *           "RegEx":"[abc]",
        *           "Replace":"mysite"
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
        * @api {post} /{siteID}/cobrowsereplacement/ create
        * @apiName post
        * @apiGroup SETTINGS > /cobrowse replacement
        * @apiDescription Create a new cobrowse replacement.
        * @apiPermission siteManager
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/cobrowsereplacement  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID":1,"RegEx":"[abc]","Replace":"mysite"}"   
        *       
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        CobrowseReplacement                                 the cobrowsereplacement object
        * @apiParam         {Number}        CobrowseReplacement.SiteID                          The unique id for this site.
        * @apiParam         {String}        CobrowseReplacement.RegEx                           The regular expression to use when replacing the domain.
        * @apiParam         {String}        CobrowseReplacement.Replace                         The new value.
        * 
        * @apiSuccess       {Object}        CobrowseReplacement                                 the cobrowsereplacement object
        * @apiSuccess       {Number}        CobrowseReplacement.CobrowseDomainID                The id of this cobrowse domain.
        * @apiSuccess       {Number}        CobrowseReplacement.SiteID                          Your site's account number.
        * @apiSuccess       {String}        CobrowseReplacement.RegEx                           The regular expression to use when replacing the domain.
        * @apiSuccess       {String}        CobrowseReplacement.Replace                         The new value.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "CobrowseDomainID":1,  
        *           "SiteID":1,
        *           "RegEx":"[abc]",
        *           "Replace":"mysite"
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
        * @api {put} /{siteID}/cobrowsereplacement/ update
        * @apiName put
        * @apiGroup SETTINGS > /cobrowse replacement
        * @apiDescription Update a cobrowse replacement.
        * @apiPermission siteManager
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/cobrowsereplacement  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"CobrowseDomainID":1,"SiteID": 1,"RegEx":"[abc]","Replace":"mysite"}"   
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        CobrowseReplacement                                 the cobrowsereplacement object
        * @apiSuccess       {Number}        CobrowseReplacement.CobrowseDomainID                The id of the cobrowse domain.
        * @apiParam         {Number}        CobrowseReplacement.SiteID                          Your site's account number.
        * @apiParam         {String}        CobrowseReplacement.RegEx                           The regular expression to use when replacing the domain.
        * @apiParam         {String}        CobrowseReplacement.Replace                         The new value.
        * 
        * @apiSuccess       {Object}        CobrowseReplacement                                 the cobrowsereplacement object
        * @apiSuccess       {Number}        CobrowseReplacement.CobrowseDomainID                The id of the cobrowse domain.
        * @apiSuccess       {Number}        CobrowseReplacement.SiteID                          Your site's account number.
        * @apiSuccess       {String}        CobrowseReplacement.RegEx                           The regular expression to use when replacing the domain.
        * @apiSuccess       {String}        CobrowseReplacement.Replace                         The new value.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "CobrowseDomainID":1,  
        *           "SiteID":1,
        *           "RegEx":"[abc]",
        *           "Replace":"mysite"
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
        * @api {delete} /{siteID}/cobrowsereplacement/:id delete
        * @apiName delete
        * @apiGroup SETTINGS > /cobrowse replacement
        * @apiDescription Delete cobrowse replacement.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/cobrowsereplacement/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id of the cobrowse replacement to delete.
        *
        * @apiError NotAuthorized The user is not authorized yet to make the call.
        * 
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 403 Forbidden
        *     {
        *       "error": "Forbidden"
        *     }
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
    }
}