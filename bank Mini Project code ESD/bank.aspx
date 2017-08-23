<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bank.aspx.cs" Inherits="bank" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 185px;
        }
        .style3
        {
            height: 26px;
        }
        .style4
        {
            width: 185px;
            height: 26px;
        }
        .style5
        {
            width: 853px;
            height: 192px;
        }
        .style6
        {
            width: 162px;
        }
        .style7
        {
            height: 26px;
            width: 162px;
        }
        .style8
        {
            width: 247px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <img alt="" class="style5" src="Image/Bank_of_India.svg_.png" /></td>
            </tr>
        </table>
    
    </div>
    <table class="style1">
        <tr>
            <td bgcolor="#99CCFF" class="style6">
                &nbsp;</td>
            <td class="style2" bgcolor="White">
                Enter Account Number</td>
            <td bgcolor="White">
                <asp:TextBox ID="txt_acc_no" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td bgcolor="#99CCFF" class="style6">
                &nbsp;</td>
            <td class="style2" bgcolor="White">
                &nbsp;</td>
            <td bgcolor="White">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Show Account Info" />
            </td>
        </tr>
        <tr>
            <td bgcolor="#99CCFF" class="style6">
                &nbsp;</td>
            <td class="style2" bgcolor="White">
                Account-Holder Name</td>
            <td bgcolor="White">
                <asp:TextBox ID="txt_Cust_Name" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td bgcolor="#99CCFF" class="style6">
                &nbsp;</td>
            <td class="style2" bgcolor="White">
                Account-Type</td>
            <td bgcolor="White">
                <asp:TextBox ID="txt_Acc_type" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td bgcolor="#99CCFF" class="style7">
                </td>
            <td class="style4" bgcolor="White">
                Balance</td>
            <td bgcolor="White" class="style3">
                <asp:TextBox ID="txt_Bal" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
    </table>
    <table class="style1">
        <tr>
            <td class="style8">
                <br />
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
