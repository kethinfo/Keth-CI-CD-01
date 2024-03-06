using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Collections.Specialized;
using System.Text;
using System.Web.Services.Protocols;
using System.Configuration;
using System.Xml;




namespace Netexam.Webservices.OracleCRM.V1
{
    /// <summary>
    /// Summary description for Service1.
    /// </summary>
    /// 
    [WebService(Namespace = "http://Webservices.NetExam.com/OracleCRM/UserService")]
    public class UserService : System.Web.Services.WebService
    {
        public UserService()
        {
            //CODEGEN: This call is required by the ASP.NET Web Services Designer
            InitializeComponent();
        }

        #region Component Designer generated code

        //Required by the Web Services Designer 
        private IContainer components = null;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

        [WebMethod(Description = "Get params")]
        public string MainDataLoad(string Param)
        {
            try
            {
                Logger.Debug("Params" + Param);


            }
            catch (APIException ex)
            {
                throw ex;
            }
            catch (ApplicationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            return "Sucess";

        }

      
        //Web Methods For Oracle CRM


        /// <summary>
        /// Oracle CRM  Add/Updates a User Group
        /// <param name="SSOToken">SSO Token</param>
        /// <param name="CompanyName">Company Name</param>
        /// <param name="UserEmail">User Email</param>
        /// <param name="ExternalId">Account External ID</param>
        /// <param name="AccountName">Account Name</param>
        /// <param name="Country">Country Name</param>
        /// </summary>
        [WebMethod(Description = "Oracle CRM - Add/Updates a User Group")]
        public string OracleCRMAddEditAccount(string SSOToken, string CompanyName, string UserEmail, string ExternalId, string AccountName, string Country)
        {
            Logger.Debug("OracleCRMAddEditAccount Start:" + DateTime.Now.ToString());
            try
            {
                if (BusinessLogicLayer.OracleCRMAuthenticateUser(SSOToken, CompanyName, UserEmail))
                {
                   

                    if ((AccountName.Length == 0) || (AccountName == string.Empty)) throw new ApplicationException("Invalid User Group Name");
                    if ((ExternalId.Length == 0) || (ExternalId == string.Empty)) throw new ApplicationException("Invalid User Group External ID");

                    int iCompany = BusinessLogicLayer.GetCompanyID(CompanyName);

                    BusinessLogicLayer.UserGroupAddEdit(iCompany, AccountName, ExternalId, Country);

                }
            }
            catch (APIException ex)
            {
                return ex.Message.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            Logger.Debug("AddEditUserGroup End");
            Logger.Debug(string.Empty);

            return new ApiResult(ErrorCodes.SUCCESS).Description;
        }

        /// <summary>
        /// Oracle CRM  Add/Updates a User Group
        /// <param name="SSOToken">SSO Token</param>
        /// <param name="CompanyName">Company Name</param>
        /// <param name="UserEmail">User Email</param>
        /// <param name="ExternalId">Account External ID</param>
        /// <param name="AccountName">Account Name</param>
        /// <param name="Country">Country Name</param>
        /// </summary>
        [WebMethod(Description = "Oracle CRM - Add/Updates a User Group")]
        public string OracleCRMAddEditAccountTest( string CompanyName, string UserEmail, string ExternalId, string AccountName, string Country)
        {
            Logger.Debug("OracleCRMAddEditAccountTest Start:" + DateTime.Now.ToString());
            try
            {
                if (BusinessLogicLayer.OracleCRMAuthenticateUserTest( CompanyName, UserEmail))
                {


                    if ((AccountName.Length == 0) || (AccountName == string.Empty)) throw new ApplicationException("Invalid User Group Name");
                    if ((ExternalId.Length == 0) || (ExternalId == string.Empty)) throw new ApplicationException("Invalid User Group External ID");

                    int iCompany = BusinessLogicLayer.GetCompanyID(CompanyName);

                    BusinessLogicLayer.UserGroupAddEdit(iCompany, AccountName, ExternalId, Country);

                }
            }
            catch (APIException ex)
            {
                return ex.Message.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            Logger.Debug("AddEditUserGroup End");
            Logger.Debug(string.Empty);

            return new ApiResult(ErrorCodes.SUCCESS).Description;
        }



        [WebMethod(Description = "Oracle CRM - Add/Updates a User GroupB")]
        public string OracleCRMAddEditAccountByWA(string Params)
        {

            string[] arrParams = Params.Split('|');
            string SSOToken = string.Empty;
            string CompanyName = string.Empty;
            string UserEmail = string.Empty;
            string ExternalId = string.Empty;
            string AccountName = string.Empty;
            string Country = string.Empty;
            return System.Web.HttpUtility.UrlEncode(Params) + "__" + Params;
            
            Params = HttpContext.Current.Request.Params[0];
            //return SSOToken;
            Logger.Debug("OracleCRMAddEditAccount Start:" + DateTime.Now.ToString());
            try
            {

                if ((AccountName.Length == 0) || (AccountName == string.Empty)) throw new ApplicationException("Invalid User Group Name");
                if ((ExternalId.Length == 0) || (ExternalId == string.Empty)) throw new ApplicationException("Invalid User Group External ID");

                int iCompany = BusinessLogicLayer.GetCompanyID(CompanyName);

                BusinessLogicLayer.UserGroupAddEdit(iCompany, AccountName, ExternalId, Country);

            }

            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

            Logger.Debug("AddEditUserGroup End");
            Logger.Debug(string.Empty);

            return "True";
        }

        /// <summary>
        /// Oracle CRM  Add/Updates a User Group
        /// <param name="SSOToken">SSO Token</param>
        /// <param name="CompanyName">Company Name</param>
        /// <param name="UserEmail">User Email</param>
        /// </summary>
        [WebMethod(Description = "Oracle CRM - Add/Updates a User Group")]
        public bool OracleCRMValidateEmailCompany(string CompanyName, string UserEmail)
        {
            Logger.Debug("OracleCRMValidateEmailCompany Start:" + DateTime.Now.ToString());
            try
            {
                if ((CompanyName.Equals(string.Empty)))
                {
                    throw new ApplicationException("Invalid Company Name");
                }

                if ((UserEmail.Equals(string.Empty)))
                {
                    throw new ApplicationException("Invalid User Email");
                }

                if (BusinessLogicLayer.ValidateCompanyName(CompanyName))
                {
                    if (BusinessLogicLayer.ValidateEmail(UserEmail))
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
            catch (APIException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

            Logger.Debug("AddEditUserGroup End");
            Logger.Debug(string.Empty);

            // return new ApiResult(ErrorCodes.SUCCESS).Description;
        }



        /// <summary>
        /// OracleCRM Inserts or Updates a User
        /// </summary>
        [WebMethod(Description = " OracleCRM Inserts or Updates a User")]
        public ApiResult OracleCRMUpsertUser(string SSOToken, string CompanyName, string UserEmail, string ExternalUserID, string FirstName, string LastName, string Email, string Language, string UserType, string UserRole, string ManagersExternalID, string UserGroups, bool PreserveUserGroup, bool Active)
        {

            Logger.Debug("OracleCRMUpsertUser Start:" + DateTime.Now.ToString());
            try
            {

                if (BusinessLogicLayer.OracleCRMAuthenticateUser(SSOToken, CompanyName, UserEmail))
                {
                    if (String.IsNullOrEmpty(FirstName)) throw new APIException(ErrorCodes.USER_FIRST_NAME_IS_EMPTY);
                    if (String.IsNullOrEmpty(LastName)) throw new APIException(ErrorCodes.USER_LAST_NAME_IS_EMPTY);
                    if (String.IsNullOrEmpty(Email)) throw new APIException(ErrorCodes.USER_EMAIL_IS_EMPTY);
                    if (String.IsNullOrEmpty(UserType)) throw new APIException(ErrorCodes.INVALID_USERTYPE);
                    if (String.IsNullOrEmpty(UserRole)) throw new APIException(ErrorCodes.INVALID_USERROLE);
                    //if((ManagersExternalID.Length == 0) || (ManagersExternalID == string.Empty)) throw new APIException(ErrorCodes.INVALID_MANAGER_EXTERNALID);

                    int iCompany = BusinessLogicLayer.GetCompanyID(CompanyName);
                    BusinessLogicLayer.OracleCRMUpsertUser(iCompany, ExternalUserID, FirstName, LastName, Email, Language, UserType, UserRole, ManagersExternalID, UserGroups, PreserveUserGroup, Active);
                }
                else
                {
                    throw new APIException(ErrorCodes.INVALID_API_CREDENTIALS);
                }
            }
            catch (APIException ex)
            {
                return new ApiResult(ex.Code);
            }
            catch (ApplicationException ex)
            {
                return new ApiResult(ErrorCodes.APPLICATION_ERROR);
            }
            catch (Exception)
            {
                throw new APIException(ErrorCodes.SYSTEM_SERVER_ERROR, SoapException.ServerFaultCode);
                //ApplicationException("General UpsertUser() System Exception");
            }

            Logger.Debug("OracleCRMUpsertUser End");
            Logger.Debug(string.Empty);

            return new ApiResult(ErrorCodes.SUCCESS);
        }




    }
}
