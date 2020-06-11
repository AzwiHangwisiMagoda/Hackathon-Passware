<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ForgotPass.aspx.cs" Inherits="Passware.PasswordReset.ForgotPass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <link href="Content/default.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div id="outerDiv" runat="server">
        <div id="content">

            <p>Please input the email you registered with in order to receive your otp</p>

            <hr />
            <div id="form">
                <div class="divEmail">
                    <input type="email" id="email" placeholder="username@company.com" required autofocus runat="server">
                </div>
            </div>

            <%--button--%>
            <asp:Button Text="Submit" runat="server" OnClick="Unnamed_Click"/>
        </div>
    </div>

    <div id="details" visible="false" runat="server">
        <p>Please check your email for the link</p>
    </div>
    
</asp:Content>
