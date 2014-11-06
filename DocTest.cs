using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class DocTest
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/blockedvisitor/ read
        * @apiName get
        * @apiGroup Blocked Visitor
        * @apiGroupDescription Provides access to manage blocked visitors, ip address ranges, and to read visitors that have been blocked.
        * @apiDescription Read all blocked visitors for this site.
        * @apiPermission siteAdministrator
        * 
        * @apiExample       {curl}              Example usage:
        *       curl -H "Authorization: Basic {authorizationToken}" https:/main.api.livefluence.com/{siteID}/blockedvisitor
        *       
        * @apiParam         {Number}        siteID                              The site's unique ID.
        * 
        * @apiSuccess       {Object[]}      BlockedVisitor                      BlockedVisitor
        * @apiSuccess       {Number}        BlockedVisitor.blockedVisitorID     The unique id of this blocked visitor.
        * @apiSuccess       {String}        BlockedVisitor.fromIPAddress        The beginning range of this visitor's ip addresses to block.
        * @apiSuccess       {String}        BlockedVisitor.toIPAddress          The ending range of this visitor's ip addresses to block.
        * @apiSuccess       {String}        BlockedVisitor.reason               The reason this visitor is being blocked.
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
        // GET api/<controller>
        public List<String> Get()
        {
            return null;
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/blockedvisitor/ Create
        * @apiName post
        * @apiGroup Blocked Visitor
        * @apiDescription Create a new blocked visitor for this site.
        * @apiPermission siteAdministrator
        * 
        * @apiExample       {curl}              Example usage:
        *       curl -X POST  https:/main.api.livefluence.com/{siteID}/blockedvisitor \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"fromIPAddres": "123.123.123.123", "toIPAddress": "123.123.123.125", "reason": "User is spamming chat requests"}"
        *       
        * @apiParam         {Number}        siteID                              The site's unique ID.
        * @apiParam         {Object}        BlockedVisitor                      BlockedVisitor
        * @apiParam         {String}        BlockedVisitor.fromIPAddress        The beginning range of this visitor's ip addresses to block.
        * @apiParam         {String}        BlockedVisitor.toIPAddress          The ending range of this visitor's ip addresses to block.
        * @apiParam         {String}        BlockedVisitor.reason               The reason this visitor is being blocked.
        * 
        * @apiSuccess       {Object}        BlockedVisitor                      BlockedVisitor
        * @apiSuccess       {Number}        BlockedVisitor.blockedVisitorID     The unique id of this blocked visitor.
        * @apiSuccess       {String}        BlockedVisitor.fromIPAddress        The beginning range of this visitor's ip addresses to block.
        * @apiSuccess       {String}        BlockedVisitor.toIPAddress          The ending range of this visitor's ip addresses to block.
        * @apiSuccess       {String}        BlockedVisitor.reason               The reason this visitor is being blocked.
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
        public String Post(String blockedVisitor)
        {
            return blockedVisitor;
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/blockedvisitor/ update
        * @apiName put
        * @apiGroup Blocked Visitor
        * @apiDescription Update a blocked visitor for this site.
        * @apiPermission siteAdministrator
        * 
        * @apiExample       {curl}              Example usage:
        *       curl -X PUT  https:/main.api.livefluence.com/{siteID}/BlockedVisitor  /
        *       -H "Authorization: Basic {authorizationToken}"  /
        *       -H "Content-Type: application/json" /
        *       -d "{"blockedVisitorID": 1, "fromIPAddres": "123.123.123.123", "toIPAddress": "123.123.123.125", "reason": "User is spamming chat requests"}"
        *      
        * @apiParam         {Number}        siteID                                  The site's unique ID.
        * @apiParam         {Object}        BlockedVisitor BlockedVisitor
        * @apiParam         {Number}        BlockedVisitor.BlockedVisitorID         The unique id of this blocked visitor.
        * @apiParam         {String}        BlockedVisitor.FromIPAddress            The beginning range of this visitor's ip addresses to block.
        * @apiParam         {String}        BlockedVisitor.ToIPAddress              The ending range of this visitor's ip addresses to block.
        * @apiParam         {String}        BlockedVisitor.Reason                   The reason this visitor is being blocked.
        * 
        * @apiSuccess       {Object}        BlockedVisitor BlockedVisitor
        * @apiSuccess       {Number}        BlockedVisitor.BlockedVisitorID         The unique id of this blocked visitor.
        * @apiSuccess       {String}        BlockedVisitor.FromIPAddress            The beginning range of this visitor's ip addresses to block.
        * @apiSuccess       {String}        BlockedVisitor.ToIPAddress              The ending range of this visitor's ip addresses to block.
        * @apiSuccess       {String}        BlockedVisitor.Reason                   The reason this visitor is being blocked.
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
        public String Put(String blockedVisitor)
        {
            return blockedVisitor;
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/blockedvisitor/:id delete
        * @apiName delete
        * @apiGroup Blocked Visitor
        * @apiDescription Delete a blocked visitor for this site.
        * @apiPermission siteAdministrator
        * 
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/blockedvisitor/{id} /
        *       -H "Authorization: Basic {authorizationToken}" 
        *       
        * @apiParam         {Number}        siteID                  The site's unique ID.
        * @apiParam         {Number}        ID                      The unique id of the blocked visitor.
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