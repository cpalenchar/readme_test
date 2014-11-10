using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readme_test
{
    class PersonaController
    {
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/persona list
        * @apiName get
        * @apiGroup Settings > /persona
        * @apiDescription list the personas for this site.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/Persona  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                                          Your site's account number.
        *
        * @apiSuccess       {Object[]}      Persona                                                         the Persona object
        * @apiSuccess       {Number}        Persona.PersonaID                                               The id of the persona.
        * @apiSuccess       {Number}        Persona.SiteID                                                  Your site's account number.
        * @apiSuccess       {String}        Persona.Name                                                    The name of the persona.
        * @apiSuccess       {String}        Persona.Description                                             The description of the persona.
        * @apiSuccess       {String}        Persona.HeadshotURL                                             The url to the headshot of the persona.
        * @apiSuccess       {Number}        Persona.CookieExpiration                                        The number of seconds before the persona's cookie expires.
        * @apiSuccess       {Object[]}      Persona.PersonaEvaluation                                       An array of evaluations that describes the persona.    
        * @apiSuccess       {Number}        Persona.PersonaEvaluation.PersonaEvaluationID                   The id of the persona evalutaion.
        * @apiSuccess       {String}        Persona.PersonaEvaluation.Name                                  The name of the evaluation.
        * @apiSuccess       {Sring}         Persona.PersonaEvaluation.Expression                            The expression to evaluation to determine if the evaluation is true or false.
        * @apiSuccess       {Number}        Persona.PersonaEvaluation.Weight                                The weight assigned to the persona based on the evaluaton.
        * @apiSuccess       {Number}        Persona.PersonaEvaluation.MaxExecutionsPerVisit                 The maximum number of times the evaluated can be executed per visit.
        * @apiSuccess       {Boolean}       Persona.PersonaEvaluation.StopIfTrue                            If the expression is true stop processing additional evaluations for the persona.
        * @apiSuccess       {Number}        Persona.PersonaEvaluation.SortOrder                             The ordinal value associated with the evalution.
        * @apiSuccess       {Number}        Persona.PersonaEvaluation.PersonaID                             The id of the persona.
        * @apiSuccess       {Object[]}      Persona.PersonaGroup                                            An array of groups to which the persona belongs.
        * @apiSuccess       {Number}        Persona.PersonaGroup.PersonaGroupID                             The id for the persona group.
        * @apiSuccess       {Number}        Persona.PersonaGroup.SiteID                                     Your site's account number.
        * @apiSuccess       {String}        Persona.PersonaGroup.Name                                       The user friendly name of the persona group.
        *   
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"PersonaId": 1,
        *          "SiteID":1,
        *          "Name":"male",
        *          "Description":"This visitor is likely to be a male",
        *          "HeadshotURL":"www.mydomain.com/personaheadhshot.jpg",
        *          "PersonaEvalutaion":
        *              ["PersonaEvaluationID":1,
        *              "Name":"male evaluation",
        *              "Expression":"({PageView} = 'STX')",
        *              "Weight":.5,
        *              "MaxExecutionsPerVisit":1,
        *              "StopIfTrue":true,
        *              "SortOrder":1
        *              ],
        *          "PersonaGroup":
        *              ["PersonaGroupID":1,
        *              "SiteID": 1,
        *              "Name":"persona group male"
        *              ]
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
        public void GetBySite(int siteID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/persona/:id read
        * @apiName get:id
        * @apiGroup Settings > /persona
        * @apiDescription Read the personas for this unique id.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/Persona/:id  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                                          The site's unique ID.
        * @apiParam         {Number}        id                                                              The unique id for this persona.
        *
        * @apiSuccess       {Object}        Persona                                                         the Persona object
        * @apiSuccess       {Number}        Persona.PersonaID                                               The id of the persona.
        * @apiSuccess       {Number}        Persona.SiteID                                                  Your site's account number.
        * @apiSuccess       {String}        Persona.Name                                                    The name of the persona.
        * @apiSuccess       {String}        Persona.Description                                             The description of the persona.
        * @apiSuccess       {String}        Persona.HeadshotURL                                             The url to the headshot of the persona.
        * @apiSuccess       {Number}        Persona.CookieExpiration                                        The number of seconds before the persona's cookie expires.
        * @apiSuccess       {Object[]}      Persona.PersonaEvaluation                                       An array of evaluations that describes the persona.    
        * @apiSuccess       {Number}        Persona.PersonaEvaluation.PersonaEvaluationID                   The id of the persona evalutaion.
        * @apiSuccess       {String}        Persona.PersonaEvaluation.Name                                  The name of the evaluation.
        * @apiSuccess       {Sring}         Persona.PersonaEvaluation.Expression                            The expression to evaluation to determine if the evaluation is true or false.
        * @apiSuccess       {Number}        Persona.PersonaEvaluation.Weight                                The weight assigned to the persona based on the evaluaton.
        * @apiSuccess       {Number}        Persona.PersonaEvaluation.MaxExecutionsPerVisit                 The maximum number of times the evaluated can be executed per visit.
        * @apiSuccess       {Boolean}       Persona.PersonaEvaluation.StopIfTrue                            If the expression is true stop processing additional evaluations for the persona.
        * @apiSuccess       {Number}        Persona.PersonaEvaluation.SortOrder                             The ordinal value associated with the evalution.
        * @apiSuccess       {Number}        Persona.PersonaEvaluation.PersonaID                             The id of the persona.
        * @apiSuccess       {Object[]}      Persona.PersonaGroup                                            An array of groups to which the persona belongs.
        * @apiSuccess       {Number}        Persona.PersonaGroup.PersonaGroupID                             The id for the persona group.
        * @apiSuccess       {Number}        Persona.PersonaGroup.SiteID                                     Your site's account number.
        * @apiSuccess       {String}        Persona.PersonaGroup.Name                                       The user friendly name of the persona group.
        *   
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"PersonaId": 1,
        *          "SiteID":1,
        *          "Name":"male",
        *          "Description":"This visitor is likely to be a male",
        *          "HeadshotURL":"www.mydomain.com/personaheadhshot.jpg",
        *          "PersonaEvalutaion":
        *              ["PersonaEvaluationID":1,
        *              "Name":"male evaluation",
        *              "Expression":"({PageView} = 'STX')",
        *              "Weight":.5,
        *              "MaxExecutionsPerVisit":1,
        *              "StopIfTrue":true,
        *              "SortOrder":1
        *              ],
        *          "PersonaGroup":
        *              ["PersonaGroupID":1,
        *              "SiteID": 1,
        *              "Name":"persona group male"
        *              ]
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
        public void Get(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/persona create
        * @apiName post
        * @apiGroup Settings > /persona
        * @apiDescription Create a new persona.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/persona  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID":1,"Name":"male persona","Description":"A visitor that is most likely to be male.","HeadshotUrl":"www.mydomain.com/personaheadshot.jpg","cookieExpiration": 300}"
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiParam         {Object}        Persona                                           the persona object
        * @apiParam         {Number}        Persona.SiteID                                    Your site's account number.
        * @apiParam         {String}        Persona.Name                                      The name of the persona.
        * @apiParam         {String}        Persona.Description                               The description of the persona.
        * @apiParam         {String}        Persona.HeadshotURL                               The url to the headshot of the persona.
        * @apiParam         {Number}        Persona.CookieExpiration                          The number of seconds before the persona's cookie expires.
        *
        * @apiSuccess       {Object}        Persona                                           the persona object
        * @apiSuccess       {Number}        Persona.PersonaID                                 The id if the persona.
        * @apiSuccess       {Number}        Persona.SiteID                                    Your site's account number.
        * @apiSuccess       {String}        Persona.Name                                      The name of the persona.
        * @apiSuccess       {String}        Persona.Description                               The description of the persona.
        * @apiSuccess       {String}        Persona.HeadshotUrl                               The url to the headshot of the persona.
        * @apiSuccess       {Number}        Persona.CookieExpiration                          The number of seconds before the persona's cookie expires.
        *   
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "PersonaID":1,
        *          "SiteID":1,
        *          "Name":"male persona",
        *          "Description":"A visitor that is most likely to be male.",
        *          "HeadshotUrl":"www.mydomain.com/personaheadshot.jpg",
        *          "CookieExpiration": 300
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
        * @api {put} /{siteID}/persona update
        * @apiName put
        * @apiGroup Settings > /persona
        * @apiDescription Update a persona.
        * @apiPermission siteAdministrator
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/persona  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID":1,"Name":"male persona","Description":"A visitor that is most likely to be male.","HeadshotUrl":"www.mydomain.com/personaheadshot.jpg","cookieExpiration": 300}"
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiParam         {Object}        Persona                                           the persona object
        * @apiParam         {Number}        Persona.SiteID                                    Your site's account number.
        * @apiParam         {String}        Persona.Name                                      The name of the persona.
        * @apiParam         {String}        Persona.Description                               The description of the persona.
        * @apiParam         {String}        Persona.HeadshotURL                               The url to the headshot of the persona.
        * @apiParam         {Number}        Persona.CookieExpiration                          The number of seconds before the persona's cookie expires.
        *
        * @apiSuccess       {Object}        Persona                                           the persona object
        * @apiSuccess       {Number}        Persona.PersonaID                                 The id if the persona.
        * @apiSuccess       {Number}        Persona.SiteID                                    Your site's account number.
        * @apiSuccess       {String}        Persona.Name                                      The name of the persona.
        * @apiSuccess       {String}        Persona.Description                               The description of the persona.
        * @apiSuccess       {String}        Persona.HeadshotUrl                               The url to the headshot of the persona.
        * @apiSuccess       {Number}        Persona.CookieExpiration                          The number of seconds before the persona's cookie expires.
        *   
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "PersonaID":1,
        *          "SiteID":1,
        *          "Name":"male persona",
        *          "Description":"A visitor that is most likely to be male.",
        *          "HeadshotUrl":"www.mydomain.com/personaheadshot.jpg",
        *          "CookieExpiration": 300
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
        * @api {delete} /{siteID}/persona/:id delete
        * @apiName delete
        * @apiGroup Settings > /persona
        * @apiDescription Delete a persona.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/persona/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiParam         {Number}        id                                                The id of the persona to delete.
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
        public void Delete(int id, int siteID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/Persona/AddPersonaEvalutaion create evaluation
        * @apiName PostEvalutaion
        * @apiGroup Settings > /persona
        * @apiDescription Create a new persona evaluation.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/alert  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"Name":"male evaluation","Expression":"({PageView} = 'STX')","Weight": .5,"MaxExecutionsPerVisit": 1,"StopIfTrue":true,"SortOrder": 1,"PersonaID": 1}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        PersonaEvaluation                                   An evaluation to add to the persona.
        * @apiParam         {String}        PersonaEvaluation.Name                              The name of the evaluation.
        * @apiParam         {Sring}         PersonaEvaluation.Expression                        The expression to evaluation to determine if the evaluation is true or false.
        * @apiParam         {Number}        PersonaEvaluation.Weight                            The weight assigned to the persona based on the evaluaton.
        * @apiParam         {Number}        PersonaEvaluation.MaxExecutionsPerVisit             The maximum number of times the evaluated can be executed per visit.
        * @apiParam         {Boolean}       PersonaEvaluation.StopIfTrue                        If the expression is true stop processing additional evaluations for the persona.
        * @apiParam         {Number}        PersonaEvaluation.SortOrder                         The ordinal value associated with the evalution.
        * @apiParam         {Number}        PersonaEvaluation.PersonaID                         The unique id of the persona.
        *
        * @apiSuccess       {Object}        PersonaEvaluation                                   The evaluation that was added.
        * @apiSuccess       {Number}        PersonaEvaluation.PersonaEvaluationID               The id of the persona evalutaion.
        * @apiSuccess       {String}        PersonaEvaluation.Name                              The name of the evaluation.
        * @apiSuccess       {String}        PersonaEvaluation.Expression                        The expression to evaluation to determine if the evaluation is true or false.
        * @apiSuccess       {Number}        PersonaEvaluation.Weight                            The weight assigned to the persona based on the evaluaton.
        * @apiSuccess       {Number}        PersonaEvaluation.MaxExecutionsPerVisit             The maximum number of times the evaluated can be executed per visit.
        * @apiSuccess       {Boolean}       PersonaEvaluation.StopIfTrue                        If the expression is true stop processing additional evaluations for the persona.
        * @apiSuccess       {Number}        PersonaEvaluation.SortOrder                         The ordinal value associated with the evalution.
        * @apiSuccess       {Number}        PersonaEvaluation.PersonaID                         The id of the persona.
        *   
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "PersonaEvaluationID": 1,
        *          "Name":"male evaluation",
        *          "Expression":"({PageView} = 'STX')",
        *          "Weight":.5,
        *          "MaxExecutionsPerVisit":1,
        *          "StopIfTrue":true,
        *          "SortOrder":1,
        *          "PersonaID": 1
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
        public void AddPersonaEvaluation(string value)
        {
        }
        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/Persona/UpdatePersonaEvalutaion update evaluation
        * @apiName PutEvaluation
        * @apiGroup Settings > /persona
        * @apiDescription Update a persona evaluation.
        * @apiPermission siteAdministrator
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/alert  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"PersonaEvalutaionID":1,"Name":"male evaluation","Expression":"({PageView} = 'STX')","Weight": .5,"MaxExecutionsPerVisit": 1,"StopIfTrue":true,"SortOrder": 1,"PersonaID": 1}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        PersonaEvaluation                                   An evaluation to add to the persona.
        * @apiParam         {Number}        PersonaEvaluation.PersonaEvaluationID               The id of the persona evalutaion.
        * @apiParam         {String}        PersonaEvaluation.Name                              The name of the evaluation.
        * @apiParam         {Sring}         PersonaEvaluation.Expression                        The expression to evaluation to determine if the evaluation is true or false.
        * @apiParam         {Number}        PersonaEvaluation.Weight                            The weight assigned to the persona based on the evaluaton.
        * @apiParam         {Number}        PersonaEvaluation.MaxExecutionsPerVisit             The maximum number of times the evaluated can be executed per visit.
        * @apiParam         {Boolean}       PersonaEvaluation.StopIfTrue                        If the expression is true stop processing additional evaluations for the persona.
        * @apiParam         {Number}        PersonaEvaluation.SortOrder                         The ordinal value associated with the evalution.
        * @apiParam         {Number}        PersonaEvaluation.PersonaID                         The unique id of the persona.
        *
        * @apiSuccess       {Object}        PersonaEvaluation                                   The evaluation that was added.
        * @apiSuccess       {Number}        PersonaEvaluation.PersonaEvaluationID               The id of the persona evalutaion.
        * @apiSuccess       {String}        PersonaEvaluation.Name                              The name of the evaluation.
        * @apiSuccess       {String}        PersonaEvaluation.Expression                        The expression to evaluation to determine if the evaluation is true or false.
        * @apiSuccess       {Number}        PersonaEvaluation.Weight                            The weight assigned to the persona based on the evaluaton.
        * @apiSuccess       {Number}        PersonaEvaluation.MaxExecutionsPerVisit             The maximum number of times the evaluated can be executed per visit.
        * @apiSuccess       {Boolean}       PersonaEvaluation.StopIfTrue                        If the expression is true stop processing additional evaluations for the persona.
        * @apiSuccess       {Number}        PersonaEvaluation.SortOrder                         The ordinal value associated with the evalution.
        * @apiSuccess       {Number}        PersonaEvaluation.PersonaID                         The id of the persona.
        *   
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "PersonaEvaluationID": 1,
        *          "Name":"male evaluation",
        *          "Expression":"({PageView} = 'STX')",
        *          "Weight":.5,
        *          "MaxExecutionsPerVisit":1,
        *          "StopIfTrue":true,
        *          "SortOrder":1,
        *          "PersonaID": 1
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
        public void UpdatePersonaEvaluation(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/Persona/updatepersonaevalutaions update evaluations
        * @apiName putevaluations
        * @apiGroup Settings > /persona
        * @apiDescription Update a persona evaluation.
        * @apiPermission siteAdministrator
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/alert  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{[{"PersonaEvaluationID":1,"Name":"male evaluation","Expression":"({PageView} = 'STX')","Weight":.5,"MaxExecutionsPerVisit": 1,"StopIfTrue":true,"SortOrder":1,"PersonaID": 1}]}" 
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object[]}      PersonaEvaluation                                   An evaluation to add to the persona.
        * @apiParam         {Number}        PersonaEvaluation.PersonaEvaluationID               The id of the persona evalutaion.
        * @apiParam         {String}        PersonaEvaluation.Name                              The name of the evaluation.
        * @apiParam         {Sring}         PersonaEvaluation.Expression                        The expression to evaluation to determine if the evaluation is true or false.
        * @apiParam         {Number}        PersonaEvaluation.Weight                            The weight assigned to the persona based on the evaluaton.
        * @apiParam         {Number}        PersonaEvaluation.MaxExecutionsPerVisit             The maximum number of times the evaluated can be executed per visit.
        * @apiParam         {Boolean}       PersonaEvaluation.StopIfTrue                        If the expression is true stop processing additional evaluations for the persona.
        * @apiParam         {Number}        PersonaEvaluation.SortOrder                         The ordinal value associated with the evalution.
        * @apiParam         {Number}        PersonaEvaluation.PersonaID                         The unique id of the persona.
        *
        * @apiSuccess       {Object[]}        PersonaEvaluation                                   The evaluation that was added.
        * @apiSuccess       {Number}        PersonaEvaluation.PersonaEvaluationID               The id of the persona evalutaion.
        * @apiSuccess       {String}        PersonaEvaluation.Name                              The name of the evaluation.
        * @apiSuccess       {String}        PersonaEvaluation.Expression                        The expression to evaluation to determine if the evaluation is true or false.
        * @apiSuccess       {Number}        PersonaEvaluation.Weight                            The weight assigned to the persona based on the evaluaton.
        * @apiSuccess       {Number}        PersonaEvaluation.MaxExecutionsPerVisit             The maximum number of times the evaluated can be executed per visit.
        * @apiSuccess       {Boolean}       PersonaEvaluation.StopIfTrue                        If the expression is true stop processing additional evaluations for the persona.
        * @apiSuccess       {Number}        PersonaEvaluation.SortOrder                         The ordinal value associated with the evalution.
        * @apiSuccess       {Number}        PersonaEvaluation.PersonaID                         The id of the persona.
        *   
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"PersonaEvaluationID": 1,
        *          "Name":"male evaluation",
        *          "Expression":"({PageView} = 'STX')",
        *          "Weight":.5,
        *          "MaxExecutionsPerVisit":1,
        *          "StopIfTrue":true,
        *          "SortOrder":1,
        *          "PersonaID": 1
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
        public void UpdatePersonaEvaluations(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/persona/deletepersonaevalutaions/:id delete evaluation
        * @apiName deleteevaluation
        * @apiGroup Settings > /persona
        * @apiDescription Delete a persona evaluation.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/persona/deletepersonaevalutaions/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiParam         {Number}        id                                                The id of the persona evaluation to delete.
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
        public void DeletePersonaEvaluation(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/persona/personaheadshot/:id create headshot
        * @apiName postheadshot
        * @apiGroup Settings > /persona
        * @apiDescription Create a headshot for this persona.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/alert  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{ formData}" 
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        *   
        * @apiSuccess       {String}        headshotURL                                       The url of the saved headshot.    
        * 
        * @apiSuccessExample {text} Success-Response:
        *     HTTP/1.1 200 OK
        *     {www.mydomain.com/personas/headshot.jpg}
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
        public void Headshot(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/persona/personasingroup/:personaID read persona groups by persona
        * @apiName getpersonasingroup
        * @apiGroup Settings > /persona
        * @apiDescription list the persona groups for this persona.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/persona/personasingroup/:personaID  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiParam         {Number}        personaID                                         The id of the persona.
        *
        * @apiSuccess       {Object[]}      PersonaGroup                                      An array of groups to which the persona belongs.
        * @apiSuccess       {Number}        PersonaGroup.PersonaGroupID                       The id for the persona group.
        * @apiSuccess       {Number}        PersonaGroup.SiteID                               Your site's account number.
        * @apiSuccess       {String}        PersonaGroup.Name                                 The user friendly name of the persona group.
        *   
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *           [{"PersonaGroupID":1,
        *          "SiteID":1,
        *           "Name":"male persona group"
        *           }]
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
        public void PersonasInGroup(int personaID, int siteID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {get} /{siteID}/persona/personagroup list persona groups
        * @apiName getpersonagroups
        * @apiGroup Settings > /persona
        * @apiDescription list the persona groups for this site.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl https:/main.api.livefluence.com/{siteID}/persona/personasingroup  \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        *
        * @apiSuccess       {Object[]}      PersonaGroup                                      An array of groups to which the persona belongs.
        * @apiSuccess       {Number}        PersonaGroup.PersonaGroupID                       The id for the persona group.
        * @apiSuccess       {Number}        PersonaGroup.SiteID                               Your site's account number.
        * @apiSuccess       {String}        PersonaGroup.Name                                 The user friendly name of the persona group.
        *   
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"PersonaGroupID":1,
        *          "SiteID":1,
        *          "name":"male persona group"
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
        public void PersonaGroupsGetBySite(int siteID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/persona/addpersonagroup create persona group
        * @apiName postpersonagroup
        * @apiGroup Settings > /persona
        * @apiDescription Add a new persona group.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/persona/addpersonagroup  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"SiteID":1,"Name":"male persona group"}" 
        *  
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiParam         {Object}        PersonaGroup                                      the persongroup object
        * @apiParam         {Number}        PersonaGroup.SiteID                               Your site's account number.
        * @apiParam         {String}        PersonaGroup.Name                                 The user friendly name of the persona group.
        *
        * @apiSuccess       {Object}        PersonaGroup                                      the persona group object
        * @apiSuccess       {Number}        PersonaGroup.PersonaGroupID                       The id for the persona group.
        * @apiSuccess       {Number}        PersonaGroup.SiteID                               Your site's account number.
        * @apiSuccess       {String}        PersonaGroup.Name                                 The user friendly name of the persona group.
        *   
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "PersonaGroupID":1,
        *          "SiteID":1,
        *          "name":"male persona group"
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
        public void AddPersonaGroup(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {put} /{siteID}/persona/updatepersonagroup update persona group
        * @apiName putpersonagroup
        * @apiGroup Settings > /persona
        * @apiDescription Update a persona group.
        * @apiPermission siteAdministrator
        *
        *       curl -X PUT https:/main.api.livefluence.com/{siteID}/persona/updatepersonagroup  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"PersonaGroupID":1,"SiteID":1,"Name":"male persona group"}" 
        *  
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiParam         {Object}        PersonaGroup                                      the persongroup object
        * @apiParam         {Number}        PersonaGroup.PersonaGroupID                       The id of the persona group.
        * @apiParam         {Number}        PersonaGroup.SiteID                               Your site's account number.
        * @apiParam         {String}        PersonaGroup.Name                                 The user friendly name of the persona group.
        *
        * @apiSuccess       {Object}        PersonaGroup                                      the persona group object
        * @apiSuccess       {Number}        PersonaGroup.PersonaGroupID                       The id for the persona group.
        * @apiSuccess       {Number}        PersonaGroup.SiteID                               Your site's account number.
        * @apiSuccess       {String}        PersonaGroup.Name                                 The user friendly name of the persona group.
        *   
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          [{"PersonaGroupID":1,
        *          "SiteID":1,
        *          "name":"male persona group"
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
        public void UpdatePersonaGroup(string value)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/persona/deletepersonagroup/:id delete persona group
        * @apiName deletepersonagroup
        * @apiGroup Settings > /persona
        * @apiDescription Delete a persona group.
        * @apiPermission siteAdministrator
        *
        * @apiExample       {curl}              Example usage:
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/persona/deletepersonagroup/:id \
        *       -H "Authorization: Basic {authorizationToken}" 
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiParam         {Number}        id                                                The id of the persona group to delete.
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
        public void DeletePersonaGroup(int id)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {post} /{siteID}/persona/addpersonatogroup add persona to group
        * @apiName postpersonatogroup
        * @apiGroup Settings > /persona
        * @apiDescription Add a new persona group.
        * @apiPermission siteAdministrator
        *
        *       curl -X POST https:/main.api.livefluence.com/{siteID}/persona/addpersonatogroup  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"PersonaID":1,"PersonaToUpdateID":2}"
        * 
        * @apiParam         {Number}        siteID                                              Your site's account number.
        * @apiParam         {Object}        PersonaGroupUpdateViewModel                         the persongroupupdateviewmodel object
        * @apiParam         {Number}        PersonaGroupUpdateViewModel.PersonaID               The id of the persona.
        * @apiParam         {String}        PersonaGroupUpdateViewModel.PersonaToUpdateID       The id of the persona to add to the group.
        *
        * @apiSuccess       {Object}        PersonaGroupUpdateViewModel                         the persongroupupdateviewmodel object
        * @apiSuccess       {Number}        PersonaGroupUpdateViewModel.PersonaID               The id of the persona.
        * @apiSuccess       {String}        PersonaGroupUpdateViewModel.PersonaToUpdateID       The id of the persona to add to the group.
        *   
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "PersonaID":1,
        *          "PersonaToUpdatID": 2
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
        public void AddPersonaToGroup(string value, int siteID)
        {
        }

        #region apiComments
        /**
        * @apiVersion 0.1.0
        * @api {delete} /{siteID}/persona/removepersonafromgroup delete persona from froup
        * @apiName deletepersonafromgroup
        * @apiGroup Settings > /persona
        * @apiDescription Add a new persona group.
        * @apiPermission siteAdministrator
        *
        *       curl -X DELETE https:/main.api.livefluence.com/{siteID}/persona/removepersonafromgroup  \
        *       -H "Authorization: Basic {authorizationToken}"  \
        *       -H "Content-Type: application/json" \
        *       -d "{"PersonaID":1,"PersonaToUpdatID":2}"
        * 
        * @apiParam         {Number}        siteID                                            Your site's account number.
        * @apiParam         {Object}        PersonaGroupUpdateViewModel                       the personagroupupdateviewmodel object
        * @apiParam         {Number}        PersonaGroupUpdateViewModel.PersonaID             The id of the persona.
        * @apiParam         {String}        PersonaGroupUpdateViewModel.PersonaToUpdateID     The id of the persona to remove from this group.
        *
        * @apiSuccess       {Object}        PersonaGroupUpdateViewModel                       the personagroupupdateviewmodel object
        * @apiSuccess       {Number}        PersonaGroupUpdateViewModel.PersonaID             The id of the persona.
        * @apiSuccess       {String}        PersonaGroupUpdateViewModel.PersonaToUpdateID     The id of the persona removed from this group.
        *   
        * @apiSuccessExample {json} Success-Response:
        *     HTTP/1.1 200 OK
        *     {
        *          "PersonaID":1,
        *          "PersonaToUpdatID": 2
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
        public void RemovePersonaFromGroup(string value, int siteID)
        {
        }
    }
}