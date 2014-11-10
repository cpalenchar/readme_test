using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    public class EngagementScheduleController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/engagementschedule/getbygroup/:groupID read by group
        * @apiName getbygroup
        * @apiGroup Settings > /engagement schedule
        * @apiDescription Read all engagement schedules for this group.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/engagementscheudle/getbygroup/:groupID
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        groupID                                             The id for the group used to read the engagement schedules.
        * 
        * @apiSuccess       {Object[]}      EngagementSchedule                                  the engagementschedule object
        * @apiSuccess       {Number}        EngagementSchedule.AvailabilityScheduleID           The id of the engagement schedule.
        * @apiSuccess       {Number}        EngagementSchedule.GroupID                          The group id of the engagement schedule.
        * @apiSuccess       {Number}        EngagementSchedule.DayOfWeek                        The day of the week of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.StartTime1                       The time of the first start time of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.EndTime1                         The time of the first end time of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.EndTime2                         The time of the second end time of the engagement schedule.
        * @apiSuccess       {Boolean}       EngagementSchedule.AllDay                           Does the engagement schedule last all day?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"AvailabilityScheduleID":1,
        *           "GroupID":1,
        *           "DatOfWeek":1,
        *           "StartTime1":"1/1/2014 8:00 am",
        *           "EndTime1":"1/1/2014 12:00 pm",
        *           "StartTime2":"1/1/2014 1:00 pm",
        *           "EndTime2": "1/1/2014 5:00 pm" 
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
        public void GetByGroup(int groupID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/engagementschedule/getbyuser/:userID read by user
        * @apiName getbyuser
        * @apiGroup Settings > /engagement schedule
        * @apiDescription Read all engagement schedules for this user.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/engagementscheudle/getbyuser/:userID
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        userid                                              The id of the user used to read the engagement schedule.
        * 
        * @apiSuccess       {Object[]}      EngagementSchedule                                  the engagementschedule object
        * @apiSuccess       {Number}        EngagementSchedule.AvailabilityScheduleID           The id of the engagement schedule.
        * @apiSuccess       {Number}        EngagementSchedule.GroupID                          The group id of the engagement schedule.
        * @apiSuccess       {Number}        EngagementSchedule.DayOfWeek                        The day of the week for the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.StartTime1                       The time of the first start time of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.EndTime1                         The time of the first end time of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.EndTime2                         The ime of the second end time of the engagement schedule.
        * @apiSuccess       {Boolean}       EngagementSchedule.AllDay                           Does the engagement schedule last all day?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"AvailabilityScheduleID":1,
        *           "GroupID":1,
        *           "DatOfWeek":1,
        *           "StartTime1":"1/1/2014 8:00 am",
        *           "EndTime1":"1/1/2014 12:00 pm",
        *           "StartTime2":"1/1/2014 1:00 pm",
        *           "EndTime2": "1/1/2014 5:00 pm" 
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
        public void GetByUser(int userID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/engagementschedule/ read all
        * @apiName get
        * @apiGroup Settings > /engagement schedule
        * @apiDescription Read all the engagement schedules for this site.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/engagementscheudle
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * 
        * @apiSuccess       {Object[]}      EngagementSchedule                                  the engagementschedule object
        * @apiSuccess       {Number}        EngagementSchedule.AvailabilityScheduleID           The id of the engagement schedule.
        * @apiSuccess       {Number}        EngagementSchedule.GroupID                          The group id of the engagement schedule.
        * @apiSuccess       {Number}        EngagementSchedule.DayOfWeek                        The day of the week for the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.StartTime1                       The time of the first start time of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.EndTime1                         The time of the first end time of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.EndTime2                         The time of the second end time of the engagement schedule.
        * @apiSuccess       {Boolean}       EngagementSchedule.AllDay                           Does the engagement schedule last all day?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"AvailabilityScheduleID":1,
        *           "GroupID":1,
        *           "DatOfWeek":1,
        *           "StartTime1":"1/1/2014 8:00 am",
        *           "EndTime1":"1/1/2014 12:00 pm",
        *           "StartTime2":"1/1/2014 1:00 pm",
        *           "EndTime2": "1/1/2014 5:00 pm" 
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
        * @api {get} /{siteID}/engagementschedule/:id read
        * @apiName get:ID
        * @apiGroup Settings > /engagement schedule
        * @apiDescription Read all engagement schedules for this group.
        * @apiPermission siteAdministrator
        *
        * @apiParam         {Number}        siteID                                              The site's unique id.
        * @apiParam         {Number}        id                                                  The id of the engagement schedule to read.
        * 
        * @apiSuccess       {Object[]}      EngagementSchedule                                  the engagementschedule object
        * @apiSuccess       {Number}        EngagementSchedule.AvailabilityScheduleID           The id of the engagement schedule.
        * @apiSuccess       {Number}        EngagementSchedule.GroupID                          The group id of the engagement schedule.
        * @apiSuccess       {Number}        EngagementSchedule.DayOfWeek                        The day of the week for the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.StartTime1                       The time of the first start time of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.EndTime1                         The time of the first end time of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.EndTime2                         The time of the second end time of the engagement schedule.
        * @apiSuccess       {Boolean}       EngagementSchedule.AllDay                           Does the engagement schedule last all day?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "AvailabilityScheduleID":1,
        *           "GroupID":1,
        *           "DatOfWeek":1,
        *           "StartTime1":"1/1/2014 8:00 am",
        *           "EndTime1":"1/1/2014 12:00 pm",
        *           "StartTime2":"1/1/2014 1:00 pm",
        *           "EndTime2": "1/1/2014 5:00 pm" 
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
        * @api {post} /{siteID}/engagementschedule create
        * @apiName post
        * @apiGroup Settings > /engagement schedule
        * @apiDescription Create a new engagement schedule for this group.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/engagementschedule  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"GroupID":1,"DatOfWeek":1,"StartTime1":"1/1/2014 8:00 am","EndTime1":"1/1/2014 12:00 pm","StartTime2":"1/1/2014 1:00 pm","EndTime2": "1/1/2014 5:00 pm" }" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        EngagementSchedule                                  the engagementschedule object
        * @apiParam         {Number}        EngagementSchedule.GroupID                          The group id for the engagement schedule.
        * @apiParam         {Number}        EngagementSchedule.DayOfWeek                        The day of the week for the engagement schedule.
        * @apiParam         {Date}          EngagementSchedule.StartTime1                       The time of the first start time of the engagement schedule.
        * @apiParam         {Date}          EngagementSchedule.EndTime1                         The time of the first end time of the engagement schedule.
        * @apiParam         {Date}          EngagementSchedule.EndTime2                         The time of the second end time of the engagement schedule.
        * @apiParam         {Boolean}       EngagementSchedule.AllDay                           Does the engagement schedule last all day?
        * 
        * @apiSuccess       {Object}        EngagementSchedule                                  the engagementschedule object 
        * @apiSuccess       {Number}        EngagementSchedule.AvailabilityScheduleID           The id of the engagement schedule.
        * @apiSuccess       {Number}        EngagementSchedule.GroupID                          The group id of the engagement schedule.
        * @apiSuccess       {Number}        EngagementSchedule.DayOfWeek                        The day of the week of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.StartTime1                       The time of the first start time of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.EndTime1                         The time of the first end time of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.EndTime2                         The time of the second end time of the engagement schedule.
        * @apiSuccess       {Boolean}       EngagementSchedule.AllDay                           Does the engagement schedule last all day?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "AvailabilityScheduleID":1,
        *           "GroupID":1,
        *           "DatOfWeek":1,
        *           "StartTime1":"1/1/2014 8:00 am",
        *           "EndTime1":"1/1/2014 12:00 pm",
        *           "StartTime2":"1/1/2014 1:00 pm",
        *           "EndTime2": "1/1/2014 5:00 pm" 
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
        * @api {put} /{siteID}/engagementschedule update
        * @apiName put
        * @apiGroup Settings > /engagement schedule
        * @apiDescription Create a new engagement schedule for this group.
        * @apiPermission siteAdministrator
        *
        *       curl -X PUTT https:/main.api.livefluence.com/{siteID}/engagementschedule  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"AvailabilityScheduleID":1,"GroupID":1,"DatOfWeek":1,"StartTime1":"1/1/2014 8:00 am","EndTime1":"1/1/2014 12:00 pm","StartTime2":"1/1/2014 1:00 pm","EndTime2": "1/1/2014 5:00 pm" }" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        EngagementSchedule                                  the engagementschedule object
        * @apiParam         {Number}        EngagementSchedule.AvailabilityScheduleID           The id of the engagement schedule.
        * @apiParam         {Number}        EngagementSchedule.GroupID                          The group id of the engagement schedule.
        * @apiParam         {Number}        EngagementSchedule.DayOfWeek                        The day of the week of the engagement schedule.
        * @apiParam         {Date}          EngagementSchedule.StartTime1                       The time of the first start time of the engagement schedule.
        * @apiParam         {Date}          EngagementSchedule.EndTime1                         The time of the first end time of the engagement schedule.
        * @apiParam         {Date}          EngagementSchedule.EndTime2                         The time of the second end time of the engagement schedule.
        * @apiParam         {Boolean}       EngagementSchedule.AllDay                           Does the engagement schedule last all day?
        * 
        * @apiSuccess       {Object}        EngagementSchedule                                  the engagementschedule object
        * @apiSuccess       {Number}        EngagementSchedule.AvailabilityScheduleID           The id of the engagement schedule.
        * @apiSuccess       {Number}        EngagementSchedule.GroupID                          The group id of the engagement schedule.
        * @apiSuccess       {Number}        EngagementSchedule.DayOfWeek                        The day of the week of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.StartTime1                       The time of the first start time of the engagement schedule.
        * @apiSuccess       {Date}          EngagementSchedule.EndTime1                         The time of the first end time of the engagement schedule.
        * @apiSuccess       {Date}          EgagementSchedule.EndTime2                          The time of the second end time of the engagement schedule.
        * @apiSuccess       {Boolean}       EngagementSchedule.AllDay                           Does the engagement schedule last all day?
        *
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           "AvailabilityScheduleID":1,
        *           "GroupID":1,
        *           "DatOfWeek":1,
        *           "StartTime1":"1/1/2014 8:00 am",
        *           "EndTime1":"1/1/2014 12:00 pm",
        *           "StartTime2":"1/1/2014 1:00 pm",
        *           "EndTime2": "1/1/2014 5:00 pm" 
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
        * @api {delete} /{siteID}/engagementschedule/:id delete
        * @apiName delete
        * @apiGroup Settings > /engagement schedule
        * @apiDescription Delete the engagement schedule for this id.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/engagementschedule/:id \
        *       -H "Authorization: Basic {authorizationToken}"
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Number}        id                                                  The id of the site to delete.
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