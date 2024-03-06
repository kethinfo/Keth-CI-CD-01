using System;
using System.Configuration; 

namespace Netexam.Webservices.OracleCRM.V1
{	
	public class ErrorCodes
	{
		static public int SUCCESS							= 0;
		static public int NO_SERVER_URL						= 1;
		static public int NO_SESSION_ID						= 2;
		static public int NO_ACCESS_TO_API					= 3;
		static public int NO_SSL							= 4;
		static public int ACTION_NOT_SUPPORTED				= 5;
		static public int MALFORMED_XML						= 6;

		static public int NO_API_KEY						= 7;
		static public int INVALID_API_KEY					= 8;

		static public int USER_EXTERNAL_ID_IS_EMPTY			= 11;
		static public int USER_FIRST_NAME_IS_EMPTY			= 12;
		static public int USER_LAST_NAME_IS_EMPTY			= 13;
		static public int USER_EMAIL_IS_EMPTY				= 14;
		static public int USERGROUP_EXTERNAL_ID_IS_EMPTY	= 15;
		static public int USERGROUP_NAME_IS_EMPTY			= 16;
		static public int INVALID_COURSE_EXTERNAL_ID        = 19;
		static public int INVALID_COMPLETION_DATE           = 20;
		static public int USER_NOT_FOUND					= 21;
		static public int INVALID_COURSE_STATUS				= 22;
		static public int INVALID_API_CREDENTIALS			= 23;
		static public int EXTERNAL_USERGROUP_MISMATCH		= 24;
		static public int INTERNAL_SYSTEM_ERROR				= 25;
		static public int DUPLICATE_EMAIL					= 26;
		static public int INVALID_USERTYPE					= 27;
		static public int INVALID_USERROLE					= 28;
		static public int INVALID_MANAGER_EXTERNALID		= 29;
		static public int SYSTEM_SERVER_ERROR				= 30;
		static public int INVALID_CUSTOM_FIELD				= 31;

        static public int INVALID_PROCTOR_EXAM_TOKEN        = 32;
        static public int DECAYED_PROCTOR_EXAM_TOKEN        = 33;
        static public int REDEEMED_PROCTOR_EXAM_TOKEN       = 34;
        static public int FAILED_PROCTORING_STATUS          = 35;
        static public int INVALIED_PROCTORING_STATUS        = 36;
        static public int GENERAL_PROCTORING_ERROR          = 37;
        static public int INVALID_PROCTOR_CREDENTIALS       = 38;

        static public int APPLICATION_ERROR                 = 39;
        static public int MULTIPLE_PRIMARY_USERGROUPS = 40;
        static public int USER_GROUPS_NOT_DEFINED = 41;
        static public int USERS_NOT_DEFINED = 42;
	}

    public class OCRMObjectType
    {
        public const string AccountType = "Account";
        public const string ContactType = "Contact";

    }
}
