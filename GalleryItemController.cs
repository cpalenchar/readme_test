using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    class GalleryItemController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/galleryItemcontroller/:id read
        * @apiName get
        * @apiGroup Settings > /gallery item
        * @apiDescription Read the gallery item for this id.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/galleryItemcontroller/:id  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id for the gallery item to read.
        * 
        * @apiSuccess       {Object}        GalleryItem                                         the galleryitem object
        * @apiSuccess       {Number}        GalleryItem.GalleryItemID                           The id of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.SiteID                                  Your site's account number.
        * @apiSuccess       {Number}        GalleryItem.UserID                                  The user id of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.ItemType                                The type of gallery item, 1: skin, 2: button, 3: headshot, 4: invitation
        * @apiSuccess       {Date}          GalleryItem.DateCreated                             The date and time the gallery item was created.
        * @apiSuccess       {String}        GalleryItem.Description                             The description of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Title                                   The title of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Location                                The location of the gallery item.
        * @apiSuccess       {Boolean}       GalleryItem.IsActive                                Is the gallery item active?
        * @apiSuccess       {Boolean}       GalleryItem.Contributed                             Is the gallery item contributed?
        * @apiSuccess       {Number}        GalleryItem.Rank                                    The rank of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.CreatedBy                               The id of the user that created the gallery item.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
         *          "GallertyItemID":1,
        *           "SiteID":1,
        *           "UserID":1,
        *           "ItemType":2,
        *           "DateCreated":"1/1/2014 12:00 am",
        *           "Description":"site default skin",
        *           "Title":"default skin",
        *           "Location":"www.mydomain.com/defaultskin",
        *           "IsActive": true,
        *           "Contributed":true,
        *           "Rank":1,
        *           "CreatedBy":1
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
        * @api {post} /{siteID}/galleryitemcontroller create
        * @apiName post
        * @apiGroup Settings > /gallery item
        * @apiDescription Create a new gallery item.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/galleryitemcontroller  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID":1,"UserID":1,"ItemType":2,"DateCreated":"1/1/2014 12:00 am","Description":"site default skin","Title":"default skin","Location":"www.mydomain.com/defaultskin","IsActive": true,"Contributed":true,"Rank":1,"CreatedBy":1}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        GalleryItem                                         the galleryitem object
        * @apiParam         {Number}        GalleryItem.SiteID                                  Your site's account number.
        * @apiParam         {Number}        GalleryItem.UserID                                  The user id of the gallery item.
        * @apiParam         {Number}        GalleryItem.ItemType                                The type of gallery item, 1: skin, 2: button, 3: headshot, 4: invitation
        * @apiParam         {Date}          GalleryItem.DateCreated                             The date and time the gallery item was created.
        * @apiParam         {String}        GalleryItem.Description                             The description of the gallery item.
        * @apiParam         {String}        GalleryItem.Title                                   The title of the gallery item.
        * @apiParam         {String}        GalleryItem.Location                                The location of the gallery item.
        * @apiParam         {Boolean}       GalleryItem.IsActive                                Is the gallery item active?
        * @apiParam         {Boolean}       GalleryItem.Contributed                             Is the gallery item contributed?
        * @apiParam         {Number}        GalleryItem.Rank                                    The rank of the gallery item.
        * @apiParam         {Number}        GalleryItem.CreatedBy                               The id of the user that created the gallery item.
        * 
        * @apiSuccess       {Object}        GalleryItem                                         the galleryitem object
        * @apiSuccess       {Number}        GalleryItem.GalleryItemID                           The id of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.SiteID                                  Your site's account number.
        * @apiSuccess       {Number}        GalleryItem.UserID                                  The user id of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.ItemType                                The type of gallery item, 1: skin, 2: button, 3: headshot, 4: invitation
        * @apiSuccess       {Date}          GalleryItem.DateCreated                             The date and time the gallery item was created.
        * @apiSuccess       {String}        GalleryItem.Description                             The description of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Title                                   The title of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Location                                The location of the gallery item.
        * @apiSuccess       {Boolean}       GalleryItem.IsActive                                Is the gallery item active?
        * @apiSuccess       {Boolean}       GalleryItem.Contributed                             Is the gallery item contributed?
        * @apiSuccess       {Number}        GalleryItem.Rank                                    The rank of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.CreatedBy                               The id of the user that created the gallery item.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
         *          "GalleryItemID":1,
        *           "SiteID":1,
        *           "UserID":1,
        *           "ItemType":2,
        *           "DateCreated":"1/1/2014 12:00 am",
        *           "Description":"site default skin",
        *           "Title":"default skin",
        *           "Location":"www.mydomain.com/defaultskin",
        *           "IsActive": true,
        *           "Contributed":true,
        *           "Rank":1,
        *           "CreatedBy":1
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
        * @api {put} /{siteID}/galleryitemcontroller update
        * @apiName put
        * @apiGroup Settings > /gallery item
        * @apiDescription Update a gallery item.
        * @apiPermission siteAdministrator
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/galleryitemcontroller  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID":1,"UserID":1,"ItemType":2,"DateCreated":"1/1/2014 12:00 am","Description":"site default skin","Title":"default skin","Location":"www.mydomain.com/defaultskin","IsActive": true,"Contributed":true,"Rank":1,"CreatedBy":1}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        GalleryItem                                         the galleryitem object
        * @apiParam         {Number}        GalleryItem.GalleryItemID                           The id of the gallery item.
        * @apiParam         {Number}        GalleryItem.SiteID                                  Your site's account number.
        * @apiParam         {Number}        GalleryItem.UserID                                  The user id of the gallery item.
        * @apiParam         {Number}        GalleryItem.ItemType                                The type of gallery item, 1: skin, 2: button, 3: headshot, 4: invitation
        * @apiParam         {Date}          GalleryItem.DateCreated                             The date and time the gallery item was created.
        * @apiParam         {String}        GalleryItem.Description                             The description of the gallery item.
        * @apiParam         {String}        GalleryItem.Title                                   The title of the gallery item.
        * @apiParam         {String}        GalleryItem.Location                                The location of the gallery item.
        * @apiParam         {Boolean}       GalleryItem.IsActive                                Is the gallery item active?
        * @apiParam         {Boolean}       GalleryItem.Contributed                             Is the gallery item contributed?
        * @apiParam         {Number}        GalleryItem.Rank                                    The rank of the gallery item.
        * @apiParam         {Number}        GalleryItem.CreatedBy                               The id of the user that created the gallery item.
        * 
        * @apiSuccess       {Object}        GalleryItem                                         the galleryitem object
        * @apiSuccess       {Number}        GalleryItem.GalleryItemID                           The id of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.SiteID                                  Your site's account number.
        * @apiSuccess       {Number}        GalleryItem.UserID                                  The user id of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.ItemType                                The type of gallery item, 1: skin, 2: button, 3: headshot, 4: invitation
        * @apiSuccess       {Date}          GalleryItem.DateCreated                             The date and time the gallery item was created.
        * @apiSuccess       {String}        GalleryItem.Description                             The description of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Title                                   The title of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Location                                The location of the gallery item.
        * @apiSuccess       {Boolean}       GalleryItem.IsActive                                Is the gallery item active?
        * @apiSuccess       {Boolean}       GalleryItem.Contributed                             Is the gallery item contributed?
        * @apiSuccess       {Number}        GalleryItem.Rank                                    The rank of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.CreatedBy                               The id of the user that created the gallery item.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "SiteID":1,
        *           "UserID":1,
        *           "ItemType":2,
        *           "DateCreated":"1/1/2014 12:00 am",
        *           "Description":"site default skin",
        *           "Title":"default skin",
        *           "Location":"www.mydomain.com/defaultskin",
        *           "IsActive": true,
        *           "Contributed":true,
        *           "Rank":1,
        *           "CreatedBy":1
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
        * @api {delete} /{siteID}/galleryitemcontroller/:id delete
        * @apiName delete
        * @apiGroup Settings > /gallery item
        * @apiDescription Delete a gallery item.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              The site's unique id.
        * @apiParam         {Number}        id                                                  The id of the gallery item to delete.
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

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/galleryitemcontroller/getgalleryvotes/:id read votes
        * @apiName getvotes
        * @apiGroup Settings > /gallery item
        * @apiDescription Read the votes for the gallery item for this id.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/getgalleryvotes/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id of the gallery item to read the votes.
        * 
        * @apiSuccess       {Object[]}      GalleryVote                                         the galleryvote object
        * @apiSuccess       {Number}        GalleryVote.GalleryVoteID                           The id of the gallery vote.
        * @apiSuccess       {Number}        GalleryVote.GalleryItemID                           The id of the gallery item for the gallery vote.
        * @apiSuccess       {Number}        GalleryVote.UserID                                  The id of the user who created the vote.
        * @apiSuccess       {Number}        GalleryVote.Vote                                    The vote.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"GalleryVoteID":1,  
        *           "GalleryItemID":,1
        *           "UserID":1,
        *           "Vote":1
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
        public void GetGalleryVotes(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/galleryitemcontroller/postgalleryvote create vote
        * @apiName postvote
        * @apiGroup Settings > /gallery item
        * @apiDescription Create a new vote for the gallery item.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/postgalleryvote  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{ "GalleryItemID":1,"UserID":1,"Vote":1}"
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        GalleryVote                                         the galleryvote object
        * @apiParam         {Number}        GalleryVote.GalleryItemID                           The id of the gallery item for the gallery vote.
        * @apiParam         {Number}        GalleryVote.UserID                                  The unique id of the user who created the vote.
        * @apiParam         {Number}        GalleryVote.Vote                                    The vote.
        * 
        * @apiSuccess       {Object}        GalleryVote                                         the galleryvote object
        * @apiSuccess       {Number}        GalleryVote.GalleryVoteID                           The unique id of the gallery vote.
        * @apiSuccess       {Number}        GalleryVote.GalleryItemID                           The unique id of the gallery item for the gallery vote.
        * @apiSuccess       {Number}        GalleryVote.UserID                                  The unique id of the user who created the vote.
        * @apiSuccess       {Number}        GalleryVote.Vote                                    The vote.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "GalleryVoteID":1,  
        *           "GalleryItemID":,1
        *           "UserID":1,
        *           "Vote":1
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
        public void PostGalleryVote(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/galleryitemcontroller/putgalleryvote update vote
        * @apiName putvote
        * @apiGroup Settings > /gallery item
        * @apiDescription Update a vote for the gallery item.
        * @apiPermission siteAdministrator
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/postgalleryvote  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"GalleryVoteID":1,"GallyerItemID":1,"UserID":1,"Vote":1}"
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        GalleryVote                                         the galleryvote object
        * @apiParam         {Number}        GalleryVote.GalleryVoteID                           The unique id of the gallery vote.
        * @apiParam         {Number}        GalleryVote.GalleryItemID                           The id of the gallery item for the gallery vote.
        * @apiParam         {Number}        GalleryVote.UserID                                  The unique id of the user who created the vote.
        * @apiParam         {Number}        GalleryVote.Vote                                    The vote.
        * 
        * @apiSuccess       {Object}        GalleryVote                                         the galleryvote object
        * @apiSuccess       {Number}        GalleryVote.GalleryVoteID                           The unique id of the gallery vote.
        * @apiSuccess       {Number}        GalleryVote.GalleryItemID                           The unique id of the gallery item for the gallery vote.
        * @apiSuccess       {Number}        GalleryVote.UserID                                  The unique id of the user who created the vote.
        * @apiSuccess       {Number}        GalleryVote.Vote                                    The vote.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "GalleryVoteID":1,  
        *           "GalleryItemID":,1
        *           "UserID":1,
        *           "Vote":1
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
        public void PutGalleryVote(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/galleryitemcontroller/deletegalleryvote/:id delete vote
        * @apiName deletevote
        * @apiGroup Settings > /gallery item
        * @apiDescription Delete a vote for this gallery item.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/deletegalleryvote/:id  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id of the gallery vote to delete.
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
        public void DeleteGalleryVote(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/galleryitemcontroller/approvegalleryitem/:galleryItemID approve
        * @apiName postapprove
        * @apiGroup Settings > /gallery item
        * @apiDescription Approve a new item gallery item.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/approvegalleryitem/:galleryItemID  /
        *       -H "Authorization: Basic {authorizationToken}"  
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id for the gallery item to approve.
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
        public void ApproveGalleryItem(int galleryItemID)
        {
        }

        #region Gallery Button related
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/galleryitemcontroller/buttongalleries read all button galleries
        * @apiName getallbuttongalleries
        * @apiGroup Settings > /gallery item
        * @apiDescription Read the gallery items that are buttons for this site.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/buttongalleries  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * 
        * @apiSuccess       {Object[]}      GalleryItem                                         the array of galleryitem objects
        * @apiSuccess       {Number}        GalleryItem.GalleryItemID                           The id for the gallery item.
        * @apiSuccess       {Number}        GalleryItem.SiteID                                   Your site's account number.
        * @apiSuccess       {Number}        GalleryItem.UserID                                  The id of the user.
        * @apiSuccess       {Number}        GalleryItem.ItemType                                The type of gallery item, 1: skin, 2: button, 3: headshot, 4: invitation
        * @apiSuccess       {Date}          GalleryItem.DateCreated                             The date and time the gallery item was created.
        * @apiSuccess       {String}        GalleryItem.Description                             The description of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Title                                   The title of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Location                                The location of the gallery item.
        * @apiSuccess       {Boolean}       GalleryItem.IsActive                                Is the gallery item active?
        * @apiSuccess       {Boolean}       GalleryItem.Contributed                             Is the gallery item contributed?
        * @apiSuccess       {Number}        GalleryItem.Rank                                    The rank of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.CreatedBy                               The id of the user that created the gallery item.
        * @apiSuccess       {String}        GalleryItem.HtmlFile                                The html file for the gallery item.
        * @apiSuccess       {String}        GalleryItem.JSFile                                  The java script file for the gallery item.
        * @apiSuccess       {String}        GalleryItem.CSSFile                                 The css file for the gallery item.
        * @apiSuccess       {String}        GalleryItem.ThumbnailImageUrl                       The url for the thumbnail image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.FullImageUrl                            The url for the full image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.ImagePreviewUrl                         The url for the preview image for the gallery item.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"GalleryItemID":1,
        *           "SiteID":1,
        *           "UserID":1,
        *           "ItemType":1,
        *           "DateCreated":"1/1/2014 12:00 am",
        *           "Description":"Description of buttion gallery",
        *           "Title":"Button Gallery",
        *           "Location":"www.mydomain.com/buttongalleries/",
        *           "IsActive":true,
        *           "Contributed":true,
        *           "Rank":1,
        *           "CreatedBy":1,
        *           "HtmlFile":"galleryfile.html",
        *           "JSFile":"galleryfile.js",
        *           "CSSFile":"galleryfile.css",
        *           "ThumbnailImageUrl":"www.mydomain.com/buttongalllery/thumbnail.jpg",
        *           "FullImageUrl":"www.mydomain.com/buttongallery/fullimage.jpg",
        *           "ImagePreviewUrl":"www.mydomain.com/buttongallery/imagepreview.jpg"
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
        public void GetButtonGalleries()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/galleryitemcontroller/buttongalleryfiles/:id read all button gallery files
        * @apiName getallbuttongalleryfiles
        * @apiGroup Settings > /gallery item
        * @apiDescription Read the button gallery file for this gallery item.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/buttongalleryfiles/:id  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * 
        * @apiSuccess       {Object}        GalleryItem                                         the galleryitem object
        * @apiSuccess       {Number}        GalleryItem.GalleryItemID                           The id of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.SiteID                                  Your site's account number.
        * @apiSuccess       {Number}        GalleryItem.UserID                                  The id of the user.
        * @apiSuccess       {Number}        GalleryItem.ItemType                                The type of gallery item, 1: skin, 2: button, 3: headshot, 4: invitation
        * @apiSuccess       {Date}          GalleryItem.DateCreated                             The date and time the gallery item was created.
        * @apiSuccess       {String}        GalleryItem.Description                             The description of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Title                                   The title of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Location                                The location of the gallery item.
        * @apiSuccess       {Boolean}       GalleryItem.IsActive                                Is the gallery item active?
        * @apiSuccess       {Boolean}       GalleryItem.Contributed                             Is the gallery item contributed?
        * @apiSuccess       {Number}        GalleryItem.Rank                                    The rank of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.CreatedBy                               The id of the user that created the gallery item.
        * @apiSuccess       {String}        GalleryItem.HtmlFile                                The html file for the gallery item.
        * @apiSuccess       {String}        GalleryItem.JSFile                                  The java script file for the gallery item.
        * @apiSuccess       {String}        GalleryItem.CSSFile                                 The css file for the gallery item.
        * @apiSuccess       {String}        GalleryItem.ThumbnailImageUrl                       The url for the thumbnail image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.FullImageUrl                            The url for the full image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.ImagePreviewUrl                         The url for the preview image for the gallery item.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "GalleryItemID":1,
        *           "SiteID":1,
        *           "UserID":1,
        *           "ItemType":1,
        *           "DateCreated":"1/1/2014 12:00 am",
        *           "Description":"Description of buttion gallery",
        *           "Title":"Button Gallery",
        *           "Location":"www.mydomain.com/buttongalleries/",
        *           "IsActive":true,
        *           "Contributed":true,
        *           "Rank":1,
        *           "CreatedBy":1,
        *           "HtmlFile":"galleryfile.html",
        *           "JSFile":"galleryfile.js",
        *           "CSSFile":"galleryfile.css",
        *           "ThumbnailImageUrl":"www.mydomain.com/buttongalllery/thumbnail.jpg",
        *           "FullImageUrl":"www.mydomain.com/buttongallery/fullimage.jpg",
        *           "ImagePreviewUrl":"www.mydomain.com/buttongallery/imagepreview.jpg"
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
        public void GetButtonFiles(int galleryItemID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/galleryitemcontroller/createonlinejpg/:groupID/:galleryItemID/ create online jpg
        * @apiName postonlinejpg
        * @apiGroup Settings > /gallery item
        * @apiDescription Create an image file for the online button this gallery item.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/createonlinejpg/:groupID/:galleryItemID  \
        *       -H "Authorization: Basic {authorizationToken}"  
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        groupID                                             The id of the group
        * @apiParam         {Number}        galleryItemID                                       The id of the gallery item.
        * 
        * @apiSuccess       {String}        fileURL                                             The url of the jpg that was created.
        *
        * @apiSuccessExample {text} Success-Response:
        *     HTTP/1.1 200 OK
        *     {www.mydomain.com/galleryItem/item.jpg}
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
        public void CreateOnlineJPG(int groupID, int galleryItemID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/galleryitemcontroller/createofflinejpg/:groupID/:galleryItemID create offline jpg
        * @apiName postofflinejpg
        * @apiGroup Settings > /gallery item
        * @apiDescription Create an image file for the offline button this gallery item.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/createonlinejpg/:groupID/:galleryItemID  \
        *       -H "Authorization: Basic {authorizationToken}"  
        * 
        * @apiParam         {Number}        siteID                                                      The site's unique id.
        * @apiParam         {Number}        groupID                                                     The id of the group.
        * @apiParam         {Number}        galleryItemID                                               The id of the gallery item.
        * 
        * @apiSuccess       {String}        fileURL                                                     The url of the jpg that was created.
        *
        * @apiSuccessExample {text} Success-Response:
        *     HTTP/1.1 200 OK
        *     {www.mydomain.com/galleryItem/item.jpg}
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
        public void CreateOfflineJPG(int groupID, int galleryItemID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/galleryitemcontroller/uploadbutton upload button
        * @apiName postbutton
        * @apiGroup Settings > /gallery item
        * @apiDescription Upload a new button to be used in a gallery for this site.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/uploadbutton \
        *       -H "Authorization: Basic {authorizationToken}" /
        *       -H "Content-Type: application/json" /
        *       -d "{formdata}"  
        * 
        * @apiParam         {Number}                                                            Your site's account number.
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
        public void  UploadButton()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/galleryitemcontroller/deletebutton/:galleryItemID delete button
        * @apiName postdeletebutton
        * @apiGroup Settings > /gallery item
        * @apiDescription Delete button for this gallery item.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/deletebutton/:galleryItemID
        *       -H "Authorization: Basic {authorizationToken}" 
        *  
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        galleryItemID                                       The id of the gallery item.
        * 
        * @apiSuccess       {Number}        galleryItemID                                       The id of the gallery item.
        *
        * @apiSuccessExample {text} Success-Response:
        *     HTTP/1.1 200 OK
        *     {www.mydomain.com/galleryItem/item.jpg}
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
        public void DeleteButton(int galleryItemID)
        {
        }

        #endregion Gallery Button related

        #region Gallery Invitation related

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/galleryitemcontroller/invitationgalleries read all invitation galleries
        * @apiName getallinvitationgalleries
        * @apiGroup Settings > /gallery item
        * @apiDescription Read the gallery items that are invitations for this site.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/invitationgalleries  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * 
        * @apiSuccess       {Object[]}      GalleryItem                                         the galleryitem object
        * @apiSuccess       {Number}        GalleryItem.GalleryItemID                           The id of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.SiteID                                  Your site's account number.
        * @apiSuccess       {Number}        GalleryItem.UserID                                  The user id.
        * @apiSuccess       {Number}        GalleryItem.ItemType                                The type of gallery item, 1: skin, 2: button, 3: headshot, 4: invitation
        * @apiSuccess       {Date}          GalleryItem.DateCreated                             The date and time the gallery item was created.
        * @apiSuccess       {String}        GalleryItem.Description                             The description of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Title                                   The title of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Location                                The location of the gallery item.
        * @apiSuccess       {Boolean}       GalleryItem.IsActive                                Is the gallery item active?
        * @apiSuccess       {Boolean}       GalleryItem.Contributed                             Is the gallery item contributed?
        * @apiSuccess       {Number}        GalleryItem.Rank                                    The rank of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.CreatedBy                               The id of the user that created the gallery item.
        * @apiSuccess       {String}        GalleryItem.HtmlFile                                The html file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.JSFile                                  The java script file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.CSSFile                                 The css file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.ThumbnailImageUrl                       The url of the thumbnail image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.FullImageUrl                            The url of the full image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.ImagePreviewUrl                         The url of the preview image for the gallery item.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"GalleryItemID":1,
        *           "SiteID":1,
        *           "UserID":1,
        *           "ItemType":1,
        *           "DateCreated":"1/1/2014 12:00 am",
        *           "Description":"Description of buttion gallery",
        *           "Title":"Button Gallery",
        *           "Location":"www.mydomain.com/buttongalleries/",
        *           "IsActive":true,
        *           "Contributed":true,
        *           "Rank":1,
        *           "CreatedBy":1,
        *           "HtmlFile":"galleryfile.html",
        *           "JSFile":"galleryfile.js",
        *           "CSSFile":"galleryfile.css",
        *           "ThumbnailImageUrl":"www.mydomain.com/buttongalllery/thumbnail.jpg",
        *           "FullImageUrl":"www.mydomain.com/buttongallery/fullimage.jpg",
        *           "ImagePreviewUrl":"www.mydomain.com/buttongallery/imagepreview.jpg"
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
        public void GetInvitationGalleries()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/galleryitemcontroller/invitationgalleryfiles/:id read invitation gallery file
        * @apiName getinvitationgalleryfile
        * @apiGroup Settings > /gallery item
        * @apiDescription Read the invitation gallery files for this gallery item.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/invitationgalleryfiles/:id  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id of the gallery item to read.
        * 
        * @apiSuccess       {Object}        GalleryItem                                         the galleryitem object
        * @apiSuccess       {Number}        GalleryItem.GalleryItemID                           The id of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.SiteID                                  Your site's account number.
        * @apiSuccess       {Number}        GalleryItem.UserID                                  The user id.
        * @apiSuccess       {Number}        GalleryItem.ItemType                                The type of gallery item, 1: skin, 2: button, 3: headshot, 4: invitation
        * @apiSuccess       {Date}          GalleryItem.DateCreated                             The date and time the gallery item was created.
        * @apiSuccess       {String}        GalleryItem.Description                             The description of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Title                                   The title of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Location                                The location of the gallery item.
        * @apiSuccess       {Boolean}       GalleryItem.IsActive                                Is the gallery item active?
        * @apiSuccess       {Boolean}       GalleryItem.Contributed                             Is the gallery item contributed?
        * @apiSuccess       {Number}        GalleryItem.Rank                                    The rank of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.CreatedBy                               The id of the user that created the gallery item.
        * @apiSuccess       {String}        GalleryItem.HtmlFile                                The html file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.JSFile                                  The java script file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.CSSFile                                 The css file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.ThumbnailImageUrl                       The url of the thumbnail image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.FullImageUrl                            The url of the full image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.ImagePreviewUrl                         The url of the preview image for the gallery item.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "GalleryItemID":1,
        *           "SiteID":1,
        *           "UserID":1,
        *           "ItemType":1,
        *           "DateCreated":"1/1/2014 12:00 am",
        *           "Description":"Description of buttion gallery",
        *           "Title":"Button Gallery",
        *           "Location":"www.mydomain.com/buttongalleries/",
        *           "IsActive":true,
        *           "Contributed":true,
        *           "Rank":1,
        *           "CreatedBy":1,
        *           "HtmlFile":"galleryfile.html",
        *           "JSFile":"galleryfile.js",
        *           "CSSFile":"galleryfile.css",
        *           "ThumbnailImageUrl":"www.mydomain.com/buttongalllery/thumbnail.jpg",
        *           "FullImageUrl":"www.mydomain.com/buttongallery/fullimage.jpg",
        *           "ImagePreviewUrl":"www.mydomain.com/buttongallery/imagepreview.jpg"
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
        public void GetInvitationFiles(int galleryItemID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/galleryitemcontroller/contributeinvitation contribute invitation
        * @apiName postcontributeinvitation
        * @apiGroup Settings > /gallery item
        * @apiDescription Contribute an invitation to this gallery.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/contributeinvitation  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID":1,"Name":"sales invitation","Description":"sales invitation.","SecondsToDisplay":30,"WaitSecondsBeforeNextDisplay":90,"ShouldFloat":false,"StartLocationX":300,"StartLocationY":-75,"EndLocationX":300,"EndLocationY":-75,"AnchorTo":"invitation_div","Width":150,"Height":75,"FloatSpeed":0,"TransparentBackground":true,"RefireAfterClose":false,"Contents":"This is the sales invitatoin content","IsDeleted":false,"Priority":1,"InvitationType":2"GalleryItemID":1,"StartingAnimationPosition":0,"EndingAnimationPosition":0,"PopUpPosition": 1,"JSFile":"www.mydomain.com/invitationjsfile.js","CSSFile":"www.mydomain.com/invitationcssfile.css","ThumbnailImageUrl":"www.mydomain.com/thumbnailimage.jpg","FullImageUrl":"www.mydomain.com/fullimage.jpg","ImagePrviewUrl":"www.mydomain.com/imagepreview.jpg"}"
        * 
        * @apiParam         {Number}        siteID                                                      Your site's account number.
        * @apiParam         {Object}        InvitationViewModel                                         the invitationviewmodel object
        * @apiParam         {Number}        InvitationViewModel.SiteID                                  Your site's account number.
        * @apiParam         {String}        InvitationViewModel.Name                                    The name of the invitation.
        * @apiParam         {String}        InvitationViewModel.Description                             The description of the invitation.
        * @apiParam         {Number}        InvitationViewModel.SecondsToDisplay                        The number of seconds to display the invitation.
        * @apiParam         {Number}        InvitationViewModel.WaitSecondsBeforeNextDisplay            The number of seconds to wait before displaying the next invitation.
        * @apiParam         {Boolean}       InvitationViewModel.ShouldFloat                             Does the invitation float?
        * @apiParam         {Number}        InvitationViewModel.StartLocationX                          The x coordinate of the starting location.
        * @apiParam         {Number}        InvitationViewModel.StartLocationY                          The y coordinate of the starting location.
        * @apiParam         {Number}        InvitationViewModel.EndLocationX                            The x coordinate of the ending location.
        * @apiParam         {Number}        InvitationViewModel.EndLocationY                            The y coordinate of the ending location.
        * @apiParam         {String}        InvitationViewModel.AnchorTo                                The element to which the invitation is anchored.
        * @apiParam         {Number}        InvitationViewModel.Width                                   The width of the invitation.
        * @apiParam         {Number}        InvitationViewModel.Height                                  The height of theinvitatoin.
        * @apiParam         {Number}        InvitationViewModel.FloatSpeed                              The speed in seconds which the invitation floats if ShouldFloat is enabled.
        * @apiParam         {Boolean}       InvitationViewModel.TransparentBackground                   Is the background transparent for the invitation?
        * @apiParam         {Boolean}       InvitationViewModel.RefireAfterClose                        Should the invitation be fired again after it is closed?
        * @apiParam         {String}        InvitationViewModel.Contents                                The contents of the invitation.
        * @apiParam         {Boolean}       InvitationViewModel.IsDeleted                               Has the invitation been deleted?
        * @apiParam         {Number}        InvitationViewModel.Priority                                The priority level of the invitation.
        * @apiParam         {Number}        InvitationViewModel.InvitationType                          The type of the invitation.
        * @apiParam         {Number}        InvitationViewModel.GalleryItemID                           The id of the gallery item for the invitation.
        * @apiParam         {Number}        InvitationViewModel.StartingAnimationPosition               The starting position for animation of the invitation.
        * @apiParam         {Number}        InvitationViewModel.EndingAnimationPosition                 The ending position for animation of the inviation.
        * @apiParam         {Number}        InvitationViewModel.PopUpPosition                           The popup position of the invitation.
        * @apiParam         {String}        InvitationViewModel.JSile                                   The javascript file to be used with the invitation.
        * @apiParam         {String}        InvitationViewModel.CSSFile                                 The css file to be used with the invitation.
        * @apiParam         {String}        InvitationViewModel.ThumbnailImageUrl                       The url of the thumbnail image of the inviation.
        * @apiParam         {String}        InvitationViewModel.FullImageUrl                            The url of the full image of the inviation.
        * @apiParam         {String}        InvitationViewModel.ImagePreviewUrl                         The url of the preview image of the invitation.
        *
        * @apiSuccess       {Number}        id                                                          The id of the gallery item.
        * 
        * @apiSuccessExample {text} Success-Response:
        *     HTTP/1.1 200 OK
        *     {123}
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
        public void ContributeInvitation(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/galleryitemcontroller/deleteinvitation/:galleryItemID delete invitation
        * @apiName postdeleteinvitation
        * @apiGroup Settings > /gallery item
        * @apiDescription Delete the invitation for this gallery item.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/deleteinvitation/:galleryItemID \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        galleryItemID                                       The id of the gallery item to delete.
        * 
        * @apiSuccess       {Number}        galleryItemID                                       The id of the deleted gallery item.
        *
        * @apiSuccessExample {text} Success-Response:
        *     HTTP/1.1 200 OK
        *     {123}
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
        public void DeleteInvitation(int galleryItemID)
        {
        }

        #endregion Gallery Invitation related

        #region Gallery Skin related

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/galleryitemcontroller/skingalleries read all skin galleries
        * @apiName getallskingalleries
        * @apiGroup Settings > /gallery item
        * @apiDescription Read the gallery items that are skins for this site.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/skingalleries  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * 
        * @apiSuccess       {Object[]}      GalleryItem                                         the galleryitem object
        * @apiSuccess       {Number}        GalleryItem.GalleryItemID                           The id of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.SiteID                                  Your site's account number.
        * @apiSuccess       {Number}        GalleryItem.UserID                                  The user id.
        * @apiSuccess       {Number}        GalleryItem.ItemType                                The type of gallery item, 1: skin, 2: button, 3: headshot, 4: invitation
        * @apiSuccess       {Date}          GalleryItem.DateCreated                             The date and time the gallery item was created.
        * @apiSuccess       {String}        GalleryItem.Description                             The description of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Title                                   The title of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Location                                The location of the gallery item.
        * @apiSuccess       {Boolean}       GalleryItem.IsActive                                Is the gallery item active?
        * @apiSuccess       {Boolean}       GalleryItem.Contributed                             Is the gallery item contributed?
        * @apiSuccess       {Number}        GalleryItem.Rank                                    The rank of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.CreatedBy                               The id of the user that created the gallery item.
        * @apiSuccess       {String}        GalleryItem.HtmlFile                                The html file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.JSFile                                  The java script file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.CSSFile                                 The css file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.ThumbnailImageUrl                       The url of the thumbnail image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.FullImageUrl                            The url of the full image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.ImagePreviewUrl                         The url of the preview image for the gallery item.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"GalleryItemID":1,
        *           "SiteID":1,
        *           "UserID":1,
        *           "ItemType":1,
        *           "DateCreated":"1/1/2014 12:00 am",
        *           "Description":"Description of buttion gallery",
        *           "Title":"Button Gallery",
        *           "Location":"www.mydomain.com/buttongalleries/",
        *           "IsActive":true,
        *           "Contributed":true,
        *           "Rank":1,
        *           "CreatedBy":1,
        *           "HtmlFile":"galleryfile.html",
        *           "JSFile":"galleryfile.js",
        *           "CSSFile":"galleryfile.css",
        *           "ThumbnailImageUrl":"www.mydomain.com/buttongalllery/thumbnail.jpg",
        *           "FullImageUrl":"www.mydomain.com/buttongallery/fullimage.jpg",
        *           "ImagePreviewUrl":"www.mydomain.com/buttongallery/imagepreview.jpg"
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
        public void GetSkinGalleries()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/galleryitemcontroller/skingalleryfiles/:galleryItemID read Skin gallery files
        * @apiName getallskingalleryfiles
        * @apiGroup Settings > /gallery item
        * @apiDescription Read the skin gallery files for this gallery item.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/skingalleries/:galleryItemID  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        galleryItemID                                       The id of the gallery item to read. 
        * 
        * @apiSuccess       {Object}        GalleryItem                                         the galleryitem object
        * @apiSuccess       {Number}        GalleryItem.galleryItemID                           The id of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.siteID                                  Your site's account number.
        * @apiSuccess       {Number}        GalleryItem.userID                                  The user id.
        * @apiSuccess       {Number}        GalleryItem.itemType                                The type of gallery item, 1: skin, 2: button, 3: headshot, 4: invitation
        * @apiSuccess       {Date}          GalleryItem.dateCreated                             The date and time the gallery item was created.
        * @apiSuccess       {String}        GalleryItem.description                             The description of the gallery item.
        * @apiSuccess       {String}        GalleryItem.title                                   The title of the gallery item.
        * @apiSuccess       {String}        GalleryItem.location                                The location of the gallery item.
        * @apiSuccess       {Boolean}       GalleryItem.isActive                                Is the gallery item active?
        * @apiSuccess       {Boolean}       GalleryItem.contributed                             Is the gallery item contributed?
        * @apiSuccess       {Number}        GalleryItem.rank                                    The rank of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.createdBy                               The id of the user that created the gallery item.
        * @apiSuccess       {String}        GalleryItem.htmlFile                                The html file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.jsFile                                  The java script file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.cssFile                                 The css file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.thumbnailImageUrl                       The url of the thumbnail image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.fullImageUrl                            The url of the full image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.imagePreviewUrl                         The url of the preview image for the gallery item.
        *
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "GalleryItemID":1,
        *           "SiteID":1,
        *           "UserID":1,
        *           "ItemType":1,
        *           "DateCreated":"1/1/2014 12:00 am",
        *           "Description":"Description of buttion gallery",
        *           "Title":"Button Gallery",
        *           "Location":"www.mydomain.com/buttongalleries/",
        *           "IsActive":true,
        *           "Contributed":true,
        *           "Rank":1,
        *           "CreatedBy":1,
        *           "HtmlFile":"galleryfile.html",
        *           "JSFile":"galleryfile.js",
        *           "CSSFile":"galleryfile.css",
        *           "ThumbnailImageUrl":"www.mydomain.com/buttongalllery/thumbnail.jpg",
        *           "FullImageUrl":"www.mydomain.com/buttongallery/fullimage.jpg",
        *           "ImagePreviewUrl":"www.mydomain.com/buttongallery/imagepreview.jpg"
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
        public void GetSkinFiles(int galleryItemID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/galleryitemcontroller/contributeskin contribute skin
        * @apiName postcontributeskin
        * @apiGroup Settings > /gallery Item
        * @apiDescription Contribute an skin to this gallery.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/contributeskin  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"GroupID":1,"SkinTitle":"sales skin","SkinDescription":"sales skin","PopoutChatJSFile":"www.mydomain.com/popoutchat.js","PopoutChatCSSFile":"www.mydomain.com/popoutchat.css","ImagePreviewUrl":"www.mydomain.com/popoutchatpreview.jpg"}"
        * 
        * @apiParam         {Number}        siteID                                                      Your site's account number.
        * @apiParam         {Object]        PopoutChatDesignerViewModel                                 the popoutchatdesignerviewmodel object
        * @apiParam         {Number}        PopoutChatDesignerViewModel.groupID                         The id of the skin.
        * @apiParam         {String}        PopoutChatDesignerViewModel.skinTitle                       The title of the skin.
        * @apiParam         {String}        PopoutChatDesignerViewModel.skinDescription                 The description of the skin.
        * @apiParam         {String}        PopoutChatDesignerViewModel.popoutChatJSFile                The javascript file to be used with the skin.
        * @apiParam         {String}        PopoutChatDesignerViewModel.popoutChatCSSFile               The css file to be used with the skin.
        * @apiParam         {String}        PopoutChatDesignerViewModel.imagePreviewUrl                 The url to preview the image of the skin.
        *
        * @apiSuccess       {Number}        id                                                          The id of the gallery item.
        *
        * @apiSuccessExample {text} Success-Response:
        *     HTTP/1.1 200 OK
        *     {123}  
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
        public void ContributeSkin(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/galleryitemcontroller/createskin create skin
        * @apiName postskin
        * @apiGroup Settings > /gallery item
        * @apiDescription Create a new skin for this gallery.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/galleryitemcontroller/createskin  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID":1,"GroupID":1,"ImagePreviewUrl":"www.mydomain.com/skinimagepreviewurl.jpg"}"
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object]        GalleryItemCreateModel                              the galleryitemcreatmodel object
        * @apiParam         {Number}        GalleryItemCreateModel.SiteId                       Your site's account number.
        * @apiParam         {Number}        GalleryItemCreateModel.GroupID                      The id of the group.
        * @apiParam         {String}        GalleryItemCreateModel.ImagePreviewUrl              The url to preview the image for the skin.
        *
        * @apiSuccess       {Object}        GalleryItem                                         the galleryitem object
        * @apiSuccess       {Number}        GalleryItem.GalleryItemID                           The id of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.SiteID                                  Your site's account number.
        * @apiSuccess       {Number}        GalleryItem.UserID                                  The user id.
        * @apiSuccess       {Number}        GalleryItem.ItemType                                The type of gallery item, 1: skin, 2: button, 3: headshot, 4: invitation
        * @apiSuccess       {Date}          GalleryItem.DateCreated                             The date and time the gallery item was created.
        * @apiSuccess       {String}        GalleryItem.Description                             The description of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Title                                   The title of the gallery item.
        * @apiSuccess       {String}        GalleryItem.Location                                The location of the gallery item.
        * @apiSuccess       {Boolean}       GalleryItem.IsActive                                Is the gallery item active?
        * @apiSuccess       {Boolean}       GalleryItem.Contributed                             Is the gallery item contributed?
        * @apiSuccess       {Number}        GalleryItem.Rank                                    The rank of the gallery item.
        * @apiSuccess       {Number}        GalleryItem.CreatedBy                               The id of the user that created the gallery item.
        * @apiSuccess       {String}        GalleryItem.HtmlFile                                The html file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.JSFile                                  The java script file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.CSSFile                                 The css file of the gallery item.
        * @apiSuccess       {String}        GalleryItem.ThumbnailImageUrl                       The url of the thumbnail image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.FullImageUrl                            The url of the full image of the gallery item.
        * @apiSuccess       {String}        GalleryItem.ImagePreviewUrl                         The url of the preview image for the gallery item.
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "GalleryItemID":1,
        *           "SiteID":1,
        *           "UserID":1,
        *           "ItemType":1,
        *           "DateCreated":"1/1/2014 12:00 am",
        *           "Description":"Description of buttion gallery",
        *           "Title":"Button Gallery",
        *           "Location":"www.mydomain.com/buttongalleries/",
        *           "IsActive":true,
        *           "Contributed":true,
        *           "Rank":1,
        *           "CreatedBy":1,
        *           "HtmlFile":"galleryfile.html",
        *           "JSFile":"galleryfile.js",
        *           "CSSFile":"galleryfile.css",
        *           "ThumbnailImageUrl":"www.mydomain.com/buttongalllery/thumbnail.jpg",
        *           "FullImageUrl":"www.mydomain.com/buttongallery/fullimage.jpg",
        *           "ImagePreviewUrl":"www.mydomain.com/buttongallery/imagepreview.jpg"
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
        public void CreateSkin(string model)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/galleryitemcontroller/deleteskin/:galleryItemID delete skin
        * @apiName deleteskin
        * @apiGroup Settings > /gallery item
        * @apiDescription Delete a skin from this gallery.
        * @apiPermission siteAdministrator
        *
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        galleryItemID                                       The id of the gallery item to delete.
        *
        * @apiSuccess       {Number}        galleryItemID                                       The id of the deleted gallery item.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {123}  
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
        public void DeleteSkin(int galleryItemID)
        {
        }
        #endregion Gallery Skin related
    }
}
