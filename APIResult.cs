using System;
using System.Configuration;

namespace Netexam.Webservices.OracleCRM.V1
{
	/// <summary>
	/// All API methods that do not return a Class Should return this
	/// Author HMK
	/// </summary>
	public class ApiResult
	{
		
		#region Fields
               
		private int code;
		private string description;
		/// <summary>
		/// Code
		/// </summary>
		public int Code
		{
			get { return code; }
			set { code = value; }
		}

		public string Description
		{
			get{return description;}
			set{description = value;}
		}

		#endregion

		#region Constructor
		/// <summary>
		/// Parameterless Constructor needed for Serailization
		/// </summary>
		public ApiResult(){}

		
		/// <summary>
		/// Public Constructor
		/// </summary>
		/// <param name="code">Code value</param>
		/// 
        	
		public ApiResult(int code)
		{
			this.code = code;
			this.description = ConfigurationSettings.AppSettings["ERROR_" + code.ToString()];
		}

		public ApiResult(int code,string description)
		{
			this.code = code;
			this.description = description;
		}
	

		#endregion	

		#region Methods
		public string ToSOAP()
		{
			return 				
				"<soap:Response>"
				+	"<code>" + Code.ToString() + "<faultcode>"
				+	"<faultString>" + Description + "</faultString>"
				+"</soap:Response>";
		}
		#endregion

	}
}
