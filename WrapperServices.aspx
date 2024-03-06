<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WrapperServices.aspx.cs" Inherits="Netexam.Webservices.OracleCRM.V1.WrapperServices" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
</head>
<script language="javascript" type="text/javascript">
    function ShowMessage(myMessage) {
        alert(myMessage);
    }

    function GoBack(sResult) {
        if (sResult.toUpperCase() == 'SUCESS') {
            alert("Sucessfully Send to NetExam");
        }
        else {
            alert(sResult);
        }
        window.history.back();
    }

</script>
<body  style="background-image:url(images/top_grad.jpg)">
<form id="form1" runat="server">
<table width="100%"  border="0" cellpadding="0" cellspacing="0">
  <tr align="left" valign="top">
    <td width="173"><!-- logo --><img src="images/top_01a.gif" width="173" height="47"></td>
    <td width="15"><img src="images/0spacer.gif" width="15" height="1"></td>
        <td width="100%" align="right" class="textSMALLboldwhite"><br>
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
  </tr>
</table>
 </form>
</body>
</html>
