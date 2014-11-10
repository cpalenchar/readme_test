using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class CobrowseDomainController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/cobrowsedomain read all
        * @apiName get
        * @apiGroup SETTINGS > /cobrowse domain
        * @apiDescription Read all the cobrowse domains for your site.
        * @apiPermission siteManager
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/cobrowsedomain  \
        *       -H "Authorization: Basic {authorizationToken}" 
        *
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * 
        * @apiSuccess       {Object[]}      CobrowseDomain                                      the cobrowsedomain object
        * @apiSuccess       {Number}        CobrowseDomain.CobrowseDomainID                     The id for the cobrowse domain.
        * @apiSuccess       {Number}        CobrowseDomain.SiteID                               Your site's account number.
        * @apiSuccess       {String}        CobrowseDomain.DomainName                           The domain name.
        * @apiSuccess       {String}        CobrowseDomain.Sampleurl                            The sample url for the cobrowse domain.
        * @apiSuccess       {Boolean}       CobrowseDomain.Approved                             Has the cobrowse domain been approved?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"CobrowseDomainID":1,  
        *           "siteID":1,
        *           "DomainName":"mydomain",
        *           "SamplUrl":"www.mydomain.com/sample",
        *           "Approved":true
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
        * @api {get} /{siteID}/cobrowsedomain/:id read
        * @apiName read:id
        * @apiGroup SETTINGS > /Cobrowse Domain
        * @apiDescription Read the cobrowse domain for the id.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/cobrowsedomain  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam     {Number}        siteID                                                  Your site's account number.
        * @apiParam     {Number}        id                                                      The id for the cobrowse domain.
        * 
        * @apiSuccess   {Object}        CobrowseDomain CobrowseDomain
        * @apiSuccess   {Number}        CobrowseDomain.CobrowseDomainID                         The id for the cobrowse domain.
        * @apiSuccess   {Number}        CobrowseDomain.SiteID                                   Your site's account number.
        * @apiSuccess   {String}        CobrowseDomain.DomainName                               The domain name.
        * @apiSuccess   {String}        CobrowseDomain.SampleURL                                The sample url for the cobrowse domain.
        * @apiSuccess   {Boolean}       CobrowseDomain.Approved                                 Has this cobrowse domain been approved?
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "CobrowseDomainID":1,  
        *           "siteID":1,
        *           "DomainName":"mydomain",
        *           "SamplUrl":"www.mydomain.com/sampleurl",
        *           "Approved":true
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
        * @api {post} /{siteID}/cobrowsedomain/ create
        * @apiName post
        * @apiGroup SETTINGS > /Cobrowse Domain
        * @apiDescription Create a new cobrowse domain.
        * @apiPermission siteManager
        * 
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/cobrowsedomain  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID":1,"DomainName":"www.mydomain.com","SampleURL":"www.mydomain.com/sampleurl","approved": true }" 
        *
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        CobrowseDomain                                      the cobrowsedomain object
        * @apiParam         {Number}        CobrowseDomain.SiteID                               Your site's account number.
        * @apiParam         {String}        CobrowseDomain.DomainName                           The domain name.
        * @apiParam         {String}        CobrowseDomain.SampleURL                            The sample url for the cobrowse domain.
        * @apiParam         {Boolean}       CobrowseDomain.Approved                             Has the cobrowse domain been approved?
        * 
        * @apiSuccess       {Object}        CobrowseDomain                                      the cobrowsedomain object
        * @apiSuccess       {Number}        CobrowseDomain.CobrowseDomainID                     The id of the cobrowse domain.
        * @apiSuccess       {Number}        CobrowseDomain.SiteID                               Your site's account number.
        * @apiSuccess       {String}        CobrowseDomain.DomainName                           The domain name.
        * @apiSuccess       {String}        CobrowseDomain.SampleURL                            The sample url of the cobrowse domain.
        * @apiSuccess       {Boolean}       CobrowseDomain.Approved                             Has the cobrowse domain been approved?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "CobrowseDomainID":1,  
        *           "siteID":1,
        *           "DomainName":"mydomain",
        *           "SamplUrl":"www.mydomain.com/sample",
        *           "Approved":true
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
        * @api {put} /{siteID}/cobrowsedomain/ update
        * @apiName put
        * @apiGroup SETTINGS > /Cobrowse Domain
        * @apiDescription Update a cobrowse domain.
        * @apiPermission siteManager
        *
        *       curl -X PuT https:/main.api.livefluence.com/{siteID}/cobrowsedomain  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"CobrowseDomainID":1,"SiteID":1,"DomainName":"www.mydomain.com","SampleURL":"www.mydomain.com/sampleurl","Approved":true}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        CobrowseDomain                                      the cobrowsedomain object
        * @apiParam         {Number}        CobrowseDomain.CobrowseDomainID                     The unique id for the cobrowse domain.
        * @apiParam         {Number}        CobrowseDomain.SiteID                               Your site's account number.
        * @apiParam         {String}        CobrowseDomain.DomainName                           The domain name.
        * @apiParam         {String}        CobrowseDomain.SampleURL                            The sample url for the cobrowse domain.
        * @apiParam         {Boolean}       CobrowseDomain.Approved                             Has the cobrowse domain been approved?
        * 
        * @apiSuccess       {Object}        CobrowseDomain                                      the cobrowsedomain object
        * @apiSuccess       {Number}        CobrowseDomain.CobrowseDomainID                     The id of the cobrowse domain.
        * @apiSuccess       {Number}        CobrowseDomain.SiteID                               Your site's account number.
        * @apiSuccess       {String}        CobrowseDomain.DomainName                           The domain name.
        * @apiSuccess       {String}        CobrowseDomain.SampleURL                            The sample url of the cobrowse domain.
        * @apiSuccess       {Boolean}       CobrowseDomain.Approved                             Has the cobrowse domain been approved?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "CobrowseDomainID":1,  
        *           "siteID":1,
        *           "DomainName":"mydomain",
        *           "SamplUrl":"www.mydomain.com/sampleurl",
        *           "Approved":true
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
        * @api {delete} /{siteID}/cobrowsedomain/:id delete
        * @apiName delete
        * @apiGroup SETTINGS > /cobrowse domain
        * @apiDescription Delete acobrowse domain.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/cobrowsedomain/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        CobrowseDomain.CobrowseDomainID                     The id for the cobrowse domain.
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