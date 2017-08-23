<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style4
        {
            width: 164px;
        }
        .style5
        {
            width: 166px;
        }
        .style6
        {
            width: 193px;
        }
        .style7
        {
            width: 358px;
        }
        .style8
        {
            width: 105px;
        }
        .style9
        {
            width: 121px;
        }
        .style10
        {
            width: 160px;
        }
        .style11
        {
            width: 110px;
        }
        .style12
        {
            width: 186px;
            height: 124px;
        }
        .style13
        {
            width: 596px;
            height: 112px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style11">
                    <img alt="" class="style12" src="image/logo.jpg" /></td>
                <td>
                    <img alt="" class="style13" src="image/maha.jpg" /></td>
            </tr>
        </table>
    
    </div>
    <table class="style1">
        <tr>
            <td class="style10" bgcolor="#CCFFCC">
                &nbsp;</td>
            <td class="style7" bgcolor="#99CCFF">
                Student Name</td>
            <td class="style4" colspan="2" bgcolor="#99CCFF">
                <asp:TextBox ID="txt_studentname" runat="server" Width="197px"></asp:TextBox>
            </td>
            <td class="style5" rowspan="3" bgcolor="#99CCFF">
                <br />
                <asp:ImageButton ID="ImageButton1" runat="server" Height="30px" 
                    ImageUrl="~/image/cal.jpg" onclick="ImageButton1_Click1" Width="37px" />
            </td>
            <td rowspan="7" bgcolor="#99CCFF">
                <asp:Panel ID="Panel1" runat="server" Height="259px" Width="297px">
                    <br />
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                        BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" 
                        DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
                        ForeColor="#003399" Height="200px" 
                        onselectionchanged="Calendar1_SelectionChanged" Width="220px">
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" 
                            Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                        
                    </asp:Calendar>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="style10" bgcolor="#CCFFCC">
                &nbsp;</td>
            <td class="style7" bgcolor="#99CCFF">
                Date of birth</td>
            <td class="style4" colspan="2" bgcolor="#99CCFF">
                <asp:TextBox ID="txt_DOB" runat="server" Width="128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10" bgcolor="#CCFFCC">
                &nbsp;</td>
            <td class="style7" bgcolor="#99CCFF">
                City</td>
            <td class="style4" colspan="2" bgcolor="#99CCFF">
                <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="1">Pune</asp:ListItem>
                    <asp:ListItem Value="2">Nashik</asp:ListItem>
                    <asp:ListItem Value="3">Nagpur</asp:ListItem>
                    <asp:ListItem Value="4">Thane</asp:ListItem>
                    <asp:ListItem Value="5">Mumbai</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style10" bgcolor="#CCFFCC">
                &nbsp;</td>
            <td class="style7" bgcolor="#99CCFF">
                Stream</td>
            <td class="style9" bgcolor="#99CCFF">
                <asp:RadioButton ID="Rad_dotnet" runat="server" Text=".Net" AutoPostBack="True" 
                    GroupName="stream" />
            </td>
            <td class="style8" bgcolor="#99CCFF">
                <asp:RadioButton ID="Rad_java" runat="server" Text="Java" AutoPostBack="True" 
                    GroupName="stream" />
            </td>
            <td class="style5" bgcolor="#99CCFF">
                <asp:RadioButton ID="Rad_Non" runat="server" AutoPostBack="True" 
                    GroupName="stream" Text="Non Selected" />
            </td>
        </tr>
        <tr>
            <td class="style10" bgcolor="#CCFFCC">
                &nbsp;</td>
            <td class="style7" bgcolor="#99CCFF">
                Optional</td>
            <td class="style4" colspan="2" bgcolor="#99CCFF">
                <asp:CheckBox ID="Check_XML" runat="server" Text="XML" AutoPostBack="True" />
            </td>
            <td class="style5" bgcolor="#99CCFF">
                <asp:CheckBox ID="Check_HTML" runat="server" Text="HTML" />
            </td>
        </tr>
        <tr>
            <td class="style10" bgcolor="#CCFFCC">
                &nbsp;</td>
            <td class="style7" bgcolor="#99CCFF">
                &nbsp;</td>
            <td class="style4" colspan="2" bgcolor="#99CCFF">
                <asp:CheckBox ID="Check_javascript" runat="server" Text="Javascript" 
                    AutoPostBack="True" />
            </td>
            <td class="style5" bgcolor="#99CCFF">
                <asp:CheckBox ID="Check_Security" runat="server" Text="Security" 
                    AutoPostBack="True" />
            </td>
        </tr>
        <tr>
            <td class="style10" bgcolor="#CCFFCC">
                &nbsp;</td>
            <td class="style7" bgcolor="#99CCFF">
                &nbsp;</td>
            <td class="style4" colspan="2" bgcolor="#99CCFF">
                <asp:Button ID="But_AddEnRoll" runat="server" Text="Add EnRoll" 
                    onclick="But_AddEnRoll_Click" />
            </td>
            <td class="style5" bgcolor="#99CCFF">
                &nbsp;</td>
        </tr>
    </table>
    <table class="style1">
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Lab_msg" runat="server" ForeColor="#3333FF"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
