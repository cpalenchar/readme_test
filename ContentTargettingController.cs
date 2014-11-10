using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    class ContentTargettingController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/contenttargeting list
        * @apiName getall
        * @apiGroup Settings > /content targeting
        * @apiDescription list the content Targeting for this site.
        * @apiPermission siteManager
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/contenttargeting  \
        *       -H "Authorization: Basic {authorizationToken}" 
        *
        * @apiParam         {Number}        siteID                                               The site's unique id.
        * 
        * @apiSuccess       {Object[]}      ContentTargeting                                    the contenttargetting object
        * @apiSuccess       {Number}        ContentTargeting.ContentTargetingID                 The id of the content Targeting item.
        * @apiSuccess       {Number}        ContentTargeting.SiteID                             The site's unique id.
        * @apiSuccess       {String}        ContentTargeting.ContentTargetingName               The name of the content Targeting item.
        * @apiSuccess       {String}        ContentTargeting.Description                        The description of the content Targeting item.
        * @apiSuccess       {String}        ContentTargeting.ElementID                          The id of the element to replace.
        * @apiSuccess       {String}        ContentTargeting.ReplaceWith                        The new content.
        * @apiSuccess       {String         ContentTargeting.Expression                         The expression to evaluate to determine if the content should be replaces.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"ContentTargetingID:1,  
        *           "SiteID":1,
        *           "ContentTargetingName":"visitor name",
        *           "Description":"replace visitor name div",
        *           "ElementID":"visitor_id",
        *           "ReplaceWith":"Welcome Visitor,",
        *           "Expression":"({DisplayName} = 'new visitor')" 
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
        * @api {get} /{siteID}/contenttargeting/:id read
        * @apiName get:id
        * @apiGroup Settings > /content targeting
        * @apiDescription Read a content Targeting for this id.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/contenttargeting/:id  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id of the content Targeting item to read.
        * 
        * @apiSuccess       {Object}        ContentTargeting                                    the content targeting object
        * @apiSuccess       {Number}        ContentTargeting.ContentTargetingID                 The id of the content Targeting item.
        * @apiSuccess       {Number}        ContentTargeting.SiteID                             Your site's account number.
        * @apiSuccess       {String}        ContentTargeting.ContentTargetingName               The name of the content Targeting item.
        * @apiSuccess       {String}        ContentTargeting.Description                        The description of the content Targeting item.
        * @apiSuccess       {String}        ContentTargeting.ElementID                         The id of the element to replace.
        * @apiSuccess       {String}        ContentTargeting.ReplaceWith                        The new content.
        * @apiSuccess       {String}        ContentTargeting.Expression                         The expression to evaluate to determine if the content should be replaces.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "ContentTargetingID:1,  
        *           "SiteID":1,
        *           "ContentTargetingName":"visitor name",
        *           "Description":"replace visitor name div",
        *           "ElementID":"visitor_id",
        *           "ReplaceWith":"Welcome Visitor,",
        *           "Expression":"({DisplayName} = 'new visitor')" 
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
        public void Get(int siteID, int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/contenttargeting/ create
        * @apiName post
        * @apiGroup Settings > /content targeting
        * @apiDescription Create a new content Targeting item for this site.
        * @apiPermission siteManager
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/contenttargeting  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID": 1,"ContentTargetingName":"visitor name","Description":"replace visitor name div","ElementID":"visitor_id","ReplaceWith":"Welcome, visitor","Exression":"({DisplayName} = 'new visitor')"}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        ContentTargeting                                    the contenttargeting object
        * @apiParam         {Number}        ContentTargeting.SiteID                             Your site's account number.
        * @apiParam         {String}        ContentTargeting.ContentTargetingName               The name of the content Targeting item.
        * @apiParam         {String}        ContentTargeting.Description                        The description of the content Targeting item.
        * @apiParam         {String}        ContentTargeting.ElementID                          The id of the element to replace.
        * @apiParam         {String}        ContentTargeting.ReplaceWith                        The new content.
        * @apiParam         {String}        ContentTargeting.Expression                         The expression to evaluate to determine if the content should be replaces.
        * 
        * @apiSuccess       {Object}        ContentTargeting                                    the contenttargeting object
        * @apiSuccess       {Number}        ContentTargeting.ContentTargetingID                 The unique id of the content Targeting item.
        * @apiSuccess       {Number}        ContentTargeting.SiteID                             Your site's account number.
        * @apiSuccess       {String}        ContentTargeting.ContentTargetingName               The name of the content Targeting item.
        * @apiSuccess       {String}        ContentTargeting.Description                        The description of the content Targeting item.
        * @apiSuccess       {String}        ContentTargeting.ElementID                          The id of the element to replace.
        * @apiSuccess       {String}        ContentTargeting.ReplaceWith                        The new content.
        * @apiSuccess       {String}        ContentTargeting.Expression                         The expression to evaluate to determine if the content should be replaces.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "ContentTargetingID:1,  
        *           "SiteID":1,
        *           "ContentTargetingName":"visitor name",
        *           "Description":"replace visitor name div",
        *           "ElementID":"visitor_id",
        *           "ReplaceWith":"Welcome Visitor,",
        *           "Expression":"({DisplayName} = 'new visitor')" 
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
        * @api {put} /{siteID}/contenttargeting/ update
        * @apiName put
        * @apiGroup Settings >  /content targeting
        * @apiDescription Update a content Targeting item for this site.
        * @apiPermission siteManager
        * 
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/contenttargeting  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"ContentTargetingID":1,"SiteID": 1,"ContentTargetingName":"visitor name","Description":"replace visitor name div","ElementID":"visitor_id","ReplaceWith":"Welcome, visitor","Exression":"({DisplayName} = 'new visitor')"}" 
        *
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        ContentTargeting                                    the contenttargeting object
        * @apiParam         {Number}        ContentTargeting.ContentTargetingID                 The id of the content Targeting item.
        * @apiParam         {Number}        ContentTargeting.SiteID                             Your site's account number.
        * @apiParam         {String}        ContentTargeting.ContentTargetingName               The name of the content Targeting item.
        * @apiParam         {String}        ContentTargeting.Description                        The description of the content Targeting item.
        * @apiParam         {String}        ContentTargeting.ElementID                          The id of the element to replace.
        * @apiParam         {String}        ContentTargeting.ReplaceWith                        The new content.
        * @apiParam         {String}        ContentTargeting.Expression                         The expression to evaluate to determine if the content should be replaces.
        * 
        * @apiSuccess       {Object}        ContentTargeting                                    the contenttargeting object
        * @apiSuccess       {Number}        ContentTargeting.ContentTargetingID                 The id of the content Targeting item.
        * @apiSuccess       {Number}        ContentTargeting.SiteID                             Your site's account number.
        * @apiSuccess       {String}        ContentTargeting.ContentTargetingName               The name of the content Targeting item.
        * @apiSuccess       {String}        ContentTargeting.Description                        The description of the content Targeting item.
        * @apiSuccess       {String}        ContentTargeting.ElementID                          The id of the element to replace.
        * @apiSuccess       {String}        ContentTargeting.ReplaceWith                        The new content.
        * @apiSuccess       {String}        ContentTargeting.Expression                         The expression to evaluate to determine if the content should be replaces.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "ContentTargetingID:1,  
        *           "SiteID":1,
        *           "ContentTargetingName":"visitor name",
        *           "Description":"replace visitor name div",
        *           "ElementID":"visitor_id",
        *           "ReplaceWith":"Welcome Visitor,",
        *           "Expression":"({DisplayName} = 'new visitor')" 
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
        * @api {delete} /{siteID}/contenttargeting/:id delete
        * @apiName delete
        * @apiGroup Settings > /content targeting
        * @apiDescription Delete a content Targeting item for this site.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/contenttargeting/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id of the content Targeting item to delete.
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
        *       "error": "Content Targeting {ID} does not exist."
        *     }* 
        */
        #endregion
        public void Delete(int id)
        {
        }
    }
}
