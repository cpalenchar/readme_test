using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class InvitationController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/invitationcontroller read all
        * @apiName get
        * @apiGroup SETTINGS > /invitation
        * @apiDescription Read all the invitations for a site.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/invitationcontroller  \
        *       -H "Authorization: Basic {authorizationToken} 
        * 
        * @apiParam         {Number}        siteID                                                      Your site's account number.
        *
        * @apiSuccess       {Object[]}      InvitationViewModel                                         the invitationviewmodel object
        * @apiSuccess       {Number}        InvitationViewModel.InvitationID                            The id of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.SiteID                                  Your site's account number.
        * @apiSuccess       {String}        InvitationViewModel.Name                                    The name of the invitation.
        * @apiSuccess       {String}        InvitationViewModel.Description                             The description of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.SecondsToDisplay                        The number of seconds to display the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.WaitSecondsBeforeNextDisplay            The number of seconds to wait before displaying the next invitation.
        * @apiSuccess       {Boolean}       InvitationViewModel.ShouldFloat                             Does the invitation float?
        * @apiSuccess       {Number}        InvitationViewModel.StartLocationX                          The x coordinate of the starting location.
        * @apiSuccess       {Number}        InvitationViewModel.StartLocationY                          The y coordinate of the starting location.
        * @apiSuccess       {Number}        InvitationViewModel.EndLocationX                            The x coordinate of the ending location.
        * @apiSuccess       {Number}        InvitationViewModel.EndLocationY                            The y coordinate of the ending location.
        * @apiSuccess       {String}        InvitationViewModel.AnchorTo                                The element to which the invitation is anchored.
        * @apiSuccess       {Number}        InvitationViewModel.Width                                   The width of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.Height                                  The height of theinvitatoin.
        * @apiSuccess       {Number}        InvitationViewModel.floatSpeed                              The speed in seconds which the invitation floats if ShouldFloat is enabled.
        * @apiSuccess       {Boolean}       InvitationViewModel.TransparentBackground                   Is the background transparent for the invitation?
        * @apiSuccess       {Boolean}       InvitationViewModel.RefireAfterClose                        Should the invitation be fired again after it is closed?
        * @apiSuccess       {String}        InvitationViewModel.Contents                                The contents of the invitation.
        * @apiSuccess       {Boolean}       InvitationViewModel.IsDeleted                               Has the invitation been deleted?
        * @apiSuccess       {Number}        InvitationViewModel.Priority                                The priority level of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.InvitationType                          The type of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.GalleryItemID                           The unique id of the gallery item for the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.StartingAnimationPosition               The starting position for animation of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.EndingAnimationPosition                 The ending position for animation of the inviation.
        * @apiSuccess       {Number}        InvitationViewModel.PopUpPosition                           The popup position of the invitation.
        * @apiSuccess       {String}        InvitationViewModel.JSFile                                  The javascript file to be used with the invitation.
        * @apiSuccess       {String}        InvitationViewModel.CSSFile                                 The css file to be used with the invitation.
        * @apiSuccess       {String}        InvitationViewModel.ThumbnailImageUrl                       The url of the thumbnail image of the inviation.
        * @apiSuccess       {String}        InvitationViewModel.FullImageUrl                            The url of the full image of the inviation.
        * @apiSuccess       {String}        InvitationViewModel.ImagePreviewUrl                         The url of the preview image of the invitation.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"InvitationID":1,
        *          "SiteID":1,
        *          "Name":"sales invitation",
        *          "Description":"sales invitation.",
        *          "SecondsToDisplay":30,
        *          "WaitSecondsBeforeNextDisplay":90,
        *          "ShouldFloat":false,
        *          "StartLocationX":300,
        *          "StartLocationY":-75,
        *          "EndLocationX":300,
        *          "EndLocationY":-75,
        *          "AnchorTo":"invitation_div", 
        *          "Width":150,
        *          "Height":75,
        *          "FloatSpeed":0,
        *          "TransparentBackground":true,
        *          "RefireAfterClose":false,
        *          "Contents":"This is the sales invitatoin content",
        *          "IsDeleted":false,
        *          "Priority":1,
        *          "InvitationType":2,
        *          "GalleryItemID":1,
        *          "StartingAnimationPosition":0,
        *          "EndingAnimationPosition":0,
        *          "PopUpPosition":1, 
        *          "JSFile":"www.mydomain.com/invitationjsfile.js",
        *          "CSSFile":"www.mydomain.com/invitationcssfile.css", 
        *          "ThumbnailImageUrl":"www.mydomain.com/thumbnailimage.jpg", 
        *          "FullImageUrl":"www.mydomain.com/fullimage.jpg",
        *          "ImagePrviewUrl": "www.mydomain.com/imagepreview.jpg"
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
        public void GetBySite()
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/invitationcontroller/:invitationID read
        * @apiName get:invitationID
        * @apiGroup SETTINGS > /invitation
        * @apiDescription Read the invitation for this unique id.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/invitationcontroller/:invitationID  \
        *       -H "Authorization: Basic {authorizationToken}  
        * 
        * @apiParam         {Number}        siteID                                                      Your site's account number.
        * @apiParam         {Number}        invitationID                                                The id of the invitation to read.
        *
        * @apiSuccess       {Object}        InvitationViewModel                                         the invitationviewmodel object
        * @apiSuccess       {Number}        InvitationViewModel.InvitationID                            The id of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.SiteID                                  Your site's account number.
        * @apiSuccess       {String}        InvitationViewModel.Name                                    The name of the invitation.
        * @apiSuccess       {String}        InvitationViewModel.Description                             The description of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.SecondsToDisplay                        The number of seconds to display the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.WaitSecondsBeforeNextDisplay            The number of seconds to wait before displaying the next invitation.
        * @apiSuccess       {Boolean}       InvitationViewModel.ShouldFloat                             Does the invitation float?
        * @apiSuccess       {Number}        InvitationViewModel.StartLocationX                          The x coordinate of the starting location.
        * @apiSuccess       {Number}        InvitationViewModel.StartLocationY                          The y coordinate of the starting location.
        * @apiSuccess       {Number}        InvitationViewModel.EndLocationX                            The x coordinate of the ending location.
        * @apiSuccess       {Number}        InvitationViewModel.EndLocationY                            The y coordinate of the ending location.
        * @apiSuccess       {String}        InvitationViewModel.AnchorTo                                The element to which the invitation is anchored.
        * @apiSuccess       {Number}        InvitationViewModel.Width                                   The width of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.Height                                  The height of theinvitatoin.
        * @apiSuccess       {Number}        InvitationViewModel.floatSpeed                              The speed in seconds which the invitation floats if ShouldFloat is enabled.
        * @apiSuccess       {Boolean}       InvitationViewModel.TransparentBackground                   Is the background transparent for the invitation?
        * @apiSuccess       {Boolean}       InvitationViewModel.RefireAfterClose                        Should the invitation be fired again after it is closed?
        * @apiSuccess       {String}        InvitationViewModel.Contents                                The contents of the invitation.
        * @apiSuccess       {Boolean}       InvitationViewModel.IsDeleted                               Has the invitation been deleted?
        * @apiSuccess       {Number}        InvitationViewModel.Priority                                The priority level of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.InvitationType                          The type of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.GalleryItemID                           The unique id of the gallery item for the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.StartingAnimationPosition               The starting position for animation of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.EndingAnimationPosition                 The ending position for animation of the inviation.
        * @apiSuccess       {Number}        InvitationViewModel.PopUpPosition                           The popup position of the invitation.
        * @apiSuccess       {String}        InvitationViewModel.JSFile                                  The javascript file to be used with the invitation.
        * @apiSuccess       {String}        InvitationViewModel.CSSFile                                 The css file to be used with the invitation.
        * @apiSuccess       {String}        InvitationViewModel.ThumbnailImageUrl                       The url of the thumbnail image of the inviation.
        * @apiSuccess       {String}        InvitationViewModel.FullImageUrl                            The url of the full image of the inviation.
        * @apiSuccess       {String}        InvitationViewModel.ImagePreviewUrl                         The url of the preview image of the invitation.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "InvitationID":1,
        *          "SiteID":1,
        *          "Name":"sales invitation",
        *          "Description":"sales invitation.",
        *          "SecondsToDisplay":30,
        *          "WaitSecondsBeforeNextDisplay":90,
        *          "ShouldFloat":false,
        *          "StartLocationX":300,
        *          "StartLocationY":-75,
        *          "EndLocationX":300,
        *          "EndLocationY":-75,
        *          "AnchorTo":"invitation_div", 
        *          "Width":150,
        *          "Height":75,
        *          "FloatSpeed":0,
        *          "TransparentBackground":true,
        *          "RefireAfterClose":false,
        *          "Contents":"This is the sales invitatoin content",
        *          "IsDeleted":false,
        *          "Priority":1,
        *          "InvitationType":2,
        *          "GalleryItemID":1,
        *          "StartingAnimationPosition":0,
        *          "EndingAnimationPosition":0,
        *          "PopUpPosition":1, 
        *          "JSFile":"www.mydomain.com/invitationjsfile.js",
        *          "CSSFile":"www.mydomain.com/invitationcssfile.css", 
        *          "ThumbnailImageUrl":"www.mydomain.com/thumbnailimage.jpg", 
        *          "FullImageUrl":"www.mydomain.com/fullimage.jpg",
        *          "ImagePrviewUrl": "www.mydomain.com/imagepreview.jpg"
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
        public void Get(int siteID, int invitationID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/invitationcontroller/getgalleryitem/:galleryItemID read by gallery item
        * @apiNamegGet:galleryItemID
        * @apiGroup SETTINGS > /invitation
        * @apiDescription Read the invitation for this gallery item.
        * @apiPermission siteManager
        * 
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/invitationcontroller/:galleryItemID  \
        *       -H "Authorization: Basic {authorizationToken}  
        *
        * @apiParam         {Number}        siteID                                                      Your site's account number.
        * @apiParam         {Number}        galleryItemID                                               The gallery id of the invitation to read.
        *
        * @apiSuccess       {Object}        InvitationViewModel                                         the invitationviewmodel object
        * @apiSuccess       {Number}        InvitationViewModel.InvitationID                            The id of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.SiteID                                  Your site's account number.
        * @apiSuccess       {String}        InvitationViewModel.Name                                    The name of the invitation.
        * @apiSuccess       {String}        InvitationViewModel.Description                             The description of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.SecondsToDisplay                        The number of seconds to display the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.WaitSecondsBeforeNextDisplay            The number of seconds to wait before displaying the next invitation.
        * @apiSuccess       {Boolean}       InvitationViewModel.ShouldFloat                             Does the invitation float?
        * @apiSuccess       {Number}        InvitationViewModel.StartLocationX                          The x coordinate of the starting location.
        * @apiSuccess       {Number}        InvitationViewModel.StartLocationY                          The y coordinate of the starting location.
        * @apiSuccess       {Number}        InvitationViewModel.EndLocationX                            The x coordinate of the ending location.
        * @apiSuccess       {Number}        InvitationViewModel.EndLocationY                            The y coordinate of the ending location.
        * @apiSuccess       {String}        InvitationViewModel.AnchorTo                                The element to which the invitation is anchored.
        * @apiSuccess       {Number}        InvitationViewModel.Width                                   The width of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.Height                                  The height of theinvitatoin.
        * @apiSuccess       {Number}        InvitationViewModel.floatSpeed                              The speed in seconds which the invitation floats if ShouldFloat is enabled.
        * @apiSuccess       {Boolean}       InvitationViewModel.TransparentBackground                   Is the background transparent for the invitation?
        * @apiSuccess       {Boolean}       InvitationViewModel.RefireAfterClose                        Should the invitation be fired again after it is closed?
        * @apiSuccess       {String}        InvitationViewModel.Contents                                The contents of the invitation.
        * @apiSuccess       {Boolean}       InvitationViewModel.IsDeleted                               Has the invitation been deleted?
        * @apiSuccess       {Number}        InvitationViewModel.Priority                                The priority level of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.InvitationType                          The type of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.GalleryItemID                           The unique id of the gallery item for the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.StartingAnimationPosition               The starting position for animation of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.EndingAnimationPosition                 The ending position for animation of the inviation.
        * @apiSuccess       {Number}        InvitationViewModel.PopUpPosition                           The popup position of the invitation.
        * @apiSuccess       {String}        InvitationViewModel.JSFile                                  The javascript file to be used with the invitation.
        * @apiSuccess       {String}        InvitationViewModel.CSSFile                                 The css file to be used with the invitation.
        * @apiSuccess       {String}        InvitationViewModel.ThumbnailImageUrl                       The url of the thumbnail image of the inviation.
        * @apiSuccess       {String}        InvitationViewModel.FullImageUrl                            The url of the full image of the inviation.
        * @apiSuccess       {String}        InvitationViewModel.ImagePreviewUrl                         The url of the preview image of the invitation.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "InvitationID":1,
        *          "SiteID":1,
        *          "Name":"sales invitation",
        *          "Description":"sales invitation.",
        *          "SecondsToDisplay":30,
        *          "WaitSecondsBeforeNextDisplay":90,
        *          "ShouldFloat":false,
        *          "StartLocationX":300,
        *          "StartLocationY":-75,
        *          "EndLocationX":300,
        *          "EndLocationY":-75,
        *          "AnchorTo":"invitation_div", 
        *          "Width":150,
        *          "Height":75,
        *          "FloatSpeed":0,
        *          "TransparentBackground":true,
        *          "RefireAfterClose":false,
        *          "Contents":"This is the sales invitatoin content",
        *          "IsDeleted":false,
        *          "Priority":1,
        *          "InvitationType":2,
        *          "GalleryItemID":1,
        *          "StartingAnimationPosition":0,
        *          "EndingAnimationPosition":0,
        *          "PopUpPosition":1, 
        *          "JSFile":"www.mydomain.com/invitationjsfile.js",
        *          "CSSFile":"www.mydomain.com/invitationcssfile.css", 
        *          "ThumbnailImageUrl":"www.mydomain.com/thumbnailimage.jpg", 
        *          "FullImageUrl":"www.mydomain.com/fullimage.jpg",
        *          "ImagePrviewUrl": "www.mydomain.com/imagepreview.jpg"
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
        public void GetByGalleryItem(int galleryItemID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/invitationcontroller create
        * @apiName post
        * @apiGroup SETTINGS > /invitation
        * @apiDescription Create a new invitation.
        * @apiPermission siteManager
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/invitationcontroller  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID":1,"Name":"sales invitation","Description":"sales invitation.","SecondsToDisplay":30,"WaitSecondsBeforeNextDisplay":90,"ShouldFloat":false,"StartLocationX":300,"StartLocationY":-75,"EndLocationX":300,"EndLocationY":-75,"AnchorTo":"invitation_div","Width":150,"Height":75,"FloatSpeed":0,"TransparentBackground":true,"RefireAfterClose":false,"Contents":"This is the sales invitatoin content","IsDeleted":false,"Priority":1,"InvitationType":2,"GalleryItemID":1,"StartingAnimationPosition":0,"EndingAnimationPosition":0,"PopUpPosition":1,"JSFile":"www.mydomain.com/invitationjsfile.js","CSSFile":"www.mydomain.com/invitationcssfile.css","ThumbnailImageUrl":"www.mydomain.com/thumbnailimage.jpg","FullImageUrl":"www.mydomain.com/fullimage.jpg","ImagePrviewUrl": "www.mydomain.com/imagepreview.jpg"
        * 
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
        * @apiParam         {Number}        InvitationViewModel.floatSpeed                              The speed in seconds which the invitation floats if ShouldFloat is enabled.
        * @apiParam         {Boolean}       InvitationViewModel.TransparentBackground                   Is the background transparent for the invitation?
        * @apiParam         {Boolean}       InvitationViewModel.RefireAfterClose                        Should the invitation be fired again after it is closed?
        * @apiParam         {String}        InvitationViewModel.Contents                                The contents of the invitation.
        * @apiParam         {Boolean}       InvitationViewModel.IsDeleted                               Has the invitation been deleted?
        * @apiParam         {Number}        InvitationViewModel.Priority                                The priority level of the invitation.
        * @apiParam         {Number}        InvitationViewModel.InvitationType                          The type of the invitation.
        * @apiParam         {Number}        InvitationViewModel.GalleryItemID                           The unique id of the gallery item for the invitation.
        * @apiParam         {Number}        InvitationViewModel.StartingAnimationPosition               The starting position for animation of the invitation.
        * @apiParam         {Number}        InvitationViewModel.EndingAnimationPosition                 The ending position for animation of the inviation.
        * @apiParam         {Number}        InvitationViewModel.PopUpPosition                           The popup position of the invitation.
        * @apiParam         {String}        InvitationViewModel.JSFile                                  The javascript file to be used with the invitation.
        * @apiParam         {String}        InvitationViewModel.CSSFile                                 The css file to be used with the invitation.
        * @apiParam         {String}        InvitationViewModel.ThumbnailImageUrl                       The url of the thumbnail image of the inviation.
        * @apiParam         {String}        InvitationViewModel.FullImageUrl                            The url of the full image of the inviation.
        * @apiParam         {String}        InvitationViewModel.ImagePreviewUrl                         The url of the preview image of the invitation.
        *
        * @apiSuccess       {Object}        InvitationViewModel                                         the invitationviewmodel object
        * @apiSuccess       {Number}        InvitationViewModel.InvitationID                            The id of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.SiteID                                  Your site's account number.
        * @apiSuccess       {String}        InvitationViewModel.Name                                    The name of the invitation.
        * @apiSuccess       {String}        InvitationViewModel.Description                             The description of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.SecondsToDisplay                        The number of seconds to display the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.WaitSecondsBeforeNextDisplay            The number of seconds to wait before displaying the next invitation.
        * @apiSuccess       {Boolean}       InvitationViewModel.ShouldFloat                             Does the invitation float?
        * @apiSuccess       {Number}        InvitationViewModel.StartLocationX                          The x coordinate of the starting location.
        * @apiSuccess       {Number}        InvitationViewModel.StartLocationY                          The y coordinate of the starting location.
        * @apiSuccess       {Number}        InvitationViewModel.EndLocationX                            The x coordinate of the ending location.
        * @apiSuccess       {Number}        InvitationViewModel.EndLocationY                            The y coordinate of the ending location.
        * @apiSuccess       {String}        InvitationViewModel.AnchorTo                                The element to which the invitation is anchored.
        * @apiSuccess       {Number}        InvitationViewModel.Width                                   The width of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.Height                                  The height of theinvitatoin.
        * @apiSuccess       {Number}        InvitationViewModel.floatSpeed                              The speed in seconds which the invitation floats if ShouldFloat is enabled.
        * @apiSuccess       {Boolean}       InvitationViewModel.TransparentBackground                   Is the background transparent for the invitation?
        * @apiSuccess       {Boolean}       InvitationViewModel.RefireAfterClose                        Should the invitation be fired again after it is closed?
        * @apiSuccess       {String}        InvitationViewModel.Contents                                The contents of the invitation.
        * @apiSuccess       {Boolean}       InvitationViewModel.IsDeleted                               Has the invitation been deleted?
        * @apiSuccess       {Number}        InvitationViewModel.Priority                                The priority level of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.InvitationType                          The type of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.GalleryItemID                           The unique id of the gallery item for the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.StartingAnimationPosition               The starting position for animation of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.EndingAnimationPosition                 The ending position for animation of the inviation.
        * @apiSuccess       {Number}        InvitationViewModel.PopUpPosition                           The popup position of the invitation.
        * @apiSuccess       {String}        InvitationViewModel.JSFile                                  The javascript file to be used with the invitation.
        * @apiSuccess       {String}        InvitationViewModel.CSSFile                                 The css file to be used with the invitation.
        * @apiSuccess       {String}        InvitationViewModel.ThumbnailImageUrl                       The url of the thumbnail image of the inviation.
        * @apiSuccess       {String}        InvitationViewModel.FullImageUrl                            The url of the full image of the inviation.
        * @apiSuccess       {String}        InvitationViewModel.ImagePreviewUrl                         The url of the preview image of the invitation.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "InvitationID":1,
        *          "SiteID":1,
        *          "Name":"sales invitation",
        *          "Description":"sales invitation.",
        *          "SecondsToDisplay":30,
        *          "WaitSecondsBeforeNextDisplay":90,
        *          "ShouldFloat":false,
        *          "StartLocationX":300,
        *          "StartLocationY":-75,
        *          "EndLocationX":300,
        *          "EndLocationY":-75,
        *          "AnchorTo":"invitation_div", 
        *          "Width":150,
        *          "Height":75,
        *          "FloatSpeed":0,
        *          "TransparentBackground":true,
        *          "RefireAfterClose":false,
        *          "Contents":"This is the sales invitatoin content",
        *          "IsDeleted":false,
        *          "Priority":1,
        *          "InvitationType":2,
        *          "GalleryItemID":1,
        *          "StartingAnimationPosition":0,
        *          "EndingAnimationPosition":0,
        *          "PopUpPosition":1, 
        *          "JSFile":"www.mydomain.com/invitationjsfile.js",
        *          "CSSFile":"www.mydomain.com/invitationcssfile.css", 
        *          "ThumbnailImageUrl":"www.mydomain.com/thumbnailimage.jpg", 
        *          "FullImageUrl":"www.mydomain.com/fullimage.jpg",
        *          "ImagePrviewUrl": "www.mydomain.com/imagepreview.jpg"
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
        public void Post(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/invitationcontroller update
        * @apiName put
        * @apiGroup SETTINGS > /invitation
        * @apiDescription Update an invitation.
        * @apiPermission siteManager
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/invitationcontroller  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"InvitationID":1,"SiteID":1,"Name":"sales invitation","Description":"sales invitation.","SecondsToDisplay":30,"WaitSecondsBeforeNextDisplay":90,"ShouldFloat":false,"StartLocationX":300,"StartLocationY":-75,"EndLocationX":300,"EndLocationY":-75,"AnchorTo":"invitation_div","Width":150,"Height":75,"FloatSpeed":0,"TransparentBackground":true,"RefireAfterClose":false,"Contents":"This is the sales invitatoin content","IsDeleted":false,"Priority":1,"InvitationType":2,"GalleryItemID":1,"StartingAnimationPosition":0,"EndingAnimationPosition":0,"PopUpPosition":1,"JSFile":"www.mydomain.com/invitationjsfile.js","CSSFile":"www.mydomain.com/invitationcssfile.css","ThumbnailImageUrl":"www.mydomain.com/thumbnailimage.jpg","FullImageUrl":"www.mydomain.com/fullimage.jpg","ImagePrviewUrl": "www.mydomain.com/imagepreview.jpg"
        * 
        * @apiParam         {Number}        siteID                                                      Your site's account number.
        * @apiParam         {Object}        InvitationViewModel                                         the invitationviewmodel object
        * @apiParam         {Number}        InvitationViewModel.InvitationID                            The id of the invitation.
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
        * @apiParam         {Number}        InvitationViewModel.floatSpeed                              The speed in seconds which the invitation floats if ShouldFloat is enabled.
        * @apiParam         {Boolean}       InvitationViewModel.TransparentBackground                   Is the background transparent for the invitation?
        * @apiParam         {Boolean}       InvitationViewModel.RefireAfterClose                        Should the invitation be fired again after it is closed?
        * @apiParam         {String}        InvitationViewModel.Contents                                The contents of the invitation.
        * @apiParam         {Boolean}       InvitationViewModel.IsDeleted                               Has the invitation been deleted?
        * @apiParam         {Number}        InvitationViewModel.Priority                                The priority level of the invitation.
        * @apiParam         {Number}        InvitationViewModel.InvitationType                          The type of the invitation.
        * @apiParam         {Number}        InvitationViewModel.GalleryItemID                           The unique id of the gallery item for the invitation.
        * @apiParam         {Number}        InvitationViewModel.StartingAnimationPosition               The starting position for animation of the invitation.
        * @apiParam         {Number}        InvitationViewModel.EndingAnimationPosition                 The ending position for animation of the inviation.
        * @apiParam         {Number}        InvitationViewModel.PopUpPosition                           The popup position of the invitation.
        * @apiParam         {String}        InvitationViewModel.JSFile                                  The javascript file to be used with the invitation.
        * @apiParam         {String}        InvitationViewModel.CSSFile                                 The css file to be used with the invitation.
        * @apiParam         {String}        InvitationViewModel.ThumbnailImageUrl                       The url of the thumbnail image of the inviation.
        * @apiParam         {String}        InvitationViewModel.FullImageUrl                            The url of the full image of the inviation.
        * @apiParam         {String}        InvitationViewModel.ImagePreviewUrl                         The url of the preview image of the invitation.        
        * 
        * @apiSuccess       {Object}        InvitationViewModel                                         the invitationviewmodel object
        * @apiSuccess       {Number}        InvitationViewModel.InvitationID                            The id of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.SiteID                                  Your site's account number.
        * @apiSuccess       {String}        InvitationViewModel.Name                                    The name of the invitation.
        * @apiSuccess       {String}        InvitationViewModel.Description                             The description of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.SecondsToDisplay                        The number of seconds to display the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.WaitSecondsBeforeNextDisplay            The number of seconds to wait before displaying the next invitation.
        * @apiSuccess       {Boolean}       InvitationViewModel.ShouldFloat                             Does the invitation float?
        * @apiSuccess       {Number}        InvitationViewModel.StartLocationX                          The x coordinate of the starting location.
        * @apiSuccess       {Number}        InvitationViewModel.StartLocationY                          The y coordinate of the starting location.
        * @apiSuccess       {Number}        InvitationViewModel.EndLocationX                            The x coordinate of the ending location.
        * @apiSuccess       {Number}        InvitationViewModel.EndLocationY                            The y coordinate of the ending location.
        * @apiSuccess       {String}        InvitationViewModel.AnchorTo                                The element to which the invitation is anchored.
        * @apiSuccess       {Number}        InvitationViewModel.Width                                   The width of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.Height                                  The height of theinvitatoin.
        * @apiSuccess       {Number}        InvitationViewModel.floatSpeed                              The speed in seconds which the invitation floats if ShouldFloat is enabled.
        * @apiSuccess       {Boolean}       InvitationViewModel.TransparentBackground                   Is the background transparent for the invitation?
        * @apiSuccess       {Boolean}       InvitationViewModel.RefireAfterClose                        Should the invitation be fired again after it is closed?
        * @apiSuccess       {String}        InvitationViewModel.Contents                                The contents of the invitation.
        * @apiSuccess       {Boolean}       InvitationViewModel.IsDeleted                               Has the invitation been deleted?
        * @apiSuccess       {Number}        InvitationViewModel.Priority                                The priority level of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.InvitationType                          The type of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.GalleryItemID                           The unique id of the gallery item for the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.StartingAnimationPosition               The starting position for animation of the invitation.
        * @apiSuccess       {Number}        InvitationViewModel.EndingAnimationPosition                 The ending position for animation of the inviation.
        * @apiSuccess       {Number}        InvitationViewModel.PopUpPosition                           The popup position of the invitation.
        * @apiSuccess       {String}        InvitationViewModel.JSFile                                  The javascript file to be used with the invitation.
        * @apiSuccess       {String}        InvitationViewModel.CSSFile                                 The css file to be used with the invitation.
        * @apiSuccess       {String}        InvitationViewModel.ThumbnailImageUrl                       The url of the thumbnail image of the inviation.
        * @apiSuccess       {String}        InvitationViewModel.FullImageUrl                            The url of the full image of the inviation.
        * @apiSuccess       {String}        InvitationViewModel.ImagePreviewUrl                         The url of the preview image of the invitation.
        * 
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "InvitationID":1,
        *          "SiteID":1,
        *          "Name":"sales invitation",
        *          "Description":"sales invitation.",
        *          "SecondsToDisplay":30,
        *          "WaitSecondsBeforeNextDisplay":90,
        *          "ShouldFloat":false,
        *          "StartLocationX":300,
        *          "StartLocationY":-75,
        *          "EndLocationX":300,
        *          "EndLocationY":-75,
        *          "AnchorTo":"invitation_div", 
        *          "Width":150,
        *          "Height":75,
        *          "FloatSpeed":0,
        *          "TransparentBackground":true,
        *          "RefireAfterClose":false,
        *          "Contents":"This is the sales invitatoin content",
        *          "IsDeleted":false,
        *          "Priority":1,
        *          "InvitationType":2,
        *          "GalleryItemID":1,
        *          "StartingAnimationPosition":0,
        *          "EndingAnimationPosition":0,
        *          "PopUpPosition":1, 
        *          "JSFile":"www.mydomain.com/invitationjsfile.js",
        *          "CSSFile":"www.mydomain.com/invitationcssfile.css", 
        *          "ThumbnailImageUrl":"www.mydomain.com/thumbnailimage.jpg", 
        *          "FullImageUrl":"www.mydomain.com/fullimage.jpg",
        *          "ImagePrviewUrl": "www.mydomain.com/imagepreview.jpg"
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
        public void Put(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/invitationcontroller/:id delete
        * @apiName delete
        * @apiGroup SETTINGS > /invitation
        * @apiDescription Delete an invitation.
        * @apiPermission siteManager
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/invitationcontroller/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id of the invitation to delete.
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
        public void Delete(int siteID, int id)
        {
        }
    }
}