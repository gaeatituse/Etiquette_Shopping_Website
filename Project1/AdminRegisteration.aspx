<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminRegisteration.aspx.cs" Inherits="Project1.AdminRegisteration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 103%;
        background-color: #E2E6EA;
    }
    .auto-style2 {
        height: 7px;
    }
        .auto-style5 {
        width: 379px;
    }
        .auto-style6 {
            height: 7px;
            width: 379px;
        }
        .auto-style7 {
            font-size: large;
        }
        .auto-style8 {
        width: 379px;
        font-size: medium;
    }
        .auto-style9 {
            height: 27px;
        }
        .auto-style11 {
            width: 379px;
            height: 27px;
        }
        .auto-style12 {
            width: 379px;
            font-size: large;
        }
    .auto-style16 {
        width: 103%;
        left: 0px;
        top: 0px;
        margin-top: 157px;
        background-color: #E2E6EA;
    }
    .auto-style20 {
        width: 173px;
    }
    .auto-style21 {
        height: 7px;
        width: 173px;
    }
    .auto-style22 {
        height: 27px;
        width: 173px;
    }
    .auto-style23 {
        width: 125px;
    }
    .auto-style24 {
        height: 7px;
        width: 125px;
    }
    .auto-style25 {
        height: 27px;
        width: 125px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style16">
    <tr>
        <td class="auto-style23"><span class="auto-style7"></td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style12"><strong>ADMIN REGISTRATION</strong></td>
        <td class="auto-style20"></span></td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5"><strong></strong></td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style8"><strong>ADMIN NAME:</strong></td>
        <td class="auto-style20">
            <asp:TextBox ID="TextBox1" runat="server" Height="32px" Width="155px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name is Required"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style8"><strong>ADMIN EMAIL:</strong></td>
        <td class="auto-style20">
            <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="161px"></asp:TextBox>
        </td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Incorrect format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style8"><strong>ADMIN ADDRESS:</strong></td>
        <td class="auto-style20">
            <asp:TextBox ID="TextBox3" runat="server" Height="60px" Width="165px" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Address is Required"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style8"><strong>ADMIN PHONE NUMBER:</strong></td>
        <td class="auto-style20">
            <asp:TextBox ID="TextBox4" runat="server" Height="34px" Width="156px"></asp:TextBox>
        </td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="Incorrect format" ValidationExpression="^[\+]{0,1}[1-9]{1}[0-9]{7,11}$"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style8"><strong>ADMIN USERNAME:</strong></td>
        <td class="auto-style20">
            <asp:TextBox ID="TextBox5" runat="server" Height="41px" Width="151px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox5" ErrorMessage="Username is Required"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style8"><strong>ADMIN PASSWORD:</strong></td>
        <td class="auto-style20">
            <asp:TextBox ID="TextBox6" runat="server" Height="35px" Width="149px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style8"><strong>ADMIN CONFIRM PASSWORD:</strong></td>
        <td class="auto-style20">
            <asp:TextBox ID="TextBox7" runat="server" Height="34px" Width="145px"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox6" ControlToValidate="TextBox7" ErrorMessage="Password mismatch"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">
            <asp:Button ID="Button1" runat="server" Font-Size="Large" Height="49px" Text="Register" Width="153px" OnClick="Button1_Click" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style24"></td>
        <td class="auto-style6"></td>
        <td class="auto-style21"></td>
        <td class="auto-style2">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style25"></td>
        <td class="auto-style11"></td>
        <td class="auto-style22"></td>
        <td class="auto-style9">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
