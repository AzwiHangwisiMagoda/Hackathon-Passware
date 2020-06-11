<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewPassword.aspx.cs" Inherits="Passware.PasswordReset.NewPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <link href="Content/default.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="outerDiv" runat="server">
        <div id="content">

            <p>Please input your new password</p>

            <hr />
            <div id="form">
                <div class="divPass">
                    <input type="password" id="password" placeholder="Password" required runat="server">
                </div>

                <div class="divPass">
                    <input type="password" id="confirm" placeholder="Confirm Password" required runat="server">
                </div>
            </div>

            <%--button--%>
            <asp:Button Text="Submit" runat="server"/>
        </div>
    </div>
</asp:Content>
