using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class ConversionController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/conversion read all
        * @apiName getall
        * @apiGroup Settings > /conversion
        * @apiDescription Read all conversions for this site.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/converstion  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                          Your site's account number.
        * 
        * @apiSuccess       {Object[]}      Conversion                                      Conversion
        * @apiSuccess       {Number}        Conversion.ConversionID                         The id of the conversion.
        * @apiSuccess       {Number}        Conversion.SiteID                               Your site's account number.
        * @apiSuccess       {String}        Conversion.ConversionName                       The user friendly name of the conversion.
        * @apiSuccess       {String}        Conversion.Url                                  The url of the page to which the conversion is applied.
        * @apiSuccess       {Number}        Conversion.DefaultDollarAmount                  The default dollar amount of the conversion.
        * @apiSuccess       {String}        Conversion.DollarAmountVariable                 The name of the conversion containing the dollar amount.
        * @apiSuccess       {Boolean}       Conversion.AllowOnce                            Is the conversion allowed only once?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"ConversionID":1,  
        *           "SiteID":1,
        *           "ConversionName","new customer",
        *           "Url","www.mydomain.com/signup/",
        *           "DefaultDollarAmount":10,
        *           "DollarAmountVariable","new customer",
        *           "AllowOnce":true
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
        public void Get()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/conversion create
        * @apiName post
        * @apiGroup Settings > /conversion
        * @apiDescription Create a new conversoin for this site.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/conversion  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID":1,"ConversionName","new customer","Url","www.mydomain.com/signup/","DefaultDollarAmount":10,"DollarAmountVariable","new customer","AllowOnce":true}"
        * 
        * @apiParam         {Number}        siteID The                                      Your site's account number.
        * @apiParam         {Object[]}      Conversion                                      Conversion
        * @apiParam         {Number}        Conversion.SiteID                               Your site's account number.
        * @apiParam         {String}        Conversion.ConversionName                       The user friendly name of the conversion.
        * @apiParam         {String}        Conversion.Url                                  The url of the page to which the conversion is applied.
        * @apiParam         {Number}        Conversion.DefaultDollarAmount                  The default dollar amount of the conversion.
        * @apiParam         {String}        Conversion.DollarAmountVariable                 The name of the conversion containing the dollar amount.
        * @apiParam         {Boolean}       Conversion.AllowOnce                            Is the conversion allowed only once?
        * 
        * @apiSuccess       {Object[]}      Conversion                                      Conversion
        * @apiSuccess       {Number}        Conversion.ConversionID                         The id of the conversion.
        * @apiSuccess       {Number}        Conversion.SiteID                               Your site's account number.
        * @apiSuccess       {String}        Conversion.ConversionName                       The user friendly name of the conversion.
        * @apiSuccess       {String}        Conversion.Url                                  The url of the page to which the conversion is applied.
        * @apiSuccess       {Number}        Conversion.DefaultDollarAmount                  The default dollar amount of the conversion.
        * @apiSuccess       {String}        Conversion.DollarAmountVariable                 The name of the conversion containing the dollar amount.
        * @apiSuccess       {Boolean}       Conversion.AllowOnce                            Is the conversion allowed only once?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "ConversionID":1,  
        *           "SiteID":1,
        *           "ConversionName","new customer",
        *           "Url","www.mydomain.com/signup/",
        *           "DefaultDollarAmount":10,
        *           "DollarAmountVariable","new customer",
        *           "AllowOnce":true
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
        public void Post(string conversion)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/conversion update
        * @apiName put
        * @apiGroup Settings > /conversion
        * @apiDescription Update a conversoin for this site.
        * @apiPermission siteAdministrator
        *
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/conversion  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"ConversionID":1,"SiteID":1,"ConversionName","new customer","Url","www.mydomain.com/signup/","DefaultDollarAmount":10,"DollarAmountVariable","new customer","AllowOnce":true}"
        *       
        * @apiParam         {Number}        siteID                                          Your site's account number.
        * @apiParam         {Object[]}      Conversion                                      Conversion
        * @apiParam         {Number}        Conversion.ConversionID                         The id of the conversion.
        * @apiParam         {Number}        Conversion.SiteID                               Your site's account number.
        * @apiParam         {String}        Conversion.ConversionName                       The user friendly name of the conversion.
        * @apiParam         {String}        Conversion.Url                                  The url of the page to which the conversion is applied.
        * @apiParam         {Number}        Conversion.DefaultDollarAmount                  The default dollar amount of the conversion.
        * @apiParam         {String}        Conversion.DollarAmountVariable                 The name of the conversion containing the dollar amount.
        * @apiParam         {Boolean}       Conversion.AllowOnce                            Is the conversion allowed only once?
        * 
        * @apiSuccess       {Object[]}      Conversion                                      Conversion
        * @apiSuccess       {Number}        Conversion.ConversionID                         The id of the conversion.
        * @apiSuccess       {Number}        Conversion.SiteID                               Your site's account number.
        * @apiSuccess       {String}        Conversion.ConversionName                       The user friendly name of the conversion.
        * @apiSuccess       {String}        Conversion.Url                                  The url of the page to which the conversion is applied.
        * @apiSuccess       {Number}        Conversion.DefaultDollarAmount                  The default dollar amount of the conversion.
        * @apiSuccess       {String}        Conversion.DollarAmountVariable                 The name of the conversion containing the dollar amount.
        * @apiSuccess       {Boolean}       Conversion.AllowOnce                            Is the conversion allowed only once?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "ConversionID":1,  
        *           "SiteID":1,
        *           "ConversionName","new customer",
        *           "Url","www.mydomain.com/signup/",
        *           "DefaultDollarAmount":10,
        *           "DollarAmountVariable","new customer",
        *           "AllowOnce":true
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
        public void Put(string conversion)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {deleate} /{siteID}/conversion/:id delete
        * @apiName delete
        * @apiGroup Settings > /conversion
        * @apiDescription Delete a conversoin for this site.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/conversion/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id of the conversion to delete.
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