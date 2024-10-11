<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminHomepage.aspx.cs" Inherits="Project1.AdminHomepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 515px;
        }
        .auto-style3 {
            font-size: medium;
        }
       .image-button:hover {
        transform: scale(1.1); /* Enlarge the button slightly on hover */
        transition: transform 0.3s ease; /* Smooth transition */
    }

    .image-button:active {
        transform: scale(0.9); /* Shrink the button slightly when clicked */
        transition: transform 0.1s ease;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
    <td class="auto-style2">&nbsp;</td>
    <td>
        <asp:ImageButton ID="ImageButton1" runat="server" CssClass="image-button" Height="177px" ImageUrl="~/AdminHome/cat.jpg" Width="183px" OnClick="ImageButton1_Click" />
        <br />
        <strong><span class="auto-style3">ADD/EDIT CATEGORIES</span></strong>
    </td>
</tr>
        <tr>
    <td class="auto-style2">&nbsp;</td>
    <td>
        &nbsp;</td>
</tr>
        <tr>
    <td class="auto-style2">&nbsp;</td>
    <td>
        &nbsp;</td>
</tr>
        <tr>
    <td class="auto-style2">&nbsp;</td>
    <td>
        &nbsp;</td>
</tr>
<tr>
    <td class="auto-style2">&nbsp;</td>
    <td>
        <asp:ImageButton ID="ImageButton2" runat="server" CssClass="image-button" Height="173px" ImageUrl="~/AdminHome/prod.jpg" Width="202px" OnClick="ImageButton2_Click" />
        <br />
        <strong><span class="auto-style3">ADD/EDIT PRODUCTS</span></strong>
    </td>
</tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
