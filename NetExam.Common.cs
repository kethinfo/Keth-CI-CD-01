using System;
using System.Collections;
namespace Netexam.Webservices.OracleCRM.V1
{
		
	#region UserProfile Class
	/// <summary>
	/// Summary description for UserProfile.
	/// </summary>
	public class UserProfile 
	{
		
		//inherrited members
		public string UserID;
		public int CompanyID;
		public string FirstName;
		public string LastName;
		public string UserName;
		public string Password;
		public string UserIDForeignKey;
		public string Email;
		public string AlternateEmail;

		public string City;
		public string Country;
		public string State;
		public string PostalCode;		

		public string Language;
		public string LanguageID;

		public string Culture;

		public string CourseReminderEmailOption;
		public string CertificationReminderEmailOption;
		public string CertificationMaintainenceEmailOption;
		public CustomField[] CustomFields;

		//Extension Memebers		
		public AddressData Address;
		public string BusinessPhone;
		public string PersonalPhone;
		public string PersonalEmail;
		public string JobCategory;
		public string JobTitle;
		public string TimeZone;

        public string UserRole;
        public string UserTypeName;
        public string ManagerExternalID;
        public string Status;
        public string PrimaryUserGroupExternalID;

		public UserProfile()
		{
			//TODO: Add constructor logic here
		}

		public UserProfile(string UserID,
			int CompanyID,
			string FirstName,
			string LastName,
			string UserName,
			string Password,
			string Email,
			string AlternateEmail,
			string City,
			string Country,
			string State,
			string PostalCode,
			string Language,
			string LanguageID,
			string Culture,
			string CourseReminderEmailOption,
			string CertificationReminderEmailOption,
			string CertificationMaintainenceEmailOption,
			CustomField[] CustomFields,			
			string BusinessPhone,
			string PersonalPhone,
			string PersonalEmail,
			string JobCategory,
			string JobTitle,
			AddressData Address,
			int TimeZone,
			string UserIDForeignKey,
            string UserRole)
		{
			this.UserID = UserID;
			this.CompanyID = CompanyID;
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.UserName = UserName;
			this.Password = Password;
			this.Email = Email;
			this.AlternateEmail = AlternateEmail;
			this.City = City;
			this.Country = Country;
			this.State = State;
			this.PostalCode = PostalCode;
			this.Language = Language;
			this.LanguageID = LanguageID;
			this.Culture = Culture;
			this.CourseReminderEmailOption = CourseReminderEmailOption;
			this.CertificationReminderEmailOption = CertificationReminderEmailOption;
			this.CertificationMaintainenceEmailOption = CertificationMaintainenceEmailOption;
			this.CustomFields = CustomFields;
			this.BusinessPhone = BusinessPhone;
			this.PersonalPhone = PersonalPhone;
			this.PersonalEmail = PersonalEmail;
			this.JobCategory = JobCategory;
			this.JobTitle = JobTitle;
			this.Address = Address;
			this.TimeZone = TimeZone.ToString();
			this.UserIDForeignKey = UserIDForeignKey;
            this.UserRole = UserRole;
		}

        public UserProfile(string UserID,
            int CompanyID,
            string FirstName,
            string LastName,
            string UserName,
            string Password,
            string Email,
            string AlternateEmail,
            string City,
            string Country,
            string State,
            string PostalCode,
            string Language,
            string LanguageID,
            string Culture,
            string CourseReminderEmailOption,
            string CertificationReminderEmailOption,
            string CertificationMaintainenceEmailOption,
            CustomField[] CustomFields,
            string BusinessPhone,
            string PersonalPhone,
            string PersonalEmail,
            string JobCategory,
            string JobTitle,
            AddressData Address,
            int TimeZone,
            string UserIDForeignKey,
            string UserRole,
            string UserTypeName,
            string ManagerExternalID,
            string Status,
            string PrimaryUserGroupExternalID)
        {
            this.UserID = UserID;
            this.CompanyID = CompanyID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.UserName = UserName;
            this.Password = Password;
            this.Email = Email;
            this.AlternateEmail = AlternateEmail;
            this.City = City;
            this.Country = Country;
            this.State = State;
            this.PostalCode = PostalCode;
            this.Language = Language;
            this.LanguageID = LanguageID;
            this.Culture = Culture;
            this.CourseReminderEmailOption = CourseReminderEmailOption;
            this.CertificationReminderEmailOption = CertificationReminderEmailOption;
            this.CertificationMaintainenceEmailOption = CertificationMaintainenceEmailOption;
            this.CustomFields = CustomFields;
            this.BusinessPhone = BusinessPhone;
            this.PersonalPhone = PersonalPhone;
            this.PersonalEmail = PersonalEmail;
            this.JobCategory = JobCategory;
            this.JobTitle = JobTitle;
            this.Address = Address;
            this.TimeZone = TimeZone.ToString();
            this.UserIDForeignKey = UserIDForeignKey;
            this.UserRole = UserRole;
            this.UserTypeName = UserTypeName;
            this.ManagerExternalID = ManagerExternalID;
            this.Status = Status;
            this.PrimaryUserGroupExternalID = PrimaryUserGroupExternalID;
        }

		public override string ToString()
		{
			string toString = string.Empty;

			toString += Util.ToString("UserID", UserID); 
			toString += Util.ToString("CompanyID", CompanyID); 
			
			toString += Util.ToString("FirstName", FirstName); 
			toString += Util.ToString("LastName", LastName); 
			toString += Util.ToString("UserName", UserName); 
			toString += Util.ToString("Password", Password); 
			toString += Util.ToString("Email", Email); 
			toString += Util.ToString("AlternateEmail", AlternateEmail); 
			toString += Util.ToString("UserIDForeignKey", UserIDForeignKey); 
			toString += Util.ToString("City", City); 
			toString += Util.ToString("Country", Country); 
			toString += Util.ToString("State", State); 
			toString += Util.ToString("PostalCode", PostalCode); 

			toString += Util.ToString("Language", Language); 
			toString += Util.ToString("LanguageID", LanguageID);
			toString += Util.ToString("Culture", Culture);			
			toString += Util.ToString("CourseReminderEmailOption", CourseReminderEmailOption); 
			toString += Util.ToString("CertificationReminderEmailOption", CertificationReminderEmailOption); 
			toString += Util.ToString("CertificationMaintainenceEmailOption", CertificationMaintainenceEmailOption); 
			toString += Util.ToString("CustomFields", CustomFields); 
			toString += Util.ToString("BusinessPhone" , BusinessPhone);
			toString += Util.ToString("PersonalPhone" , PersonalPhone);
			toString += Util.ToString("PersonalEmail" , PersonalEmail);
			toString += Util.ToString("JobCategory" , JobCategory);
			toString += Util.ToString("JobTitle" , JobTitle);
			toString += Util.ToString("Address" , Address);
			toString += Util.ToString("TimeZone", TimeZone);
            toString += Util.ToString("UserRole", UserRole);
            toString += Util.ToString("UserTypeName", UserTypeName);
            toString += Util.ToString("ManagerExternalID", ManagerExternalID);
            toString += Util.ToString("Status", Status);
            toString += Util.ToString("PrimaryUserGroupExternalID", PrimaryUserGroupExternalID);

			return toString;
		}
	}
	#endregion

	#region CustomData Class
	[Serializable]
	public class CustomField
	{
		public string Name;
		public string Value;
		
		//only becuase the ASP.net WebService Engine demand a public default ctor
		public CustomField()
		{
		}

		public CustomField(string Name,string Value)
		{
			this.Name = Name;
			this.Value = Value;			
		}

		public override string ToString()
		{
			string toString = string.Empty;
			toString += Util.ToString("Name", Name); 
			toString += Util.ToString("Value", Value); 
			return toString;
		}
	}
	#endregion

	#region Address Data Class
	/// <summary>
	/// Summary description for AddressData.
	/// </summary>
	public class AddressData
	{
		public string StreetAddress1;
		public string StreetAddress2;
		public string City;
		public string State;
		public string Country;
		public string PostalCode;

		public AddressData()
		{
		}

		public AddressData(string StreetAddress1,string StreetAddress2,string City,string State,string Country,string PostalCode)
		{
			this.StreetAddress1 = StreetAddress1;
			this.StreetAddress2 = StreetAddress2;
			this.City = City;
			this.State = State;
			this.Country = Country;
			this.PostalCode = PostalCode;
		}

		public override string ToString()
		{
			string toString = string.Empty;

			toString += Util.ToString("StreetAddress1", StreetAddress1); 
			toString += Util.ToString("StreetAddress2", StreetAddress2); 			
			toString += Util.ToString("City", City); 
			toString += Util.ToString("State", State); 
			toString += Util.ToString("Country", Country); 
			toString += Util.ToString("PostalCode", PostalCode); 

			return toString;
		}
	}
	#endregion

	#region Util Class
	public class Util
	{
		private Util()
		{
		}

		public static string ToString(string fieldName, object fieldValue)
		{
			string returnValue = string.Empty;

			if (fieldValue.GetType().IsArray)
			{
				//its an array
				returnValue += "<" + fieldName + ">";

				foreach(object obj in (object[]) fieldValue)
				{
					returnValue += Util.ToString("ArrayItem", obj); 
				}
					
				returnValue += "</" + fieldName + ">";
			} 
			else if (fieldValue != null) 
			{
				returnValue += "<" + fieldName + ">" + fieldValue.ToString() + "</" + fieldName + ">";
			}
			else
			{
				returnValue += "<" + fieldName + ">" + "null" + "</" + fieldName + ">";
			}

			return returnValue;
		}
	}
	#endregion

	#region CertificationData Class
	[Serializable]
	public class CertificationData 
	{
		public int ID;
		public int Type;
		public string Name;
		public string Description;
		public string Language;
		public string LanguageID;
		public string Culture;
		public string LanguageDisplay;
		public string Updated;
		public int ExamID;
		public string CompleteBy;
		public bool Expired;
		public string Subscribed;
		public int Version;
		public int LanguageIndependantID;
		public int CatalogID;
		public string CatalogName;
		public CourseData[] Courses;
        public string ExternalCertificationID;
		/// <summary>
		/// Default ctor needed for Serilazation
		/// </summary>
		public CertificationData(){}


		public CertificationData(int ID,
			int ExamID,
			string CompleteByDate,
			string Name,
			string Description,
			string Language,
			string Culture,
			int Version, 
			int LanguageIndependentID,
			int Type,
			string Subscribed,
			CourseData[]Courses)
		{
			this.ID = ID;
			this.ExamID = ExamID;
			this.CompleteBy = CompleteByDate;
			this.Name = Name;
			this.Description = Description;			
			this.Language = Language;
			this.Culture = Culture;
			this.Version = Version;
			this.LanguageIndependantID = LanguageIndependentID;
			this.Type = Type;	
			this.Subscribed = Subscribed;
			this.Courses = Courses;
		}


		public CertificationData(int ID,
			int ExamID,
			string CompleteByDate,
			string Name,
			string Description,
			string Language,
			string Culture,
			int Version, 
			int LanguageIndependentID,
			int Type,
			string Subscribed,
			int CatalogID,
			string CatalogName,
			CourseData[]Courses)
		{
			this.ID = ID;
			this.ExamID = ExamID;
			this.CompleteBy = CompleteByDate;
			this.Name = Name;
			this.Description = Description;			
			this.Language = Language;
			this.Culture = Culture;
			this.Version = Version;
			this.LanguageIndependantID = LanguageIndependentID;
			this.Type = Type;	
			this.Subscribed = Subscribed;
			this.CatalogID = CatalogID;
			this.CatalogName = CatalogName;
			this.Courses = Courses;
		}
        
        public CertificationData(int ID,
            int ExamID,
            string CompleteByDate,
            string Name,
            string Description,
            string Language,
            string Culture,
            int Version,
            int LanguageIndependentID,
            int Type,
            string Subscribed,
            int CatalogID,
            string CatalogName,
            string ExternalCertificationID,
            CourseData[] Courses)
        {
            this.ID = ID;
            this.ExamID = ExamID;
            this.CompleteBy = CompleteByDate;
            this.Name = Name;
            this.Description = Description;
            this.Language = Language;
            this.Culture = Culture;
            this.Version = Version;
            this.LanguageIndependantID = LanguageIndependentID;
            this.Type = Type;
            this.Subscribed = Subscribed;
            this.CatalogID = CatalogID;
            this.CatalogName = CatalogName;
            this.ExternalCertificationID = ExternalCertificationID;
            this.Courses = Courses;
        }

				
		public override string ToString()
		{
			string toString = string.Empty;

			toString += Util.ToString("ID", ID); 
			toString += Util.ToString("Type", Type); 
			toString += Util.ToString("Name", Name); 
			toString += Util.ToString("Description", Description); 
			toString += Util.ToString("Language", Language);
			toString += Util.ToString("Culture", Culture);			
			toString += Util.ToString("LanguageID", LanguageID);
			toString += Util.ToString("LanguageDisplay", LanguageDisplay); 
			toString += Util.ToString("Updated", Updated); 			
			toString += Util.ToString("ExamID", ExamID);  
			toString += Util.ToString("CompleteBy", CompleteBy);  
			toString += Util.ToString("Expired", Expired);	
			toString += Util.ToString("Subscribed", Subscribed);
			toString += Util.ToString("Version", Version); 
			toString += Util.ToString("LanguageIndependantID", LanguageIndependantID); 	
			toString += Util.ToString("CatalogID", CatalogID); 
			toString += Util.ToString("CatalogName", CatalogName); 
			toString += Util.ToString("Courses", Courses);
            toString += Util.ToString("ExternalCertificationID", ExternalCertificationID);
			
			return toString;
		}
	
	}
	#endregion

	#region CourseData Class
	public class CourseData
	{
		public int CourseID;
		public string CourseName;
		public string CourseLanguage;
		public string CourseLanguageID;
		public string CourseLanguageDisplay;
		public string CourseCulture;
		
		public int CourseDaysToComplete;
		public int CourseLength;
		public string CourseObjective;
		public double CoursePrice;
		public double CourseRetakePrice;
		public string CMID;
		public string CompleteByDate; 
		public int ExamID; 
		public string ExamRequirement;
		public string ExamPassingScore;
		public bool Expired;
		public string ExamFrequency;
		public string Subscribed;
		public bool ClassRoomCourse;
			
	
		/// <summary>
		/// Default ctor needed for Serilazation
		/// </summary>
		public CourseData(){}

		public CourseData(int CourseID,	string CourseName,string Language, string Culture,string LanguageID,string LanguageDisplay,string CMID,string Subscribed,int iClassRoom)
		{
			this.CourseID = CourseID;
			this.CourseName = CourseName;
			this.CourseLanguage = Language;
			this.CourseCulture = Culture;

			this.CourseLanguageID = LanguageID;
			this.CourseLanguageDisplay = LanguageDisplay;
			this.CMID = CMID;	
			this.Subscribed = Subscribed;
			this.ClassRoomCourse = ((iClassRoom==1)? true:false);
		}

        public CourseData(int CourseID, string CourseName, string Language, string Culture, string LanguageID, string LanguageDisplay, string CMID, int iClassRoom)
        {
            this.CourseID = CourseID;
            this.CourseName = CourseName;
            this.CourseLanguage = Language;
            this.CourseCulture = Culture;

            this.CourseLanguageID = LanguageID;
            this.CourseLanguageDisplay = LanguageDisplay;
            this.CMID = CMID;
            this.ClassRoomCourse = ((iClassRoom == 1) ? true : false);
        }
	
		public override string ToString()
		{
			string toString = string.Empty;
			toString += Util.ToString("CourseID", CourseID); 
			toString += Util.ToString("CourseName", CourseName); 
			toString += Util.ToString("CourseLanguage", CourseLanguage); 
			toString += Util.ToString("CourseCulture", CourseCulture); 
			toString += Util.ToString("CourseLanguageID", CourseLanguageID); 
			toString += Util.ToString("CourseLanguageDisplay", CourseLanguageDisplay); 
			toString += Util.ToString("CourseDaysToComplete", CourseDaysToComplete); 
			toString += Util.ToString("CourseLength", CourseLength); 
			toString += Util.ToString("CourseObjective", CourseObjective); 
			toString += Util.ToString("CoursePrice", CoursePrice); 
			toString += Util.ToString("CourseRetakePrice", CourseRetakePrice); 
			toString += Util.ToString("CMID", CMID); 
			toString += Util.ToString("Subscribed", Subscribed); 
			toString += Util.ToString("CompleteByDate", CompleteByDate); 
			toString += Util.ToString("ExamID", ExamID); 
			toString += Util.ToString("ExamRequirement", ExamRequirement); 
			toString += Util.ToString("ExamPassingScore", ExamPassingScore); 
			toString += Util.ToString("Expired", Expired);	
			toString += Util.ToString("ExamFrequency",ExamFrequency);
			toString += Util.ToString("ClassRoomCourse",ClassRoomCourse);
			return toString;
		}		
	}
	#endregion

	#region SubscribedCertificationData Class
	public class SubscribedCertificationData : CertificationData
	{
		public string Subscribed;
		public int Ordered;
		public string OrderDate;
		public int Paid;
		public string PaidDate;
		public int Complete;
		public string CertificationDate;
		public double Score;
		public string NewerVersionAvailable;
		public int ExamAllowedTime;
		public SubscribedCourseData[] SubscribedCourses;
        public string ExpirationDate;
		
		//no-op ctor required for serialization
		public SubscribedCertificationData(){}

		public SubscribedCertificationData(int ID,string Name,SubscribedCourseData[]SubscribedCourses)
		{
			this.ID = ID;
			this.Name = Name;
			this.SubscribedCourses = SubscribedCourses;
		}
		public SubscribedCertificationData(int CertificationID,
			string Name,
			string Description,
			int ExamID,
			int Complete,
			double Score, 				
			int AllowedTime,
			string NewerVersionAvailable,
			string CertificationDate,
            string ExpirationDate,
			SubscribedCourseData[] SubscribedCourses)
		{
			this.ID = CertificationID;
			this.Name = Name;
			this.Description = Description;
			this.ExamID = ExamID;
			this.Complete = Complete;
			this.Score = Score;
			this.ExamAllowedTime = AllowedTime;
			this.NewerVersionAvailable = NewerVersionAvailable;
			this.CertificationDate = CertificationDate;
            this.ExpirationDate = ExpirationDate;
			this.SubscribedCourses = SubscribedCourses;
		}
	
		public SubscribedCertificationData(int CertificationID,											   
			int ExamID,
			int Ordered,     
			string OrderDate,
			int Paid,
			string PaidDate,
			int Complete,
			string CertificationDate,
			string CompleteBy,
			double Score,
			string Subscribed,
			string Name,
			string Description,
			string Language,
			int Type,
			SubscribedCourseData[] SubscribedCourses)
		{
			this.ID =  CertificationID;
			this.ExamID = ExamID;
			this.Ordered = Ordered;
			this.OrderDate = OrderDate;
			this.Paid = Paid;
			this.PaidDate = PaidDate;
			this.Complete = Complete;
			this.CertificationDate = CertificationDate;
			this.CompleteBy = CompleteBy;
			this.Score = Score;
			this.Subscribed = Subscribed;
			this.Name = Name;
			this.Description = Description;
			this.Language =Language;
			this.Type = Type;
			this.SubscribedCourses = SubscribedCourses;
		}

		public SubscribedCertificationData(int CertificationID,											   
			int ExamID,
			int Ordered,     
			string OrderDate,
			int Paid,
			string PaidDate,
			int Complete,
			string CertificationDate,
			string CompleteBy,
			Double Score, 				
			string Subscribed,  
			string Name,
			string Description,
			string Language,
			int Version, 
			int LanguageIndependentID,
			SubscribedCourseData[] SubscribedCourses)
		{
			this.ID = CertificationID;			
			this.ExamID = ExamID;
			this.Ordered = Ordered;     
			this.OrderDate = OrderDate;
			this.Paid = Paid;
			this.PaidDate = PaidDate;
			this.Complete = Complete;
			this.CertificationDate = CertificationDate;
			this.CompleteBy = CompleteBy;
			this.Score = Score;		
			this.Subscribed = Subscribed;
			this.Name = Name;
			this.Description = Description;
			this.Language = Language;
			this.Version = Version;
			this.LanguageIndependantID = LanguageIndependentID;
			this.SubscribedCourses = SubscribedCourses;
		}

		public override string ToString()
		{
			string toString = string.Empty;

			toString += Util.ToString("Subscribed", Subscribed);
			toString += Util.ToString("Ordered", Ordered); 
			toString += Util.ToString("Ordered", Ordered); 
			toString += Util.ToString("OrderDate", OrderDate); 
			toString += Util.ToString("Paid", Paid); 
			toString += Util.ToString("PaidDate", PaidDate); 
			toString += Util.ToString("Complete", Complete); 
			toString += Util.ToString("CertificationDate", CertificationDate); 			
			toString += Util.ToString("Score", Score);
			toString += Util.ToString("Subscribed",Subscribed);
			toString += Util.ToString("Name",Name);
			toString += Util.ToString("Description",Description);
			toString += Util.ToString("Language",Language);
			toString += Util.ToString("Version",Version);
			toString += Util.ToString("LanguageIndependentID",LanguageIndependantID);
			toString += Util.ToString("NewerVersionAvailable", NewerVersionAvailable); 
			toString += Util.ToString("ExamAllowedTime", ExamAllowedTime);
            toString += Util.ToString("ExpirationDate", ExpirationDate);
			toString += Util.ToString("SubscribedCourses", SubscribedCourses); 
			
			return toString;
		}
	}
	#endregion

	#region SubscribedCourseData Class
	public class SubscribedCourseData: CourseData
	{
		public string Subscribed;
		public string Completed; 
		public string Score; 
		public string CompleteDate; 
		public string Ordered;
		public string OrderDate;
		
					
		/// <summary>
		/// Default ctor needed for Serilazation
		/// </summary>
		public SubscribedCourseData(){}

		public SubscribedCourseData(int CSID,
			string Name,
			int ExamID,
			bool Expired,
			string Complete,
			string Score,
			string CompletedDate,
			string CompleteByDate,
			string CMID)
		{
			this.CourseID = CSID;
			this.CourseName = Name;
			this.ExamID = ExamID;
			this.Expired = Expired;
			this.Completed = Complete;
			this.Score = Score;
			this.CompleteDate = CompletedDate;
			this.CompleteByDate = CompleteByDate;
			this.CMID = CMID;
		}

		public SubscribedCourseData(int CSID, 
			string Name,
			int ExamID,
			string Complete,
			string Score,
			string CompleteDate,
			string CompleteByDate,
			string CMID,
			int iClassroom)
		{
			this.CourseID = CSID; 
			this.CourseName = Name;
			this.ExamID = ExamID;
			this.Completed = Complete;
			this.Score = Score;
			this.CompleteDate = CompleteDate;
			this.CompleteByDate = CompleteByDate;
			this.CMID = CMID;
			this.ClassRoomCourse = ((iClassroom ==1)? true:false);	
		}

		public SubscribedCourseData(int CSID,
			string Name,
			string Language,
			string LanguageID,
			string LanguageDisplay,
			string CMID,
			string Subscribed)
		{
			this.CourseID = CSID;
			this.CourseName = Name;
			this.CourseLanguage = Language;
			this.CourseLanguageID = LanguageID;
			this.CourseLanguageDisplay = LanguageDisplay;
			this.CMID = CMID;
			this.Subscribed = Subscribed;
		}

		public SubscribedCourseData(int CSID,
			string Name,
			int ExamID,
			bool Expired,
			string Complete,
			string Score,
			string CompletedDate,
			string CompleteByDate,
			string CMID,
			int iClassroom)
		{
			this.CourseID = CSID;
			this.CourseName = Name;
			this.ExamID = ExamID;
			this.Expired = Expired;
			this.Completed = Complete;
			this.Score = Score;
			this.CompleteDate = CompletedDate;
			this.CompleteByDate = CompleteByDate;
			this.CMID = CMID;
			this.ClassRoomCourse = ((iClassroom ==1)? true:false);			
		}
		
		
		public override string ToString()
		{
			string toString = string.Empty;
			toString += Util.ToString("Subscribed", Subscribed); 
			toString += Util.ToString("Completed", Completed); 
			toString += Util.ToString("Score", Score); 
			toString += Util.ToString("CompleteDate", CompleteDate); 
			toString += Util.ToString("Ordered", Ordered);
			toString += Util.ToString("OrderDate", OrderDate);	
			return toString;
		}
	}
	#endregion

	#region UserGroup Class
	public class UserGroup
	{
		public int ID;
		public string Name;
		public string ExternalID;
        public string Country;	
	
		/// <summary>
		/// Default ctor needed for Serilazation
		/// </summary>
		public UserGroup(){}

		public UserGroup(int ID,string Name, string ExternalID)
		{
			this.ID = ID;
			this.Name = Name;
			this.ExternalID = ExternalID;
		}

        public UserGroup(int ID, string Name, string ExternalID,string Country)
        {
            this.ID = ID;
            this.Name = Name;
            this.ExternalID = ExternalID;
            this.Country = Country;
        }
	
		public override string ToString()
		{
			string toString = string.Empty;
			toString += Util.ToString("ID", ID); 
			toString += Util.ToString("Name", Name); 
			toString += Util.ToString("ExternalID", ExternalID);
            toString += Util.ToString("Country", Country);
			return toString;
		}		
	}
	#endregion

	#region CourseDescription

	public class CourseDescription
	{
		public int CourseId;
		public string CourseName;
		public string Description;
		public int Points;
		
		public CourseDescription(){}

		public CourseDescription(int ID,string Name, string Description,int Points)
		{
			this.CourseId = ID;
			this.CourseName = Name;
			this.Description = Description;
			this.Points = Points;
		}

		public override string ToString()
		{
			string toString = string.Empty;
			toString += Util.ToString("CourseId", CourseId); 
			toString += Util.ToString("CourseName", CourseName); 
			toString += Util.ToString("Description", Description);
			toString += Util.ToString("Points", Points);
			return toString;
		}		

	}

	#endregion

    #region UserCertifications Class
    public class UserCertifications
    {
        public string UserName;
        public string Email;
        public string UserExternalID;
        public string CertificationName;
        public string CertificationID;
        public string CertificationExternalID;
        public string CompletedDate;
        public string ExpirationDate;
        public string Score;
        public string Type;
        public string ExpirationType;
        public DateTime UpdatedDate;

        /// <summary>
        /// Default ctor needed for Serilazation
        /// </summary>
        public UserCertifications(){}

        public UserCertifications(string UserName, 
            string Email, 
            string UserExternalID, 
            string CertificationName,
            string CertificationID,
            string CertificationExternalID,            
            string CompletedDate,
            string ExpirationDate,
            string Score,
            string Type,
            string ExpirationType,
            DateTime UpdatedDate)
        {
            this.UserName = UserName;
            this.Email = Email;
            this.UserExternalID = UserExternalID;
            this.CertificationName = CertificationName;
            this.CertificationExternalID = CertificationExternalID;
            this.CompletedDate = CompletedDate;
            this.ExpirationDate = ExpirationDate;
            this.Score = Score;
            this.Type = Type;
            this.ExpirationType = ExpirationType;
            this.CertificationID = CertificationID;
            this.UpdatedDate = UpdatedDate;

        }

        public override string ToString()
        {
            string toString = string.Empty;
            toString += Util.ToString("UserName", UserName);
            toString += Util.ToString("Email", Email);
            toString += Util.ToString("UserExternalID", UserExternalID);
            toString += Util.ToString("CertificationName", CertificationName);
            toString += Util.ToString("CertificationExternalID", CertificationExternalID);
            toString += Util.ToString("CompletedDate", CompletedDate);
            toString += Util.ToString("ExpirationDate", ExpirationDate);
            toString += Util.ToString("Score", Score);
            toString += Util.ToString("Type", Type);
            toString += Util.ToString("ExpirationType", ExpirationType);
            toString += Util.ToString("CertificationID", CertificationID);
            toString += Util.ToString("UpdatedDate", UpdatedDate);            

            return toString;
        }		
    }
    #endregion

    #region CertificationResults
    public class CertificationResults
    {
        public UserCertifications[] UserCertifications;
        public int recordCount; // the total number of records found
        public int pageNumber; // the page number
        public int numberOfPages; //the total number of pages

        /// <summary>
        /// Default ctor needed for Serilazation
        /// </summary>
        public CertificationResults(){}

        public CertificationResults(UserCertifications[] UserCertifications,
            int recordCount,
            int pageNumber,
            int numberOfPages)
        {
            this.UserCertifications = UserCertifications;
            this.recordCount = recordCount;
            this.pageNumber = pageNumber;
            this.numberOfPages = numberOfPages;
        }

        public override string ToString()
        {
            string toString = string.Empty;
            toString += Util.ToString("UserCertifications", UserCertifications);
            toString += Util.ToString("recordCount", recordCount);
            toString += Util.ToString("pageNumber", pageNumber);
            toString += Util.ToString("numberOfPages", numberOfPages);
            return toString;
        }		

    }
    #endregion

    #region UserUserGroup Class
    public class UserUserGroup
    {
        public string Name;
        public string ExternalID;
        public int IsPrimaryUserGroup;
        public string Country;


        /// <summary>
        /// Default ctor needed for Serilazation
        /// </summary>
        public UserUserGroup() { }


        public UserUserGroup(string Name, string ExternalID, int IsPrimaryUserGroup)
        {
            this.Name = Name;
            this.ExternalID = ExternalID;
            this.IsPrimaryUserGroup = IsPrimaryUserGroup;
        }

        public UserUserGroup(string Name, string ExternalID, int IsPrimaryUserGroup,string Country)
        {
            this.Name = Name;
            this.ExternalID = ExternalID;
            this.IsPrimaryUserGroup = IsPrimaryUserGroup;
            this.Country = Country;
        }

        public override string ToString()
        {
            string toString = string.Empty;
            toString += Util.ToString("Name", Name);
            toString += Util.ToString("ExternalID", ExternalID);
            toString += Util.ToString("IsPrimaryUserGroup", IsPrimaryUserGroup);
            toString += Util.ToString("Country", Country);
            return toString;
        }
    }
    #endregion

    #region User Class
    /// <summary>
    /// Summary description for UserProfile.
    /// </summary>
    public class User
    {

        //inherrited members
        public string FirstName;
        public string LastName;
        public string UserName;
        public string ExternalID;
        public string Email;
        public string AlternateEmail;
        public string City;
        public string Country;
        public string State;
        public string PostalCode;
        public string Language;
         //Extension Memebers		
         public string BusinessPhone;
        public string PersonalPhone;
        public string PersonalEmail;
        public string JobCategory;
        public string JobTitle;
        public string TimeZone;
        public string UserRole;
        public string UserTypeName;
        public string ManagerExternalID;
        public string Status;
        public UserUserGroup userGroup;
   
        public User()
        {
            //TODO: Add constructor logic here
        }

        public User(string FirstName,
            string LastName,
            string UserName,           
            string Email,
            string AlternateEmail,
            string City,
            string Country,
            string State,
            string PostalCode,
            string Language,
            string BusinessPhone,
            string PersonalPhone,
            string PersonalEmail,
            string JobCategory,
            string JobTitle,
            int TimeZone,
            string ExternalID,
            string UserRole,
            string UserTypeName,
            string ManagerExternalID,
            string Status,
            UserUserGroup userGroup)
        {
            
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.UserName = UserName;           
            this.Email = Email;
            this.AlternateEmail = AlternateEmail;
            this.City = City;
            this.Country = Country;
            this.State = State;
            this.PostalCode = PostalCode;
            this.Language = Language;
            this.BusinessPhone = BusinessPhone;
            this.PersonalPhone = PersonalPhone;
            this.PersonalEmail = PersonalEmail;
            this.JobCategory = JobCategory;
            this.JobTitle = JobTitle;
            this.TimeZone = TimeZone.ToString();
            this.ExternalID = ExternalID;
            this.UserRole = UserRole;
            this.UserTypeName = UserTypeName;
            this.ManagerExternalID = ManagerExternalID;
            this.Status = Status;
            this.userGroup = userGroup;
        }        

        public override string ToString()
        {
            string toString = string.Empty;

            toString += Util.ToString("FirstName", FirstName);
            toString += Util.ToString("LastName", LastName);
            toString += Util.ToString("UserName", UserName);
            toString += Util.ToString("Email", Email);
            toString += Util.ToString("AlternateEmail", AlternateEmail);
            toString += Util.ToString("ExternalID", ExternalID);
            toString += Util.ToString("City", City);
            toString += Util.ToString("Country", Country);
            toString += Util.ToString("State", State);
            toString += Util.ToString("PostalCode", PostalCode);
            toString += Util.ToString("Language", Language);
            toString += Util.ToString("BusinessPhone", BusinessPhone);
            toString += Util.ToString("PersonalPhone", PersonalPhone);
            toString += Util.ToString("PersonalEmail", PersonalEmail);
            toString += Util.ToString("JobCategory", JobCategory);
            toString += Util.ToString("JobTitle", JobTitle);
            toString += Util.ToString("TimeZone", TimeZone);
            toString += Util.ToString("UserRole", UserRole);
            toString += Util.ToString("UserTypeName", UserTypeName);
            toString += Util.ToString("ManagerExternalID", ManagerExternalID);
            toString += Util.ToString("Status", Status);
            toString += Util.ToString("userGroup", userGroup);

            return toString;
        }
    }
    #endregion

    #region Bulk Upload Transaction Log
    /// <summary>
    ///Bulk Upload Transaction Log.
    /// </summary>
    public class BulkUploadTransaction
    {

        //inherrited members
        public string TransactionID;        
        public string Email;
        public string FirstName;
        public string LastName;
        public string ErrorCode;
        public string ErrorDescription;
        public string TransactionDate;

        public BulkUploadTransaction()
        {
            //TODO: Add constructor logic here
        }

        public BulkUploadTransaction(string TransactionID,       
        string Email,
        string FirstName,
        string LastName,
        string ErrorCode,
        string ErrorDescription,
        string TransactionDate)
        {
            this.TransactionID = TransactionID;       
            this.Email = Email;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ErrorCode = ErrorCode;
            this.ErrorDescription = ErrorDescription;
            this.TransactionDate = TransactionDate;
        }

        public override string ToString()
        {
            string toString = string.Empty;

            toString += Util.ToString("TransactionID", TransactionID);
            toString += Util.ToString("Email", Email);
            toString += Util.ToString("FirstName", FirstName);
            toString += Util.ToString("LastName", LastName);
            toString += Util.ToString("ErrorCode", ErrorCode);
            toString += Util.ToString("ErrorDescription", ErrorDescription);
            toString += Util.ToString("TransactionDate", TransactionDate);
            return toString;
        }
    }
    #endregion

}

	

