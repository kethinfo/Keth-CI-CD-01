using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Web;
using System.Web.Services;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using System.Globalization;
using System.IO;

namespace Netexam.Webservices.OracleCRM.V1
{
    /// <summary>
    /// Summary description for BusinessLogicLayer.
    /// </summary>
    public class BusinessLogicLayer
    {

        static string ConnectionString = ConfigurationSettings.AppSettings["Connectionstring"];
        static string DefaultDateFormat = "d";

        public BusinessLogicLayer()
        {
        }



        private static bool ValidCustomField(int iCompany, string CustomFieldName)
        {
            bool bValid = false;
            Logger.Debug("ValidCustomField:: CustomFieldName: " + CustomFieldName);

            try
            {
                int iExists = (int)SqlHelper.ExecuteScalar(ConnectionString, "APIAuthenticateCustomField", iCompany, CustomFieldName);
                if (iExists > 0)
                    bValid = true;
            }
            catch (Exception ex)
            {
                //Do Nothing
                Logger.Debug(ex.Message.ToString());
            }

            Logger.Debug("ValidCustomField Returned " + bValid.ToString());

            return bValid;
        }

   

        public static void UserGroupAddEdit(int iCompany, string UserGroupName, string UserGroupExternalID, string Country)
        {

            Logger.Debug("UserGroupAddEdit:: UserGroupName: " + UserGroupName + " UserGroupExternalID: " + UserGroupExternalID + " Country: " + Country);

            try
            {

                //Validate Paramerters
                if (!ValidateRequeiredParameter(UserGroupName)) throw new APIException(ErrorCodes.USERGROUP_NAME_IS_EMPTY);
                if (!ValidateRequeiredParameter(UserGroupExternalID)) throw new APIException(ErrorCodes.USERGROUP_EXTERNAL_ID_IS_EMPTY);



                //Add/Update User
                SqlHelper.ExecuteNonQuery(ConnectionString, "APIUserGroupAddUpdateForOracleCRM", iCompany, UserGroupExternalID, UserGroupName, Country.ToUpper());

            }
            catch (SqlException ex)
            {
                Logger.Fatal(ex.ToString());
                throw ex;
                //throw new APIException(ErrorCodes.INTERNAL_SYSTEM_ERROR);
            }
            catch (Exception ex)
            {
                Logger.Fatal(ex.ToString());
                throw ex;
                //throw new APIException(ErrorCodes.INTERNAL_SYSTEM_ERROR);
            }

            Logger.Debug("UserGroupAddEdit END");
            Logger.Debug(string.Empty);

        }


        private static bool ValidateRequeiredParameter(string p)
        {
            if (p == null) return false;
            if (p.Length == 0) return false;
            return true;
        }

        public static bool ValidateCompanyName(string CompanyName)
        {
            DataSet dsCompany = new DataSet();
            dsCompany = SqlHelper.ExecuteDataset(ConnectionString, "APICheckCompanyNameForOrcleCRM", CompanyName);
            if (dsCompany.Tables.Count > 0)
            {
                if (dsCompany.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static bool ValidateEmail(string Email)
        {
            DataSet dsCompany = new DataSet();
            dsCompany = SqlHelper.ExecuteDataset(ConnectionString, "APICheckEmailForOrcleCRM", Email);
            if (dsCompany.Tables.Count > 0)
            {
                if (dsCompany.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        private static string GetDefaultCostCenter(int iCompany)
        {
            string defaultCostCenter = (string)SqlHelper.ExecuteScalar(ConnectionString, "APIGetDefaultCostCenter", iCompany);
            return defaultCostCenter;
        }

        private static int GetLanguageID(int iCompany, string Language)
        {
            int LanguageID = (int)SqlHelper.ExecuteScalar(ConnectionString, "APIGetLanguageIDByNameAndCompany", Language, iCompany);
            return LanguageID;
        }

        private static int GetUserGroupIDFromExternalID(int iCompany, string ExternalUserGroupID)
        {
            Logger.Debug("GetUserGroupIDFromExternalID:: ExternalUserGroupID: " + ExternalUserGroupID);

            int iUserGroupID = 0;
            if (!ExternalUserGroupID.Equals(string.Empty))
                iUserGroupID = (int)SqlHelper.ExecuteScalar(ConnectionString, "APIGetUserGroupIDByExternalIDForOracleCRMV1", iCompany, ExternalUserGroupID);

            Logger.Debug("GetUserGroupIDFromExternalID Returned: " + iUserGroupID);

            return iUserGroupID;
        }

        private static bool IsDuplicateEmail(int iCompany, string Email, string ExternalID)
        {
            Logger.Debug("IsDuplicateEmail " + Email + "," + ExternalID);
            bool bDuplicate = false;
            try
            {
                //SFDCVerifyUsersEmail looks for a user within the company who has this same email, but
                //different External ID. If Found that means we have a potential duplicate email condition
                using (SqlDataReader drUserInfo = SqlHelper.ExecuteReader(ConnectionString, "VerifyUsersEmailForOracleCRMV1", iCompany, Email, ExternalID))
                {
                    if (drUserInfo.Read())
                        bDuplicate = true;
                }
            }
            catch (Exception ex)
            {
                Logger.Debug("IsDuplicateEmail " + ex.ToString());
                //Do Nothing
            }

            Logger.Debug("IsDuplicateEmail: " + bDuplicate);

            return bDuplicate;
        }

        public static int GetCompanyID(string CompanyName)
        {
            Logger.Debug("GetCompanyID: " + CompanyName);
            int iCompany = 0;
            try
            {
                iCompany = (int)SqlHelper.ExecuteScalar(ConnectionString, "APIGetCompanyIdByCompanyName", CompanyName);

            }
            catch (Exception ex)
            {
                Logger.Debug(ex.Message.ToString());
            }

            return iCompany;

        }

        private static int AuthenticateUserType(int iCompany, string UserType)
        {
            Logger.Debug("AuthenticateUserType " + UserType);
            //Default to English
            int iUserTypeID = -1;
            try
            {
                iUserTypeID = (int)SqlHelper.ExecuteScalar(ConnectionString, "APIGetUserTypeIDByName", UserType, iCompany);
            }
            catch (Exception ex)
            {
                Logger.Debug("AuthenticateUserType " + ex.ToString());
                //Do Nothing
            }

            Logger.Debug("AuthenticateUserType: Returned UserType ID " + iUserTypeID);

            return iUserTypeID;
        }

        private static int AuthenticateUserRole(int iCompany, string UserRole)
        {
            Logger.Debug("AuthenticateUserRole " + UserRole);
            //Default to English
            int iUserRole = -1;
            try
            {
                iUserRole = (int)SqlHelper.ExecuteScalar(ConnectionString, "APIGetUserRoleIDByName", UserRole, iCompany);
            }
            catch (Exception ex)
            {
                Logger.Debug("AuthenticateUserRole " + ex.ToString());
                //Do Nothing
            }

            Logger.Debug("AuthenticateUserRole: Returned UserRole ID " + iUserRole);

            return iUserRole;
        }

        private static bool ValidateUserByExternalID(int iCompany, string ExternalID)
        {
            bool bExists = false;
            try
            {
                if (ExternalID.Equals(string.Empty) || ExternalID.Length == 0)
                {
                    bExists = false;
                }
                else
                {
                    int iExists = (int)SqlHelper.ExecuteScalar(ConnectionString, "APIAuthenticateUserByExternalIDForOracleCRM", iCompany, ExternalID);
                    if (iExists > 0)
                        bExists = true;
                }
            }
            catch (Exception ex)
            {
                //Do Nothing
                Logger.Debug(ex.Message.ToString());
            }
            return bExists;
        }


        public static bool OracleCRMAuthenticateUser(string SSOToken, string CompanyName, string UserEmail)
        {
            bool authenticated = false;
 
            SSOToken = System.Web.HttpUtility.UrlEncode(SSOToken);

            Logger.Debug("OracleCRMAuthenticateUser SSOToken:" + SSOToken + " CompanyName: " + CompanyName + " UserEmail: " + UserEmail);

            try
            {

                string sessionId = string.Empty;

                // Check that SSO  have been specified
                if (SSOToken == null)
                {
                    throw new Exception("SSO Token not specified!");
                }

                string url = "https://secure-slsomxvga.crmondemand.com/Services/Integration?command=ssologin&odSsoToken=" + SSOToken;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                // cookie container has to be added to request in order to 
                // retrieve the cookie from the response. 
                req.CookieContainer = new CookieContainer();

                // make the HTTP call
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();


                StreamReader responseStream;
                Cookie cookie;
                if (resp.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    responseStream = new StreamReader(resp.GetResponseStream());
                    resp.Close();
                    responseStream.Close();

                    // store cookie for later
                    cookie = resp.Cookies["JSESSIONID"];

                    if (cookie == null)
                    {
                        return false;
                    }
                    else
                    {
                        sessionId = cookie.Value;
                        if (sessionId.Equals(string.Empty))
                        {
                            return false;
                        }
                        else
                        {
                            return true; //// sessionId;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            Logger.Debug("OracleCRMAuthenticateUser Returned:" + authenticated.ToString());
            Logger.Debug(string.Empty);

            return false;
        }


        public static bool OracleCRMAuthenticateUserTest(string CompanyName, string UserEmail)
        {
            bool authenticated = false;

            Logger.Debug("OracleCRMAuthenticateUser" + " CompanyName: " + CompanyName + " UserEmail: " + UserEmail);

            try
            {

                //
                 //string server = string.Empty;
                string username = string.Empty;
                string password = string.Empty;
                string sessionId = string.Empty;
                // string sessionId = string.Empty;
                Cookie cookie = null;

                username = "MEDIA478/HIMANSU@MEDIADEFINED.COM";
                password = "Makita1984!";


                // Check that username and password have been specified
                if (username == null)
                {
                    throw new Exception("Username not specified!");
                }
                if (password == null)
                {
                    throw new Exception("Password not specified!");
                }
                


                // create a container for an HTTP request
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(GetLogInURL());

                // username and password are passed as HTTP headers
                req.Headers.Add("UserName", username);
                req.Headers.Add("Password", password);

                // cookie container has to be added to request in order to 
                // retrieve the cookie from the response. 
                req.CookieContainer = new CookieContainer();

                // make the HTTP call
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                if (resp.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // store cookie for later...
                    cookie = resp.Cookies["JSESSIONID"];
                    if (cookie == null)
                    {
                        throw new Exception("No JSESSIONID cookie found in log-in response!");
                    }
                    sessionId = cookie.Value;

                    if (sessionId != null)
                    {
                        authenticated = true;
                    }
                }
                //// hard coded for testing
                //authenticated = true;


            }
            catch (Exception)
            {
                throw;
            }

            Logger.Debug("OracleCRMAuthenticateUser Returned:" + authenticated.ToString());
            Logger.Debug(string.Empty);

            return authenticated;
        }


        public static string GetLogInURL()
        {
            string server = "secure-slsomxvga.crmondemand.com";
            string httpBase = "http://";	// Use https for production implementations
            //CheckServerPort();
            return httpBase + server + "/Services/Integration?command=login";
        }


        public static void OracleCRMUpsertUser(int iCompany, string ExternalUserID, string FirstName, string LastName, string Email, string Language, string UserType, string UserRole, string ManagersExternalID, string UserGroups, bool PreserveUserGroup, bool Active)
        {
            Logger.Debug("OracleCRMUpsertUser:: ExternalUserID: " + ExternalUserID + " FirstName: " + FirstName + " LastName: " + LastName + " Email:" + Email + " Language: " + Language + " UserType: " + UserType + " UserRole: " + UserRole + " ManagersExternalID: " + ManagersExternalID + " PreserveUserGroup: " + PreserveUserGroup);

            try
            {

                if (!ValidateRequeiredParameter(ExternalUserID)) throw new APIException(ErrorCodes.USER_EXTERNAL_ID_IS_EMPTY);
                if (!ValidateRequeiredParameter(FirstName)) throw new APIException(ErrorCodes.USER_FIRST_NAME_IS_EMPTY);
                if (!ValidateRequeiredParameter(LastName)) throw new APIException(ErrorCodes.USER_LAST_NAME_IS_EMPTY);
                if (!ValidateRequeiredParameter(Email)) throw new APIException(ErrorCodes.USER_EMAIL_IS_EMPTY);
                if (IsDuplicateEmail(iCompany, Email, ExternalUserID)) throw new APIException(ErrorCodes.DUPLICATE_EMAIL);

                int iPreserveUserGroups = 0;
                int iStatus = 1;

                if (PreserveUserGroup)
                    iPreserveUserGroups = 1;

                if (!Active)
                    iStatus = 0;



                /*
                 NOTES FOR USER GROUP and CUSTOM FIELDS
                 We are accepting an array for both the User Groups and Custom Fields
                 This code is ableto handle:				
                 1) An Array that is Null i.e defined but never initialized
                 2) Empty Array values ("" or string.Empty)
                 3) Array values that are Null i.e defined never initialized
                 */


                bool bValidUserGroupArray = true;
                //bool bValidCustomFieldArray = true;

                //Check if User Groups were passed
                if (UserGroups == null)
                    bValidUserGroupArray = false;


      

                //Get the RoleID
                int iRoleID = AuthenticateUserRole(iCompany, UserRole);
                if (iRoleID == -1) throw new APIException(ErrorCodes.INVALID_USERROLE);

                //Get the UserType
                int iUserTypeID = AuthenticateUserType(iCompany, UserType);
                if (iUserTypeID == -1) throw new APIException(ErrorCodes.INVALID_USERTYPE);

                if (!ValidateRequeiredParameter(ManagersExternalID)) ManagersExternalID = string.Empty;

                if (!(ManagersExternalID.Equals(string.Empty) || ManagersExternalID.Length == 0))
                {
                    if (!ValidateUserByExternalID(iCompany, ManagersExternalID)) throw new APIException(ErrorCodes.INVALID_MANAGER_EXTERNALID);
                }
                else
                {
                    ManagersExternalID = null;
                }

                string CostCenter = GetDefaultCostCenter(iCompany);
                int iLanguageID = GetLanguageID(iCompany, Language);

                SqlHelper.ExecuteNonQuery(ConnectionString, "APIUpsertUserForOracleCRMV1", iCompany, ExternalUserID, FirstName, LastName, Email, iRoleID, iUserTypeID, CostCenter, iLanguageID, ManagersExternalID, iPreserveUserGroups, iStatus);


                //Add the User Group
                int iUserGroupID = 0;

                iUserGroupID = GetUserGroupIDFromExternalID(iCompany, UserGroups);
                if (iUserGroupID > 0){
                    SqlHelper.ExecuteNonQuery(ConnectionString, "APIAddUserToUserGroupByUserExternalIDAndSetPrimaryUserGroupForOracleCRM", iUserGroupID, ExternalUserID, iCompany, 1);
                }
       

            }
            catch (Exception ex)
            {
                Logger.Debug("UpsertUser:: Exception: " + ex.ToString());
                throw;
            }

            Logger.Debug("UpsertUser Completed");
            Logger.Debug(string.Empty);
        }


    }
}
