using System;
using System.Collections.Specialized;
using System.Text;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Configuration; 
using System.Xml;

namespace Netexam.Webservices.OracleCRM.V1
{
	/// <summary>
	/// Base Exception Class for all API Errors
	/// </summary>
	public class APIException : SoapException
	{	
		public readonly int Code;
		public readonly string Description ;

		/// <summary>
		/// Constructor - read description from Config file
		/// </summary>
		/// <param name="i"></param>
		/// 
		public APIException(int i) : base(ConfigurationSettings.AppSettings["ERROR_" + i.ToString()], SoapException.ClientFaultCode) 
		{		
			Code = i;
			Description = ConfigurationSettings.AppSettings["ERROR_" + i.ToString()];
		}

		public APIException(int i, System.Xml.XmlQualifiedName faultCode) : base(ConfigurationSettings.AppSettings["ERROR_" + i.ToString()], faultCode) 
		{		
			Code = i;
			Description = ConfigurationSettings.AppSettings["ERROR_" + i.ToString()];
		}

		public APIException(int i,string Parameter) : base(ConfigurationSettings.AppSettings["ERROR_" + i.ToString()], SoapException.ClientFaultCode,Parameter) 
		{		
			Code = i;
			Description = ConfigurationSettings.AppSettings["ERROR_" + i.ToString()] + " :" + Parameter;
		}

		/// <summary>
		/// ToString Method Overriden to return Descript
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Description;
		}

		/// <summary>
		/// Retruns the Error as JSON string 
		/// </summary>
		/// <returns></returns>
		public string ToJSON()
		{
			return 				
				" NEAPICallback("
				+ "{"
				+ "error:{"
				+ "		code:" + Code 
				+ "		,description:'" + Description + "'"
				+ "		}"
				+ "}"
				+ ")";
		}

		/// <summary>
		/// Retruns the Error in XML 
		/// </summary>
		/// <returns></returns>
		public string ToXML()
		{
			return 				
				"<Error>"
				+ "<Code>" + Code + "<Code>"
				+ "<Description>" + Description + "</Description>"
				+ "</Error>";
		}


		/// <summary>
		/// Returns the Error as SOAP Fault Code
		/// </summary>
		/// <returns></returns>
		public string ToSOAP()
		{
			return 				
				"<soap:Response>"
				+	"<code>" + "soap:Client" + "<faultcode>"
				+	"<faultString>" + Description + "</faultString>"
				+"</soap:Response>";
		}


		/// <summary>
		/// Returns the Error as SOAP Fault Code
		/// </summary>
		/// <returns></returns>
		public string ToText()
		{
			return Description;
		}

	}


}