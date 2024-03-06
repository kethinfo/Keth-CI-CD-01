using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Netexam.Webservices.OracleCRM.V1
{
    public partial class WrapperServices : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Logger.Debug("testing log files by keth");
            //Requsting Query Params
            string objecttype = Request.QueryString["ObjectType"];
            string ssotoken = Request.QueryString["SSOToken"];
            string company = Request.QueryString["CompanyName"];
            string useremail = Request.QueryString["UserEmail"];
            string externalid = Request.QueryString["ExternalId"];
            string servicesResult = string.Empty;

            UserService us = new UserService();
            switch (objecttype)
            {
                case OCRMObjectType.AccountType:

                    string accountname = Request.QueryString["AccountName"];
                    string country = Request.QueryString["Country"];
                    servicesResult = us.OracleCRMAddEditAccount(ssotoken, company, useremail, externalid, accountname, country);
                    break;
                case OCRMObjectType.ContactType:

                    string FirstName = Request.QueryString["FirstName"];
                    string LastName = Request.QueryString["LastName"];
                    string Language = Request.QueryString["Language"];
                    string UserType = Request.QueryString["UserType"];
                    string UserRole = Request.QueryString["UserRole"];
                    string ManagersExternalID = Request.QueryString["ManagersExternalID"];
                    string UserGroups = Request.QueryString["UserGroups"];
                    bool PreserveUserGroup = false;
                    bool Active = false;
                    bool.TryParse(Request.QueryString["PreserveUserGroup"], out PreserveUserGroup);
                    bool.TryParse(Request.QueryString["Active"], out Active);
                    servicesResult = us.OracleCRMUpsertUser(ssotoken, company, useremail, externalid, FirstName, LastName, useremail, Language, UserType, UserRole, ManagersExternalID, UserGroups, PreserveUserGroup, Active).Description;
                    break;
                default:
                    servicesResult = "False";
                    break;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("GoBack('" + servicesResult + "');");
            // if the script is not already registered
            if (!Page.ClientScript.IsClientScriptBlockRegistered(Page.GetType(), "MsgPopup"))
                // notice that I added the boolean value as the last parameter
                ClientScript.RegisterClientScriptBlock(Page.GetType(), "MsgPopup", sb.ToString(), true);
        }
    }
}
